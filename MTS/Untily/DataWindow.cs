﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Design;


namespace MTS
{
    public class DataWindow : ComboBox
        {
            #region 成员变量
            private const int WM_LBUTTONDOWN = 0x201, WM_LBUTTONDBLCLK = 0x203;
            private ToolStripControlHost dataGridViewHost;
            private ToolStripControlHost textBoxHost;
            private ToolStripDropDown dropDown;

            private string m_sKeyWords = "";
            private string m_sDisplayMember = "";
            private string m_sValueMember = "";
            private string m_sDisplayField = "";
            private string m_Separator = "|";
            private string m_NullValue = "";


            private bool m_blDropShow = false;
            private bool m_blPopupAutoSize = false;
            private int m_SelectedIndex = -1;

            public event AfterSelectorEventHandler AfterSelector;

            #endregion
            #region 构造函数
            public DataWindow()
            {
                DrawDataGridView();
            }
            #endregion
            #region 属性
            [Description("空值时的默认值"), Browsable(true), Category("N8")]
            public string NullValue
            {
                set
                {
                    m_NullValue = value;
                }
                get
                {
                    return m_NullValue;
                }
            }
            [Description("查询关键字"), Browsable(true), Category("N8")]
            public string sKeyWords
            {
                get
                {
                    return m_sKeyWords;
                }
                set
                {
                    m_sKeyWords = value;
                }
            }
            [Description("文本框显示字段用逗号分割！"), Browsable(true), Category("N8")]
            public string sDisplayMember
            {
                set
                {
                    m_sDisplayMember = value;

                }
                get
                {
                    return m_sDisplayMember;
                }
            }
            [Description("是否显示条件输入窗口！"), Browsable(true), Category("N8")]
            public bool RowFilterVisible
            {
                set
                {
                    dropDown.Items[0].Visible = value;
                }
                get
                {
                    return dropDown.Items[0].Visible;
                }
            }
            [Description("取值字段"), Browsable(true), Category("N8")]
            public string sValueMember
            {
                set
                {
                    m_sValueMember = value;
                }
                get
                {
                    return m_sValueMember;
                }
            }
            public DataView DataView
            {
                get
                {
                    DataTable dataTable = GetDataTableFromDataSource();
                    if (dataTable == null)
                    {
                        return null;
                    }
                    return dataTable.DefaultView;
                }
            }
            [Description("设置DataGridView属性"), Browsable(true), Category("N8")]
            public DataGridView DataGridView
            {
                get
                {
                    return dataGridViewHost.Control as DataGridView;
                }
            }
            public TextBox TextBox
            {
                get
                {
                    return textBoxHost.Control as TextBox;
                }
            }
            [Description("下拉表格显示列，空为显示所有列！"), Browsable(true), Category("N8")]
            public string sDisplayField
            {
                set
                {
                    m_sDisplayField = value;
                }
                get
                {
                    return m_sDisplayField;
                }
            }
            [Description("数据源"), Browsable(true), Category("N8")]
            public new Object DataSource
            {
                set
                {
                    if (m_sDisplayField != String.Empty)
                    {
                        DataGridView.Columns.Clear();
                        DataGridView.AutoGenerateColumns = false;
                        string[] sDisplayFields = m_sDisplayField.Split(',');
                        foreach (string sDisplay in sDisplayFields)
                        {
                            DataGridViewTextBoxColumn dgvCell = new DataGridViewTextBoxColumn();
                            dgvCell.Name = sDisplay;
                            dgvCell.DataPropertyName = sDisplay;
                            DataGridView.Columns.Add(dgvCell);
                        }
                    }
                    DataGridView.DataSource = value;
                }
                get
                {
                    return DataGridView.DataSource;
                }
            }

