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
    public partial class frm_Bom : Form
    {
        private string connString = SqlHelper.ConnString;//连接字符串
        private string cmdText;//需要执行的命令
        DataSet ds;//数据集

        public frm_Bom()
        {
            InitializeComponent();
        }

        private void iniDataGridViewDW()//设置datagridview的数据与格式
        {
            DataGridViewColumn column = new DataGridViewDataWindowColumn();

            (column as DataGridViewDataWindowColumn).SDisplayField = "cpsnd,cpxh";
            (column as DataGridViewDataWindowColumn).SDisplayMember = "cpsnd";
            (column as DataGridViewDataWindowColumn).SKeyWords = "cpxh";
            (column as DataGridViewDataWindowColumn).DataSource = ds.Tables[1];//分录中半成品编码的下拉列表的取值
            (column as DataGridViewDataWindowColumn).HeaderText = "半成品编码";
            dat_Bom.Columns.Add(column);//实际的插入一列            
            dat_Bom.Columns.Add(new DataGridViewTextBoxColumn());//增加一列文本框类型的列
            dat_Bom.Columns[3].HeaderText = "半成品型号";//增加的列的抬头

            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
        }

        private void frm_Bom_Load(object sender, EventArgs e)
        {
            cmdText = @"select zzbh,zzmc from zzgy;select cpsnd,cpxh from cpxh where zzp <> 1;select cpsnd,cpxh from cpxh where zzp = 1";//取得组装工艺表中的组装工艺
            ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText);//填充到数据集
            zzbh.DataSource = ds.Tables[0];//表格中组装类型的下拉列表的取值
            zzbh.DisplayMember = "zzmc";
            zzbh.ValueMember = "zzbh";
            bcpsnd.DataSource = ds.Tables[1];//表格中半成品编码的下拉列表的取值
            bcpsnd.DisplayMember = "cpxh";
            bcpsnd.ValueMember = "cpsnd";
            com_cp.DataSource = ds.Tables[2];//成品料号
            com_cp.DisplayMember = "cpxh";
            com_cp.ValueMember = "cpsnd";
            iniDataGridViewDW();//初始化表格控件，插入一列datagridedatawindowcolumn
        }

        

        private void but_Bom_Click(object sender, EventArgs e)
        {
            if (but_Bom.Text == "Save")
            {
                cmdText = "insert into bom(cpsnd,bcpsn,zzbh,yxj) values(@cpsnd,@bcpsn,@zzbh,@yxj)";               
            }
            else
            {
                cmdText ="delete from bom where cpsnd="+"'"+com_cp.SelectedValue.ToString().Trim()+"'";//先删除表中的所有这个型号的数据

                SqlHelper.ExecuteNonQuery(connString, CommandType.Text, cmdText);//删除所有数据                

                cmdText = "insert into bom(cpsnd,bcpsn,zzbh,yxj) values(@cpsnd,@bcpsn,@zzbh,@yxj)"; //再插入数据
                
            }
            for (int i = 0; i < dat_Bom.RowCount - 1; i++)
            {
                SqlHelper.ExecuteNonQuery(connString, CommandType.Text, cmdText,
                    new SqlParameter("@cpsnd", com_cp.SelectedValue.ToString().Trim()),
                    //new SqlParameter("@zzbh", dat_Bom.Rows[i].Cells[0].EditedFormattedValue.ToString().Trim()),//取显示值
                    new SqlParameter("@zzbh",dat_Bom.Rows[i].Cells[0].Value.ToString().Trim()),//取内含值
                    new SqlParameter("@bcpsn", dat_Bom.Rows[i].Cells[2].Value.ToString().Trim()),
                    new SqlParameter("@yxj", (i + 1).ToString()));//插入优先级，用于在组装时确认组装的顺序
            }
            MessageBox.Show("保存成功", "成功");
            
        }

        private void com_cp_Leave(object sender, EventArgs e)
        {
            cmdText = @"select count(cpsnd) from bom where cpsnd=@cpsnd";
            string str_Result=SqlHelper.ExecuteScalar(connString,CommandType.Text,cmdText,new SqlParameter("@cpsnd",
                com_cp.SelectedValue.ToString().Trim())).ToString();
            if (str_Result == "0")//如果没有找到
            {
                but_Bom.Text = "Save";//按钮名称改为Save
                dat_Bom.Rows.Clear();//清除所有行,要不然,如果程序不退出,行会不断的增加
            }
            else
            {
                dat_Bom.Rows.Clear(); //清除所有的行,要不然,如果程序不退出,行会不断的增加
                cmdText = @"select a.zzbh,a.bcpsn,b.cpxh from bom a left join cpxh b on a.bcpsn=b.cpsnd where a.cpsnd=@cpsnd";
                ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, cmdText, new SqlParameter("@cpsnd",
                    com_cp.SelectedValue.ToString().Trim()));
                /*
                zzbh.DataSource = ds.Tables[0];
                zzbh.DisplayMember = "zzbh";
                zzbh.ValueMember = "bcpsn";
                */
                //dataGridView1.DataSource = ds.Tables[0];
                
                
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dat_Bom.Rows.Add();//增加新行,如果不增加新行,下面的代码会出错
                    dat_Bom.Rows[i].Cells[0].Value = ds.Tables[0].Rows[i][0].ToString().Trim();
                    dat_Bom.Rows[i].Cells[2].Value = ds.Tables[0].Rows[i][1].ToString().Trim();//更改此处
                    dat_Bom.Rows[i].Cells[3].Value = ds.Tables[0].Rows[i][2].ToString().Trim();
                    
                }
                
                 
                but_Bom.Text = "Modify";//按钮修改为Modify
            }
        }

        private void dat_Bom_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dat_Bom.CurrentCell.OwningColumn is DataGridViewComboBoxColumn)
            {
                ((ComboBox)e.Control).DropDownStyle = ComboBoxStyle.DropDown;
                ((ComboBox)e.Control).AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                ((ComboBox)e.Control).AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            else
            {
                if (e.Control is DataWindow)//如果当前单元格是datawindow类型的
                {
                    (e.Control as DataWindow).AfterSelector -= new AfterSelectorEventHandler(dat_Bom_AfterSelector);
                    (e.Control as DataWindow).AfterSelector += new AfterSelectorEventHandler(dat_Bom_AfterSelector);//订阅dat_Bom_AfterSelector事件
                }
            }
        }

        void dat_Bom_AfterSelector(object sender, AfterSelectorEventArgs e)
        {
            DataGridViewRow row = e.Value as DataGridViewRow;
            DataRowView dataRow = row.DataBoundItem as DataRowView;

            dat_Bom.Rows[e.RowIndex].Cells[3].Value = dataRow["cpxh"].ToString().Trim();//当选中产品编码后，在后面显示出产品型号

        }

        
    }
}
