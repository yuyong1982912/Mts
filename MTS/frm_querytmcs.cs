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
    public partial class frm_querytmcs : Form
    {
        private string connString = SqlHelper.ConnString;//连接字符串
        //private string cmdText;//需要执行的命令
        //DataSet ds;//数据集
        DataTable dt;//数据表
        SqlDataAdapter sda;//数据适配器
        DataView dv;//数据视图

        public frm_querytmcs()
        {            
            InitializeComponent();
        }        

        private void frm_querytmcs_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            SqlConnection conn = new SqlConnection(connString);//创建一个数据连接
            sda = new SqlDataAdapter();//创建数据适配器的实例
            sda.SelectCommand = new SqlCommand("select tmcs.id as 编号,tmcs.cpsnd as 产品短码,tmcs.bb as 版本,tmcs.workid as 工单号,cpxh.cpxh as 产品型号,tmcs.qty as 数量,tmcs.scxb as 生产线别,tmcs.qxsn as 起始条码,tmcs.jssn as 结束条码,tmcs.sj as 产生时间 from tmcs left join cpxh on tmcs.cpsnd=cpxh.cpsnd order by tmcs.sj", conn);
            dt = new DataTable();//实例化数据表
            sda.Fill(dt);//填充数据表
            //删除的代码
            sda.DeleteCommand = new SqlCommand("Delete FROM tmcs Where ID=@ID", conn);
            sda.DeleteCommand.Parameters.Add("@ID", SqlDbType.Int, 10);
            sda.DeleteCommand.Parameters[0].SourceColumn = "编号";
            sda.DeleteCommand.Parameters[0].SourceVersion = DataRowVersion.Original;

            //dat_Tmcs.DataSource = dt;//在表格中列出所有的数据
            conn.Close();//断开连接
        }

        private void but_Save_Click(object sender, EventArgs e)
        {
            if (tex_Password.Text == "52415098")
            {
                sda.Update(dt);//更新回数据库
                MessageBox.Show("删除成功", "成功");
            }
            else
            {
                MessageBox.Show("密码不对", "请重新输入");
                tex_Password.Focus();//文本框获得焦点
            }
        }

        private void but_Search_Click(object sender, EventArgs e)
        {
            string tStart = dtpStart.Text;
            string tEnd = dtpEnd.Text;
            if (tex_Rwdh.Text == "" && tStart == tEnd)
            {
                GetData();
                dv = dt.DefaultView;
                dat_Tmcs.DataSource = dv;
            }
            else
            {
                if (tex_Rwdh.Text == "")//如果查询框为空的话
                {
                    dtpStart.CustomFormat = "yyyy-MM-dd";
                    dtpStart.Format = DateTimePickerFormat.Custom;
                    dtpEnd.CustomFormat = "yyyy-MM-dd";
                    dtpEnd.Format = DateTimePickerFormat.Custom;

                    dv = dt.DefaultView;//为数据表定义一个视图
                    dv.RowFilter = "产生时间 >='" + tStart + "' and  产生时间 <='" + tEnd + "'";//在数据视图中按工单号筛选出所需数据
                    dat_Tmcs.DataSource = dv;//显示出该数据                
                }
                else
                {
                    dv = dt.DefaultView;//为数据表定义一个视图
                    dv.RowFilter = "工单号='" + tex_Rwdh.Text.ToString().Trim() + "'";//在数据视图中按工单号筛选出所需数据
                    dat_Tmcs.DataSource = dv;//显示出该数据
                }
            }            
        }

        private void but_Export_Click(object sender, EventArgs e)
        {
            //DataToExcel(dat_Tmcs);
            {
                if (dat_Tmcs.Rows.Count > 0) //如果有找到信息
                {
                    HSSFWorkbook book = new HSSFWorkbook();//创建一个EXCEL工作簿
                    HSSFSheet sheet = book.CreateSheet("Daochu") as HSSFSheet;//创建一个EXCEL表格
                    HSSFRow row = sheet.CreateRow(0) as HSSFRow;//创建一个EXCEL行

                    for (int i = 0; i < dat_Tmcs.Columns.Count; i++)//创建表头
                    {
                        row.CreateCell(i).SetCellValue(dat_Tmcs.Columns[i].HeaderText);
                    }

                    for (int i = 0; i < dat_Tmcs.Rows.Count-1; i++)//创建内容
                    {
                        HSSFRow row2 = sheet.CreateRow(i + 1) as HSSFRow;
                        for (int j = 0; j < dat_Tmcs.Columns.Count; j++)
                        {
                            row2.CreateCell(j).SetCellValue(dat_Tmcs.Rows[i].Cells[j].Value.ToString());
                        }
                    }

                    FileStream file = new FileStream(@"c:\Daochu.xls", FileMode.Create);//创建文件
                    book.Write(file);//将工作簿写入到文件中
                    file.Close();//关闭文件
                    MessageBox.Show("导出成功,请至C盘打开Daochu.xls", "成功");
                }
            }
        }

        private void but_searchall_Click(object sender, EventArgs e)
        {
            
            GetData();//取得数据
            DataTable dtFenYe = FenYe.GetPagedTable(dt, 1, 20);
            int pageCount = FenYe.PageCount(dt.Rows.Count, 20);
            labAll.Text = "共" + pageCount.ToString() + "页";
            dv = dtFenYe.DefaultView;            
            dat_Tmcs.DataSource = dv;
            butEnd.Visible = true;

        }

        private void butEnd_Click(object sender, EventArgs e)
        {
            int pageCount = FenYe.PageCount(dt.Rows.Count, 20);  //所有分页数    
            DataTable dtFenYe = FenYe.GetPagedTable(dt, pageCount, 20);//最后一页                 
            dv = dtFenYe.DefaultView;
            dat_Tmcs.DataSource = dv;
            butEnd.Visible = false;
        }      
    }
}
