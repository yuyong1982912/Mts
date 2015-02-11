namespace MTS
{
    partial class Frm_Bzxm
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
            this.lab_bzxm = new System.Windows.Forms.Label();
            this.tex_bzxm = new System.Windows.Forms.TextBox();
            this.but_bzxm = new System.Windows.Forms.Button();
            this.lis_bzxm = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lab_bzxm
            // 
            this.lab_bzxm.AutoSize = true;
            this.lab_bzxm.Location = new System.Drawing.Point(10, 22);
            this.lab_bzxm.Name = "lab_bzxm";
            this.lab_bzxm.Size = new System.Drawing.Size(59, 12);
            this.lab_bzxm.TabIndex = 0;
            this.lab_bzxm.Text = "包装项目:";
            // 
            // tex_bzxm
            // 
            this.tex_bzxm.Location = new System.Drawing.Point(67, 19);
            this.tex_bzxm.Name = "tex_bzxm";
            this.tex_bzxm.Size = new System.Drawing.Size(100, 21);
            this.tex_bzxm.TabIndex = 1;
            // 
            // but_bzxm
            // 
            this.but_bzxm.Location = new System.Drawing.Point(12, 216);
            this.but_bzxm.Name = "but_bzxm";
            this.but_bzxm.Size = new System.Drawing.Size(75, 23);
            this.but_bzxm.TabIndex = 2;
            this.but_bzxm.Text = "OK";
            this.but_bzxm.UseVisualStyleBackColor = true;
            this.but_bzxm.Click += new System.EventHandler(this.but_bzxm_Click);
            // 
            // lis_bzxm
            // 
            this.lis_bzxm.FormattingEnabled = true;
            this.lis_bzxm.ItemHeight = 12;
            this.lis_bzxm.Location = new System.Drawing.Point(173, 19);
            this.lis_bzxm.Name = "lis_bzxm";
            this.lis_bzxm.Size = new System.Drawing.Size(120, 220);
            this.lis_bzxm.TabIndex = 3;
            // 
            // Frm_Bzxm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 266);
            this.Controls.Add(this.lis_bzxm);
            this.Controls.Add(this.but_bzxm);
            this.Controls.Add(this.tex_bzxm);
            this.Controls.Add(this.lab_bzxm);
            this.Name = "Frm_Bzxm";
            this.Text = "包装项目";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_bzxm;
        private System.Windows.Forms.TextBox tex_bzxm;
        private System.Windows.Forms.Button but_bzxm;
        private System.Windows.Forms.ListBox lis_bzxm;
    }
}