namespace MTS
{
    partial class frm_Weixiu
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
            this.lab_Wxsn = new System.Windows.Forms.Label();
            this.tex_Weixiu = new System.Windows.Forms.TextBox();
            this.lab_Err = new System.Windows.Forms.Label();
            this.tex_Err = new System.Windows.Forms.TextBox();
            this.lab_Cwbz = new System.Windows.Forms.Label();
            this.tex_Cwbz = new System.Windows.Forms.TextBox();
            this.lab_Weixiu = new System.Windows.Forms.Label();
            this.lab_Wxbz = new System.Windows.Forms.Label();
            this.tex_Wxbz = new System.Windows.Forms.TextBox();
            this.but_OK = new System.Windows.Forms.Button();
            this.lab_gy = new System.Windows.Forms.Label();
            this.tex_gy = new System.Windows.Forms.TextBox();
            this.dW_Wxdm = new MTS.DataWindow();
            this.SuspendLayout();
            // 
            // lab_Wxsn
            // 
            this.lab_Wxsn.AutoSize = true;
            this.lab_Wxsn.Location = new System.Drawing.Point(44, 33);
            this.lab_Wxsn.Name = "lab_Wxsn";
            this.lab_Wxsn.Size = new System.Drawing.Size(35, 12);
            this.lab_Wxsn.TabIndex = 0;
            this.lab_Wxsn.Text = "条码:";
            // 
            // tex_Weixiu
            // 
            this.tex_Weixiu.Location = new System.Drawing.Point(105, 23);
            this.tex_Weixiu.Name = "tex_Weixiu";
            this.tex_Weixiu.Size = new System.Drawing.Size(175, 21);
            this.tex_Weixiu.TabIndex = 1;
            this.tex_Weixiu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex_Weixiu_KeyDown);
            // 
            // lab_Err
            // 
            this.lab_Err.AutoSize = true;
            this.lab_Err.Location = new System.Drawing.Point(46, 76);
            this.lab_Err.Name = "lab_Err";
            this.lab_Err.Size = new System.Drawing.Size(59, 12);
            this.lab_Err.TabIndex = 2;
            this.lab_Err.Text = "错误描述:";
            // 
            // tex_Err
            // 
            this.tex_Err.Location = new System.Drawing.Point(105, 76);
            this.tex_Err.Name = "tex_Err";
            this.tex_Err.Size = new System.Drawing.Size(175, 21);
            this.tex_Err.TabIndex = 3;
            // 
            // lab_Cwbz
            // 
            this.lab_Cwbz.AutoSize = true;
            this.lab_Cwbz.Location = new System.Drawing.Point(48, 118);
            this.lab_Cwbz.Name = "lab_Cwbz";
            this.lab_Cwbz.Size = new System.Drawing.Size(59, 12);
            this.lab_Cwbz.TabIndex = 4;
            this.lab_Cwbz.Text = "错误备注:";
            // 
            // tex_Cwbz
            // 
            this.tex_Cwbz.Location = new System.Drawing.Point(105, 118);
            this.tex_Cwbz.Multiline = true;
            this.tex_Cwbz.Name = "tex_Cwbz";
            this.tex_Cwbz.Size = new System.Drawing.Size(175, 123);
            this.tex_Cwbz.TabIndex = 5;
            // 
            // lab_Weixiu
            // 
            this.lab_Weixiu.AutoSize = true;
            this.lab_Weixiu.Location = new System.Drawing.Point(309, 76);
            this.lab_Weixiu.Name = "lab_Weixiu";
            this.lab_Weixiu.Size = new System.Drawing.Size(59, 12);
            this.lab_Weixiu.TabIndex = 6;
            this.lab_Weixiu.Text = "维修代码:";
            // 
            // lab_Wxbz
            // 
            this.lab_Wxbz.AutoSize = true;
            this.lab_Wxbz.Location = new System.Drawing.Point(311, 118);
            this.lab_Wxbz.Name = "lab_Wxbz";
            this.lab_Wxbz.Size = new System.Drawing.Size(59, 12);
            this.lab_Wxbz.TabIndex = 8;
            this.lab_Wxbz.Text = "维修备注:";
            // 
            // tex_Wxbz
            // 
            this.tex_Wxbz.Location = new System.Drawing.Point(388, 118);
            this.tex_Wxbz.Multiline = true;
            this.tex_Wxbz.Name = "tex_Wxbz";
            this.tex_Wxbz.Size = new System.Drawing.Size(190, 123);
            this.tex_Wxbz.TabIndex = 9;
            // 
            // but_OK
            // 
            this.but_OK.Location = new System.Drawing.Point(105, 264);
            this.but_OK.Name = "but_OK";
            this.but_OK.Size = new System.Drawing.Size(75, 23);
            this.but_OK.TabIndex = 10;
            this.but_OK.Text = "OK";
            this.but_OK.UseVisualStyleBackColor = true;
            this.but_OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab_gy
            // 
            this.lab_gy.AutoSize = true;
            this.lab_gy.Location = new System.Drawing.Point(313, 31);
            this.lab_gy.Name = "lab_gy";
            this.lab_gy.Size = new System.Drawing.Size(35, 12);
            this.lab_gy.TabIndex = 11;
            this.lab_gy.Text = "工艺:";
            // 
            // tex_gy
            // 
            this.tex_gy.Location = new System.Drawing.Point(388, 23);
            this.tex_gy.Name = "tex_gy";
            this.tex_gy.Size = new System.Drawing.Size(190, 21);
            this.tex_gy.TabIndex = 12;
            // 
            // dW_Wxdm
            // 
            this.dW_Wxdm.FormattingEnabled = true;
            this.dW_Wxdm.Location = new System.Drawing.Point(388, 76);
            this.dW_Wxdm.Name = "dW_Wxdm";
            this.dW_Wxdm.NullValue = "";
            this.dW_Wxdm.PopupGridAutoSize = false;
            this.dW_Wxdm.RowFilterVisible = false;
            this.dW_Wxdm.sDisplayField = "";
            this.dW_Wxdm.sDisplayMember = "";
            this.dW_Wxdm.SeparatorChar = "|";
            this.dW_Wxdm.Size = new System.Drawing.Size(121, 20);
            this.dW_Wxdm.sKeyWords = "";
            this.dW_Wxdm.sValueMember = "";
            this.dW_Wxdm.TabIndex = 13;
            this.dW_Wxdm.Value = "";
            // 
            // frm_Weixiu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 316);
            this.Controls.Add(this.dW_Wxdm);
            this.Controls.Add(this.tex_gy);
            this.Controls.Add(this.lab_gy);
            this.Controls.Add(this.but_OK);
            this.Controls.Add(this.tex_Wxbz);
            this.Controls.Add(this.lab_Wxbz);
            this.Controls.Add(this.lab_Weixiu);
            this.Controls.Add(this.tex_Cwbz);
            this.Controls.Add(this.lab_Cwbz);
            this.Controls.Add(this.tex_Err);
            this.Controls.Add(this.lab_Err);
            this.Controls.Add(this.tex_Weixiu);
            this.Controls.Add(this.lab_Wxsn);
            this.Name = "frm_Weixiu";
            this.Text = "维修站";
            this.Load += new System.EventHandler(this.frm_Weixiu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Wxsn;
        private System.Windows.Forms.TextBox tex_Weixiu;
        private System.Windows.Forms.Label lab_Err;
        private System.Windows.Forms.TextBox tex_Err;
        private System.Windows.Forms.Label lab_Cwbz;
        private System.Windows.Forms.TextBox tex_Cwbz;
        private System.Windows.Forms.Label lab_Weixiu;
        private System.Windows.Forms.Label lab_Wxbz;
        private System.Windows.Forms.TextBox tex_Wxbz;
        private System.Windows.Forms.Button but_OK;
        private System.Windows.Forms.Label lab_gy;
        private System.Windows.Forms.TextBox tex_gy;
        private DataWindow dW_Wxdm;
    }
}