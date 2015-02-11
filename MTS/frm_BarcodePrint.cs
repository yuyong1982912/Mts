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
using System.Text.RegularExpressions;//正则表达式
using LabelManager2;

namespace MTS
{
    public partial class frm_BarcodePrint : Form
    {
        
        SqlConnection connection = new SqlConnection(SqlHelper.ConnString);

        string printFilePath, imageFilePath, Var0, Var1, Var2, Var3;
        string userid;       
        public frm_BarcodePrint(string id)
        {
            InitializeComponent();
            userid = id;
            butPrint.Enabled = false;
        }           

        private void textSN_KeyDown(object sender, KeyEventArgs e)
        {
            lblMsg.Text = "";
            if (e.KeyCode==Keys.Enter)//按下回车键触发
            {
                if (Regex.IsMatch(textSN.Text.ToString().Trim(), @"^\d{18}$"))//正则表达式，只能输入18位数字
                {                    
                    connection.Open();//打开连接   
                    //edit by zjp use for new print
                    //var cpxh = connection.Query<Mcpxh>("select cpxh from cpxh where cpsnd=@cpsnd", new { cpsnd = textSN.Text.ToString().Trim().Substring(0, 6) });
                    var cpxh = connection.Query<Mcpxh>("select* from Itprintmb where cpsnd=@cpsnd", new { cpsnd = textSN.Text.ToString().Trim().Substring(0, 6) });
                    if (cpxh.Count() == 0)
                    {
                        MessageBox.Show("此序列号无对应的规格型号", "错误");
                        textSN.Text = "";
                        textXH.Text = "";
                        textSN.Focus();
                    }
                    else 
                    { 
                        textXH.Text = cpxh.First().cpxh.ToString();
                        com_bzbom_Enter(null, null);
                        Var0 = textSN.Text;
                        Var1 = cpxh.First().cpxh.ToString();
                        Var2 = cpxh.First().cptype.ToString();
                        printFilePath = cpxh.First().filePath.ToString();
                        imageFilePath = cpxh.First().imagePath.ToString();
                        Var3 = cpxh.First().Var3.ToString();
                        //PrintVar[1] = cpxh.First().cpsnd.ToString();
                    }                    
                    connection.Close();//关闭连接 
                }
                else
                {
                    MessageBox.Show("序列号为18位长度的数字", "错误");
                }                               
            }
        }

        /// <summary>
        /// 判断需要输入条码的表格的每一个单元格是否都输入了值 
        /// </summary>
        /// <returns>为空返回false,不为空返回true</returns>
        private bool DatagridviewNullValue()
        {
            int err = 0;//错误计数

            foreach (DataGridViewRow row in dat_bzbom.Rows)
            {
                if (row.Cells["input"].Value == null)//单元格为空
                {
                    MessageBox.Show("第" + row.Cells["input"].RowIndex.ToString() + "行为空!", "错误");
                    err++;
                }                             
            }
            if (err > 0) { return false; } else { return true; }
        }

        private void butPrint_Click(object sender, EventArgs e)
        {
            string sql_bzfb_ins = @"insert into bzfb (bzsj,bzry,cpsn,glbzbom) values(@bzsj,@bzry,@cpsn,@glbzbom);select @@identity";
            string sql_bzzb_ins = @"insert into bzzb(bzfbid,bzxm,xmsn) values(@bzfbid,@bzxm,@xmsn)";
            string sql_bzfb_sel = @"select max(id) as id from bzfb";
            if ((Regex.IsMatch(textSN.Text.ToString().Trim(), @"^\d{18}$")) && (com_bzbom.SelectedValue != null))
            {
                //写入父表
                if (connection.State == ConnectionState.Closed) //判断连接状态
                {
                    connection.ConnectionString = SqlHelper.ConnString;
                    connection.Open();
                }
                SqlTransaction tran = connection.BeginTransaction();   //启动一个事务，保证写入完整性

                connection.Execute(sql_bzfb_ins, new { bzsj = serverTime.sDateTime, bzry = userid,
                                                                    cpsn = textSN.Text.ToString().Trim(),
                                                                    glbzbom = com_bzbom.SelectedValue.ToString() },tran);//写入包装父表
                var bzfbid = connection.Query<Mbzfb>(sql_bzfb_sel, null,tran);
                int int_bzfbid =Convert.ToInt32( bzfbid.First().id.ToString()) ;//取得父表ID值 
                if (DatagridviewNullValue())//写入包装子表
                {
                    foreach (DataGridViewRow row in dat_bzbom.Rows)
                    {
                        connection.Execute(sql_bzzb_ins, new { bzfbid = int_bzfbid, bzxm = row.Cells["bzxm"].Value.ToString(), xmsn = row.Cells["input"].Value.ToString().Trim() }, tran);
                    }
                    tran.Commit();//提交事务
                    connection.Close();//关闭连接
                   lblMsg.Text ="写入成功!";
                    button1_Click(null, null);
                    textSN.Focus();
                    textSN.Text = "";
                }
                else
                {
                    tran.Rollback();//返回事务
                    connection.Close();                    
                }
            }
            else
            {
                MessageBox.Show("序列号不为18位或包装BOM为空", "错误");
            }           
        }

