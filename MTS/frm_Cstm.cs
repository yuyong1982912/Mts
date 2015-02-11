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
    public partial class frm_Cstm : Form
    {
        private string connString = SqlHelper.ConnString;//连接字符串
        private string cmdText;//需要执行的命令
        DataSet ds;//数据集
        DateTime dat_sj = serverTime.sDateTime;//保存写入数据库时的时间

        public frm_Cstm()
        {
            InitializeComponent();
        }       

        private void frm_Cstm_Load(object sender, EventArgs e)//得到下拉框数据
        {
            cmdText = @"select cpsnd,cpxh from cpxh";
            ds=SqlHelper.ExecuteDataset(connString,CommandType.Text,cmdText);
            com_Cpsnd.DataSource = ds.Tables[0];
            com_Cpsnd.DisplayMember = "cpxh";
            com_Cpsnd.ValueMember = "cpsnd";
        }

        private void com_Cpsnd_Leave(object sender, EventArgs e)//得到当前型号的版本
        {
            cmdText = @"select bb from cpxh where cpsnd=@cpsnd";
            ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText,
                new SqlParameter("@cpsnd", com_Cpsnd.SelectedValue.ToString().Trim()));
            tex_Bb.Text = ds.Tables[0].Rows[0][0].ToString();//假设是每个型号仅有唯一的值
            tex_Cpxh.Text = com_Cpsnd.Text;//显示产品型号
        }

        private string zuHe()//组合当前的条码
        {
            int int_Year = Convert.ToInt32(serverTime.sDateTime.Year.ToString().Substring(2, 2)) + 55;
            int int_Month = Convert.ToInt32(serverTime.sDateTime.Month.ToString()) + 66;
            string str_Year = int_Year.ToString();//取得当前年份加上55
            string str_Month = int_Month.ToString();//取得当前月份加上66
            string str_Zuhe = com_Cpsnd.SelectedValue.ToString().Trim() + tex_Bb.Text.Trim().ToString() + str_Year + str_Month;              
            return str_Zuhe;//返回条码的前12位
        }
        
        private void but_Creat_Click(object sender, EventArgs e)
        {
            string str_Qxsn;//保存起始编号
            string str_Jssn;//保存结束编号
            string str_Sn;//保存序列号
            

            cmdText = "select count(cpsnd) from tmcs where jssn like " + "'"+zuHe()+"%'" ;
            string str_Result = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText).ToString();

            if (str_Result == "0")//如果没有找到
            {
                str_Sn = tex_Qty.Text.ToString().Trim().PadLeft(4, '0');
                str_Qxsn = zuHe() + tex_Xb.Text.ToString().Trim() + "0001";
                str_Jssn = zuHe() + tex_Xb.Text.ToString().Trim() + str_Sn;
                tex_Qxsn.Text = str_Qxsn;//起始序列号
                tex_Jssn.Text = str_Jssn;//结束序列号
                
            }
            else//如果找到了
            {
                string str_HouWuWei;
                int int_HouWuWei;
                int int_Qxsn;
                int int_Jssn;
                cmdText = "select jssn from tmcs where jssn like " + "'" + zuHe() + "%'" +" order by id desc";//以自动产生的序列号排序
                string str_JssnDesc = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText).ToString();//得到最后一个结束序列号
                str_HouWuWei = str_JssnDesc.Substring(14, 4);//取得最后的序列号
                int_HouWuWei = Convert.ToInt32(str_HouWuWei);//将字符改变成数字
                int_Jssn =int_HouWuWei + Convert.ToInt32(tex_Qty.Text.Trim());
                int_Qxsn = int_HouWuWei + 1;
                str_Qxsn = zuHe() + tex_Xb.Text.ToString().Trim() + int_Qxsn.ToString().PadLeft(4, '0');//转成字符的起始SN
                str_Jssn = zuHe() + tex_Xb.Text.ToString().Trim() + int_Jssn.ToString().PadLeft(4, '0');//转成字符的结束SN
                tex_Qxsn.Text = str_Qxsn;
                tex_Jssn.Text = str_Jssn;               
            }
            tex_HeBin.Text = tex_Qxsn.Text + "-" + tex_Jssn.Text.Substring(14, 4);//产生合并的序列号,便于COPY
           
        }

        private void but_Save_Click(object sender, EventArgs e)//存储到数据库
        {
            cmdText = @"select count(id) from tmcs where qxsn=@qxsn";//检查一下在条码产生表中是否存在相同的起始SN
            string str_Result = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText,
                new SqlParameter("@qxsn", tex_Qxsn.Text.ToString().Trim())).ToString();
            if (str_Result != "0") //如果不唯一的话
            {
                MessageBox.Show("此条码已产生过,请勿重复产生", "错误");
            }
            else
            {
                cmdText = @"insert into tmcs(cpsnd,bb,workid,qty,scxb,qxsn,jssn,sj) values(@cpsnd,@bb,@workid,@qty,@scxb,@qxsn,@jssn,@sj)";
                SqlHelper.ExecuteNonQuery(connString, CommandType.Text, cmdText,
                    new SqlParameter("@cpsnd", com_Cpsnd.SelectedValue.ToString().Trim()),
                    new SqlParameter("@bb", tex_Bb.Text.Trim().ToString()),
                    new SqlParameter("@workid", tex_WorkId.Text.ToString().Trim()),
                    new SqlParameter("@qty", tex_Qty.Text.ToString().Trim()),
                    new SqlParameter("@scxb", tex_Xb.Text.ToString().Trim()),
                    new SqlParameter("@qxsn", tex_Qxsn.Text.ToString().Trim()),
                    new SqlParameter("@jssn", tex_Jssn.Text.ToString().Trim()),
                    new SqlParameter("@sj", dat_sj));
                MessageBox.Show("保存成功", "保存");
            }           
        }
    }
}
