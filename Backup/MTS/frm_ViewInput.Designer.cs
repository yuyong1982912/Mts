namespace MTS
{
    partial class frm_ViewInput
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
            this.tex_Bir = new System.Windows.Forms.TextBox();
            this.lab_Bir = new System.Windows.Forms.Label();
            this.lab_Sn = new System.Windows.Forms.Label();
            this.tex_Sn = new System.Windows.Forms.TextBox();
            this.lab_Mo = new System.Windows.Forms.Label();
            this.tex_Mo = new System.Windows.Forms.TextBox();
            this.tex_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tex_Bir
            // 
            this.tex_Bir.Location = new System.Drawing.Point(94, 48);
            this.tex_Bir.Name = "tex_Bir";
            this.tex_Bir.Size = new System.Drawing.Size(158, 21);
            this.tex_Bir.TabIndex = 0;
            // 
            // lab_Bir
            // 
            this.lab_Bir.AutoSize = true;
            this.lab_Bir.Location = new System.Drawing.Point(41, 56);
            this.lab_Bir.Name = "lab_Bir";
            this.lab_Bir.Size = new System.Drawing.Size(41, 12);
            this.lab_Bir.TabIndex = 1;
            this.lab_Bir.Text = "烧机室";
            // 
            // lab_Sn
            // 
            this.lab_Sn.AutoSize = true;
            this.lab_Sn.Location = new System.Drawing.Point(41, 99);
            this.lab_Sn.Name = "lab_Sn";
            this.lab_Sn.Size = new System.Drawing.Size(29, 12);
            this.lab_Sn.TabIndex = 2;
            this.lab_Sn.Text = "条码";
            // 
            // tex_Sn
            // 
            this.tex_Sn.Location = new System.Drawing.Point(94, 99);
            this.tex_Sn.Name = "tex_Sn";
            this.tex_Sn.Size = new System.Drawing.Size(158, 21);
            this.tex_Sn.TabIndex = 3;
            this.tex_Sn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex_Sn_KeyDown);
            // 
            // lab_Mo
            // 
            this.lab_Mo.AutoSize = true;
            this.lab_Mo.Location = new System.Drawing.Point(45, 152);
            this.lab_Mo.Name = "lab_Mo";
            this.lab_Mo.Size = new System.Drawing.Size(29, 12);
            this.lab_Mo.TabIndex = 4;
            this.lab_Mo.Text = "型号";
            // 
            // tex_Mo
            // 
            this.tex_Mo.Enabled = false;
            this.tex_Mo.Location = new System.Drawing.Point(94, 152);
            this.tex_Mo.Name = "tex_Mo";
            this.tex_Mo.Size = new System.Drawing.Size(158, 21);
            this.tex_Mo.TabIndex = 5;
            // 
            // tex_Result
            // 
            this.tex_Result.Location = new System.Drawing.Point(283, 48);
            this.tex_Result.Multiline = true;
            this.tex_Result.Name = "tex_Result";
            this.tex_Result.Size = new System.Drawing.Size(279, 125);
            this.tex_Result.TabIndex = 6;
            // 
            // frm_ViewInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 216);
            this.Controls.Add(this.tex_Result);
            this.Controls.Add(this.tex_Mo);
            this.Controls.Add(this.lab_Mo);
            this.Controls.Add(this.tex_Sn);
            this.Controls.Add(this.lab_Sn);
            this.Controls.Add(this.lab_Bir);
            this.Controls.Add(this.tex_Bir);
            this.Name = "frm_ViewInput";
            this.Text = "显示录入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tex_Bir;
        private System.Windows.Forms.Label lab_Bir;
        private System.Windows.Forms.Label lab_Sn;
        private System.Windows.Forms.TextBox tex_Sn;
        private System.Windows.Forms.Label lab_Mo;
        private System.Windows.Forms.TextBox tex_Mo;
        private System.Windows.Forms.TextBox tex_Result;
    }
}