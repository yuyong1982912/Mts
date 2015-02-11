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
    public partial class frm_ViewInput : Form
    {
        string connString = SqlHelper.ConnString;
        string userid;

        public frm_ViewInput()
        {
            InitializeComponent();
        }

        public frm_ViewInput(string id)//构造函数
        {
            userid = id;
            InitializeComponent();
        }

        private void tex_Sn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )//如果按下回车键的话           
                {
                    if ( tex_Sn.Text.Length == 18)
                    {                        
                        string s = tex_Sn.Text.Trim().ToString().Substring(0, 6);
                        string cmdtext = @"select count(cpxh) from cpxh where cpsnd=@sn";
                        string sr = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdtext, new SqlParameter("@sn", s)).ToString();
                        if (sr == "1")
                        {
                            cmdtext = @"select cpxh from cpxh where cpsnd=@sn";
                            string mo = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdtext, new SqlParameter("@sn", s)).ToString();
                            tex_Mo.Text = mo;//显示所输入条码对应的型号
                            //下面一段程序是将数据写入到数据库中
                            cmdtext = @"insert into snrecord(sn,mo,bir,en,ts) values(@sn,@mo,@bir,@en,@ts)";                            
                            SqlParameter[] paras ={
                                                 new SqlParameter("@sn",tex_Sn.Text.Trim().ToString()),
                                                 new SqlParameter("@mo",tex_Mo.Text.Trim().ToString()),
                                                 new SqlParameter("@bir",tex_Bir.Text.Trim().ToString()),
                                                 //new SqlParameter("@en",this.MdiParent.Text.Substring(this.MdiParent.Text.LastIndexOf("*") + 1)),
                                                 new SqlParameter("@en",userid),
                                                 new SqlParameter("@ts",serverTime.sDateTime)
                                                  };
                            int i = SqlHelper.ExecuteNonQuery(connString, CommandType.Text, cmdtext, paras);
                            if (i==1)//如果写入成功
                            {
                                tex_Result.AppendText(String.Format("{0}成功进入烧机房...\r\n",  tex_Sn.Text.Trim().ToString()));
                                tex_Sn.Focus();
                                tex_Sn.Text = "";
                            }                            
                        }
                        else
                        {
                            MessageBox.Show("没有此条码资料，请重新输入", "错误");
                            tex_Sn.Focus();
                            tex_Sn.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("条码长度不足18位", "错误");
                        tex_Sn.Focus();
                        tex_Sn.Text = "";
                    }
                }
                
            
        }
    }
}
