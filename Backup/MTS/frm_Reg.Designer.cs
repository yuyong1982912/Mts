namespace MTS
{
    partial class frm_Reg
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
            this.tex_ID = new System.Windows.Forms.TextBox();
            this.tex_Name = new System.Windows.Forms.TextBox();
            this.tex_Password = new System.Windows.Forms.TextBox();
            this.tex_RepPass = new System.Windows.Forms.TextBox();
            this.but_Ok = new System.Windows.Forms.Button();
            this.lab_GongHao = new System.Windows.Forms.Label();
            this.lab_name = new System.Windows.Forms.Label();
            this.lab_Password = new System.Windows.Forms.Label();
            this.lab_RepPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tex_ID
            // 
            this.tex_ID.Location = new System.Drawing.Point(128, 37);
            this.tex_ID.Name = "tex_ID";
            this.tex_ID.Size = new System.Drawing.Size(100, 21);
            this.tex_ID.TabIndex = 0;
            // 
            // tex_Name
            // 
            this.tex_Name.Location = new System.Drawing.Point(128, 81);
            this.tex_Name.Name = "tex_Name";
            this.tex_Name.Size = new System.Drawing.Size(100, 21);
            this.tex_Name.TabIndex = 1;
            // 
            // tex_Password
            // 
            this.tex_Password.Location = new System.Drawing.Point(128, 123);
            this.tex_Password.Name = "tex_Password";
            this.tex_Password.Size = new System.Drawing.Size(100, 21);
            this.tex_Password.TabIndex = 2;
            this.tex_Password.UseSystemPasswordChar = true;
            // 
            // tex_RepPass
            // 
            this.tex_RepPass.Location = new System.Drawing.Point(128, 169);
            this.tex_RepPass.Name = "tex_RepPass";
            this.tex_RepPass.Size = new System.Drawing.Size(100, 21);
            this.tex_RepPass.TabIndex = 3;
            this.tex_RepPass.UseSystemPasswordChar = true;
            // 
            // but_Ok
            // 
            this.but_Ok.Location = new System.Drawing.Point(96, 212);
            this.but_Ok.Name = "but_Ok";
            this.but_Ok.Size = new System.Drawing.Size(75, 23);
            this.but_Ok.TabIndex = 4;
            this.but_Ok.Text = "确定";
            this.but_Ok.UseVisualStyleBackColor = true;
            this.but_Ok.Click += new System.EventHandler(this.but_Ok_Click);
            // 
            // lab_GongHao
            // 
            this.lab_GongHao.AutoSize = true;
            this.lab_GongHao.Location = new System.Drawing.Point(63, 45);
            this.lab_GongHao.Name = "lab_GongHao";
            this.lab_GongHao.Size = new System.Drawing.Size(35, 12);
            this.lab_GongHao.TabIndex = 5;
            this.lab_GongHao.Text = "工号:";
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Location = new System.Drawing.Point(65, 89);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(35, 12);
            this.lab_name.TabIndex = 6;
            this.lab_name.Text = "姓名:";
            // 
            // lab_Password
            // 
            this.lab_Password.AutoSize = true;
            this.lab_Password.Location = new System.Drawing.Point(65, 131);
            this.lab_Password.Name = "lab_Password";
            this.lab_Password.Size = new System.Drawing.Size(41, 12);
            this.lab_Password.TabIndex = 7;
            this.lab_Password.Text = "密码：";
            // 
            // lab_RepPass
            // 
            this.lab_RepPass.AutoSize = true;
            this.lab_RepPass.Location = new System.Drawing.Point(65, 177);
            this.lab_RepPass.Name = "lab_RepPass";
            this.lab_RepPass.Size = new System.Drawing.Size(59, 12);
            this.lab_RepPass.TabIndex = 8;
            this.lab_RepPass.Text = "确认密码:";
            // 
            // frm_Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.lab_RepPass);
            this.Controls.Add(this.lab_Password);
            this.Controls.Add(this.lab_name);
            this.Controls.Add(this.lab_GongHao);
            this.Controls.Add(this.but_Ok);
            this.Controls.Add(this.tex_RepPass);
            this.Controls.Add(this.tex_Password);
            this.Controls.Add(this.tex_Name);
            this.Controls.Add(this.tex_ID);
            this.Name = "frm_Reg";
            this.Text = "用户注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tex_ID;
        private System.Windows.Forms.TextBox tex_Name;
        private System.Windows.Forms.TextBox tex_Password;
        private System.Windows.Forms.TextBox tex_RepPass;
        private System.Windows.Forms.Button but_Ok;
        private System.Windows.Forms.Label lab_GongHao;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Label lab_Password;
        private System.Windows.Forms.Label lab_RepPass;
    }
}