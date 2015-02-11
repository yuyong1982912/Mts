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
//using System.Text.RegularExpressions;//正则表达式

namespace MTS
{
    public partial class Frm_Bzxm : Form
    {
        SqlConnection cn = new SqlConnection(SqlHelper.ConnString);
        public Frm_Bzxm()
        {
            InitializeComponent();
            Getlist();
        }

        private void Getlist()
        {
            cn.Open();
            var bzxm = cn.Query<Bzxmb>("select id,name from bzxmb", null);
            lis_bzxm.DataSource = bzxm;
            lis_bzxm.DisplayMember = "name";
            lis_bzxm.ValueMember = "id";
            cn.Close();
        }

        private void but_bzxm_Click(object sender, EventArgs e)
        {
            if (tex_bzxm.Text.ToString().Trim() == "")
            {
                MessageBox.Show("包装项目不能为空!", "错误");
            }
            else
            {
                cn.Open();
                cn.Execute(@"insert into bzxmb(name) values(@name)", new { name = tex_bzxm.Text.ToString().Trim() });//插入语句
                cn.Close();
                Getlist();
            }
        }
    }
}
