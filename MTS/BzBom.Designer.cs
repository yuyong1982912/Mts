namespace MTS
{
    partial class BzBom
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
            this.lab_bm = new System.Windows.Forms.Label();
            this.lab_mc = new System.Windows.Forms.Label();
            this.tex_bm = new System.Windows.Forms.TextBox();
            this.tex_mc = new System.Windows.Forms.TextBox();
            this.dat_Bzzb = new System.Windows.Forms.DataGridView();
            this.Col_Bzxm = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.but_Ok = new System.Windows.Forms.Button();
            this.dat_bzfb = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Bzsn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dat_Bzzb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dat_bzfb)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_bm
            // 
            this.lab_bm.AutoSize = true;
            this.lab_bm.Location = new System.Drawing.Point(29, 37);
            this.lab_bm.Name = "lab_bm";
            this.lab_bm.Size = new System.Drawing.Size(35, 12);
            this.lab_bm.TabIndex = 0;
            this.lab_bm.Text = "编号:";
            // 
            // lab_mc
            // 
            this.lab_mc.AutoSize = true;
            this.lab_mc.Location = new System.Drawing.Point(31, 71);
            this.lab_mc.Name = "lab_mc";
            this.lab_mc.Size = new System.Drawing.Size(35, 12);
            this.lab_mc.TabIndex = 1;
            this.lab_mc.Text = "名称:";
            // 
            // tex_bm
            // 
            this.tex_bm.Location = new System.Drawing.Point(85, 34);
            this.tex_bm.Name = "tex_bm";
            this.tex_bm.Size = new System.Drawing.Size(165, 21);
            this.tex_bm.TabIndex = 2;
            // 
            // tex_mc
            // 
            this.tex_mc.Location = new System.Drawing.Point(85, 68);
            this.tex_mc.Name = "tex_mc";
            this.tex_mc.Size = new System.Drawing.Size(165, 21);
            this.tex_mc.TabIndex = 3;
            // 
            // dat_Bzzb
            // 
            this.dat_Bzzb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_Bzzb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Bzxm,
            this.Col_Bzsn});
            this.dat_Bzzb.Location = new System.Drawing.Point(33, 95);
            this.dat_Bzzb.Name = "dat_Bzzb";
            this.dat_Bzzb.RowTemplate.Height = 23;
            this.dat_Bzzb.Size = new System.Drawing.Size(244, 314);
            this.dat_Bzzb.TabIndex = 4;
            // 
            // Col_Bzxm
            // 
            this.Col_Bzxm.HeaderText = "包装项目";
            this.Col_Bzxm.Name = "Col_Bzxm";
            // 
            // but_Ok
            // 
            this.but_Ok.Location = new System.Drawing.Point(33, 416);
            this.but_Ok.Name = "but_Ok";
            this.but_Ok.Size = new System.Drawing.Size(75, 23);
            this.but_Ok.TabIndex = 5;
            this.but_Ok.Text = "OK";
            this.but_Ok.UseVisualStyleBackColor = true;
            this.but_Ok.Click += new System.EventHandler(this.but_Ok_Click);
            // 
            // dat_bzfb
            // 
            this.dat_bzfb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_bzfb.Location = new System.Drawing.Point(283, 34);
            this.dat_bzfb.Name = "dat_bzfb";
            this.dat_bzfb.RowTemplate.Height = 23;
            this.dat_bzfb.Size = new System.Drawing.Size(430, 375);
            this.dat_bzfb.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "包装序列号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Col_Bzsn
            // 
            this.Col_Bzsn.HeaderText = "包装序列号";
            this.Col_Bzsn.Name = "Col_Bzsn";
            // 
            // BzBom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 451);
            this.Controls.Add(this.dat_bzfb);
            this.Controls.Add(this.but_Ok);
            this.Controls.Add(this.dat_Bzzb);
            this.Controls.Add(this.tex_mc);
            this.Controls.Add(this.tex_bm);
            this.Controls.Add(this.lab_mc);
            this.Controls.Add(this.lab_bm);
            this.Name = "BzBom";
            this.Text = "包装BOM";
            this.Load += new System.EventHandler(this.BzBom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_Bzzb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dat_bzfb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_bm;
        private System.Windows.Forms.Label lab_mc;
        private System.Windows.Forms.TextBox tex_bm;
        private System.Windows.Forms.TextBox tex_mc;
        private System.Windows.Forms.DataGridView dat_Bzzb;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col_Bzxm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Bzsn;
        private System.Windows.Forms.Button but_Ok;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dat_bzfb;
    }
}