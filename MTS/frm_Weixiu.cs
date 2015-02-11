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
    public partial class frm_Weixiu : Form
    {
        private string connString = SqlHelper.ConnString;//连接字符串
        private string cmdText;//需要执行的命令
        DataSet ds;//数据集
        string gysn;//工艺编码
        string cwdm;//错误代码
        DateTime dat_dt;//维修表中的时间

        public frm_Weixiu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            cmdText = @"insert into wxh(cpsn,gysn,cwdm,wxdm,wxbz,sj) values(@cpsn,@gysn,@cwdm,@wxdm,@wxbz,@sj)";//维修记录写入到维修好表中
            string strCpsn = tex_Weixiu.Text.Trim().ToString();
            string strWxdm = dW_Wxdm.Value.ToString();
            string strWxbz = tex_Wxbz.Text.Trim().ToString();
            DateTime strSj = serverTime.sDateTime;
            SqlHelper.ExecuteNonQuery(connString, CommandType.Text, cmdText,
                new SqlParameter("@cpsn", strCpsn),
                new SqlParameter("@gysn", gysn),
                new SqlParameter("@cwdm", cwdm),
                new SqlParameter("@wxdm", strWxdm),
                new SqlParameter("@wxbz", strWxbz),
                new SqlParameter("@sj", strSj));
            cmdText =@"update wxb set wxh='Y' where cpsn=@cpsn and sj=@sj";//更新回维修表中的维修好字段为Y
            SqlHelper.ExecuteNonQuery(connString,CommandType.Text,cmdText,new SqlParameter("@cpsn",strCpsn),new SqlParameter("@sj",dat_dt));
            MessageBox.Show("维修成功", "谢谢");
            tex_Weixiu.Focus();//条码输入框取得焦点
            tex_Weixiu.Text = "";//清空条码框
        }

        private void frm_Weixiu_Load(object sender, EventArgs e)
        {
            cmdText = @"select wxdm as 维修代码,wxms as 维修描述 from wxdmb";//检出维修代码表
            ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText);           

            dW_Wxdm.DataSource = ds.Tables[0];//下拉编辑窗体的数据源
            dW_Wxdm.sDisplayField = "维修代码,维修描述";
            dW_Wxdm.sDisplayMember = "维修描述";
            dW_Wxdm.sValueMember = "维修代码";
            dW_Wxdm.sKeyWords = "维修代码";
            dW_Wxdm.RowFilterVisible = true;
        }

        

        private void tex_Weixiu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //如果按下回车键
            {
                string str_tex_Weixiu_Leave;
                str_tex_Weixiu_Leave = tex_Weixiu.Text.Trim().ToString();//得到输入的条码
                cmdText = @"select count(cpsn) from wxb where cpsn=@cpsn and wxh is null";//看一下这个条码是否存在于维修表中,是否需要维修
                string str_Result;
                str_Result = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText, new SqlParameter("@cpsn", str_tex_Weixiu_Leave)).ToString();
                if (str_Result != "0")
                {
                    cmdText = @"SELECT wxb.cpsn, wxb.gysn, gy.gymc,wxb.cwdm, wxb.cwbz, cwdmb.cwms,wxb.sj
                        FROM wxb INNER JOIN
                        gy ON wxb.gysn = gy.gysn INNER JOIN
                        cwdmb ON wxb.cwdm = cwdmb.cwdm 
                        where wxb.cpsn=@cpsn and wxh is null";//得到错误
                    ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText, new SqlParameter("@cpsn", str_tex_Weixiu_Leave));
                    tex_gy.Text = ds.Tables[0].Rows[0][2].ToString();//工艺
                    tex_Err.Text = ds.Tables[0].Rows[0][5].ToString();//错误描述
                    tex_Cwbz.Text = ds.Tables[0].Rows[0][4].ToString();//错误备注
                    gysn = ds.Tables[0].Rows[0][1].ToString();//工艺代码
                    cwdm = ds.Tables[0].Rows[0][3].ToString();//错误代码
                    dat_dt = (DateTime)ds.Tables[0].Rows[0][6];//时间
                }
                else
                {
                    MessageBox.Show("该产品不需要维修", "错误");
                    tex_Weixiu.Focus();
                    tex_Weixiu.Text = "";
                }
            }
        }
        
    }
}
