namespace MTS
{
    partial class frm_Bom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_Bom = new System.Windows.Forms.Label();
            this.dat_Bom = new System.Windows.Forms.DataGridView();
            this.but_Bom = new System.Windows.Forms.Button();
            this.com_cp = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zzbh = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bcpsnd = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dat_Bom)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_Bom
            // 
            this.lab_Bom.AutoSize = true;
            this.lab_Bom.Location = new System.Drawing.Point(42, 33);
            this.lab_Bom.Name = "lab_Bom";
            this.lab_Bom.Size = new System.Drawing.Size(59, 12);
            this.lab_Bom.TabIndex = 0;
            this.lab_Bom.Text = "成品料号:";
            // 
            // dat_Bom
            // 
            this.dat_Bom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dat_Bom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_Bom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zzbh,
            this.bcpsnd});
            this.dat_Bom.Location = new System.Drawing.Point(27, 60);
            this.dat_Bom.Name = "dat_Bom";
            this.dat_Bom.RowTemplate.Height = 23;
            this.dat_Bom.Size = new System.Drawing.Size(495, 150);
            this.dat_Bom.TabIndex = 2;
            this.dat_Bom.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dat_Bom_EditingControlShowing);
            // 
            // but_Bom
            // 
            this.but_Bom.Location = new System.Drawing.Point(44, 231);
            this.but_Bom.Name = "but_Bom";
            this.but_Bom.Size = new System.Drawing.Size(75, 23);
            this.but_Bom.TabIndex = 3;
            this.but_Bom.Text = "Save";
            this.but_Bom.UseVisualStyleBackColor = true;
            this.but_Bom.Click += new System.EventHandler(this.but_Bom_Click);
            // 
            // com_cp
            // 
            this.com_cp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_cp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_cp.FormattingEnabled = true;
            this.com_cp.Location = new System.Drawing.Point(130, 24);
            this.com_cp.Name = "com_cp";
            this.com_cp.Size = new System.Drawing.Size(121, 20);
            this.com_cp.TabIndex = 4;
            this.com_cp.Leave += new System.EventHandler(this.com_cp_Leave);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "半成品型号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // zzbh
            // 
            this.zzbh.HeaderText = "组装类型";
            this.zzbh.Name = "zzbh";
            this.zzbh.Width = 59;
            // 
            // bcpsnd
            // 
            this.bcpsnd.HeaderText = "半成品型号";
            this.bcpsnd.Name = "bcpsnd";
            this.bcpsnd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bcpsnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bcpsnd.Visible = false;
            this.bcpsnd.Width = 90;
            // 
            // frm_Bom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 266);
            this.Controls.Add(this.com_cp);
            this.Controls.Add(this.but_Bom);
            this.Controls.Add(this.dat_Bom);
            this.Controls.Add(this.lab_Bom);
            this.Name = "frm_Bom";
            this.Text = "物料清单";
            this.Load += new System.EventHandler(this.frm_Bom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_Bom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Bom;
        private System.Windows.Forms.DataGridView dat_Bom;
        private System.Windows.Forms.Button but_Bom;
        private System.Windows.Forms.ComboBox com_cp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn zzbh;
        private System.Windows.Forms.DataGridViewComboBoxColumn bcpsnd;
    }
}