namespace MTS
{
    partial class frm_Login
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
            this.tex_UserID = new System.Windows.Forms.TextBox();
            this.tex_Password = new System.Windows.Forms.TextBox();
            this.but_Ok = new System.Windows.Forms.Button();
            this.but_Can = new System.Windows.Forms.Button();
            this.lab_Gh = new System.Windows.Forms.Label();
            this.lab_Mima = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tex_UserID
            // 
            this.tex_UserID.Location = new System.Drawing.Point(124, 23);
            this.tex_UserID.Name = "tex_UserID";
            this.tex_UserID.Size = new System.Drawing.Size(100, 21);
            this.tex_UserID.TabIndex = 0;
            // 
            // tex_Password
            // 
            this.tex_Password.Location = new System.Drawing.Point(124, 50);
            this.tex_Password.Name = "tex_Password";
            this.tex_Password.Size = new System.Drawing.Size(100, 21);
            this.tex_Password.TabIndex = 1;
            this.tex_Password.UseSystemPasswordChar = true;
            // 
            // but_Ok
            // 
            this.but_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.but_Ok.Location = new System.Drawing.Point(51, 91);
            this.but_Ok.Name = "but_Ok";
            this.but_Ok.Size = new System.Drawing.Size(75, 23);
            this.but_Ok.TabIndex = 2;
            this.but_Ok.Text = "登录";
            this.but_Ok.UseVisualStyleBackColor = true;
            this.but_Ok.Click += new System.EventHandler(this.but_Ok_Click);
            // 
            // but_Can
            // 
            this.but_Can.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_Can.Location = new System.Drawing.Point(165, 91);
            this.but_Can.Name = "but_Can";
            this.but_Can.Size = new System.Drawing.Size(75, 23);
            this.but_Can.TabIndex = 3;
            this.but_Can.Text = "取消";
            this.but_Can.UseVisualStyleBackColor = true;
            // 
            // lab_Gh
            // 
            this.lab_Gh.AutoSize = true;
            this.lab_Gh.Location = new System.Drawing.Point(49, 31);
            this.lab_Gh.Name = "lab_Gh";
            this.lab_Gh.Size = new System.Drawing.Size(35, 12);
            this.lab_Gh.TabIndex = 4;
            this.lab_Gh.Text = "工号:";
            // 
            // lab_Mima
            // 
            this.lab_Mima.AutoSize = true;
            this.lab_Mima.Location = new System.Drawing.Point(51, 58);
            this.lab_Mima.Name = "lab_Mima";
            this.lab_Mima.Size = new System.Drawing.Size(35, 12);
            this.lab_Mima.TabIndex = 5;
            this.lab_Mima.Text = "密码:";
            // 
            // frm_Login
            // 
            this.AcceptButton = this.but_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 142);
            this.Controls.Add(this.lab_Mima);
            this.Controls.Add(this.lab_Gh);
            this.Controls.Add(this.but_Can);
            this.Controls.Add(this.but_Ok);
            this.Controls.Add(this.tex_Password);
            this.Controls.Add(this.tex_UserID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.Text = "系统登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tex_UserID;
        private System.Windows.Forms.TextBox tex_Password;
        private System.Windows.Forms.Button but_Ok;
        private System.Windows.Forms.Button but_Can;
        private System.Windows.Forms.Label lab_Gh;
        private System.Windows.Forms.Label lab_Mima;
    }
}