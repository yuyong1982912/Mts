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
    public partial class frm_Input : Form
    {
        private string connString = SqlHelper.ConnString;//连接字符串
        private string cmdText;//需要执行的命令
        DataSet ds;//数据集
        frm_Input frm_Input1;//引用窗体
        string userid;
        bool boo_sfcs;//在PASS以后是否可以再次扫描

        public frm_Input()
        {
            InitializeComponent();
        }

        public frm_Input(string id)
        {
            userid = id;
            InitializeComponent();
        }

        private void frm_Input_Load(object sender, EventArgs e)//初始化下拉文本框
        {
            cmdText = @"select gysn,gymc from gy where gysn != '001';select cwdm as 错误代码,cwms as 错误描述 from cwdmb;select cpsnd as 产品代码,cpxh as 产品型号 from cpxh";
            ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText);
            com_Zd.DataSource = ds.Tables[0];
            com_Zd.DisplayMember = "gymc";
            com_Zd.ValueMember = "gysn";
            
            dW_Err.DataSource = ds.Tables[1];
            dW_Err.sDisplayField = "错误代码,错误描述";
            dW_Err.sDisplayMember = "错误描述";
            dW_Err.sValueMember = "错误代码";
            dW_Err.sKeyWords = "错误代码";
            dW_Err.RowFilterVisible = true;

            dw_xh.DataSource = ds.Tables[2];
            dw_xh.sDisplayField = "产品代码,产品型号";
            dw_xh.sDisplayMember = "产品代码";
            dw_xh.sKeyWords = "产品型号";
            dw_xh.RowFilterVisible = true;

           this.BindData();
        }       

        #region 检测输入的条码是否与当前正要生产的条码一致
        private bool tmyz(string str_tm)
        {
            try
            {
                if (dw_xh.Enabled) //如果此站点需要验证型号
                {                    
                    if (dw_xh.Text != "" && dw_xh.Text.ToString() == str_tm)
                    {
                        return true;                       
                    }
                    else
                    {
                        MessageBox.Show("型号不能为空或条码与型号不一致", "错误");
                        dw_xh.Focus();
                        return false;
                    }                   
                }                
                    return true; //如果此站点不需要验证型号，直接返回True               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "错误");
                return false;
            }
            
        }
        #endregion


        private void com_Zd_SelectedIndexChanged(object sender, EventArgs e)
        {           
            frm_Input1 = this;//窗体实例化            
            frm_Input1.Text = com_Zd.Text;//窗体的标题            
            cmdText = @"select sfjy from gy where gysn=@gysn";//取得是否需要检验的模块
            string cmdText1=@"select sfyzxh from gy where gysn=@gysn";//取得是否需要验证型号
            string cmdText2 = @"select sfcs from gy where gysn=@gysn";//取得是否可以PASS以后再扫描
            string str0 = com_Zd.SelectedValue.ToString();//取得组合框中的存储值
            if (str0.Length==3)//判断取的值是是3位数字
            {
                string str1 = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText, new SqlParameter("@gysn", str0)).ToString();
                string str2 = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText1, new SqlParameter("@gysn", str0)).ToString();
                string str3 = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText2, new SqlParameter("@gysn", str0)).ToString();
                //是否激活检验模块
                if (str1 == "True") {   gro_POF.Enabled = true; } else { gro_POF.Enabled = false; }
                //是否激活型号检查模块
                if (str2 == "True") { dw_xh.Enabled = true; } else { dw_xh.Enabled = false; }
                //返回一个PASS后是否可以重新扫描
                if (str3 == "True") { boo_sfcs = true; } else { boo_sfcs = false; }
            }
            
        }

        private void rad_Fail_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_Fail.Checked)
            {
                
                dW_Err.Enabled = true;
                tex_Memo.Enabled = true;//激活备注
            }
            else
            {
                
                dW_Err.Enabled = false;
                tex_Memo.Enabled = false;
            }
        }

        private string findLoad()//找到当前条码的路线图
        {
            if (tex_Barcode.Text.ToString().Trim().Length == 18)
            {
                string strFind;
                string strFindPre = tex_Barcode.Text.ToString().Trim().Substring(0, 6);
                cmdText = @"SELECT count(luxian.luxian) FROM road LEFT OUTER JOIN luxian ON road.roadid = luxian.luxianID where road.cpsnd=@cpsnd";
                string strFindResult = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText, new SqlParameter("@cpsnd", strFindPre)).ToString();
                if (strFindResult == "1")
                {
                    cmdText = @"SELECT luxian.luxian FROM road LEFT OUTER JOIN luxian ON road.roadid = luxian.luxianID where road.cpsnd=@cpsnd";
                    strFind = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText, new SqlParameter("@cpsnd", strFindPre)).ToString();
                    return strFind;
                }
                else
                {
                    return "Not";
                }

            }
            else { return "Not"; }            
        }

        private string findPre()//找到上一站,如果返回值为N,表示没有找到上一站
        {
            
            string strFindPre = "N";
            //MessageBox.Show(findLoad());
            if (findLoad() != "Not")
            {
                string[] str;//声明一个变量数组
                str = findLoad().Split(new[] { ',' });//以逗号为分隔符切分出每个数组
                for (int i = 0; i < str.Length; i++)
                {
                    if (com_Zd.SelectedValue.ToString() == str[i].ToString().Trim())//如果当前站点等于数组中的某个值,返回数组的下标
                    {
                        if (i - 1 >= 0)//如果不是第一站的话
                        {
                            strFindPre = str[i - 1].ToString().Trim();//返回上一站的工艺
                        }
                        else
                        {
                            strFindPre = str[i].ToString().Trim();//小于0的话(第一站)返回本站的工艺                             
                        }
                    }
                }
                return strFindPre;//返回工艺编号
            }
            else
            {
                return strFindPre;
            }      
        }

        private bool dyz()//检测是不是第一站
        {
            bool booDyz=false;
            if (findLoad() != "Not")
            {
                string[] str;//声明一个变量数组
                str = findLoad().Split(new[] { ',' });//以逗号为分隔符切分出每个数组
                for (int i = 0; i < str.Length; i++)
                {
                    if (com_Zd.SelectedValue.ToString() == str[i].ToString().Trim())//如果当前站点等于数组中的某个值,返回数组的下标
                    {
                        if (i - 1 >= 0)//如果不是第一站的话
                        {
                            booDyz=false;//返回假
                        }
                        else
                        {
                            booDyz=true;//第一站返回真
                        }
                    }
                }
                return booDyz;
            }
            else
            {
                return booDyz;
            }      
        }

        //private bool zhyz()//检测是不是最后一站,是最后一站返回真
        //{
        //    bool booDyz=false;
        //    if (findLoad() != "Not")
        //    {
        //        string[] str;//声明一个变量数组
        //        str = findLoad().Split(new[] { ',' });//以逗号为分隔符切分出每个数组
        //        for (int i = 0; i < str.Length; i++)
        //        {
        //            if (com_Zd.SelectedValue.ToString() == str[i].ToString().Trim())//如果当前站点等于数组中的某个值,返回数组的下标
        //            {
        //                if (i != str.Length-1)//如果是最后一站的话
        //                {
        //                    booDyz=false;//返回假
        //                }
        //                else
        //                {
        //                    booDyz=true;//第一站返回真
        //                }
        //            }
        //        }
        //        return booDyz;
        //    }
        //    else
        //    {
        //        return booDyz;
        //    }      
        //}
        

        private bool ztjc()//检测上一站的状态,状态检查
        {
            string strcpsn = tex_Barcode.Text.ToString().Trim();
            string strgysn = findPre().Trim().ToString();
            string strztjc;
            DataSet ds1;
            if ((strcpsn.Length != 18) || (strgysn == "N"))
            {
                MessageBox.Show("条码不足18位或前置工艺没有", "错误");
                return false;//条码不足18位,

            }
            else//如果找到上一站
            {
                if (dyz())//如果是第一站
                {
                    return true;//返回真
                }
                else
                {
                    cmdText = @"select count(gyzt) from cpzt where cpsn=@cpsn and gysn=@gysn";
                    strztjc = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText, new SqlParameter("@cpsn", strcpsn), new SqlParameter("@gysn", strgysn)).ToString();
                    if (strztjc != "0")//有该产品的信息
                    {
                        cmdText = @"select gyzt,wxzt from cpzt where cpsn=@cpsn and gysn=@gysn order by sj desc";
                        ds1 = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText, new SqlParameter("@cpsn", strcpsn), new SqlParameter("@gysn", strgysn));
                        if (ds1.Tables[0].Rows[0][0].ToString() == "1") 
                        {
                            return true;//并且经过了本站点并且维修状态为好的话(双字段都为1)
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }                
                
            }
        }
        /// <summary>
        /// 用来刷新柱状图
        /// </summary>
        private void BindData()
        {
            DateTime dt= serverTime.sDateTime;//当前时间
            string strsj = dt.GetDateTimeFormats('s')[0].ToString().Substring(0,10);   //取时间前10位
            chartlet1.ChartTitle.Text = "每小时产量";
            for (int i = 0; i < 11; i++) //柱子的颜色都设置为黑色
            {
                chartlet1.Aurora[i] = Color.Blue;    
            }   

            chartlet1.AppearanceStyle = FanG.Chartlet.AppearanceStyles.Bar_2D_Aurora_FlatCrystal_Glow_NoBorder;
            chartlet1.Background.Paper = Color.FromArgb(0, 0, 0, 0);
            string cmdText = "select  substring(convert(varchar(13),sj,20),12,2)+':00' as 小时,count(cpsn) as 产量 from cpzt  where gysn=@gysn and convert(varchar(10),sj,20)=@sj  group by convert(varchar(13),sj,20)";
            DataSet ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText,
                                                                        new SqlParameter("@gysn",com_Zd.SelectedValue.ToString().Trim()),
                                                                        new SqlParameter("@sj",strsj));            
            chartlet1.BindChartData(ds.Tables[0]);
        }

        private void but_Save_Click(object sender, EventArgs e)
        {
            string strSaveCpsn = tex_Barcode.Text.ToString().Trim();//产品条码
            string strSaveGysn = com_Zd.SelectedValue.ToString().Trim();//工艺编码
            string strSaveCwdm = dW_Err.Value.ToString().Trim();//错误代码
            string strSaveBz = tex_Memo.Text.Trim().ToString();//备注
            //string strSaveWgzt = "1";//完工状态
            DateTime strSaveSj = serverTime.sDateTime;//当前时间
            string strSaveGyzt="1";//工艺状态
            //string strSaveWxzt = "1";//维修状态
            if (tmyz(tex_Barcode.Text.ToString().Substring(0,6))==true)//如果输入的条码与正在生产的条码一致
            {
                if (ztjc())//如果状态为真
                {
                    if (gro_POF.Enabled == true)//如果Pass Or Fail可用
                    {
                        if (rad_Pass.Checked)
                        {
                            strSaveGyzt = "1";//如果选中pass,工艺状态为1
                        }
                        else
                        {
                            strSaveGyzt = "0";//如果选中Fail,工艺状态为0
                            //strSaveWxzt = "0";//维修状态也为0
                        }

                    }
                                       
                    //加入一段验证代码，如果条码在此站已PASS过一次，不允许再存储一次
                    cmdText = @"select count(cpsn) from cpzt where cpsn=@cpsn and gysn=@gysn and gyzt='1'";
                    string strResult = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText, new SqlParameter("@cpsn", strSaveCpsn),
                                                new SqlParameter("@gysn", strSaveGysn)).ToString();
                    if (strResult == "1" && boo_sfcs==false)//如果得到结果为1的话，表明此条码已在此站PASS过了,并且此工艺在PASS以后不可以再扫描的话
                    {
                        MessageBox.Show("此序列号已在此站点输入过一次并且为PASS，不允许再输入", "错误");
                        tex_Barcode.Focus();//再得到焦点
                        tex_Barcode.Text = "";//清空文本框
                    }
                    else
                    {
                        //如果此条码进行了维修流程，但维修没有维修过直接返回来，是不允许入库的
                        cmdText = @"select count(cpsn) from wxb where (gysn=@gysn) and (cpsn=@cpsn) and (wxh is null) ";
                        string strWxh = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText,
                            new SqlParameter("@cpsn", strSaveCpsn),
                            new SqlParameter("@gysn", strSaveGysn)).ToString();
                        if (strWxh == "0")//如果不存在此条记录的话
                        {
                            cmdText = @"insert into cpzt(cpsn,gysn,gyzt,sj,mtsname) values(@cpsn,@gysn,@gyzt,@sj,@mtsname)";//写入到产品状态表
                            SqlHelper.ExecuteNonQuery(connString, CommandType.Text, cmdText,
                                new SqlParameter("@cpsn", strSaveCpsn),
                                new SqlParameter("@gysn", strSaveGysn),
                                new SqlParameter("@gyzt", strSaveGyzt),
                                new SqlParameter("@sj", strSaveSj),
                                //new SqlParameter("@mtsname",this.MdiParent.Text.Substring(this.MdiParent.Text.LastIndexOf("-")+1))
                                new SqlParameter("@mtsname", userid));

                            lis_Result.Items.Add(tex_Barcode.Text.Trim().ToString() + "成功保存到数据库");//在右边显示成功与否
                            lis_Result.SelectedIndex = lis_Result.Items.Count - 1;

                            //判断错误代码和备注是否可用,写维修表
                            if (tex_Memo.Enabled == true)//如果可用,将错误写入到维修表
                            {
                                cmdText = @"insert into wxb(cpsn,gysn,cwdm,cwbz,sj,mtsname) values(@cpsn,@gysn,@cwdm,@cwbz,@sj,@mtsname)";
                                SqlHelper.ExecuteNonQuery(connString, CommandType.Text, cmdText,
                                    new SqlParameter("@cpsn", strSaveCpsn),
                                    new SqlParameter("@gysn", strSaveGysn),
                                    new SqlParameter("@cwdm", strSaveCwdm),
                                    new SqlParameter("@cwbz", strSaveBz),
                                    new SqlParameter("@sj", strSaveSj),
                                    //new SqlParameter("@mtsname", this.MdiParent.Text.Substring(this.MdiParent.Text.LastIndexOf("*") + 1))
                                    new SqlParameter("@mtsname", userid));
                            }
                            else//如果没有发现错误的话，又是最后一站的话写入一条完工记录
                            {
                                //判断是否是最后一站,如果是最后一站的话,存储一条完工记录,并记录时间
                                //if (zhyz())
                                //{
                                //    cmdText = @"insert into cpzt(cpsn,wgzt,sj) values(@cpsn,@wgzt,@sj)";
                                //    SqlHelper.ExecuteNonQuery(connString, CommandType.Text, cmdText, new SqlParameter("@cpsn", strSaveCpsn), new SqlParameter("@wgzt", strSaveWgzt), new SqlParameter("@sj", strSaveSj));
                                //    Log.wLog = tex_Barcode.Text.ToString().Trim() + "物料已完成所有工艺"; //记录一日志到c:\logfile.txt
                                //}
                            }

                            //成功清空文本框，如果文本框没有清空的话，说明存储到数据库出现问题
                            tex_Barcode.Focus();//再得到焦点
                            tex_Barcode.Text = "";//清空文本框
                        }
                        else
                        {
                            MessageBox.Show("该产品还未维修完成，请先进行维修", "错误");
                            tex_Barcode.Focus();//获取焦点
                            tex_Barcode.Text = "";//清空文本

                        }
                    }

                }
                else
                {
                    MessageBox.Show("上一站没有输入或上一站没有通过或上一站没有维修", "错误");
                    tex_Barcode.Focus();//再得到焦点
                    tex_Barcode.Text = "";//清空文本框
                }
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BindData();
            this.chartlet1.Refresh();
        }
    }
}
