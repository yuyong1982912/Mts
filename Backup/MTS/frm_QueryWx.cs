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
    public partial class frm_QueryWx : Form
    {
        private string connString = SqlHelper.ConnString;//连接字符串
        private string cmdText;//需要执行的命令
        DataSet ds;//数据集

        public frm_QueryWx()
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

                cmdText = "SELECT gy.gymc as 工艺名称, cwdmb.cwms as 错误描述, wxdmb.wxms as 维修描述, wxh.wxbz as 维修备注, wxh.sj as 维修时间" +
" FROM wxh LEFT OUTER JOIN gy ON wxh.gysn = gy.gysn LEFT OUTER JOIN cwdmb ON wxh.cwdm = cwdmb.cwdm LEFT OUTER JOIN wxdmb ON wxh.wxdm = wxdmb.wxdm" +
" WHERE (wxh.cpsn = '" + tex_Sn.Text.ToString().Trim() +"')";//构造 出查询语句
                ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText);
                dat_Result.DataSource = ds.Tables[0];
            }
        }
    }
}
