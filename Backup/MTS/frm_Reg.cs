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
    public partial class frm_Reg : Form
    {
        private string connString = SqlHelper.ConnString;//连接字符串
        private string cmdText;//需要执行的命令        

        public frm_Reg()
        {
            InitializeComponent();
        }

        private void but_Ok_Click(object sender, EventArgs e)
        {
            if (tex_ID.Text == "" || tex_Name.Text == "" || tex_Password.Text == "" || tex_RepPass.Text == "" || tex_Password.Text != tex_RepPass.Text)
            {
                MessageBox.Show("工号或姓名或密码或确认密码为空或两次输入的密码不相同", "错误");
                tex_ID.Text = ""; tex_Name.Text = ""; tex_Password.Text = ""; tex_RepPass.Text = "";
                tex_ID.Focus();//工号获得焦点
            }
            else
            {
                cmdText = @"select count(id) from mtsuser where id=@id";
                string strResult = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText, new SqlParameter("@id", tex_ID.Text.Trim())).ToString();
                if (strResult == "1")
                {
                    MessageBox.Show("系统中存在相同的ID", "错误");
                    tex_ID.Text = ""; tex_Name.Text = ""; tex_Password.Text = ""; tex_RepPass.Text = "";
                    tex_ID.Focus();//工号获得焦点
                }
                else
                {
                    cmdText = @"insert into mtsuser(id,name,password) values(@id,@name,@password)";
                    SqlHelper.ExecuteNonQuery(connString,CommandType.Text,cmdText,new SqlParameter("@id",tex_ID.Text.Trim()),
                        new SqlParameter("@name",tex_Name.Text.Trim()),new SqlParameter("@password",tex_Password.Text.Trim()));
                    MessageBox.Show("用户添加成功", "成功");
                      
                }
            }
        }
    }
}
