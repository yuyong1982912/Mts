using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using LabelManager2;
using System.Text.RegularExpressions;//正则表达式
using Dapper;

namespace MTS
{
    public partial class frm_Keithley : Form
    {
        string userid,Cn;
        string MBFilePathnx, MBFilePathwx2, MBFilePathwx1;
        string[] Var_str=new string[25];
        int boxSelect1 = 0, boxSelect2 = 0;
        long BZCounter = 0;
        string[] pringVar = new string[21];
        SqlConnection connection = new SqlConnection(SqlHelper.ConnString);


        Dictionary<string, string> configOption = new Dictionary<string, string>();

        public frm_Keithley(string id)
        {
            InitializeComponent();
            userid = id;

            //添加字典
            configOption.Add("288686", "A0");
            configOption.Add("288767", "A1");
            configOption.Add("287184", "A10");
            configOption.Add("288768", "A11");
            configOption.Add("289590", "A13");
            configOption.Add("288769", "A2");
            configOption.Add("288770", "A3");
            configOption.Add("288795", "A4");
            configOption.Add("288796", "A5");
            configOption.Add("288797", "A7");
            configOption.Add("288798", "A8");
            configOption.Add("288838", "A99");
            configOption.Add("288799", "A9");
            configOption.Add("288839", "E1");
        }

