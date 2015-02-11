using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MTS
{
    public partial class frm_GllxCplx : Form
    {
        private string connString = SqlHelper.ConnString;//连接字符串
        private string cmdText;//需要执行的命令
        DataSet ds;//数据集
        private string str_GllxCplx="";
        public string Str_GllxCplx 
        { 
            get
                {return str_GllxCplx;}
              set
                {str_GllxCplx=value;}
        }

        public frm_GllxCplx()
        {
            InitializeComponent();
        }

        private void frm_GllxCplx_Load(object sender, EventArgs e)
        {
            string[] sDisplayFields = null;//定义一个数组

            //列出当前的所有工艺
            cmdText = @"select luxianid as 编号,luxian as 路线 from luxian";
            ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText);

            //下面这一段是将类似"001,002,003"之类的改成"组装,精标,预标"
            foreach (DataRow row in ds.Tables[0].Rows)//遍历取出来的路线图
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
            dat_Luxian.DataSource = ds.Tables[0];
        }

        private void dat_Luxian_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Str_GllxCplx = dat_Luxian.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();//取得双击行中的第一列的值
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
