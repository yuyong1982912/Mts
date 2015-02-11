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
    public partial class frmCPTypeEdit : Form
    {
        SqlConnection cn = new SqlConnection(SqlHelper.ConnString);//数据库连接
        public frmCPTypeEdit()
        {
            InitializeComponent();
            dbfresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sqlInset, sqlread;
            
            int i;
            btnAdd.Enabled = false;
            lblmsg.Text = "";
            if (cn.State == ConnectionState.Closed) //判断连接状态
            {
                cn.ConnectionString = SqlHelper.ConnString;
                cn.Open();
            }
            sqlread = "select * from cptype where cptype='" + txtCpType.Text + "' ";
            SqlCommand testCMD = new SqlCommand();
            testCMD.Connection = cn;
            testCMD.CommandText = sqlread;

            SqlDataReader testReader = testCMD.ExecuteReader();
            while (testReader.Read())
            {
                if (testReader.HasRows)
                {
                    MessageBox.Show("已存在这个类型，请确认!");
                    testReader.Close();
                    btnAdd.Enabled = true;
                    return;
                }
            }

            testReader.Close();


            SqlCommand comd = new SqlCommand();
            comd.Connection = cn;

            sqlInset = "INSERT INTO cptype (cptype) values ('" + txtCpType.Text + "')";

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
                if (cn.State == ConnectionState.Closed)
                {
                    cn.ConnectionString = SqlHelper.ConnString;
                    cn.Open();
                }

                SqlCommand comd = new SqlCommand();
                comd.Connection = cn;
                SQL = "Delete from cptype where cptype='" + s_IDNumber + "'";


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
        private void dbfresh()
        {
            string sql_sel = @"select cptype from cptype";
            DataSet ds = SqlHelper.ExecuteDataset(cn, CommandType.Text, sql_sel);            
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void CPTypeEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
