using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;

namespace MTS
{
    public partial class frmMBSet : Form
    {
        TextBox[] tb = new TextBox[21];//49

        SqlConnection connection = new SqlConnection(SqlHelper.ConnString);
        public frmMBSet(string id)
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMBSet_Load(object sender, EventArgs e)
        {
            
            tb[0] = txt0;
            tb[1] = txt1;
            tb[2] = txt2;
            tb[3] = txt3;
            tb[4] = txt4;
            tb[5] = txt5;
            tb[6] = txt6;
            tb[7] = txt7;
            tb[8] = txt8;
            tb[9] = txt9;
            tb[10] = txt10;
            tb[11] = txt11;
            tb[12] = txt12;
            tb[13] = txt13;
            tb[14] = txt14;
            tb[15] = txt15;
            tb[16] = txt16;
            tb[17] = txt17;
            tb[18] = txt18;
            tb[19] = txt19;
            tb[20] = txt20;

            dateRead();
            
        }
        private void dateRead()
        {
            string sql_sel = @"select * from printmb";
            SqlDataAdapter da = new SqlDataAdapter(sql_sel, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int index;
            int i;
            try
            {
                index = dataGridView1.SelectedRows[0].Index;
                for (i = 0; i <= 20; i++)
                {
                    try
                    {
                        tb[i].Text = dataGridView1.Rows[index].Cells[i].Value.ToString();
                    }
                    catch (System.Exception ex)
                    {

                    }
                }
                textBox1.Text = dataGridView1.Rows[index].Cells[i].Value.ToString();
            }
            catch (System.Exception ex)
            {
            	
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sqlInset,sqlread;
            string ss1, ss2;
            int i;
            btnAdd.Enabled = false; 
            sqlInset = "";
            ss2="";
            lblmsg.Text = "";
            ss1 = "cpsnd,cpxh,FilePathnx,FilePathwx2,Config,Model,CN";
            for (i = 7; i <= 20;i++ )
            {
                ss1 = ss1 + ",Var" + i.ToString();
            }
            ss1 = ss1 + ",FilePathwx1";
            ss2 = "'" + tb[0].Text + "'";
            for (i = 1; i <= 20;i++ )
            {
                ss2 = ss2 + ",'" + tb[i].Text +"'";
            }
            ss2 = ss2 + ",'" + textBox1.Text + "'";
                     
            if (connection.State == ConnectionState.Closed) //判断连接状态
            {
                connection.ConnectionString = SqlHelper.ConnString;
                connection.Open();
            }
            sqlread = "select * from printmb where cpsnd='" + txt0.Text + "' and Config='" + txt4.Text+ "' " ;
            SqlCommand testCMD = new SqlCommand();
            testCMD.Connection = connection;
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
            comd.Connection = connection;
            sqlInset = "INSERT INTO printmb (" + ss1 + ") values (" + ss2 + ")";
            
            comd.CommandText = sqlInset;
            i = comd.ExecuteNonQuery();
            if (i <= 0)
            {
                lblmsg.Text="新增出错！";
            }
            else
                lblmsg.Text="新增成功！";


            connection.Close();
            dateRead();
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
                if (connection.State == ConnectionState.Closed)
                {
                    connection.ConnectionString = SqlHelper.ConnString;
                    connection.Open();
                }
                
                SqlCommand comd = new SqlCommand();
                comd.Connection = connection;
                SQL = "Delete from printmb where cpsnd='" + s_IDNumber + "' and Config='" + s_Config + "'";


                comd.CommandText = SQL;
                i = comd.ExecuteNonQuery();
                if (i <= 0)
                {
                    lblmsg.Text="删除出错！";
                }
                else
                    lblmsg.Text = "删除成功！";


                connection.Close();
                
            }
            catch (System.Exception ex)
            {
                if (s_IDNumber == "")
                {
                    MessageBox.Show("请选择要删除的一行！");
                }
                else
                    lblmsg.Text="删除出错！";
            }
            dateRead();
            btnDelet.Enabled = true;
        }
    }
}
