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
    public partial class frm_Luxian : Form
    {
        private string connString = SqlHelper.ConnString;//连接字符串
        private string cmdText;//需要执行的命令
        DataSet ds;//数据集

        public frm_Luxian()
        {
            InitializeComponent();
        }

        private void frm_Luxian_Load(object sender, EventArgs e)
        {
            string[] sDisplayFields = null;//定义一个数组
            
            //列出当前的所有工艺
            cmdText = @"select luxianid as 编号,luxian as 路线 from luxian;select gysn,gymc from gy";
            ds=SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText);
            
            //下面这一段是将类似"001,002,003"之类的改成"组装,精标,预标"
            foreach (DataRow row in ds.Tables[0].Rows)//遍历取出来的路线图
            {
                sDisplayFields = row[1].ToString().Split(',');//将路线按逗号进行切割
                string sStr = null;//定义一个字符变量
                for (int i = 0; i < sDisplayFields.Length; i++)
                {
                   cmdText=@"select gymc from gy where gysn=" + "'"+sDisplayFields[i]+"'";
                   sStr = sStr+SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText).ToString()+",";                   
                }
                row[1] = sStr.Substring(0,sStr.Length-1);//写回到数据库
            }
            
            dat_Xiancun.DataSource = ds.Tables[0];//窗体加载时出现现存的路线 
            Col_Luxian.DataSource = ds.Tables[1];//工艺名称表
            Col_Luxian.DisplayMember = "gymc";//显示值是工艺名称
            Col_Luxian.ValueMember = "gysn";//内码是工艺编码
        }

        private string zhenLi()//将表格中的数据整理成如下格式 001,002,003
        {
            string str_ZhenLi=null;
            for (int i = 0; i < dat_Luxian.Rows.Count-1; i++)
            {
                str_ZhenLi = str_ZhenLi + dat_Luxian.Rows[i].Cells[0].Value.ToString().Trim() +",";
            }
            return str_ZhenLi.Substring(0,str_ZhenLi.Length-1);//去掉最后一个逗号
        }

        private void but_Luxian_Click(object sender, EventArgs e)//存入数据库
        {
            //写得太烦了,出问题再写
            cmdText = @"insert into luxian(luxianid,luxian) values(@luxianid,@luxian)";
            string str_ButLuxian;
            str_ButLuxian = zhenLi();
            if (tex_LuXianId.Text.ToString().Trim().Length != 3)
            {
                MessageBox.Show("路线编号为3位", "错误");
                tex_LuXianId.Focus();
            }
            else
            {
                SqlHelper.ExecuteNonQuery(connString, CommandType.Text, cmdText,
                    new SqlParameter("@luxianid", tex_LuXianId.Text.ToString().Trim()),
                    new SqlParameter("@luxian", str_ButLuxian));
                MessageBox.Show("保存成功", "保存");
            }

        }
    }
}
