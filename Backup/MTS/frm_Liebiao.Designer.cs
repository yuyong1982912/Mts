namespace MTS
{
    partial class frm_Liebiao
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
            this.lab_Kssj = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_Kssj = new System.Windows.Forms.DateTimePicker();
            this.dtp_Jssj = new System.Windows.Forms.DateTimePicker();
            this.com_Gy = new System.Windows.Forms.ComboBox();
            this.dat_Result = new System.Windows.Forms.DataGridView();
            this.but_Exp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dat_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_Kssj
            // 
            this.lab_Kssj.AutoSize = true;
            this.lab_Kssj.Location = new System.Drawing.Point(37, 27);
            this.lab_Kssj.Name = "lab_Kssj";
            this.lab_Kssj.Size = new System.Drawing.Size(59, 12);
            this.lab_Kssj.TabIndex = 0;
            this.lab_Kssj.Text = "开始时间:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "结束时间:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "工艺:";
            // 
            // dtp_Kssj
            // 
            this.dtp_Kssj.Location = new System.Drawing.Point(102, 18);
            this.dtp_Kssj.Name = "dtp_Kssj";
            this.dtp_Kssj.Size = new System.Drawing.Size(139, 21);
            this.dtp_Kssj.TabIndex = 3;
            // 
            // dtp_Jssj
            // 
            this.dtp_Jssj.Location = new System.Drawing.Point(313, 18);
            this.dtp_Jssj.Name = "dtp_Jssj";
            this.dtp_Jssj.Size = new System.Drawing.Size(160, 21);
            this.dtp_Jssj.TabIndex = 4;
            // 
            // com_Gy
            // 
            this.com_Gy.FormattingEnabled = true;
            this.com_Gy.Location = new System.Drawing.Point(531, 18);
            this.com_Gy.Name = "com_Gy";
            this.com_Gy.Size = new System.Drawing.Size(121, 20);
            this.com_Gy.TabIndex = 5;
            // 
            // dat_Result
            // 
            this.dat_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_Result.Location = new System.Drawing.Point(39, 45);
            this.dat_Result.Name = "dat_Result";
            this.dat_Result.RowTemplate.Height = 23;
            this.dat_Result.Size = new System.Drawing.Size(714, 290);
            this.dat_Result.TabIndex = 6;
            // 
            // but_Exp
            // 
            this.but_Exp.Location = new System.Drawing.Point(678, 14);
            this.but_Exp.Name = "but_Exp";
            this.but_Exp.Size = new System.Drawing.Size(75, 23);
            this.but_Exp.TabIndex = 7;
            this.but_Exp.Text = "导出";
            this.but_Exp.UseVisualStyleBackColor = true;
            this.but_Exp.Click += new System.EventHandler(this.but_Exp_Click);
            // 
            // frm_Liebiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 347);
            this.Controls.Add(this.but_Exp);
            this.Controls.Add(this.dat_Result);
            this.Controls.Add(this.com_Gy);
            this.Controls.Add(this.dtp_Jssj);
            this.Controls.Add(this.dtp_Kssj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_Kssj);
            this.Name = "frm_Liebiao";
            this.Text = "经过工艺列表";
            this.Load += new System.EventHandler(this.frm_Liebiao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Kssj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_Kssj;
        private System.Windows.Forms.DateTimePicker dtp_Jssj;
        private System.Windows.Forms.ComboBox com_Gy;
        private System.Windows.Forms.DataGridView dat_Result;
        private System.Windows.Forms.Button but_Exp;
    }
}