namespace MTS
{
    partial class frm_JgGy
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
            this.dat_Result = new System.Windows.Forms.DataGridView();
            this.tex_Sn = new System.Windows.Forms.TextBox();
            this.lab_Sn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dat_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // dat_Result
            // 
            this.dat_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_Result.Location = new System.Drawing.Point(28, 64);
            this.dat_Result.Name = "dat_Result";
            this.dat_Result.RowTemplate.Height = 23;
            this.dat_Result.Size = new System.Drawing.Size(466, 190);
            this.dat_Result.TabIndex = 0;
            // 
            // tex_Sn
            // 
            this.tex_Sn.Location = new System.Drawing.Point(248, 37);
            this.tex_Sn.Name = "tex_Sn";
            this.tex_Sn.Size = new System.Drawing.Size(152, 21);
            this.tex_Sn.TabIndex = 1;
            this.tex_Sn.Leave += new System.EventHandler(this.tex_Sn_Leave);
            // 
            // lab_Sn
            // 
            this.lab_Sn.AutoSize = true;
            this.lab_Sn.Location = new System.Drawing.Point(161, 45);
            this.lab_Sn.Name = "lab_Sn";
            this.lab_Sn.Size = new System.Drawing.Size(47, 12);
            this.lab_Sn.TabIndex = 2;
            this.lab_Sn.Text = "序列号:";
            // 
            // frm_JgGy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 266);
            this.Controls.Add(this.lab_Sn);
            this.Controls.Add(this.tex_Sn);
            this.Controls.Add(this.dat_Result);
            this.Name = "frm_JgGy";
            this.Text = "经过工艺查询";
            ((System.ComponentModel.ISupportInitialize)(this.dat_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dat_Result;
        private System.Windows.Forms.TextBox tex_Sn;
        private System.Windows.Forms.Label lab_Sn;
    }
}