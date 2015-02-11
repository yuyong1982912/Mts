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
    public partial class frm_zzgy : Form
    {
        private string connString = SqlHelper.ConnString;//连接字符串
        private string cmdText;//需要执行的命令
        DataSet ds;//数据集

        public frm_zzgy()
        {
            InitializeComponent();
        }

        private void tex_Gybh_Leave(object sender, EventArgs e)
        {
            cmdText = @"select count(zzbh) from zzgy where zzbh=@zzbh";//检测一下是否存在该组装工艺
            string str_Result = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText,
                new SqlParameter("@zzbh", tex_Gybh.Text.ToString().Trim())).ToString();
            if (str_Result == "0")//如果不存在的话
            {
                but_Save.Text = "Save";//按钮的名字为
            }
            else
            {
                but_Save.Text = "Modify";
                cmdText = @"select zzmc from zzgy where zzbh=@zzbh";
                ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText,
                    new SqlParameter("@zzbh", tex_Gybh.Text.ToString().Trim()));
                tex_Gymc.Text = ds.Tables[0].Rows[0][0].ToString();
            }
        }

        private void but_Save_Click(object sender, EventArgs e)
        {
            if (but_Save.Text =="Save")//如果按钮名字是保存的话
            {
                if ((tex_Gybh.Text.Length != 0) && (tex_Gymc.Text.Length != 0))
                {
                    cmdText = @"insert into zzgy(zzbh,zzmc) values(@zzbh,@zzmc)";
                    try
                    {
                        SqlHelper.ExecuteNonQuery(connString,CommandType.Text,cmdText,
                            new SqlParameter("@zzbh",tex_Gybh.Text.ToString().Trim()),
                            new SqlParameter("@zzmc",tex_Gymc.Text.ToString().Trim()));
                        MessageBox.Show("保存成功","成功");
                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show(ex.ToString());
                    }
                    
                }
                else
                {
                    cmdText=@"update zzgy set zzmc=@zzmc where zzbh=@zzbh";
                    SqlHelper.ExecuteNonQuery(connString,CommandType.Text,cmdText,
                            new SqlParameter("@zzbh",tex_Gybh.Text.ToString().Trim()),
                            new SqlParameter("@zzmc",tex_Gymc.Text.ToString().Trim()));
                        MessageBox.Show("更新成功","成功");
                }
            }
        }

        private void frm_zzgy_Load(object sender, EventArgs e)
        {
            cmdText = @"select zzbh as 组装编号,zzmc as 组装名称 from zzgy";
            ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText);
            dat_Zzgy.DataSource = ds.Tables[0];

        }
    }
}
