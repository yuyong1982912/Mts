namespace MTS
{
    partial class Frm_CP
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
            this.com_cpmc = new System.Windows.Forms.ComboBox();
            this.lab_cpmc = new System.Windows.Forms.Label();
            this.but_save = new System.Windows.Forms.Button();
            this.tex_cpsnd = new System.Windows.Forms.TextBox();
            this.lab_cpsnd = new System.Windows.Forms.Label();
            this.rad_bcp = new System.Windows.Forms.RadioButton();
            this.rad_cp = new System.Windows.Forms.RadioButton();
            this.tex_Bb = new System.Windows.Forms.TextBox();
            this.lab_bb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // com_cpmc
            // 
            this.com_cpmc.FormattingEnabled = true;
            this.com_cpmc.Location = new System.Drawing.Point(113, 113);
            this.com_cpmc.Name = "com_cpmc";
            this.com_cpmc.Size = new System.Drawing.Size(266, 20);
            this.com_cpmc.TabIndex = 3;
            // 
            // lab_cpmc
            // 
            this.lab_cpmc.AutoSize = true;
            this.lab_cpmc.Location = new System.Drawing.Point(48, 121);
            this.lab_cpmc.Name = "lab_cpmc";
            this.lab_cpmc.Size = new System.Drawing.Size(59, 12);
            this.lab_cpmc.TabIndex = 2;
            this.lab_cpmc.Text = "产品名称:";
            // 
            // but_save
            // 
            this.but_save.Location = new System.Drawing.Point(113, 214);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(75, 23);
            this.but_save.TabIndex = 5;
            this.but_save.Text = "保存";
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // tex_cpsnd
            // 
            this.tex_cpsnd.Location = new System.Drawing.Point(113, 33);
            this.tex_cpsnd.Name = "tex_cpsnd";
            this.tex_cpsnd.Size = new System.Drawing.Size(121, 21);
            this.tex_cpsnd.TabIndex = 1;
            this.tex_cpsnd.Leave += new System.EventHandler(this.tex_cpsnd_Leave);
            // 
            // lab_cpsnd
            // 
            this.lab_cpsnd.AutoSize = true;
            this.lab_cpsnd.Location = new System.Drawing.Point(46, 33);
            this.lab_cpsnd.Name = "lab_cpsnd";
            this.lab_cpsnd.Size = new System.Drawing.Size(59, 12);
            this.lab_cpsnd.TabIndex = 0;
            this.lab_cpsnd.Text = "产品编号:";
            // 
            // rad_bcp
            // 
            this.rad_bcp.AutoSize = true;
            this.rad_bcp.Checked = true;
            this.rad_bcp.Location = new System.Drawing.Point(50, 183);
            this.rad_bcp.Name = "rad_bcp";
            this.rad_bcp.Size = new System.Drawing.Size(59, 16);
            this.rad_bcp.TabIndex = 7;
            this.rad_bcp.TabStop = true;
            this.rad_bcp.Text = "半成品";
            this.rad_bcp.UseVisualStyleBackColor = true;
            // 
            // rad_cp
            // 
            this.rad_cp.AutoSize = true;
            this.rad_cp.Location = new System.Drawing.Point(50, 160);
            this.rad_cp.Name = "rad_cp";
            this.rad_cp.Size = new System.Drawing.Size(47, 16);
            this.rad_cp.TabIndex = 4;
            this.rad_cp.TabStop = true;
            this.rad_cp.Text = "成品";
            this.rad_cp.UseVisualStyleBackColor = true;
            // 
            // tex_Bb
            // 
            this.tex_Bb.Location = new System.Drawing.Point(113, 73);
            this.tex_Bb.Name = "tex_Bb";
            this.tex_Bb.Size = new System.Drawing.Size(100, 21);
            this.tex_Bb.TabIndex = 8;
            // 
            // lab_bb
            // 
            this.lab_bb.AutoSize = true;
            this.lab_bb.Location = new System.Drawing.Point(60, 82);
            this.lab_bb.Name = "lab_bb";
            this.lab_bb.Size = new System.Drawing.Size(35, 12);
            this.lab_bb.TabIndex = 9;
            this.lab_bb.Text = "版本:";
            // 
            // Frm_CP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 373);
            this.Controls.Add(this.lab_bb);
            this.Controls.Add(this.tex_Bb);
            this.Controls.Add(this.rad_cp);
            this.Controls.Add(this.rad_bcp);
            this.Controls.Add(this.tex_cpsnd);
            this.Controls.Add(this.lab_cpsnd);
            this.Controls.Add(this.com_cpmc);
            this.Controls.Add(this.lab_cpmc);
            this.Controls.Add(this.but_save);
            this.Name = "Frm_CP";
            this.Text = "产品型号";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox com_cpmc;
        private System.Windows.Forms.Label lab_cpmc;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.TextBox tex_cpsnd;
        private System.Windows.Forms.Label lab_cpsnd;
        private System.Windows.Forms.RadioButton rad_bcp;
        private System.Windows.Forms.RadioButton rad_cp;
        private System.Windows.Forms.TextBox tex_Bb;
        private System.Windows.Forms.Label lab_bb;

    }
}