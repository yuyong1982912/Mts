using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MTS
{
    public partial class frm_JgGy : Form
    {
        private string connString = SqlHelper.ConnString;//连接字符串
        private string cmdText;//需要执行的命令
        DataSet ds;//数据集

        public frm_JgGy()
        {
            InitializeComponent();
        }

        private void tex_Sn_Leave(object sender, EventArgs e)
        {
            if (tex_Sn.Text.ToString().Trim().Length != 18)
            {
                MessageBox.Show("字符串长度不足18位,请重新输入", "错误");
            }
            else
            {
                
                cmdText = "SELECT gy.gymc AS 工艺名称, (case cpzt.gyzt when '1' then 'PASS' when '0' then 'FAIL' end) as 工艺状态, cpzt.sj as 输入时间" +
                    " FROM cpzt LEFT OUTER JOIN gy ON cpzt.gysn = gy.gysn" +
                    " WHERE (cpzt.cpsn = '" + tex_Sn.Text.ToString().Trim() + "')";//构造出查询语句

                ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText);
                dat_Result.DataSource = ds.Tables[0];
            }
        }
    }
}
