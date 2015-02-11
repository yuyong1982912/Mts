namespace MTS
{
    partial class frm_ZZSX
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
            this.comb_Cpsnd = new System.Windows.Forms.ComboBox();
            this.dat_Zzbh = new System.Windows.Forms.DataGridView();
            this.col_Zzbh = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lab_Cpsnd = new System.Windows.Forms.Label();
            this.but_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dat_Zzbh)).BeginInit();
            this.SuspendLayout();
            // 
            // comb_Cpsnd
            // 
            this.comb_Cpsnd.FormattingEnabled = true;
            this.comb_Cpsnd.Location = new System.Drawing.Point(76, 29);
            this.comb_Cpsnd.Name = "comb_Cpsnd";
            this.comb_Cpsnd.Size = new System.Drawing.Size(145, 20);
            this.comb_Cpsnd.TabIndex = 0;
            this.comb_Cpsnd.Leave += new System.EventHandler(this.comb_Cpsnd_Leave);
            // 
            // dat_Zzbh
            // 
            this.dat_Zzbh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_Zzbh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Zzbh});
            this.dat_Zzbh.Location = new System.Drawing.Point(76, 66);
            this.dat_Zzbh.Name = "dat_Zzbh";
            this.dat_Zzbh.RowTemplate.Height = 23;
            this.dat_Zzbh.Size = new System.Drawing.Size(145, 215);
            this.dat_Zzbh.TabIndex = 1;
            // 
            // col_Zzbh
            // 
            this.col_Zzbh.HeaderText = "组装编号";
            this.col_Zzbh.Name = "col_Zzbh";
            // 
            // lab_Cpsnd
            // 
            this.lab_Cpsnd.AutoSize = true;
            this.lab_Cpsnd.Location = new System.Drawing.Point(13, 36);
            this.lab_Cpsnd.Name = "lab_Cpsnd";
            this.lab_Cpsnd.Size = new System.Drawing.Size(59, 12);
            this.lab_Cpsnd.TabIndex = 2;
            this.lab_Cpsnd.Text = "产品型号:";
            // 
            // but_Save
            // 
            this.but_Save.Location = new System.Drawing.Point(76, 310);
            this.but_Save.Name = "but_Save";
            this.but_Save.Size = new System.Drawing.Size(75, 23);
            this.but_Save.TabIndex = 3;
            this.but_Save.Text = "Save";
            this.but_Save.UseVisualStyleBackColor = true;
            this.but_Save.Click += new System.EventHandler(this.but_Save_Click);
            // 
            // frm_ZZSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 383);
            this.Controls.Add(this.but_Save);
            this.Controls.Add(this.lab_Cpsnd);
            this.Controls.Add(this.dat_Zzbh);
            this.Controls.Add(this.comb_Cpsnd);
            this.Name = "frm_ZZSX";
            this.Text = "组装顺序";
            this.Load += new System.EventHandler(this.frm_ZZSX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_Zzbh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comb_Cpsnd;
        private System.Windows.Forms.DataGridView dat_Zzbh;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_Zzbh;
        private System.Windows.Forms.Label lab_Cpsnd;
        private System.Windows.Forms.Button but_Save;
    }
}