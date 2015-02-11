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
    public partial class frm_Gy : Form
    {
        private string connString = SqlHelper.ConnString;//连接字符串
        private string cmdText;//需要执行的命令
        DataSet ds;//数据集

        public frm_Gy()
        {
            InitializeComponent();
        }

        private void frm_Gy_Load(object sender, EventArgs e)
        {
            cmdText = @"select gysn as 工艺编号,gymc as 工艺名称,sfjy as 是否检验, sfyzxh as 是否验证型号 ,sfcs as 是否多次扫描 from gy";
            ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText);
            dat_Gy.DataSource = ds.Tables[0];//得到系统中的工艺表
        }

        private void but_Save_Click(object sender, EventArgs e)
        {
            int int_Sfjy = (che_Sfjy.Checked ? 1 : 0);//存储是否检验值 
            int int_sfyzxh=(che_sfyzxh.Checked ? 1 : 0);//存储是否验证型号
            int int_sfcs=(che_sfcs.Checked ? 1 : 0); //存储是否可以多次扫描           
            if ((tex_Gysn.Text.ToString() == "") || (tex_Gymc.Text.ToString() == ""))
            {
                MessageBox.Show("工艺编号或工艺名称为空", "错误");
                tex_Gymc.Focus();
            }
            else
            {
                if (but_Save.Text == "Save")//插入数据库
                {
                    cmdText = @"insert into gy(gysn,gymc,sfjy,sfyzxh,sfcs) values(@gysn,@gymc,@sfjy,@sfyzxh,@sfcs)";
                    SqlHelper.ExecuteNonQuery(connString, CommandType.Text, cmdText,
                        new SqlParameter("@gysn", tex_Gysn.Text.ToString().Trim()),
                        new SqlParameter("@gymc", tex_Gymc.Text.ToString().Trim()),
                        new SqlParameter("@sfjy", int_Sfjy),
                        new SqlParameter("@sfyzxh", int_sfyzxh),
                        new SqlParameter("@sfcs",int_sfcs));                        
                    MessageBox.Show("保存成功", "保存");
                }
                else//更新数据库--2013/04/19注释掉此段代码，不允许变更工艺的代码与名称--2013/12/04更新此段代码，允许变更是否检验和是否多次扫描
                {
                   
                    cmdText = @"update gy set sfyzxh=@sfyzxh,sfjy=@sfjy,sfcs=@sfcs where gysn=@gysn";
                    SqlHelper.ExecuteNonQuery(connString, CommandType.Text, cmdText,
                        new SqlParameter("@gysn", tex_Gysn.Text.ToString().Trim()),
                         new SqlParameter("@sfyzxh", int_sfyzxh),
                        new SqlParameter("@sfcs",int_sfcs),
                        new SqlParameter("@sfjy", int_Sfjy));
                    MessageBox.Show("更新成功", "更新");
                     

                }
            }


            
        }

        private void tex_Gysn_Leave(object sender, EventArgs e)
        {
            
            cmdText = @"select count(gysn) from gy where gysn=@gysn";
            string str_Result = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText,
                new SqlParameter("@gysn", tex_Gysn.Text.ToString().Trim())).ToString();
            if (str_Result == "0")//如果没有找到
            {
                but_Save.Text = "Save";                
            }
            else
            {
                but_Save.Text = "Modify";
                cmdText = @"select gymc,sfjy,sfyzxh,sfcs from gy where gysn=@gysn";
                ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText,
                    new SqlParameter("@gysn", tex_Gysn.Text.ToString().Trim()));                    
                tex_Gymc.Text = ds.Tables[0].Rows[0][0].ToString();//工艺名称
                if ((bool)ds.Tables[0].Rows[0][1]) { che_Sfjy.Checked = true; } else { che_Sfjy.Checked = false;  }
                if ((bool)ds.Tables[0].Rows[0][2]) {  che_sfyzxh.Checked = true; } else { che_sfyzxh.Checked = false;  }
                if ((bool)ds.Tables[0].Rows[0][3]) { che_sfcs.Checked = true; } else { che_sfcs.Checked = false; }
            }
        }

       
    }
}
