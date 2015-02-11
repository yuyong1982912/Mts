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
    public partial class frm_QueryBd : Form
    {
        private string connString = SqlHelper.ConnString;//连接字符串
        private string cmdText;//需要执行的命令
        DataSet ds;//数据集

        public frm_QueryBd()
        {
            InitializeComponent();
        }

        private void tex_Sn_Leave(object sender, EventArgs e)
        {
            if (tex_Sn.Text.Trim().ToString().Length != 18)
            {
                MessageBox.Show("条码长度不足18位,请重新输入", "错误");
            }
            else
            {
                cmdText = "select zzgy as 组装工艺,zjsn as 组件序列号,sj as 时间,mtsuser as 员工 from zzbd where cpsn =" + "'" + tex_Sn.Text.Trim().ToString() + "'";
                ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText);
                dat_Result.DataSource = ds.Tables[0];
            }
        }
    }
}
