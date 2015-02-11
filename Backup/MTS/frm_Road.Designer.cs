namespace MTS
{
    partial class frm_Road
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
            this.tex_Cpxh = new System.Windows.Forms.TextBox();
            this.tex_Cplx = new System.Windows.Forms.TextBox();
            this.but_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dat_Cpxh = new MTS.DataWindow();
            this.dat_Cplx = new MTS.DataWindow();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tex_Cpxh
            // 
            this.tex_Cpxh.Location = new System.Drawing.Point(119, 31);
            this.tex_Cpxh.Name = "tex_Cpxh";
            this.tex_Cpxh.Size = new System.Drawing.Size(100, 21);
            this.tex_Cpxh.TabIndex = 0;
            this.tex_Cpxh.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
            this.tex_Cpxh.Leave += new System.EventHandler(this.tex_Cpxh_Leave);
            // 
            // tex_Cplx
            // 
            this.tex_Cplx.Location = new System.Drawing.Point(119, 58);
            this.tex_Cplx.Name = "tex_Cplx";
            this.tex_Cplx.Size = new System.Drawing.Size(100, 21);
            this.tex_Cplx.TabIndex = 1;
            this.tex_Cplx.DoubleClick += new System.EventHandler(this.tex_Cplx_DoubleClick);
            // 
            // but_Save
            // 
            this.but_Save.Location = new System.Drawing.Point(119, 170);
            this.but_Save.Name = "but_Save";
            this.but_Save.Size = new System.Drawing.Size(75, 23);
            this.but_Save.TabIndex = 2;
            this.but_Save.Text = "Save";
            this.but_Save.UseVisualStyleBackColor = true;
            this.but_Save.Click += new System.EventHandler(this.but_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "产品型号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "产品路线";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "请双击文本框";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "产品型号:";
            // 
            // dat_Cpxh
            // 
            this.dat_Cpxh.FormattingEnabled = true;
            this.dat_Cpxh.Location = new System.Drawing.Point(119, 85);
            this.dat_Cpxh.Name = "dat_Cpxh";
            this.dat_Cpxh.NullValue = "";
            this.dat_Cpxh.PopupGridAutoSize = false;
            this.dat_Cpxh.RowFilterVisible = false;
            this.dat_Cpxh.sDisplayField = "";
            this.dat_Cpxh.sDisplayMember = "";
            this.dat_Cpxh.SeparatorChar = "|";
            this.dat_Cpxh.Size = new System.Drawing.Size(121, 20);
            this.dat_Cpxh.sKeyWords = "";
            this.dat_Cpxh.sValueMember = "";
            this.dat_Cpxh.TabIndex = 6;
            this.dat_Cpxh.Value = "";      
            // 
            // dat_Cplx
            // 
            this.dat_Cplx.FormattingEnabled = true;
            this.dat_Cplx.Location = new System.Drawing.Point(119, 112);
            this.dat_Cplx.Name = "dat_Cplx";
            this.dat_Cplx.NullValue = "";
            this.dat_Cplx.PopupGridAutoSize = false;
            this.dat_Cplx.RowFilterVisible = false;
            this.dat_Cplx.sDisplayField = "";
            this.dat_Cplx.sDisplayMember = "";
            this.dat_Cplx.SeparatorChar = "|";
            this.dat_Cplx.Size = new System.Drawing.Size(121, 20);
            this.dat_Cplx.sKeyWords = "";
            this.dat_Cplx.sValueMember = "";
            this.dat_Cplx.TabIndex = 8;
            this.dat_Cplx.Value = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "产品路线:";
            // 
            // frm_Road
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dat_Cplx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dat_Cpxh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_Save);
            this.Controls.Add(this.tex_Cplx);
            this.Controls.Add(this.tex_Cpxh);
            this.Name = "frm_Road";
            this.Text = "关联路线";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tex_Cpxh;
        private System.Windows.Forms.TextBox tex_Cplx;
        private System.Windows.Forms.Button but_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DataWindow dat_Cpxh;
        private System.Windows.Forms.Label label4;
        private DataWindow dat_Cplx;
        private System.Windows.Forms.Label label5;
    }
}