        private void b_Print_Click(object sender, EventArgs e)
        {
            ApplicationClass barPrint = new ApplicationClass();

            
            barPrint.Documents.Open(@"c:\2231\2231A.LAB", false);
            Document doc = barPrint.ActiveDocument;
            
            doc.Variables.FreeVariables.Item("Var0").Value = t_Sn.Text;
            doc.Variables.FreeVariables.Item("Var1").Value = "S" + t_Sn.Text;
            doc.Variables.FreeVariables.Item("Var2").Value = t_Config.Text;
            doc.Variables.FreeVariables.Item("Var3").Value = "31P" + t_Config.Text;
            string var4;
            if (configOption.TryGetValue(t_Config.Text, out var4))
            {
                doc.Variables.FreeVariables.Item("Var4").Value = var4;
            }            
            string var5;
            var5="34P2231A-30-3 " + t_Sn.Text;
            doc.Variables.FreeVariables.Item("Var5").Value = var5;
            doc.Variables.FreeVariables.Item("Var6").Value = System.DateTime.Now.ToString("d");            
            
            doc.PrintDocument(1);
            
            barPrint.Quit();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            
            button1.Enabled = false;
            try
            {
                lblMsg.Text = "打印中...";
                System.Windows.Forms.Application.DoEvents();

                button2_Click(null, null);
                if (MBFilePathnx == "")
                {
                    MessageBox.Show("找不到相关数据!");
                    return;
                }
                ApplicationClass barPrint = new ApplicationClass();
                Document doc = barPrint.ActiveDocument;
                
                //内箱1
                boxSelect1 = 0;
                boxSelect2 = 0;
                if (Regex.IsMatch(t_Sn.Text.ToString().Trim(), @"^\d{18}$"))//正则表达式，只能输入18位数字
                {
                    boxSelect1 = 1;
                }                
                
                if (Regex.IsMatch(t_Sn2.Text.ToString().Trim(), @"^\d{18}$"))//正则表达式，只能输入18位数字
                {
                    boxSelect2 = 1;
                }

                if (boxSelect1==1)//正则表达式，只能输入18位数字
                {

                    barPrint.Documents.Open(MBFilePathnx, false);
                    doc = barPrint.ActiveDocument;
                    doc.Variables.FreeVariables.Item("Var0").Value = t_Sn.Text;                                      //SN
                    doc.Variables.FreeVariables.Item("Var2").Value = t_Config.Text;                                  //config
                    doc.Variables.FreeVariables.Item("Var3").Value = System.DateTime.Now.ToString("yyyy.MM.dd");     //Date
                    doc.Variables.FreeVariables.Item("Var4").Value = Cn.Trim() + " " + t_Sn.Text.Trim();             //CN
                    for (i = 7; i <= 14; i++)
                    {
                        if (Var_str[i].Trim().ToUpper() == "SN")
                        {
                            pringVar[i]=t_Sn.Text;
                        }
                        else if (Var_str[i].Trim().ToUpper() == "CONFIG")
                        {
                            pringVar[i] = t_Config.Text.Trim();
                        }
                        else
                            pringVar[i] = Var_str[i];
                        
                    }
                    pringVar[7]=pringVar[7]+pringVar[8];
                    pringVar[9]=pringVar[9]+pringVar[10];
                    pringVar[11]=pringVar[11]+pringVar[12];
                    pringVar[13]=pringVar[13]+pringVar[14];
                    pringVar[15] = txtOrder.Text.Trim();
                    for (i = 7; i <= 20; i++)
                    {             
                        if (pringVar[i]!=null)
                        if (pringVar[i]!= "" && i!=8 && i!=10 && i!=12 && i!=14)
                        {
                            doc.Variables.Item("Var" + i.ToString()).Value = pringVar[i];
                        }
                    }

                    doc.PrintDocument(1);
                    //  barPrint.Quit();
                    BZCounter++;
                    lblNumber.Text = BZCounter.ToString();
                    
                }
                //内箱2
                if (boxSelect2==1)//正则表达式，只能输入18位数字
                {

                    barPrint.Documents.Open(MBFilePathnx, false);
                    doc = barPrint.ActiveDocument;
                    doc.Variables.FreeVariables.Item("Var0").Value = t_Sn2.Text;                                      //SN
                    doc.Variables.FreeVariables.Item("Var2").Value = t_Config.Text;                                  //config
                    doc.Variables.FreeVariables.Item("Var3").Value = System.DateTime.Now.ToString("yyyy.MM.dd");     //Date
                    doc.Variables.FreeVariables.Item("Var4").Value = Cn.Trim() + " " + t_Sn2.Text.Trim(); //CN
                    for (i = 7; i <= 14; i++)
                    {
                        if (Var_str[i].Trim().ToUpper() == "SN")
                        {
                            pringVar[i]=t_Sn2.Text;
                        }
                        else if (Var_str[i].Trim().ToUpper() == "CONFIG")
                        {
                            pringVar[i] = t_Config.Text.Trim();
                        }
                        else
                            pringVar[i] = Var_str[i];
                        
                    }
                    pringVar[7]=pringVar[7]+pringVar[8];
                    pringVar[9]=pringVar[9]+pringVar[10];
                    pringVar[11]=pringVar[11]+pringVar[12];
                    pringVar[13]=pringVar[13]+pringVar[14];
                    pringVar[15] = txtOrder.Text.Trim();
                    for (i = 7; i <= 20; i++)
                    {
                        if (pringVar[i] != null)
                        {
                            if (pringVar[i].Trim() != "" && i != 8 && i != 10 && i != 12 && i != 14)
                            {
                                doc.Variables.Item("Var" + i.ToString()).Value = pringVar[i];
                            }                            
                        }
                    }
                    doc.PrintDocument(1);
                    BZCounter++;
                    lblNumber.Text = BZCounter.ToString();
                    
                }
                //  barPrint.Quit();

                //外箱
                if (boxSelect1 > 0 || boxSelect2>0)
                {
                    if ((boxSelect1 + boxSelect2) >= 2)
                    {
                        barPrint.Documents.Open(MBFilePathwx2, false);
                    }
                    else
                    {
                        barPrint.Documents.Open(MBFilePathwx1, false);
                    }
                    doc = barPrint.ActiveDocument;
                    if (boxSelect1 == 1)
                    {
                        doc.Variables.FreeVariables.Item("Var0").Value = t_Sn.Text;
                        doc.Variables.FreeVariables.Item("Var4").Value = Cn.Trim() + " " + t_Sn.Text.Trim();    //CN1
                    }
                    
                    doc.Variables.FreeVariables.Item("Var2").Value = t_Config.Text;                             //config
                    doc.Variables.FreeVariables.Item("Var3").Value = System.DateTime.Now.ToString("yyyy.MM.dd");//Date
                    
                    if (boxSelect2==1)
                    {
                        doc.Variables.FreeVariables.Item("Var1").Value = t_Sn2.Text;                             //SN
                        doc.Variables.FreeVariables.Item("Var6").Value = Cn.Trim() + " " + t_Sn2.Text.Trim();    //CN
                        
                    }
                    doc.Variables.FreeVariables.Item("Var5").Value =Convert.ToString(boxSelect1 + boxSelect2);   //数量
                    for (i = 7; i <= 10; i++)
                    {
                        if (Var_str[i].Trim().ToUpper() == "SN")
                        {
                            pringVar[i]=t_Sn.Text;
                        }
                        else if (Var_str[i].Trim().ToUpper() == "CONFIG")
                        {
                            pringVar[i] = t_Config.Text.Trim();
                        }
                        else
                            pringVar[i] = Var_str[i];
                        
                    }
                    for (i = 11; i <= 14; i++)
                    {
                        if (Var_str[i].Trim().ToUpper() == "SN")
                        {
                            pringVar[i] = t_Sn2.Text;
                        }
                        else if (Var_str[i].Trim().ToUpper() == "CONFIG")
                        {
                            pringVar[i] = t_Config.Text.Trim();
                        }
                        else
                            pringVar[i] = Var_str[i];
                        
                    }
                    pringVar[7]=pringVar[7]+pringVar[8];
                    pringVar[9]=pringVar[9]+pringVar[10];
                    pringVar[11]=pringVar[11]+pringVar[12];
                    pringVar[13]=pringVar[13]+pringVar[14];
                    pringVar[15] = txtOrder.Text.Trim();
                    for (i = 7; i <= 20; i++)
                    {
                        if (pringVar[i] != null)
                        if (pringVar[i].Trim() != "" && i!=8 && i!=10 && i!=12 && i!=14)
                        {
                            doc.Variables.Item("Var" + i.ToString()).Value = pringVar[i];
                        }
                    }
                    doc.PrintDocument(1);
                    barPrint.Quit();
                    lblMsg.Text = "打印完成";
                    savetosql();
                    t_Sn2.Text = "";
                    t_Sn.Text = "";
                   // t_Config.Text = "";
                }
                else
                {
                    lblMsg.Text = "输入条码错误,没能打印";
                }
               
                
                
                t_Config.Focus();
                


            
            }
            catch (System.Exception ex)
            {
                lblMsg.Text = "打印出错"+ex.ToString();
                System.Windows.Forms.Application.DoEvents();
            }

            button1.Enabled = true;

        }
        private void savetosql()
        {
            string sqlInsert;
            int i;
            if (connection.State == ConnectionState.Closed)
            {
                connection.ConnectionString = SqlHelper.ConnString;
                connection.Open();
            }
            if (boxSelect1 == 1)
            {
                string sql_cpybzbomgl_ins = @"insert into printRecord(Sn,OrderNum,Date1,Counter) values(@Sn,@OrderNum,@Date1,@Counter)";
                connection.Execute(sql_cpybzbomgl_ins, new { Sn = t_Sn.Text.ToString().Trim(), OrderNum = txtOrder.Text.ToString().Trim(), Date1 = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), Counter = BZCounter });
            }
            if (boxSelect2 == 1)
            {
                string sql_cpybzbomgl_ins = @"insert into printRecord(Sn,OrderNum,Date1,Counter) values(@Sn,@OrderNum,@Date1,@Counter)";
                connection.Execute(sql_cpybzbomgl_ins, new { Sn = t_Sn2.Text.ToString().Trim(), OrderNum = txtOrder.Text.ToString().Trim(), Date1 = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), Counter = BZCounter });
            }
            
            
           // MessageBox.Show("写入成功", "成功");
            connection.Close();


        }
        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            
            string sql_sel;

            if (t_Sn.TextLength!=18)
            {
                MessageBox.Show("找不到此条码数据");
            }
            if (t_Config.Text!="")
            {
                sql_sel = @"select * from printmb where Config='"+ t_Config.Text + "'";
            }
            else
            {
                sql_sel = @"select * from printmb where Cpsnd='" + t_Sn.Text.Substring(0,6) + "'";
            }
            if (connection.State == ConnectionState.Closed) //判断连接状态
            {
                connection.ConnectionString = SqlHelper.ConnString;
                connection.Open();
            }
            SqlCommand testCMD = new SqlCommand();
            testCMD.Connection = connection;
            testCMD.CommandText = sql_sel;
            MBFilePathnx = "";
            MBFilePathwx1 = "";
            MBFilePathwx2 = "";
            SqlDataReader testReader = testCMD.ExecuteReader();
            while (testReader.Read())
            {
                if (testReader.HasRows)
                {
                    MBFilePathnx = Convert.ToString(testReader["FilePathnx"]);
                    MBFilePathwx2 = Convert.ToString(testReader["FilePathwx2"]);
                    MBFilePathwx1 = Convert.ToString(testReader["FilePathwx1"]);
                    //t_Config.Text = Convert.ToString(testReader["Config"]);
                    Cn=Convert.ToString(testReader["CN"]);
                    for (i = 7; i <= 20;i++ )
                    {
                        
                        Var_str[i] = Convert.ToString(testReader["var" + i.ToString()]);
                        pringVar[i] = Var_str[i];
                    }
                    
                }
            }

            testReader.Close();
            

        }

        private void t_Config_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//按下回车键触发
            {
                
                    t_Sn.Focus();
                
            }
        }

        private void t_Sn_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void t_Sn2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//按下回车键触发
            {
                if (Regex.IsMatch(t_Sn2.Text.ToString().Trim(), @"^\d{18}$"))//正则表达式，只能输入18位数字
                {
                    button1_Click(null,null);
                }
            }
        }

        private void t_Sn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//按下回车键触发
            {
                if (Regex.IsMatch(t_Sn.Text.ToString().Trim(), @"^\d{18}$"))//正则表达式，只能输入18位数字
                {
                    t_Sn2.Focus();
                }
            }
        }

        private void frm_Keithley_Load(object sender, EventArgs e)
        {
            t_Config.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BZCounter=0;
            lblNumber.Text = BZCounter.ToString();
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            BZCounter++;
            lblNumber.Text = BZCounter.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            
            try
            {
            
                lblMsg.Text = "打印中...";
                System.Windows.Forms.Application.DoEvents();
                button2_Click(null, null);
                if (MBFilePathnx == "")
                {
                    MessageBox.Show("找不到相关数据!");
                    return;
                }
                ApplicationClass barPrint = new ApplicationClass();
                Document doc = barPrint.ActiveDocument;

                //内箱1
                boxSelect1 = 0;
                boxSelect2 = 0;
                if (Regex.IsMatch(t_Sn.Text.ToString().Trim(), @"^\d{18}$"))//正则表达式，只能输入18位数字
                {
                    boxSelect1 = 1;
                }


                if (Regex.IsMatch(t_Sn2.Text.ToString().Trim(), @"^\d{18}$"))//正则表达式，只能输入18位数字
                {
                    boxSelect2 = 1;
                }

                if (boxSelect1 == 1)//正则表达式，只能输入18位数字
                {
                    
                    barPrint.Documents.Open(MBFilePathnx, false);
                    doc = barPrint.ActiveDocument;
                    doc.Variables.FreeVariables.Item("Var0").Value = t_Sn.Text;                                      //SN
                    doc.Variables.FreeVariables.Item("Var2").Value = t_Config.Text;                                  //config
                    doc.Variables.FreeVariables.Item("Var3").Value = System.DateTime.Now.ToString("yyyy.MM.dd");     //Date
                    doc.Variables.FreeVariables.Item("Var4").Value = Cn.Trim() + " " + t_Sn.Text.Trim();             //CN
                    for (i = 7; i <= 14; i++)
                    {
                        if (Var_str[i].Trim().ToUpper() == "SN")
                        {
                            pringVar[i] = t_Sn.Text;
                        }
                        else if (Var_str[i].Trim().ToUpper() == "CONFIG")
                        {
                            pringVar[i] = t_Config.Text.Trim();
                        }
                        else
                            pringVar[i] = Var_str[i];
                    }
                    pringVar[7] = pringVar[7] + pringVar[8];
                    pringVar[9] = pringVar[9] + pringVar[10];
                    pringVar[11] = pringVar[11] + pringVar[12];
                    pringVar[13] = pringVar[13] + pringVar[14];
                    pringVar[15] = txtOrder.Text.Trim();
                    for (i = 7; i <= 20; i++)
                    {
                        if (pringVar[i] != null)
                        {
                            if (pringVar[i].Trim() != "" && i != 8 && i != 10 && i != 12 && i != 14)
                            {
                                doc.Variables.Item("Var" + i.ToString()).Value = pringVar[i];
                            }
                        }
                        

                    }
                    doc.PrintDocument(1);
                    barPrint.Quit();
                    lblMsg.Text = "打印完成";

                }
            }
            catch (System.Exception ex)
            {
                lblMsg.Text = "打印出错";
            }
            
            
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }
    }
}
