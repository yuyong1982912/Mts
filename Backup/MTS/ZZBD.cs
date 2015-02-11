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
    public partial class frm_Zzbd : Form
    {
        private string connString=SqlHelper.ConnString;//连接字符串
        private string cmdText;//需要执行的命令
        DataSet ds;//数据集
        string userid;

        public frm_Zzbd()
        {
            InitializeComponent();                

        }

        public frm_Zzbd(string id)
        {
            userid = id;
            InitializeComponent(); 
        }

        private void frm_Zzbd_Load(object sender, EventArgs e)
        {            
            cmdText=@"select * from cpxh where zzp=1";//取产品数据库的组装品列表
            ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText);//得到数据集
            com_Model.DataSource = ds.Tables[0];//绑定数据表
            com_Model.DisplayMember = "cpxh";//显示产品名称
            com_Model.ValueMember = "cpsnd";//存储产品短码
            com_Model.Focus();//组合框获得焦点
        }           

        private bool selectCpsn()//检测barcode表中是否存在该产品编号
        {
            
            string strSelectCpsn = SqlHelper.ExecuteScalar(connString, CommandType.Text, @"select count(cpsn) from zzbd where cpsn=@cpsn and zzgy=@zzgy ", 
                new SqlParameter("@cpsn", tex_Sn.Text.ToString().Trim()),
                new SqlParameter("@zzgy",lab_Zzsn.Text.Trim().ToString())).ToString();
            if (strSelectCpsn == "0")
            {
                return true;//如果barcode表中不存在该产品编号返回真的
            }
            else
            {
                return false;//存在返回假的
            }
            
        }

        private bool bom(string strBom1)//与BOM作比较查看输入的条码是否属于这个型号
        {

            string strBom=tex_Sn.Text.ToString().Trim().Substring(0,6);
            string bomCmdText="select bcpsn from bom where zzbh =" + "'"+strBom1.ToString().Trim()+"' and cpsnd ="+"'"+strBom+"'";           
            //取出bom表中对应的短码
            string strBom2 = SqlHelper.ExecuteScalar(connString, CommandType.Text, bomCmdText).ToString();
            if (tex_Zzsn.Text.Length == 18)
            {
                if (strBom2 == tex_Zzsn.Text.ToString().Trim().Substring(0, 6))
                {
                    return true;
                }
                else
                {
                   
                    return false;
                }
            }            
            else
            {
                MessageBox.Show("型号不对或字符长度不足18位,请重新输入", "错误");
                tex_Zzsn.Focus();
                tex_Zzsn.Text = "";
                return false;
               
            }
        }

        private string findLoad()//找到当前条码的路线中的最后一个站点
        {
            if (tex_Zzsn.Text.ToString().Trim().Length == 18)
            {
                string strFind;
                string strFindPre = tex_Zzsn.Text.ToString().Trim().Substring(0, 6);
                cmdText = @"SELECT count(luxian.luxian) FROM road LEFT OUTER JOIN luxian ON road.roadid = luxian.luxianID where road.cpsnd=@cpsnd";
                string strFindResult = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText, new SqlParameter("@cpsnd", strFindPre)).ToString();
                if (strFindResult == "1")
                {
                    cmdText = @"SELECT luxian.luxian FROM road LEFT OUTER JOIN luxian ON road.roadid = luxian.luxianID where road.cpsnd=@cpsnd";
                    strFind = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText, new SqlParameter("@cpsnd", strFindPre)).ToString();
                    return strFind.Substring(strFind.LastIndexOf(",")+1);//返回最后一个逗号后面的数据
                }
                else
                {
                    return "Not";
                }
            }
            else { return "Not"; }
        }

        private bool completed()//检查组件的完工状态,组件在绑定之前,检测是否已完工
        {
            if (findLoad() != "Not")//如果找到路线
            {
                string cmdCompleted = @"select count(cpsn) from cpzt where (cpsn=@cpsn) and (gysn=@gysn) and (gyzt='1')";
                string strCompleted = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdCompleted,
                    new SqlParameter("@cpsn", tex_Zzsn.Text.Trim().ToString()),
                    new SqlParameter("@gysn", findLoad())).ToString();
                if (strCompleted != "0")
                {
                    return true;//在CPZT表中找到记录的话返回真
                }
                else
                {
                    return false;//否则返回假
                }
            }
            else
            {
                MessageBox.Show("该组成品没有设置路线","错误");
                return false;
            }
            
        }
                    

        private void tex_Zzsn_Enter(object sender, EventArgs e)
        {
            if (tex_Sn.Text.ToString() == string.Empty)//判断成品序列号是否为空
            {
                MessageBox.Show("成品序列号不能为空", "错误");
                tex_Sn.Focus();//取得焦点
            }
        }      

        private void tex_Sn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //如果按下回车键，触发如下事件
            {
                if (tex_Sn.Text.Length != 18)//如果长度不足18位
                {
                    MessageBox.Show("序列号不足18位,请重新输入......", "错误");
                    tex_Sn.Focus();//取得焦点
                    tex_Sn.Text = "";//清空已有数据
                    return;
                }
                else
                {
                    string strSn = com_Model.SelectedValue.ToString();//等于型号对应的产品短码
                    if (tex_Sn.Text.Trim().Substring(0, 6) != strSn)//如果不等于所选择型号的前六位
                    {
                        MessageBox.Show("型号不符合,请重新输入", "错误");
                        tex_Sn.Text = "";//清空
                        tex_Sn.Focus();//获得焦点
                        return;//跳出处理方法
                    }

                    cmdText = @"select zzbh from bom where cpsnd=@cpsnd order by yxj";//从BOM表中取出组装顺序
                    ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText, new SqlParameter("@cpsnd", strSn)); //将该表置于数据集            


                    foreach (DataRow row in ds.Tables[0].Rows)//改写第二个文本框前的标题
                    {
                        string strRow = row[0].ToString().Trim();
                        string strResult;
                        string strSnc = tex_Sn.Text.ToString().Trim();//产品条码
                        cmdText = @"select count(zjsn) from zzbd where cpsn=@cpsn and zzgy=@zzgy";//查看组装表中是否有该工艺的信息
                        strResult = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText,
                            new SqlParameter("@cpsn", strSnc),
                            new SqlParameter("@zzgy", strRow)).ToString();
                        if (strResult == "0")
                        {
                            lab_Zzsn.Text = strRow;
                            tex_Zzsn.Enabled = true;//找到了还未绑定的组件工艺时
                            break;
                        }                      
                            tex_Zzsn.Enabled = false;//禁用子件条码输入框                            
                    }
                    tex_Zzsn.Focus();//组件文本框取得焦点
                    tex_Zzsn.Text = "";//清空
                }
            }
        }

        private string getZzzh()//这个函数用来获取当前成品的最后一个绑定的部件名称
        {
            string strZzbh;
            cmdText = @"select zzbh from bom where cpsnd=@cpsnd and yxj in (select max(yxj) from bom where cpsnd=@cpsnd)";
            strZzbh = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText,
                new SqlParameter("@cpsnd", tex_Sn.Text.ToString().Trim().Substring(0, 6))).ToString();
            return strZzbh;

        }

        bool bdg()//此函数用来查证子件代码是否绑定过，如果绑定过返回True
        {
            string strBdg;//子件是否绑定过
            cmdText = @"select count(cpsn) from zzbd where zjsn=@zjsn";
            strBdg=SqlHelper.ExecuteScalar(connString,CommandType.Text,cmdText,
                new SqlParameter("@zjsn",tex_Zzsn.Text.ToString().Trim())).ToString();
            if (strBdg == "1")
	        {
                return true;
	        }
            else
            {
                return false;
            }
        }

        private void tex_Zzsn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //如果按下的键是回车键的话
            {
                string str_tex_Zzsn_Lease = lab_Zzsn.Text.Trim().ToString();//取得第二个文本框前的文本                
                if (bom(str_tex_Zzsn_Lease) == false)//与BOM表比较为真的话,输入的子件条码符合要输入的条码
                {
                    MessageBox.Show("该条码与BOM数据不符合，请检查BOM表", "错误");
                    tex_Zzsn.Text = "";//清空组装文本框的内容
                    tex_Sn.Focus();//成品文本框得到焦点
                    tex_Sn.Text = "";//清空文本框内容
                    lab_Zzsn.Text = "";//清空子件文本框前的标签，以防误导作业员
                }
                else
                {
                    if (selectCpsn() == false)//判断成品此组件是否已有绑定
                    {
                        MessageBox.Show("此成品此工艺已绑定过", "错误");
                        tex_Zzsn.Text = "";//清空组装文本框的内容
                        tex_Sn.Focus();//成品文本框得到焦点
                        tex_Sn.Text = "";//清空文本框内容
                        lab_Zzsn.Text = "";//清空子件文本框前的标签，以防误导作业员
                    }
                    else
                    {
                        if (completed() == false)//判断组件是否完工
                        {
                            MessageBox.Show("此组件未完工", "错误");
                            tex_Zzsn.Text = "";//清空组装文本框的内容
                            tex_Sn.Focus();//成品文本框得到焦点
                            tex_Sn.Text = "";//清空文本框内容
                            lab_Zzsn.Text = "";//清空子件文本框前的标签，以防误导作业员
                        }
                        else
                        {
                            if (bdg() == true)//判断组件是否被绑定到别的成品上
                            {
                                MessageBox.Show("子件已被绑定过,请重新绑定", "错误");
                                tex_Zzsn.Text = "";//清空组装文本框的内容
                                tex_Sn.Focus();//成品文本框得到焦点
                                tex_Sn.Text = "";//清空文本框内容
                                lab_Zzsn.Text = "";//清空子件文本框前的标签，以防误导作业员
                            }
                            else
                            {
                                //cmdText = @"insert into zzbd(cpsn,zzgy,zjsn,sj,mtsuser) values(@cpsn,@zzgy,@zjsn,@sj,@mtsuser)";
                                SqlHelper.ExecuteNonQuery(connString, CommandType.StoredProcedure, "pro_zzbd",
                                    new SqlParameter("@cpsn", tex_Sn.Text.Trim().ToString()),
                                    new SqlParameter("@zzgy", str_tex_Zzsn_Lease),
                                    new SqlParameter("@zjsn", tex_Zzsn.Text.Trim().ToString()),
                                    new SqlParameter("@sj",serverTime.sDateTime),
                                    new SqlParameter("@zh",lab_Zzsn.Text.ToString().Trim() == getZzzh()?1:0),
                                    //new SqlParameter("@mtsuser", this.MdiParent.Text.Substring(this.MdiParent.Text.LastIndexOf("*") + 1))
                                    new SqlParameter("@mtsuser",userid));                                
                                    tex_Result.AppendText(String.Format("{0}组件成功绑定到{1}成品上...\r\n", tex_Zzsn.Text.Trim().ToString(), tex_Sn.Text.Trim().ToString()));
                                
                                
                                ///*下面这段代码用来实现当所要绑定的子件条码是父件条码的最后一个条码时，将父件条码的组装站状态置1*/
                                //if (lab_Zzsn.Text.ToString().Trim() == getZzzh())//判断是不是成品组装的最后一个部件
                                //{
                                //    cmdText = @"insert into cpzt(cpsn,gysn,gyzt,sj,mtsname) values(@cpsn,@gysn,@gyzt,@sj,@mtsname)";//如果是成品组装的最后一个部件
                                //    SqlHelper.ExecuteNonQuery(connString, CommandType.Text, cmdText,//将成品条码写入至产品状态表，表明经过了这个工艺
                                //        new SqlParameter("@cpsn", tex_Sn.Text.ToString().Trim()),
                                //        new SqlParameter("@gysn", "001"),
                                //        new SqlParameter("@gyzt", "1"),
                                //        new SqlParameter("@sj", serverTime.sDateTime),
                                //        new SqlParameter("@mtsname", this.MdiParent.Text.Substring(this.MdiParent.Text.LastIndexOf("*") + 1)));
                                //}
                                tex_Zzsn.Text = "";//清空组装文本框的内容
                                tex_Sn.Focus();//成品文本框得到焦点
                                tex_Sn.Text = "";//清空文本框内容
                                lab_Zzsn.Text = "";//清空子件文本框前的标签，以防误导作业员
                            }
                        }
                    }
                }
            }         
                //tex_Zzsn.Text = "";//清空组装文本框的内容
                //tex_Sn.Focus();//成品文本框得到焦点
                //tex_Sn.Text = "";//清空文本框内容
                //lab_Zzsn.Text = "";//清空子件文本框前的标签，以防误导作业员
            }
        }       
    }
    
