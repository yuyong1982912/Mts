using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using System.Text.RegularExpressions;//正则表达式

namespace MTS
{
    public partial class BzBom : Form
    {
        SqlConnection cn = new SqlConnection(SqlHelper.ConnString);//数据库连接

        public BzBom()
        {
            InitializeComponent();
            using (cn) //自动打开和关闭数据连接
            {
                string sql_bzxmb=@"select id,name from bzxmb";
                var bzxm = cn.Query<Bzxmb>(sql_bzxmb, null);//填充项目列表
                Col_Bzxm.DataSource = bzxm;
                Col_Bzxm.DisplayMember = "name";
                Col_Bzxm.ValueMember = "id";
                string sql_bzbomf_sel = @"Select bomid,name from bzbomf";
                 var bzbomf=cn.Query<Mbzbomf>(sql_bzbomf_sel,null);
                 dat_bzfb.DataSource = bzbomf;
            }
        }

        private void but_Ok_Click(object sender, EventArgs e)
        {
            string str_bm = tex_bm.Text.ToString().Trim();
            string str_mc = tex_mc.Text.ToString().Trim();
            if ((Regex.IsMatch(str_bm, @"^\d{3}$")) && (str_mc !="") && (dat_Bzzb.RowCount >1)) //正则表达式，只能输入3位数字
            {
                
                    string sql_bzbomf_ins = @"insert into bzbomf(bomid,name) values(@bomid,@name)";
                    string sql_bzbomz_ins = @"insert into bzbomz(bomid,sx,bzxm,bzsn) values(@bomid,@sx,@bzxm,@bzsn)";
                    cn.ConnectionString = SqlHelper.ConnString;
                    cn.Open();
                    SqlTransaction tran = cn.BeginTransaction();//启动一个事务，保证父子表的写入一致性
                    //写入父表
                    cn.Execute(sql_bzbomf_ins, new { bomid = tex_bm.Text.ToString().Trim(), name = tex_mc.Text.ToString().Trim() }, tran);
                    //写入子表
                    foreach (DataGridViewRow row in dat_Bzzb.Rows)
                    {
                        if (row.IsNewRow)//最后一行(用于输入新数据行)
                        { break; }//跳出循环
                        else
                        {
                            if ((row.Cells[0].Value == null) || (row.Cells[1].Value == null))//单元格不能为空
                            { MessageBox.Show("单元格的值不能为空！", "错误"); }
                            else
                            {
                                cn.Execute(sql_bzbomz_ins, new { bomid = tex_bm.Text.ToString().Trim(),
                                                                                 sx = row.Cells[0].RowIndex.ToString(),
                                                                                 bzxm = row.Cells[0].Value.ToString(),
                                                                                 bzsn = row.Cells[1].Value.ToString() }, tran); 
                            }
                        }
                    }
                    tran.Commit();//提交事务
                    cn.Close();
                    MessageBox.Show("写入成功!", "成功");
            }
            else
            {
                MessageBox.Show("编码不是三位数字或名称为空或表格为空！", "错误");
            }
        }
    }
}
