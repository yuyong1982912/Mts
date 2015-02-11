using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;

namespace MTS
{
    public partial class frm_Liebiao : Form
    {
        string connString = SqlHelper.ConnString;//连接字符串
        string cmdText;//需要执行的命令
        DataSet ds;//数据集

        public frm_Liebiao()
        {
            InitializeComponent();
        }

        private void frm_Liebiao_Load(object sender, EventArgs e) //窗体加载时填充下拉列表
        {
            cmdText = @"select gysn,gymc from gy";
            ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText);
            com_Gy.DataSource = ds.Tables[0];
            com_Gy.DisplayMember = "gymc";
            com_Gy.ValueMember = "gysn";
        }

        private void but_Exp_Click(object sender, EventArgs e)
        {
            string dat_Kssj = dtp_Kssj.Value.Date.ToString();
            string dat_Jssj = dtp_Jssj.Value.Date.ToString();
            //cmdText = @"select cpsn as 产品条码,t1.cpxh as 产品型号,case when (gyzt=1) then 'Pass'
                        //when (gyzt=0) then 'Fail' else 'Completed' end as 工艺状态,sj as 时间,mtsname as 用户 from cpzt left join cpxh t1 on t1.cpsnd=left(cpsn,6)  where (sj >= @kssj and sj <= @jssj) and gysn=@gysn order by sj";
            cmdText = @"SELECT
	                            t2.cpsn AS 产品条码,
	                            t1.cpxh AS 产品型号,
	                            t4.cwms AS 不良描述,
	                            t3.cwbz AS 不良备注,
	                            t6.wxms AS 维修描述,
	                            t5.wxbz AS 维修备注,
	                            CASE
                            WHEN (t2.gyzt = 1) THEN
	                            'Pass'
                            WHEN (t2.gyzt = 0) THEN
	                            'Fail'
                            ELSE
	                            'Completed'
                            END AS 工艺状态,
                             t2.sj AS 时间,
                             t2.mtsname AS 用户
                            FROM
	                            cpzt t2
                            LEFT JOIN cpxh t1 ON t1.cpsnd = LEFT (t2.cpsn, 6)
                            LEFT JOIN wxb t3 ON t2.cpsn=t3.cpsn
                            LEFT JOIN cwdmb t4 ON t3.cwdm=t4.cwdm
                            LEFT JOIN wxh t5 ON t5.cpsn=t2.cpsn
                            LEFT JOIN wxdmb t6 ON t6.wxdm=t5.wxdm
                            WHERE
	                            (t2.sj >= @kssj AND t2.sj <= @jssj)
                            AND t2.gysn =@gysn
                            ORDER BY
	                            t2.sj";
            ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText,new SqlParameter("@kssj",dat_Kssj)
                ,new SqlParameter("@jssj",dat_Jssj),new SqlParameter("@gysn",com_Gy.SelectedValue.ToString()));
            
            if (ds.Tables[0].Rows.Count > 0) //如果有找到信息
            {
                dat_Result.DataSource = ds.Tables[0];
                HSSFWorkbook book = new HSSFWorkbook();//创建一个EXCEL工作簿
                HSSFSheet sheet = book.CreateSheet("Daochu") as HSSFSheet;//创建一个EXCEL表格
                HSSFRow row = sheet.CreateRow(0) as HSSFRow;//创建一个EXCEL行

                for (int i = 0; i < ds.Tables[0].Columns.Count; i++)//创建表头
                {
                    row.CreateCell(i).SetCellValue(ds.Tables[0].Columns[i].ColumnName);
                }

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)//创建内容
                {
                    HSSFRow row2 = sheet.CreateRow(i + 1) as HSSFRow;
                    for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                    {
                        row2.CreateCell(j).SetCellValue(ds.Tables[0].Rows[i][j].ToString());
                    }
                }

                FileStream file = new FileStream(@"c:\Daochu.xls", FileMode.Create);//创建文件
                book.Write(file);//将工作簿写入到文件中
                file.Close();//关闭文件
                MessageBox.Show("导出成功,请至C盘打开Daochu.xls", "成功");
            }
            else
            {
                MessageBox.Show("此日期范围此站无任何信息", "错误");                
            }
        }

    }
}
