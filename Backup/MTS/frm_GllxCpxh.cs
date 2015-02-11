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
    public partial class frm_GllxCpxh : Form
    {
        private string connString = SqlHelper.ConnString;//连接字符串
        private string cmdText;//需要执行的命令
        DataSet ds;//数据集
        private string str_GllxCpxh;//字符变量
        public string Str_GllxCpxh { 
            get
            { return str_GllxCpxh; }
            set
            { str_GllxCpxh=value; }
             }//返回到主窗口的值



        public frm_GllxCpxh()
        {
            InitializeComponent();
        }

        private void frm_GllxCpxh_Load(object sender, EventArgs e)
        {
            cmdText = @"select cpsnd,cpxh from cpxh";
            ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText);
            dat_GllxCpxh.DataSource = ds.Tables[0];//得到产品型号表
        }

        private void dat_GllxCpxh_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Str_GllxCpxh = dat_GllxCpxh.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();//取得双击行中的第一列的值
            this.DialogResult = DialogResult.Cancel;
            
        }
    }
}
