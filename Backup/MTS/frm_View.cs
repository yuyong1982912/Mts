using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MTS
{
    public partial class frm_View : Form
    {
        int i;
        //从app.config文件中取得连接字符串
        string connString = SqlHelper.ConnString;
        string num; //烧机室编号

        #region 通过构造函数，弹出一个对话框，在对话框中输入烧机室编号后，只显示此烧机室的正在烧机的机器
        public frm_View()
        {
            InitializeComponent();
            frm_ViewFirst Frm_viewfirst = new frm_ViewFirst();
            Frm_viewfirst.ShowDialog();
            if (Frm_viewfirst.DialogResult == DialogResult.OK)
            {
                num = Frm_viewfirst.number;
            }
            else { num = "1"; }
            Frm_viewfirst.Close();
        }
        #endregion

        #region 计时器运行触发事件
        //得到所有的数据集条数K，得到所有数据集可以分成几页。超过该页数，数据从第一页开始显示
        private void tim_View_Tick(object sender, EventArgs e)
        {
            string sqlString = "select count(*) from snrecord where te is null and bir='" + num + "'";
            int k=int.Parse(SqlHelper.ExecuteScalar(connString,CommandType.Text,sqlString).ToString());
            i = i + 1;
            binddata(i);            
            if (i==k/15+1)
           {
               i = 0;
            }
            this.Text = "第"+(i+1).ToString()+"页"+"/"+"共"+(k/15+1).ToString()+"页";//在标题上显示
        }
        #endregion

        # region 窗体加载触发事件
        //计时器开始计时
        //表格中显示第一页数据
        private void frm_View_Load(object sender, EventArgs e)
        {
            tim_View.Enabled = true;            
            binddata(1);           
        }
        #endregion

        # region 表格绑定数据函数,并设置整个表格的默认样式
        //参数j表示当前页的页数
        private void binddata(int j)//绑定每个分页的数据
        {
            SqlParameter[] parameters = {                                             
                    new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageNumber", SqlDbType.Int),
                    new SqlParameter("@bir",SqlDbType.NVarChar)
					};
            parameters[0].Value = 15;
            parameters[1].Value = j;
            parameters[2].Value = num;
            DataSet ds = SqlHelper.ExecuteDataset(connString, CommandType.StoredProcedure, "GetsnrecordByPage", parameters);
            DataTable dt = ds.Tables[0];
            dat_View.DataSource = dt;
            dat_View.DefaultCellStyle.Font = new Font("Tahoma", 24);//15号Tahoma字体
            dat_View.DefaultCellStyle.ForeColor = Color.White;//前景色为白色
            dat_View.DefaultCellStyle.BackColor = Color.Beige;//背景色为米黄色
            dat_View.Columns[0].FillWeight = 160;
            dat_View.Columns[2].FillWeight = 50;
            dat_View.Columns[3].FillWeight = 50;
            dat_View.CurrentCell = null;//在表格中没有任何激活或被选中的单元格，使得颜色统一

        }
        #endregion

        #region 根据烧机时间的长短设置不同行的背景色
        /*
          前景色为白色
           普通机型:
          （1）0-6 小时 ：绿色（2）6-12小时 ：蓝色（3）12-18小时：黄色（4）18-24小时：橙色（5）〉24  小时：红色
            TEK 机型:
          （1）0-12 小时 ：绿色（2）12-24小时 ：蓝色（3）24-36小时：黄色（4）36-48小时：橙色（5）〉48  小时：红色
         */
        private void dat_View_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
           if   (e.RowIndex   >=   dat_View.Rows.Count   -   1)   return; 
           DataGridViewRow   dgr   =   dat_View.Rows[e.RowIndex]; 
           try 
           {
               string s=dgr.Cells["烧机时间"].Value.ToString();
               int i=s.LastIndexOf("-");
               int j = int.Parse(s.Substring(0, i));//已烧机J小时
               //非公司机型,烧机48小时
               if (dgr.Cells["产品型号"].Value.ToString().Substring(0, 2) == "PW" || dgr.Cells["产品型号"].Value.ToString().Substring(0, 2) == "22")
               {
                   if (j >= 48) { dgr.DefaultCellStyle.BackColor = Color.Red; }//烧机时间大于48小时，背景色为红色                   
                   else if (j >= 36) { dgr.DefaultCellStyle.BackColor = Color.Orange; }//烧机时间大于36小时，小于48小时，背景色为橙色                  
                   else if (j >= 24) { dgr.DefaultCellStyle.BackColor = Color.Goldenrod; }//烧机时间大于24小时，小于36小时，背景色为黄色
                   else if (j >= 12) { dgr.DefaultCellStyle.BackColor = Color.Blue; }//烧机时间大于12小时，小于24小时，背景色为蓝色
                   else { dgr.DefaultCellStyle.BackColor = Color.Green; }//烧机时间小于12小时，背景色为绿色
               }
               else //公司机型
               {                   
                   if (j >= 24) { dgr.DefaultCellStyle.BackColor = Color.Red; }//烧机时间大于24小时，背景色为红色                   
                   else if (j >= 18) { dgr.DefaultCellStyle.BackColor = Color.Orange; }//烧机时间大于18小时，小于24小时，背景色为橙色                  
                   else if (j >= 12) { dgr.DefaultCellStyle.BackColor = Color.Goldenrod; }//烧机时间大于12小时，小于18小时，背景色为黄色
                   else if (j >= 6) { dgr.DefaultCellStyle.BackColor = Color.Blue; }//烧机时间大于6小时，小于12小时，背景色为蓝色
                   else { dgr.DefaultCellStyle.BackColor = Color.Green; }//烧机时间小于6小时，背景色为绿色
               }               
           } 
           catch   (Exception   ex) 
           { 
                   MessageBox.Show(ex.Message); 
           }
        }
        #endregion

        #region 双击某行，计时器停止将该行数据的结束时间写入到数据库中
        private void dat_View_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tim_View.Enabled==true)
            {
                tim_View.Enabled = false;//将计时器停止
            }            
            string sn = dat_View.Rows[e.RowIndex].Cells[0].Value.ToString();//取出当前双击单元格的条码值
            string cmd_Text = @"update snrecord set te=@te where sn=@sn";
            SqlParameter[] para = {
                                      new SqlParameter("@te",SqlDbType.DateTime),
                                      new SqlParameter("@sn",SqlDbType.Char,18)
                                  };
            para[0].Value = serverTime.sDateTime;
            para[1].Value = sn;
            SqlHelper.ExecuteScalar(connString, CommandType.Text, cmd_Text,para);

            cmd_Text = @"insert into cpzt(cpsn,gysn,gyzt,sj) values(@cpsn,@gysn,@gyzt,@sj)";//写入到产品状态表,都是PASS
            SqlHelper.ExecuteNonQuery(connString, CommandType.Text, cmd_Text,
                new SqlParameter("@cpsn", sn),
                new SqlParameter("@gysn", "003"),//老化测试
                new SqlParameter("@gyzt", "1"),//PASS
                new SqlParameter("@sj", serverTime.sDateTime));
                //new SqlParameter("@mtsname",this.MdiParent.Text.Substring(this.MdiParent.Text.LastIndexOf("-")+1))
                //new SqlParameter("@mtsname", userid));

            MessageBox.Show("已成功存入数据库", "保存");
            if (i == 0) { binddata(1);} else { binddata(i); }//停在当前
            
        }
        #endregion
        
    }
}
