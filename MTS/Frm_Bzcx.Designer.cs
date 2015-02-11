namespace MTS
{
    partial class Frm_Bzcx
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
            this.lab_Sn = new System.Windows.Forms.Label();
            this.tex_Sn = new System.Windows.Forms.TextBox();
            this.dat_bzfb = new System.Windows.Forms.DataGridView();
            this.dat_Bzzb = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dat_bzfb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dat_Bzzb)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_Sn
            // 
            this.lab_Sn.AutoSize = true;
            this.lab_Sn.Location = new System.Drawing.Point(26, 31);
            this.lab_Sn.Name = "lab_Sn";
            this.lab_Sn.Size = new System.Drawing.Size(71, 12);
            this.lab_Sn.TabIndex = 0;
            this.lab_Sn.Text = "待查序列号:";
            // 
            // tex_Sn
            // 
            this.tex_Sn.Location = new System.Drawing.Point(118, 28);
            this.tex_Sn.Name = "tex_Sn";
            this.tex_Sn.Size = new System.Drawing.Size(199, 21);
            this.tex_Sn.TabIndex = 1;
            this.tex_Sn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex_Sn_KeyDown);
            // 
            // dat_bzfb
            // 
            this.dat_bzfb.AllowUserToAddRows = false;
            this.dat_bzfb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_bzfb.Location = new System.Drawing.Point(28, 55);
            this.dat_bzfb.Name = "dat_bzfb";
            this.dat_bzfb.RowTemplate.Height = 23;
            this.dat_bzfb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dat_bzfb.Size = new System.Drawing.Size(352, 140);
            this.dat_bzfb.TabIndex = 2;
            this.dat_bzfb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_bzfb_CellClick);
            // 
            // dat_Bzzb
            // 
            this.dat_Bzzb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_Bzzb.Location = new System.Drawing.Point(28, 201);
            this.dat_Bzzb.Name = "dat_Bzzb";
            this.dat_Bzzb.RowTemplate.Height = 23;
            this.dat_Bzzb.Size = new System.Drawing.Size(352, 154);
            this.dat_Bzzb.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "包装时间";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "包装人员";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Frm_Bzcx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 381);
            this.Controls.Add(this.dat_Bzzb);
            this.Controls.Add(this.dat_bzfb);
            this.Controls.Add(this.tex_Sn);
            this.Controls.Add(this.lab_Sn);
            this.Name = "Frm_Bzcx";
            this.Text = "包装查询";
            ((System.ComponentModel.ISupportInitialize)(this.dat_bzfb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dat_Bzzb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Sn;
        private System.Windows.Forms.TextBox tex_Sn;
        private System.Windows.Forms.DataGridView dat_bzfb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dat_Bzzb;
    }
}