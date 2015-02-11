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
    public partial class Frm_CP : Form
    {
        private string connString = SqlHelper.ConnString;//连接字符串
        private string cmdText;//需要执行的命令
        DataSet ds;//数据集

        public Frm_CP()
        {
            InitializeComponent();
        }                

        private void but_save_Click(object sender, EventArgs e)
        {
            int int_Zzp = 0;//默认为半成品
            if (rad_cp.Checked)//如果选择了成品,则BIT位等于1
            {
                int_Zzp = 1;
            }

            if (but_save.Text == "保存")
            {
                if ((tex_cpsnd.Text.Trim().Length != 6) || (tex_Bb.Text.Trim().Length != 3))//判断是不是6位,如果不是6位显示错误
                {
                    MessageBox.Show("编码为6位,版本为3位", "请重输入");
                    tex_cpsnd.Focus();
                    tex_cpsnd.Text = "";
                }
                else
                {
                    cmdText = @"insert into cpxh(cpsnd,cpxh,zzp,bb) values(@cpsnd,@cpxh,@zzp,@bb)";
                    try
                    {
                        SqlHelper.ExecuteNonQuery(connString, CommandType.Text, cmdText,
                        new SqlParameter("@cpsnd", tex_cpsnd.Text.ToString().Trim()),
                        new SqlParameter("@cpxh", com_cpmc.Text.ToString().Trim()),
                        new SqlParameter("@zzp", int_Zzp),
                        new SqlParameter("@bb",tex_Bb.Text.ToString().Trim()));
                        MessageBox.Show("保存成功", "保存");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());//抛出异常
                    }
                }
            }
            else
            {
                cmdText = @"update cpxh set cpxh=@cpxh,zzp=@zzp,bb=@bb where cpsnd=@cpsnd";
                try
                {
                    SqlHelper.ExecuteNonQuery(connString, CommandType.Text, cmdText,
                    new SqlParameter("@cpsnd", tex_cpsnd.Text.ToString().Trim()),
                    new SqlParameter("@cpxh", com_cpmc.Text.ToString().Trim()),
                    new SqlParameter("@zzp", int_Zzp),
                    new SqlParameter("@bb", tex_Bb.Text.Trim().ToString()));
                    MessageBox.Show("更新成功", "更新");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());//抛出异常
                }
            }           

        }
        
        private void tex_cpsnd_Leave(object sender, EventArgs e)
        {
            cmdText = @"select count(cpsnd) from cpxh where cpsnd=@cpsnd";//根据文本输入得到值
            string str_Result = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText,
                new SqlParameter("@cpsnd", tex_cpsnd.Text.ToString().Trim())).ToString();
            if (str_Result == "0")
            {
                but_save.Text="保存";
            }
            else
            {                
                but_save.Text = "更新";//更改按钮的名称
                cmdText = @"select cpxh,zzp,bb from cpxh where cpsnd=@cpsnd";
                ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText,
                    new SqlParameter("@cpsnd", tex_cpsnd.Text.ToString().Trim()));
                com_cpmc.Text = ds.Tables[0].Rows[0][0].ToString();
                tex_Bb.Text = ds.Tables[0].Rows[0][2].ToString();

                if ((bool)ds.Tables[0].Rows[0][1])//检测数据库中的值是
                {
                    rad_cp.Checked = true;//如果为true
                }
                else
                {
                    rad_bcp.Checked = true;//如果为false
                }
            }
        }

        private void Frm_CP_Load(object sender, EventArgs e)//从组装工艺中得到产品名称
        {
            cmdText = @"select zzbh,zzmc from zzgy";
            ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText);
            com_cpmc.DataSource = ds.Tables[0];
            com_cpmc.DisplayMember = "zzbh";
            com_cpmc.ValueMember = "zzbh";
        }
       
        
    }
}
