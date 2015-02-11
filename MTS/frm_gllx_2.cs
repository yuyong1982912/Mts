using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MTS
{
    public partial class frm_gllx_2 : Form
    {

        private string connString = SqlHelper.ConnString;//连接字符串
        private string cmdText;//需要执行的命令
        DataSet ds;//数据集

        public frm_gllx_2()
        {
            InitializeComponent();
        }        

        private void frm_gllx_2_Load(object sender, EventArgs e)
        {
            string[] sDisplayFields = null;
            cmdText = @"select cpsnd as 产品代码,cpxh as 产品型号 from cpxh;select luxianid as 编号,luxian as 路线 from luxian";
            ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText);

            //下面这一段是将类似"001,002,003"之类的改成"组装,精标,预标"
            foreach (DataRow row in ds.Tables[1].Rows)//遍历取出来的路线图
            {
                sDisplayFields = row[1].ToString().Split(',');//将路线按逗号进行切割
                string sStr = null;//定义一个字符变量
                for (int i = 0; i < sDisplayFields.Length; i++)//拆分后的每一个值转换成文字
                {
                    cmdText = @"select gymc from gy where gysn=" + "'" + sDisplayFields[i] + "'";
                    sStr = sStr + SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText).ToString() + ",";
                }
                row[1] = sStr.Substring(0, sStr.Length - 1);//写回到数据集
            }


            dw_Cpxh.DataSource = ds.Tables[0];//下拉编辑窗体的数据源
            dw_Cpxh.sDisplayField = "产品代码,产品型号";
            dw_Cpxh.sDisplayMember = "产品代码";
            dw_Cpxh.sKeyWords = "产品型号";
            dw_Cpxh.RowFilterVisible = true;
            dw_Cpxh.AfterSelector += new AfterSelectorEventHandler(dw_Cpxh_AfterSelector);

            dw_Cplx.DataSource = ds.Tables[1];
            dw_Cplx.sDisplayField = "编号,路线";
            dw_Cplx.sKeyWords = "编号";
            dw_Cplx.sDisplayField = "编号";
            dw_Cplx.RowFilterVisible = true;
        }

        void dw_Cpxh_AfterSelector(object sender, EventArgs e)
        {
            cmdText = @"select count(cpsnd) from road where cpsnd=@cpsnd";
            string str_Result = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText, new SqlParameter("@cpsnd", dw_Cpxh.Text.ToString().Trim())).ToString();
            if (str_Result == "0")//没有找到产品型号
            {
                but_Save.Text = "Save";
            }
            else
            {
                cmdText = @"select roadid from road where cpsnd=@cpsnd";
                ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText, new SqlParameter("@cpsnd", dw_Cpxh.Text.ToString().Trim()));

                dw_Cplx.Text = ds.Tables[0].Rows[0][0].ToString();
                but_Save.Text = "Modify";
            }
        }

        private void but_Save_Click(object sender, EventArgs e)
        {

            if (but_Save.Text == "Save")//如果按钮名称为保存
            {
                cmdText = @"insert into road(cpsnd,roadid) values(@cpsnd,@roadid)";
            }
            else
            {
                cmdText = @"update road set roadid=@roadid where cpsnd=@cpsnd";
            }
            SqlHelper.ExecuteNonQuery(connString, CommandType.Text, cmdText,
                new SqlParameter("@cpsnd", dw_Cpxh.Text.ToString().Trim()),
                new SqlParameter("@roadid", dw_Cplx.Text.ToString().Trim()));
            MessageBox.Show("保存或更新成功", "保存");
        }
    }
}
