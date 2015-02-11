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
    public partial class frm_ZZSX : Form
    {
        private string connString = SqlHelper.ConnString;//连接字符串
        private string cmdText;//需要执行的命令
        DataSet ds;//数据集

        public frm_ZZSX()
        {
            InitializeComponent();
        }

        private void frm_ZZSX_Load(object sender, EventArgs e)//初始化下拉框
        {
            cmdText = @"select cpsnd,cpxh from cpxh where zzp=1;select zzbh,zzmc from zzgy";
            ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText);
            comb_Cpsnd.DataSource = ds.Tables[0];
            comb_Cpsnd.DisplayMember = "cpxh";
            comb_Cpsnd.ValueMember = "cpsnd";
            col_Zzbh.DataSource = ds.Tables[1];
            col_Zzbh.DisplayMember = "zzmc";
            col_Zzbh.ValueMember = "zzbh";
        }

        private void comb_Cpsnd_Leave(object sender, EventArgs e)
        {
            cmdText = @"select count(cpsnd) from zzsx where cpsnd=@cpsnd";
            string str_Result = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText,
                new SqlParameter("@cpsnd", comb_Cpsnd.SelectedValue.ToString().Trim())).ToString();
            if (str_Result == "0")
            {
                dat_Zzbh.Rows.Clear();//清空表
                but_Save.Text = "Save";
            }
            else
            {
                dat_Zzbh.Rows.Clear();//清空表
                cmdText = @"select zzbh from zzsx where cpsnd=@cpsnd order by yxj";
                ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText, new SqlParameter("@cpsnd", comb_Cpsnd.SelectedValue.ToString().Trim()));
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dat_Zzbh.Rows.Add();//新增加一行
                    dat_Zzbh.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][0].ToString();
                }
                but_Save.Text = "Modify";
            }
        }

        private void but_Save_Click(object sender, EventArgs e)
        {
            if (but_Save.Text == "Save")
            {
                cmdText = @"insert into zzsx(cpsnd,zzbh,yxj) values(@cpsnd,@zzbh,@yxj)";
                for (int i = 0; i < dat_Zzbh.Rows.Count - 1; i++)
                {
                    string str_Cpsnd = dat_Zzbh.Rows[i].Cells[0].Value.ToString();
                    SqlHelper.ExecuteNonQuery(connString, CommandType.Text, cmdText,
                        new SqlParameter("@cpsnd", comb_Cpsnd.SelectedValue.ToString().Trim()),
                        new SqlParameter("@zzbh", str_Cpsnd),
                        new SqlParameter("@yxj", (i + 1).ToString()));
                }
                MessageBox.Show("保存成功", "保存");
            }
            else
            {
                cmdText = "delete from zzsx where cpsnd=" + "'" + comb_Cpsnd.SelectedValue.ToString().Trim() + "'";
                SqlHelper.ExecuteNonQuery(connString, CommandType.Text, cmdText);//先删除表中该型号的组装顺序
                //再写入
                cmdText = @"insert into zzsx(cpsnd,zzbh,yxj) values(@cpsnd,@zzbh,@yxj)";
                for (int i = 0; i < dat_Zzbh.Rows.Count - 1; i++)
                {
                    string str_Cpsnd = dat_Zzbh.Rows[i].Cells[0].Value.ToString();
                    SqlHelper.ExecuteNonQuery(connString, CommandType.Text, cmdText,
                        new SqlParameter("@cpsnd", comb_Cpsnd.SelectedValue.ToString().Trim()),
                        new SqlParameter("@zzbh", str_Cpsnd),
                        new SqlParameter("@yxj", (i + 1).ToString()));
                }
                MessageBox.Show("更新成功", "更新");
            }
        }
    }
}
