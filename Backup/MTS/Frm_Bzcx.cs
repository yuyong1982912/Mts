using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Dapper;
using System.Data.SqlClient;

namespace MTS
{
    public partial class Frm_Bzcx : Form
    {
        SqlConnection cn = new SqlConnection(SqlHelper.ConnString);
        public Frm_Bzcx()
        {
            InitializeComponent();
        }

        public class BzfbSel//查询出来的父表
        {
            public int? id { get; set; }
            public DateTime bzsj { get; set; }
            public string name { get; set; }
        }

        public class Bzzbsel//查询出来的子表
        {
            public string name { get; set; }
            public string xmsn { get; set; }
        }

        private void tex_Sn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if (Regex.IsMatch(tex_Sn.Text.ToString().Trim(),@"^\d{18}$"))
                {
                    if (cn.State == ConnectionState.Closed) //判断连接状态
                    {
                        cn.ConnectionString = SqlHelper.ConnString;
                        cn.Open();
                    }
                    using (cn)
                    {
                        string sql_bzfb_sel= @"select ta.id,bzsj,tb.name from bzfb ta left join mtsuser tb on ta.bzry=tb.id where ta.cpsn=@cpsn ";
                        var bzfb = cn.Query<BzfbSel>(sql_bzfb_sel, new { cpsn = tex_Sn.Text.ToString().Trim() });
                        dat_bzfb.DataSource = bzfb;
                    }                   
                }
                else
                { 
                    MessageBox.Show("待查条码不足18位", "错误");
                    tex_Sn.Focus();
                    tex_Sn.Text = "";
                }
            }
        }

        private void dat_bzfb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cn.State == ConnectionState.Closed) //判断连接状态
            {
                cn.ConnectionString = SqlHelper.ConnString;
                cn.Open();
            }
            using (cn)
            {
                string sql_bzzb_sel = @"select ta.bzfbid,tb.name,ta.xmsn from bzzb ta left join bzxmb tb on ta.bzxm=tb.id where ta.bzfbid=@bzfbid";
                var bzzb = cn.Query<Bzzbsel>(sql_bzzb_sel, new { bzfbid = dat_bzfb.Rows[e.RowIndex].Cells["id"].Value.ToString().Trim() });
                dat_Bzzb.DataSource=bzzb;
            }

        }
    }
}
