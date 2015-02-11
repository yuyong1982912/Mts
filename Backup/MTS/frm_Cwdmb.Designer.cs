namespace MTS
{
    partial class frm_Cwdmb
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
            this.tex_Cwdm = new System.Windows.Forms.TextBox();
            this.tex_Cwms = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.but_Save = new System.Windows.Forms.Button();
            this.dat_Cw = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dat_Cw)).BeginInit();
            this.SuspendLayout();
            // 
            // tex_Cwdm
            // 
            this.tex_Cwdm.Location = new System.Drawing.Point(85, 71);
            this.tex_Cwdm.Name = "tex_Cwdm";
            this.tex_Cwdm.Size = new System.Drawing.Size(100, 21);
            this.tex_Cwdm.TabIndex = 0;
            this.tex_Cwdm.Leave += new System.EventHandler(this.tex_Cwdm_Leave);
            // 
            // tex_Cwms
            // 
            this.tex_Cwms.Location = new System.Drawing.Point(85, 116);
            this.tex_Cwms.Name = "tex_Cwms";
            this.tex_Cwms.Size = new System.Drawing.Size(100, 21);
            this.tex_Cwms.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "错误代码:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "错误描述:";
            // 
            // but_Save
            // 
            this.but_Save.Location = new System.Drawing.Point(85, 170);
            this.but_Save.Name = "but_Save";
            this.but_Save.Size = new System.Drawing.Size(75, 23);
            this.but_Save.TabIndex = 4;
            this.but_Save.Text = "Save";
            this.but_Save.UseVisualStyleBackColor = true;
            this.but_Save.Click += new System.EventHandler(this.but_Save_Click);
            // 
            // dat_Cw
            // 
            this.dat_Cw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_Cw.Location = new System.Drawing.Point(191, 36);
            this.dat_Cw.Name = "dat_Cw";
            this.dat_Cw.RowTemplate.Height = 23;
            this.dat_Cw.Size = new System.Drawing.Size(282, 206);
            this.dat_Cw.TabIndex = 5;
            // 
            // frm_Cwdmb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 266);
            this.Controls.Add(this.dat_Cw);
            this.Controls.Add(this.but_Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tex_Cwms);
            this.Controls.Add(this.tex_Cwdm);
            this.Name = "frm_Cwdmb";
            this.Text = "错误代码表";
            this.Load += new System.EventHandler(this.frm_Cwdmb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_Cw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tex_Cwdm;
        private System.Windows.Forms.TextBox tex_Cwms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_Save;
        private System.Windows.Forms.DataGridView dat_Cw;
    }
}