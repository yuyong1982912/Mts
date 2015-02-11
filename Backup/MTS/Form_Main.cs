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
    public partial class Frm_main : Form
    {
        private string connString = SqlHelper.ConnString;//连接字符串
        private string cmdText;//需要执行的命令
        string UserID;
        //public string userid { get { return UserID; } }
        //DataSet ds;//数据集

        public Frm_main()
        {
            InitializeComponent();            
        }

        private void 型号数据MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CP frm_CP = new Frm_CP();//创建一个引用
            frm_CP.MdiParent = this;//这个引用指向这个父窗体
            frm_CP.Show();//显示这个窗体

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Zzbd frm_Zzbd = new frm_Zzbd(UserID);//组装绑定
            frm_Zzbd.MdiParent = this;//指定父窗体
            frm_Zzbd.Show();//显示这个窗体
        }

        private void 关闭CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Input frm_Input = new frm_Input(UserID);//录入条码
            frm_Input.MdiParent = this;
            frm_Input.Show();
        }

        private void 维修WToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Weixiu frm_Weixiu = new frm_Weixiu();//维修站点
            frm_Weixiu.MdiParent = this;
            frm_Weixiu.Show();
        }

        

        private void 产品工艺ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_Gy frm_Gy = new frm_Gy();//工艺清单
            frm_Gy.MdiParent = this;
            frm_Gy.Show();
        }
       

        private void 组装工艺ZToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_zzgy frm_Zzgy = new frm_zzgy();//组装工艺
            frm_Zzgy.MdiParent = this;
            frm_Zzgy.Show();
        }

        private void 型号数据MToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_CP frm_CP = new Frm_CP();//创建一个引用
            frm_CP.MdiParent = this;//这个引用指向这个父窗体
            frm_CP.Show();//显示这个窗体
        }

        private void 物料清单WToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_Bom frm_Bom = new frm_Bom();//物料清单
            frm_Bom.MdiParent = this;
            frm_Bom.Show();
        }

        private void 产品路线LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Luxian frm_Luxian = new frm_Luxian();//路线图
            frm_Luxian.MdiParent = this;
            frm_Luxian.Show();
        }

        private void 路线关联GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Road frm_Road = new frm_Road();//路线关联图
            frm_Road.MdiParent = this;
            frm_Road.Show();
        }

        private void 组装顺序XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ZZSX frm_Zzsx = new frm_ZZSX();//组装顺序
            frm_Zzsx.MdiParent = this;
            frm_Zzsx.Show();
        }

        private void 条码产生TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Cstm frm_Cstm = new frm_Cstm();//产生条码
            frm_Cstm.MdiParent = this;
            frm_Cstm.Show();
        }

        private void 绑定查询BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QueryBd frm_QueryBd = new frm_QueryBd();//绑定查询
            frm_QueryBd.MdiParent = this;
            frm_QueryBd.Show();
        }

        private void 经过工艺查询JToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_JgGy frm_JgGy = new frm_JgGy();//经过工艺
            frm_JgGy.MdiParent = this;
            frm_JgGy.Show();
        }

        private void 维修查询WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QueryWx frm_QueryWx = new frm_QueryWx();//维修查询
            frm_QueryWx.MdiParent = this;
            frm_QueryWx.Show();
        }

        private void 错误代码CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Cwdmb frm_Cwdmb = new frm_Cwdmb();//错误代码表
            frm_Cwdmb.MdiParent = this;
            frm_Cwdmb.Show();
        }

        private void 维修代码XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Wxdmb frm_Wxdmb = new frm_Wxdmb();//维修代码表
            frm_Wxdmb.MdiParent = this;
            frm_Wxdmb.Show();
        }

        private void 条码产生查询TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_querytmcs frm_Querytmcs = new frm_querytmcs();//条码产生表
            frm_Querytmcs.MdiParent = this;
            frm_Querytmcs.Show();
        }

        private void 路线关联二ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_gllx_2 frm_gllx_2 = new frm_gllx_2();//路线关联二
            frm_gllx_2.MdiParent = this;
            frm_gllx_2.Show();
        }

        private void 退出程序EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();//退出程序
            Log.wLog = "系统成功关闭";//记录到c:\logfile.txt文件
            
        }

        private void 更新历史GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_History frm_History = new frm_History();//打开更新历史窗体
            frm_History.MdiParent = this;
            frm_History.Show();
        }

        private void 经过工艺列表LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Liebiao frm_Liebiao = new frm_Liebiao();//打开更新历史窗体
            frm_Liebiao.MdiParent = this;
            frm_Liebiao.Show();
        }

        private void Frm_main_Load(object sender, EventArgs e)
        {
            Int16 int_Count = 1;    
            frm_Login Frm_Login = new frm_Login();
        Logo: if (Frm_Login.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)//这个写法真是操蛋，就是为了实现输入三次错误密码功能。
            {
                cmdText = @"select count(id) from mtsuser where id=@id and password=@password";
                string str_Result = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText,
                    new SqlParameter("@id", Frm_Login.UserID), new SqlParameter("@password", Frm_Login.Password)).ToString();
                if (str_Result == "1")
                {
                    cmdText = @"select name from mtsuser where id=@id";
                    string str_Resultname = SqlHelper.ExecuteScalar(connString, CommandType.Text, cmdText,
                        new SqlParameter("@id", Frm_Login.UserID)).ToString();
                    this.Text = this.Text + "---" + str_Resultname;//改变主窗口的标题
                    UserID = Frm_Login.UserID;//将登录的ID保存下来
                    Frm_Login.Dispose();                        
                }
                else
                {
                    MessageBox.Show("用户名或密码不对", "错误");
                    int_Count++;
                    if (int_Count > 3)
                    {
                        Frm_Login.Dispose();
                        this.Dispose();
                    }
                    else
                    {
                        goto Logo;
                    }
                }
                //string userID = Frm_Login.UserID;
                //string Password = Frm_Login.Password;
            }
            else
            {
                Frm_Login.Dispose();
                this.Dispose();
            }

            if ((UserID == "00156") || (UserID == "264"))
            {
                this.基础数据BToolStripMenuItem.Enabled = true;
            }
            else { this.基础数据BToolStripMenuItem.Enabled = false; }
        }

        private void 用户注册RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Reg Frm_reg = new frm_Reg();//打开更新历史窗体
            Frm_reg.MdiParent = this;
            Frm_reg.Show();
        }

        private void 综合查询ZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Treequery Frm_treequery = new frm_Treequery();//打开综合查询窗体
            Frm_treequery.MdiParent = this;
            Frm_treequery.Show();
        }

        private void 显示程序VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ViewInput Frm_viewinput = new frm_ViewInput(UserID);//打开录入显示板程序
            Frm_viewinput.MdiParent = this;
            Frm_viewinput.Show();
        }

        private void 烧机显示VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View Frm_view = new frm_View();//打开显示板程序
            Frm_view.MdiParent = this;
            Frm_view.Show();            
        }

        private void 条码产生TToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Cstm frm_Cstm = new frm_Cstm();//产生条码
            frm_Cstm.MdiParent = this;
            frm_Cstm.Show();
        }

        private void 条码打印PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_BarcodePrint Frm_BarcodePrint = new frm_BarcodePrint(UserID);//条码打印
            Frm_BarcodePrint.MdiParent = this;
            Frm_BarcodePrint.Show();
        }

        private void 包装项目bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Bzxm frm_Bzxm = new Frm_Bzxm();//包装项目
            frm_Bzxm.MdiParent = this;
            frm_Bzxm.Show();
        }

        private void 包装BOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BzBom bzBom = new BzBom();//包装BOM表
            bzBom.MdiParent = this;
            bzBom.Show();
        }

        private void 产品包装BOM关联AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Bomgl frm_Bomgl = new Frm_Bomgl();//产品与包装BOM关联
            frm_Bomgl.MdiParent = this;
            frm_Bomgl.Show();
        }

        private void 包装查询CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Bzcx frm_Bzcx = new Frm_Bzcx();//包装查询
            frm_Bzcx.MdiParent = this;
            frm_Bzcx.Show();
        }        
    }
}
