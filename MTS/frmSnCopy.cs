using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LabelManager2;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;//正则表达式

namespace MTS
{
    public partial class frmSnCopy : Form
    {
        static string connString2 = SqlHelper.ConnString2;
        string SqlTabelName2 = "t_ICItem";
        string filePath = "c:\\sncopy.lab";
        string printVar1, printVar2;
        public frmSnCopy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printVar2 = "";
            try
            {
                string SQL;
                SqlDataReader testReader;
                SqlConnection conn = new SqlConnection(connString2);
                conn.Open();
                SqlCommand testCMD = new SqlCommand();
                testCMD.Connection = conn;
                txtLH.Text = "";
                SQL = "SELECT  FName,FModel,FNumber FROM " + SqlTabelName2 + " where FNumber = '" + txtSn.Text.Substring(0,6) + "'";
                testCMD.CommandText = SQL;
                testReader = testCMD.ExecuteReader();
                while (testReader.Read())
                {
                    if (testReader.HasRows)
                    {                        
                        printVar2 = Convert.ToString(testReader["FModel"]);
                        txtLH.Text = printVar2;
                        break;
                    }
                }
                testReader.Close();
            }
            catch (System.Exception ex)
            {

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int i;
            int boxSelect1;
            try
            {

                lblMsg.Text = "打印中...";
                System.Windows.Forms.Application.DoEvents();
                button1_Click(null, null);
                if (File.Exists(filePath)==false)
                {
                    MessageBox.Show("找不到相关模版!");
                    return;
                }

                btnPrint.Enabled = false;
                ApplicationClass barPrint = new ApplicationClass();
                Document doc = barPrint.ActiveDocument;

                //内箱1
                
                //if (Regex.IsMatch(txtSn.Text.ToString().Trim(), @"^\d{18}$"))//正则表达式，只能输入18位数字
                //{
                //    boxSelect1 = 1;
                //}               

                if (txtLH.Text!="")//
                {

                    barPrint.Documents.Open(filePath, false);
                    doc = barPrint.ActiveDocument;
                    doc.Variables.FreeVariables.Item("Var0").Value = txtSn.Text;                                      //SN
                    doc.Variables.FreeVariables.Item("Var1").Value = txtNumber.Text;
                    doc.Variables.FreeVariables.Item("Var2").Value = printVar2;      
                    
                    doc.PrintDocument(1);
                    barPrint.Quit();
                    
                    lblMsg.Text = "打印完成";
                    txtSn.Text = "";
                    txtNumber.Text = "";
                    txtSn.Focus();

                }
            }
            catch (System.Exception ex)
            {
                lblMsg.Text = "打印出错";
            }
            btnPrint.Enabled = true;
        }

        private void txtSn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//按下回车键触发
            {
                txtNumber.Focus();
            }
        }

        private void txtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//按下回车键触发
            {
                btnPrint_Click(null, null);
            }
        }

        private void frmSnCopy_Load(object sender, EventArgs e)
        {

        }
    }
}
