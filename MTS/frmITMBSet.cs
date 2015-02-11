using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;

namespace MTS
{
    public partial class frmITMBSet : Form
    {
        SqlConnection cn = new SqlConnection(SqlHelper.ConnString);//数据库连接
        public frmITMBSet(string id)
        {
            InitializeComponent();

            string sql_sel = @"select cptype from cptype;select cpsnd,cpxh from cpxh where zzp=1 ";
            DataSet ds = SqlHelper.ExecuteDataset(cn, CommandType.Text, sql_sel);

            dat_Cptype.DataSource = ds.Tables[0]; //产品种类下拉列表
            dat_Cptype.sDisplayField = "cptype";
            dat_Cptype.sDisplayMember = "cptype";
            dat_Cptype.sKeyWords = "cptype";
            dat_Cptype.RowFilterVisible = true;

            dat_Cp.DataSource = ds.Tables[1]; //产品型号下拉列表
            dat_Cp.sDisplayField = "cpsnd,cpxh";
            dat_Cp.sDisplayMember = "cpsnd";
            
            dat_Cp.sKeyWords = "cpxh";
            dat_Cp.RowFilterVisible = true;

            dbfresh();

        }
        private void dbfresh()
        {
            string sql_sel = @"select cptype from cptype;select cpsnd,cpxh from cpxh where zzp=1 ";
            DataSet ds = SqlHelper.ExecuteDataset(cn, CommandType.Text, sql_sel);
            sql_sel = @"select * from Itprintmb";
            ds = SqlHelper.ExecuteDataset(cn, CommandType.Text, sql_sel);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void frmITMBSet_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog1.Filter = "模版文件|*.Lab";
            txtFilePath.Text = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog1.Filter = "图片文件|*.bmp";
            txtImagePath.Text = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sqlInset, sqlread;
            string ss1, ss2;
            int i;
            btnAdd.Enabled = false;
            lblmsg.Text = "";
            if (cn.State == ConnectionState.Closed) //判断连接状态
            {
                cn.ConnectionString = SqlHelper.ConnString;
                cn.Open();
            }
            sqlread = "select * from itprintmb where cpsnd='" + dat_Cp.Text + "' ";
            SqlCommand testCMD = new SqlCommand();
            testCMD.Connection = cn;
            testCMD.CommandText = sqlread;

            SqlDataReader testReader = testCMD.ExecuteReader();
            while (testReader.Read())
            {
                if (testReader.HasRows)
                {
                    MessageBox.Show("已存在这个SN和Config，请确认!");
                    testReader.Close();
                    btnAdd.Enabled = true;
                    return;
                }
            }

            testReader.Close();


            SqlCommand comd = new SqlCommand();
            comd.Connection = cn;

            ss1 = "cpsnd,cpxh,cptype,FilePath,ImagePath,Var3";
            ss2 = "'" + dat_Cp.Text + "','" + txtCpname.Text + "','" + dat_Cptype.Text + "','" + txtFilePath.Text + "','" + txtImagePath.Text + "','" + txtVar3.Text +"'";
            sqlInset = "INSERT INTO itprintmb (" + ss1 + ") values (" + ss2 + ")";

            comd.CommandText = sqlInset;
            i = comd.ExecuteNonQuery();
            if (i <= 0)
            {
                 lblmsg.Text = "新增出错！";
            }
            else
                lblmsg.Text = "新增成功！";


            cn.Close();
            dbfresh();
            btnAdd.Enabled = true; 
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            string SQL;
            string s_IDNumber;
            string s_Config;
            int i;
            lblmsg.Text = "";
            
            try
            {
                i = dataGridView1.SelectedRows[0].Index;
                s_IDNumber = dataGridView1.Rows[i].Cells[0].Value.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("请选择要删除的一行！");
                return;
            }
            lblmsg.Text = "";
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要删除 " + s_IDNumber + "吗?", "删除记录", messButton);
            if (dr != DialogResult.OK)
            {
                return;
            }
            btnDelet.Enabled = false;
            s_IDNumber = "";
            try
            {

                i = dataGridView1.SelectedRows[0].Index;

                s_IDNumber = dataGridView1.Rows[i].Cells[0].Value.ToString();
                s_Config = dataGridView1.Rows[i].Cells[4].Value.ToString();
                if (cn.State == ConnectionState.Closed)
                {
                    cn.ConnectionString = SqlHelper.ConnString;
                    cn.Open();
                }

                SqlCommand comd = new SqlCommand();
                comd.Connection = cn;
                SQL = "Delete from itprintmb where cpsnd='" + s_IDNumber+ "'";


                comd.CommandText = SQL;
                i = comd.ExecuteNonQuery();
                if (i <= 0)
                {
                    lblmsg.Text = "删除出错！";
                }
                else
                    lblmsg.Text = "删除成功！";


                cn.Close();
                
            }
            catch (System.Exception ex)
            {
                if (s_IDNumber == "")
                {
                    MessageBox.Show("请选择要删除的一行！");
                }
                else
                    lblmsg.Text = "删除出错！";
            }
            dbfresh();
            btnDelet.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sqlInset, sqlread;
            string ss1, ss2;
            int i;
            btnEdit.Enabled = false;
            lblmsg.Text = "";
            if (cn.State == ConnectionState.Closed) //判断连接状态
            {
                cn.ConnectionString = SqlHelper.ConnString;
                cn.Open();
            }
            sqlread = "select * from itprintmb where cpsnd='" + dat_Cp.Text + "' ";
            SqlCommand testCMD = new SqlCommand();
            testCMD.Connection = cn;
            testCMD.CommandText = sqlread;

            SqlDataReader testReader = testCMD.ExecuteReader();
            while (testReader.Read())
            {
                if (testReader.HasRows==false)
                {
                    MessageBox.Show("不存在这个产品编号，请确认!");
                    testReader.Close();
                    btnEdit.Enabled = true;
                    return;
                }
                
            }

            testReader.Close();


            SqlCommand comd = new SqlCommand();
            comd.Connection = cn;

            //ss1 = "cpsnd,cpxh,cptype,FilePath,ImagePath,Var3";
            //ss2 = "cpsnd=" + '" + dat_Cp.Text + "',cpxh='" + txtCpname.Text + "','" + dat_Cptype.Text + "','" + txtFilePath.Text + "','" + txtImagePath.Text + "','" + txtVar3.Text + "'";
           
            sqlInset = string.Format("Update itprintmb set cpxh='{0}',cptype='{1}',FilePath='{2}',ImagePath='{3}',Var3='{4}' where cpsnd='"+ dat_Cp.Text +"'",txtCpname.Text, dat_Cptype.Text,txtFilePath.Text ,txtImagePath.Text, txtVar3.Text );

            comd.CommandText = sqlInset;
            i = comd.ExecuteNonQuery();
            if (i <= 0)
            {
                lblmsg.Text = "修改出错！";
            }
            else
                lblmsg.Text = "修改成功！";


            cn.Close();
            dbfresh();
            btnEdit.Enabled = true; 

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int index;
            int i;
            try
            {
                lblmsg.Text = "";
                index = dataGridView1.SelectedRows[0].Index;
                
                    try
                    {
                        dat_Cp.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                        txtCpname.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        dat_Cptype.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                        txtFilePath.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                        txtImagePath.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                        txtVar3.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                        
                    }
                    catch (System.Exception ex)
                    {

                    }
                
                
            }
            catch (System.Exception ex)
            {

            }
        }

        private void dat_Cp_AfterSelector(object sender, AfterSelectorEventArgs e)
        {
            
            txtCpname.Text=dat_Cp.GetDataProperty("cpxh");
        }

        private void btnCPTypeEdit_Click(object sender, EventArgs e)
        {
            frmCPTypeEdit frmCPTypeEdit = new frmCPTypeEdit();
           // frmCPTypeEdit.MdiParent = this;
            frmCPTypeEdit.Show();
        }
    }
}
