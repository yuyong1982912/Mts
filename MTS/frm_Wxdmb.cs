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
    public partial class frm_Wxdmb : Form
    {
        private string connString = SqlHelper.ConnString;//连接字符串
        private string cmdText;//需要执行的命令
        DataSet ds;//数据集

        public frm_Wxdmb()
        {
            InitializeComponent();
        }

        private void frm_Cwdmb_Load(object sender, EventArgs e)
        {
            cmdText = @"select wxdm as 错误代码,wxms as 错误描述 from wxdmb";
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
                cmdText = @"select count(wxdm) from wxdmb where wxdm=@wxdm";
                string str_Result = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText,
                    new SqlParameter("@wxdm", tex_Cwdm.Text.ToString().Trim())).ToString();
                if (str_Result == "0")//没有找到
                {
                    but_Save.Text = "Save";
                }
                else
                {
                    cmdText = @"select wxms from wxdmb where wxdm=@wxdm";
                    str_Result = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText,
                    new SqlParameter("@wxdm", tex_Cwdm.Text.ToString().Trim())).ToString();
                 tex_Cwms.Text = str_Result;
                 but_Save.Text = "Modify";
                }
            }
        }

        private void but_Save_Click(object sender, EventArgs e)
        {
            if (but_Save.Text == "Save")
            {
                cmdText = @"insert into wxdmb(wxdm,wxms) values(@wxdm,@wxms)";
                
            }
            else
            {
                cmdText = @"Update wxdmb set wxms=@wxms where wxdm=@wxdm";
            }
            SqlHelper.ExecuteNonQuery(connString, CommandType.Text, cmdText,
                    new SqlParameter("@wxdm", tex_Cwdm.Text.ToString().Trim()),
                    new SqlParameter("@wxms", tex_Cwms.Text.ToString().Trim()));
            MessageBox.Show("保存成功", "保存");
        }

        
    }
}
