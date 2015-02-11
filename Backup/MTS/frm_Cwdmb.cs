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
    public partial class frm_Cwdmb : Form
    {
        private string connString = SqlHelper.ConnString;//连接字符串
        private string cmdText;//需要执行的命令
        DataSet ds;//数据集

        public frm_Cwdmb()
        {
            InitializeComponent();
        }

        private void frm_Cwdmb_Load(object sender, EventArgs e)
        {
            cmdText = @"select cwdm as 错误代码,cwms as 错误描述 from cwdmb";
            ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText);
            dat_Cw.DataSource = ds.Tables[0];
        }

        private void tex_Cwdm_Leave(object sender, EventArgs e)
        {
            if (tex_Cwdm.Text.ToString().Trim().Length != 3)
            {
                MessageBox.Show("编码长度为3码", "错误");
            }
            else
            {
                cmdText = @"select count(cwdm) from cwdmb where cwdm=@cwdm";
                string str_Result = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText,
                    new SqlParameter("@cwdm", tex_Cwdm.Text.ToString().Trim())).ToString();
                if (str_Result == "0")//没有找到
                {
                    but_Save.Text = "Save";
                }
                else
                {
                    cmdText = @"select cwms from cwdmb where cwdm=@cwdm";
                    str_Result = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText,
                    new SqlParameter("@cwdm", tex_Cwdm.Text.ToString().Trim())).ToString();
                 tex_Cwms.Text = str_Result;
                 but_Save.Text = "Modify";
                }
            }
        }

        private void but_Save_Click(object sender, EventArgs e)
        {
            if (but_Save.Text == "Save")
            {
                cmdText = @"insert into cwdmb(cwdm,cwms) values(@cwdm,@cwms)";
                
            }
            else
            {
                cmdText = @"Update cwdmb set cwms=@cwms where cwdm=@cwdm";
            }
            SqlHelper.ExecuteNonQuery(connString, CommandType.Text, cmdText,
                    new SqlParameter("@cwdm", tex_Cwdm.Text.ToString().Trim()),
                    new SqlParameter("@cwms", tex_Cwms.Text.ToString().Trim()));
            MessageBox.Show("保存成功", "保存");
        }

        
    }
}