            [Description("下拉表格尺寸是否为自动"), Browsable(true), Category("N8")]
            public bool PopupGridAutoSize
            {
                set
                {
                    m_blPopupAutoSize = value;
                }
                get
                {
                    return m_blPopupAutoSize;
                }
            }
            [Description("分割符号"), Browsable(true), Category("N8")]
            public string SeparatorChar
            {
                set
                {
                    m_Separator = value;
                }
                get
                {
                    return m_Separator;
                }
            }
            [Browsable(false), Bindable(true)]
            public string Value
            {
                get
                {
                    if (Text == String.Empty)
                    {
                        m_SelectedIndex = -1;
                    }
                    if (!String.IsNullOrEmpty(m_sValueMember))
                    {
                        if (DataView == null)
                        {
                            return Text;
                        }
                        if (m_SelectedIndex > -1)
                        {
                            object obj = DataView[m_SelectedIndex][m_sValueMember];
                            return obj.ToString();
                        }
                        else
                        {
                            return m_NullValue;
                        }
                    }
                    else
                    {
                        return Text;
                    }
                }
                set
                {
                    int i = 0;
                    if (m_sValueMember == String.Empty)
                    {
                        Text = value;
                    }
                    else
                    {
                        Text = "";
                        if (DataView != null)
                        {
                            DataView.RowFilter = "";
                            foreach (DataRowView dataRowView in DataView)
                            {
                                if (dataRowView[m_sValueMember].ToString() == value)
                                {
                                    m_SelectedIndex = i;
                                    string[] sDisplayList = m_sDisplayMember.Split(',');
                                    foreach (string sDisplay in sDisplayList)
                                    {
                                        if (DataGridView.Columns.Contains(sDisplay))
                                        {
                                            object obj = DataView[m_SelectedIndex][sDisplay];
                                            Text += obj.ToString() + m_Separator;
                                        }
                                    }
                                    Text = Text.TrimEnd('|');
                                    break;
                                }
                                i++;
                            }
                        }
                    }

                }
            }
            #endregion
            #region 方法
            #region 绘制DataGridView以及下拉DataGridView
            private void DrawDataGridView()
            {
                DataGridView dataGridView = new DataGridView();
                dataGridView.ScrollBars = ScrollBars.Both;
                dataGridView.AutoSize = true;
                dataGridView.AllowUserToAddRows = false;
                dataGridView.AllowUserToDeleteRows = false;
                dataGridView.AllowUserToResizeRows = false;
                dataGridView.Dock = DockStyle.Fill;

                dataGridView.BackgroundColor = SystemColors.Control;
                dataGridView.BorderStyle = BorderStyle.None;
                dataGridView.ReadOnly = true;
                dataGridView.AllowUserToAddRows = false;
                dataGridView.RowHeadersVisible = false;
                dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView.DoubleClick += new EventHandler(dataGridView_DoubleClick);
                dataGridView.KeyDown += new KeyEventHandler(dataGridView_KeyDown);

                //设置DataGridView的数据源
                Form frmDataSource = new Form();
                frmDataSource.Controls.Add(dataGridView);
                frmDataSource.SuspendLayout();
                dataGridViewHost = new ToolStripControlHost(dataGridView);
                dataGridViewHost.AutoSize = m_blPopupAutoSize;

                TextBox textBox = new TextBox();
                textBox.Width = dataGridView.Width;
                textBox.TextChanged += new EventHandler(textBox_TextChanged);
                textBox.KeyDown += new KeyEventHandler(textBox_KeyDown);
                textBoxHost = new ToolStripControlHost(textBox);
                textBoxHost.AutoSize = false;

                dropDown = new ToolStripDropDown();
                dropDown.Items.Add(textBoxHost);
                dropDown.Items.Add(dataGridViewHost);
            }
            #endregion
            public string GetDataProperty(string sColumn)
            {
                string sValue = "";
                if (DataView != null)
                {
                    if (DataGridView.Columns.Contains(sColumn))
                    {
                        sValue = DataView[m_SelectedIndex][sColumn].ToString();
                    }
                }
                return sValue;
            }
            public void dataGridView_DoubleClick(object sender, EventArgs e)
            {
                PopupGridView(e);
            }
            /// <summary>
            /// 弹出下拉表格并触发选择后事件
            /// </summary>
            /// <param name="e"></param>
            private void PopupGridView(EventArgs e)
            {
                if (DataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow dgvRow = DataGridView.CurrentRow;
                    m_SelectedIndex = DataGridView.CurrentRow.Index;
                    if (m_sDisplayMember != String.Empty)
                    {
                        Text = "";
                        string[] sDisplayList = m_sDisplayMember.Split(',');
                        foreach (string sDisplay in sDisplayList)
                        {
                            if (DataGridView.Columns.Contains(sDisplay))
                            {
                                Text += dgvRow.Cells[sDisplay].Value.ToString() + m_Separator;
                            }
                        }
                        Text = Text.TrimEnd('|');
                    }
                    else
                    {
                        Text = dgvRow.Cells[0].Value.ToString();
                    }

                    RaiseAfterSelector(this, new AfterSelectorEventArgs(-1, -1, dgvRow));

                }
                dropDown.Close();
                m_blDropShow = false;

            }
            private DataTable GetDataTableFromDataSource()
            {
                object dataSource = DataGridView.DataSource;
                return GetDataTableFromDataSource(dataSource);
            }
            /// <summary>
            /// 从DataGridView 获取数据表
            /// </summary>
            /// <returns></returns>
            private DataTable GetDataTableFromDataSource(object dataSource)
            {
                if (dataSource is DataTable)
                {
                    return (DataTable)dataSource;
                }
                else if (dataSource is DataView)
                {
                    return ((DataView)dataSource).Table;
                }
                else if (dataSource is BindingSource)
                {
                    object bind = ((BindingSource)dataSource).DataSource;
                    if (bind is DataTable)
                    {
                        return (DataTable)bind;
                    }
                    else
                    {
                        return ((DataView)bind).Table;
                    }
                }
                else
                {
                    return null;
                }
            }
            private void ShowDropDown()
            {
                if (dropDown != null)
                {
                    if (DataView != null)
                    {
                        DataView.RowFilter = "";
                        TextBox.Text = "";
                        //textBoxHost.Width = 200;
                        //dataGridViewHost.AutoSize = m_blPopupAutoSize;
                        //dataGridViewHost.Size = new Size(DropDownWidth - 2, DropDownHeight);
                        dropDown.Show(this, 0, this.Height);

                        TextBox.Focus();
                    }

                }
            }
            private void dataGridView_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyData == Keys.Enter)
                {
                    PopupGridView(e);
                }
            }

            protected void OnAfterSelector(object sender, AfterSelectorEventArgs e)
            {
                if (AfterSelector != null)
                {
                    AfterSelector(sender, e);
                }
            }

            protected virtual void RaiseAfterSelector(object sender, AfterSelectorEventArgs e)
            {
                OnAfterSelector(sender, e);
            }
            #region 重写方法

            private string GetRowFilterString(string sText)
            {
                string sFilter = "";
                if (m_sDisplayMember == String.Empty || m_sDisplayMember == null)
                {

                    m_sDisplayMember = DataView.Table.Columns[0].ColumnName;
                }
                if (m_sKeyWords == String.Empty)
                {
                    foreach (DataColumn column in DataView.Table.Columns)
                    {
                        m_sKeyWords += column.ColumnName + ",";
                    }
                    m_sKeyWords = m_sKeyWords.Trim().TrimEnd(",".ToCharArray());
                }
                string[] sColumns = m_sKeyWords.Split(',');
                foreach (string sColumn in sColumns)
                {
                    sFilter += "Convert(" + sColumn + ",'System.String') like " + "'%" + sText + "%'" + " or ";
                }

                sFilter = sFilter.Trim().TrimEnd("or".ToCharArray());
                return sFilter;
            }
            private void textBox_TextChanged(object sender, System.EventArgs e)
            {
                DataView.RowFilter = GetRowFilterString(TextBox.Text);
            }
            private void textBox_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyData == Keys.Enter)
                {
                    PopupGridView(e);
                }
                else if (e.KeyData == Keys.Down || e.KeyData == Keys.Up)
                {
                    DataGridView.Focus();
                }
            }

            protected override void OnKeyDown(KeyEventArgs e)
            {
                base.OnKeyDown(e);
                ShowDropDown();

                if (e.KeyData == Keys.Enter)
                {
                    DataView.RowFilter = GetRowFilterString(Text);
                    PopupGridView(null);
                }
            }

            protected override void OnKeyPress(KeyPressEventArgs e)
            {
                if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar))
                {
                    this.TextBox.Text = e.KeyChar.ToString();
                    this.TextBox.SelectionStart = this.TextBox.Text.Length;
                    e.Handled = true;
                }
                base.OnKeyPress(e);
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == WM_LBUTTONDBLCLK || m.Msg == WM_LBUTTONDOWN)
                {
                    if (m_blDropShow)
                    {
                        m_blDropShow = false;
                    }
                    else
                    {
                        m_blDropShow = true;
                    }
                    if (m_blDropShow)
                    {
                        ShowDropDown();
                    }
                    else
                    {
                        dropDown.Close();
                    }
                    return;
                }
                base.WndProc(ref m);
            }
            protected override void Dispose(bool disposing)
            {
                if (disposing)
                {
                    if (dropDown != null)
                    {
                        dropDown.Dispose();
                        dropDown = null;
                    }
                }
                base.Dispose(disposing);
            }
            #endregion
            #endregion
        }

        public delegate void AfterSelectorEventHandler(object sender, AfterSelectorEventArgs e);

        public class AfterSelectorEventArgs : EventArgs
        {
            private int _rowIndex;
            private int _columnIndex;
            private object _value;

            public int RowIndex
            {
                get { return _rowIndex; }
                set { _rowIndex = value; }
            }
            public int ColumnIndex
            {
                get { return _columnIndex; }
                set { _columnIndex = value; }
            }
            public object Value
            {
                get { return _value; }
                set { _value = value; }
            }

            public AfterSelectorEventArgs(int rowIndex, int columnIndex, object value)
                : base()
            {
                _rowIndex = rowIndex;
                _columnIndex = columnIndex;
                _value = value;
            }
        }
    }

