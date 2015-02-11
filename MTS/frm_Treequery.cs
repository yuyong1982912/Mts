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
    public partial class frm_Treequery : Form
    {
        string cmdText;
        string connString = SqlHelper.ConnString;
        DataSet ds;
        public frm_Treequery()
        {
            InitializeComponent();
        }

        private void tex_Sn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果按下回车键的话
            {
                if (tex_Sn.Text.Length != 18)
                {
                    MessageBox.Show("条码长度不足18位，请重新输入", "错误");
                    tex_Sn.Text = "";
                    tex_Sn.Focus();
                }
                else
                {
                    //第一个标签
                    cmdText = @"select count(cpsn) from cpzt where cpsn = @cpsn";
                    string strResult = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText, new SqlParameter("@cpsn", tex_Sn.Text.Trim().ToString())).ToString();
                    if (strResult != "0")
                    {
                        cmdText = @"select t0.gysn as 工艺编号,t1.gymc as 工艺名称,case when (t0.gyzt=1) then 'Pass' when (t0.gyzt=0) then 'Fail' end as 工艺状态,                                        sj as 时间,mtsname as 用户 from cpzt t0 left join gy t1 on t0.gysn=t1.gysn
                                        where cpsn=@cpsn";
                        ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText, new SqlParameter("@cpsn",
                            tex_Sn.Text.Trim().ToString()));                        
                        dat_Cpzt.DataSource = ds.Tables[0];
                    }

                    //第二个标签
                    cmdText = @"select count(cpsn) from zzbd where cpsn=@cpsn or zjsn=@cpsn";
                    strResult = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText, new SqlParameter("@cpsn", tex_Sn.Text.Trim().ToString())).ToString();
                    if (strResult != "0")
                    {
                        cmdText = @"select t0.cpsn as 产品编号,t0.zzgy as 组装工艺,t0.zjsn as 组装编号,sj as 时间,mtsuser as 用户 from zzbd t0 
                                        where cpsn=@cpsn or zjsn=@cpsn";
                        ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText, new SqlParameter("@cpsn",
                            tex_Sn.Text.Trim().ToString()));
                         dat_Cpbd.DataSource = ds.Tables[0];
                    }

                    //第三个标签
                    cmdText = @"select count(cpsn) from wxh where cpsn=@cpsn";
                    strResult = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText, new SqlParameter("@cpsn", tex_Sn.Text.Trim().ToString())).ToString();
                    if (strResult != "0")
                    {
                        cmdText = @"SELECT
	                                        cpsn AS 产品条码,
	                                        t1.gymc AS 工艺名称,
	                                        t2.cwms AS 错误描述,
	                                        t3.wxms AS 维修描述,
	                                        wxbz AS 维修备注,
	                                        sj AS 时间
                                        FROM
	                                        wxh t0
                                        LEFT JOIN gy t1 ON t0.gysn = t1.gysn
                                        LEFT JOIN cwdmb t2 ON t0.cwdm = t2.cwdm
                                        LEFT JOIN wxdmb t3 ON t0.wxdm = t3.wxdm
                                        where cpsn=@cpsn";
                        ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText, new SqlParameter("@cpsn",
                            tex_Sn.Text.Trim().ToString()));
                        dat_Wxjl.DataSource = ds.Tables[0];
                    }

                    //第四个标签
                    cmdText = @"select count(cpsn) from wxb where cpsn=@cpsn";
                    strResult = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText, new SqlParameter("@cpsn", tex_Sn.Text.Trim().ToString())).ToString();
                    if (strResult != "0")
                    {
                        cmdText = @"SELECT
	                                        cpsn AS 产品条码,
	                                        t1.gymc AS 工艺名称,
	                                        t2.cwms AS 错误描述,	                                        
	                                        cwbz AS 错误备注,
	                                        sj AS 时间,
                                            t0.wxh as 维修好,
                                            t0.mtsname as 用户
                                        FROM
	                                        wxb t0
                                        LEFT JOIN gy t1 ON t0.gysn = t1.gysn
                                        LEFT JOIN cwdmb t2 ON t0.cwdm = t2.cwdm                                       
                                        where cpsn=@cpsn";
                        ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText, new SqlParameter("@cpsn",
                            tex_Sn.Text.Trim().ToString()));
                        dat_Bljl.DataSource = ds.Tables[0];
                    }

                    //第五个标签
                    cmdText = @"SELECT COUNT(*) FROM snrecord WHERE sn=@sn";
                    strResult = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText, new SqlParameter("@sn", tex_Sn.Text.Trim().ToString())).ToString();
                    if (strResult !="0")
                    {
                        cmdText = @"SELECT
	                                    sn AS 产品条码,
	                                    mo AS 产品型号,
	                                    bir AS 烧机室,
	                                    en AS 烧机人员编号,
	                                    ts AS 烧机开始时间,
	                                    te AS 烧机结束时间
                                    FROM
	                                    snrecord
                                    WHERE sn=@sn";
                        ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText, new SqlParameter("@sn", tex_Sn.Text.Trim().ToString()));
                        dat_sjcx.DataSource = ds.Tables[0];
                    }
                }
            }
        }

        
    }
}