        private void com_bzbom_SelectedIndexChanged(object sender, EventArgs e)
        {            
            dat_bzbom.Columns.Clear();//清空所有列
            if (com_bzbom.SelectedValue.ToString()!=@"MTS.Mcpybzbomgl")
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.ConnectionString = SqlHelper.ConnString;
                    connection.Open();
                }
                string sql_bzmobz_sel = @"select tb.name,bzsn,bzxm from bzbomz ta left join bzxmb tb on ta.bzxm=tb.id where bomid=@bomid order by sx";                
                var bzbomz = connection.Query<Mbzbomz>(sql_bzmobz_sel, new { bomid = com_bzbom.SelectedValue });
                dat_bzbom.DataSource = bzbomz;
                dat_bzbom.Columns["id"].Visible = false;//不显示ID列
                dat_bzbom.Columns["BOMid"].Visible = false;
                dat_bzbom.Columns["sx"].Visible = false;
                dat_bzbom.Columns["bzxm"].Visible = false;
                dat_bzbom.Columns["bzsn"].Visible = false;
                connection.Close();

                //增加新列，用于输入实际的条码
                DataGridViewTextBoxColumn input = new DataGridViewTextBoxColumn();
                input.Name = "input";
                input.HeaderText = "barcode";
                dat_bzbom.Columns.Add(input);
                dat_bzbom.Columns["input"].Width = 150;
            }
        }

        private void com_bzbom_Enter(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.ConnectionString = SqlHelper.ConnString;
                connection.Open();
            }
            if (Regex.IsMatch(textSN.Text.ToString().Trim(), @"^\d{18}"))
            {
                //下拉列表
                string sql_cpybzbomgl_sel = @"select ta.bomid as bomid,tb.name as name from cpybzbomgl ta left join bzbomf tb on ta.bomid=tb.bomid
where ta.cpbh=@cpbh";
                var bzbom = connection.Query<Mcpybzbomgl>(sql_cpybzbomgl_sel, new { cpbh = textSN.Text.ToString().Trim().Substring(0, 6) });
                if (bzbom.Count() == 0)
                {
                    MessageBox.Show("此物料无关联的包装BOM", "错误");
                }
                else
                {
                    com_bzbom.DataSource = bzbom;
                    com_bzbom.DisplayMember = "name";
                    com_bzbom.ValueMember = "bomid";
                }
            }
            else
            { MessageBox.Show("序列号为18位长度的数字", "错误"); }            
            connection.Close();
        }

        private void dat_bzbom_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dat_bzbom.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim().Length < 6)//判断条形长度必须大于等于6
                {
                    MessageBox.Show("条码长度小于6位数", "错误");
                    butPrint.Enabled = false;
                }
                else if (dat_bzbom.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim().Substring(0, 6) != dat_bzbom.Rows[e.RowIndex].Cells["bzsn"].Value.ToString().Trim())
                {
                    MessageBox.Show("与包装BOM表不符", "错误");
                    butPrint.Enabled = false;
                }
                else
                {
                    butPrint.Enabled = true;
                }
            }
            catch (System.Exception ex)
            {
            	
            }
            
        }

        private void textSN_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_BarcodePrint_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            try
            {
                lblMsg.Text = "打印中...";
                System.Windows.Forms.Application.DoEvents();
                
                if (printFilePath == "")
                {
                    MessageBox.Show("找不到相关数据!");
                    return;
                }
                ApplicationClass barPrint = new ApplicationClass();
                Document doc = barPrint.ActiveDocument;                       

                if (true)//正则表达式，只能输入18位数字
                {

                    barPrint.Documents.Open(printFilePath, false);
                    doc = barPrint.ActiveDocument;
                    if (Var0!="")
                    {
                        doc.Variables.FreeVariables.Item("Var0").Value = Var0;                                      //SN
                    }
                    if (Var1 != "")
                        doc.Variables.FreeVariables.Item("Var1").Value = Var1;                                      //SN
                    if (Var2 != "")
                        doc.Variables.FreeVariables.Item("Var2").Value = Var2;                                  //config
                    if (Var3 != "")
                        doc.Variables.FreeVariables.Item("Var3").Value = Var3;     //Date
                         
                    doc.PrintDocument(1);
                    barPrint.Quit();
                    lblMsg.Text = "打印完成";

                }
            }
            catch (System.Exception ex)
            {
                lblMsg.Text = "打印出错";
            }
            button1.Enabled = true;
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }       
    }
}
