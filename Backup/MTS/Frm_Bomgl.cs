using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;

namespace MTS
{
    public partial class Frm_Bomgl : Form
    {
        SqlConnection cn = new SqlConnection(SqlHelper.ConnString);//数据库连接

        public Frm_Bomgl()
        {
            InitializeComponent();
            string sql_sel = @"select cpsnd,cpxh from cpxh where zzp=1;select bomid,name from bzbomf";
            DataSet ds = SqlHelper.ExecuteDataset(cn, CommandType.Text, sql_sel);     

            dat_Cp.DataSource = ds.Tables[0]; //产品型号下拉列表
            dat_Cp.sDisplayField = "cpsnd,cpxh";
            dat_Cp.sDisplayMember = "cpsnd";
            dat_Cp.sKeyWords = "cpxh";
            dat_Cp.RowFilterVisible = true;

            dat_Bzbom.DataSource =ds.Tables[1];//包装BOM下拉列表
            dat_Bzbom.sDisplayField = "bomid,name";
            dat_Bzbom.sDisplayMember = "bomid";
            dat_Bzbom.sKeyWords = "name";
            dat_Bzbom.RowFilterVisible = true;              
        }

        private void but_Ok_Click(object sender, EventArgs e)
        {
            if ((dat_Cp.Text.ToString().Trim() == "") || (dat_Bzbom.Text.ToString().Trim() == ""))
            {
                MessageBox.Show("产品编号或包装BOM不能为空", "错误");
            }
            else
            {
               if (cn.State==ConnectionState.Closed)
               {
                   cn.ConnectionString=SqlHelper.ConnString;
                   cn.Open();
               }	
                string sql_cpybzbomgl_ins = @"insert into cpybzbomgl(cpbh,bomid) values(@cpbh,@bomid)";
                cn.Execute(sql_cpybzbomgl_ins, new { cpbh = dat_Cp.Text.ToString().Trim(), bomid = dat_Bzbom.Text.ToString().Trim() });
                MessageBox.Show("写入成功", "成功");
                cn.Close();                
            }           
        }
    }
}
