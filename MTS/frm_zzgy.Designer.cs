namespace MTS
{
    partial class frm_zzgy
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
            this.tex_Gybh = new System.Windows.Forms.TextBox();
            this.tex_Gymc = new System.Windows.Forms.TextBox();
            this.lab_Gybh = new System.Windows.Forms.Label();
            this.lab_Gymc = new System.Windows.Forms.Label();
            this.but_Save = new System.Windows.Forms.Button();
            this.dat_Zzgy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dat_Zzgy)).BeginInit();
            this.SuspendLayout();
            // 
            // tex_Gybh
            // 
            this.tex_Gybh.Location = new System.Drawing.Point(131, 45);
            this.tex_Gybh.Name = "tex_Gybh";
            this.tex_Gybh.Size = new System.Drawing.Size(100, 21);
            this.tex_Gybh.TabIndex = 0;
            this.tex_Gybh.Leave += new System.EventHandler(this.tex_Gybh_Leave);
            // 
            // tex_Gymc
            // 
            this.tex_Gymc.Location = new System.Drawing.Point(131, 107);
            this.tex_Gymc.Name = "tex_Gymc";
            this.tex_Gymc.Size = new System.Drawing.Size(100, 21);
            this.tex_Gymc.TabIndex = 1;
            // 
            // lab_Gybh
            // 
            this.lab_Gybh.AutoSize = true;
            this.lab_Gybh.Location = new System.Drawing.Point(66, 45);
            this.lab_Gybh.Name = "lab_Gybh";
            this.lab_Gybh.Size = new System.Drawing.Size(59, 12);
            this.lab_Gybh.TabIndex = 2;
            this.lab_Gybh.Text = "工艺编号:";
            // 
            // lab_Gymc
            // 
            this.lab_Gymc.AutoSize = true;
            this.lab_Gymc.Location = new System.Drawing.Point(66, 107);
            this.lab_Gymc.Name = "lab_Gymc";
            this.lab_Gymc.Size = new System.Drawing.Size(59, 12);
            this.lab_Gymc.TabIndex = 3;
            this.lab_Gymc.Text = "工艺名称:";
            // 
            // but_Save
            // 
            this.but_Save.Location = new System.Drawing.Point(77, 173);
            this.but_Save.Name = "but_Save";
            this.but_Save.Size = new System.Drawing.Size(75, 23);
            this.but_Save.TabIndex = 4;
            this.but_Save.Text = "Save";
            this.but_Save.UseVisualStyleBackColor = true;
            this.but_Save.Click += new System.EventHandler(this.but_Save_Click);
            // 
            // dat_Zzgy
            // 
            this.dat_Zzgy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_Zzgy.Location = new System.Drawing.Point(281, 45);
            this.dat_Zzgy.Name = "dat_Zzgy";
            this.dat_Zzgy.RowTemplate.Height = 23;
            this.dat_Zzgy.Size = new System.Drawing.Size(400, 168);
            this.dat_Zzgy.TabIndex = 5;
            // 
            // frm_zzgy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 266);
            this.Controls.Add(this.dat_Zzgy);
            this.Controls.Add(this.but_Save);
            this.Controls.Add(this.lab_Gymc);
            this.Controls.Add(this.lab_Gybh);
            this.Controls.Add(this.tex_Gymc);
            this.Controls.Add(this.tex_Gybh);
            this.Name = "frm_zzgy";
            this.Text = "组装工艺";
            this.Load += new System.EventHandler(this.frm_zzgy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_Zzgy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tex_Gybh;
        private System.Windows.Forms.TextBox tex_Gymc;
        private System.Windows.Forms.Label lab_Gybh;
        private System.Windows.Forms.Label lab_Gymc;
        private System.Windows.Forms.Button but_Save;
        private System.Windows.Forms.DataGridView dat_Zzgy;
    }
}