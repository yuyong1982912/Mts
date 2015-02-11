namespace MTS
{
    partial class frm_gllx_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.but_Save = new System.Windows.Forms.Button();
            this.dw_Cplx = new MTS.DataWindow();
            this.dw_Cpxh = new MTS.DataWindow();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "产品型号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "产品路线:";
            // 
            // but_Save
            // 
            this.but_Save.Location = new System.Drawing.Point(121, 124);
            this.but_Save.Name = "but_Save";
            this.but_Save.Size = new System.Drawing.Size(75, 23);
            this.but_Save.TabIndex = 5;
            this.but_Save.Text = "Save";
            this.but_Save.UseVisualStyleBackColor = true;
            this.but_Save.Click += new System.EventHandler(this.but_Save_Click);
            // 
            // dw_Cplx
            // 
            this.dw_Cplx.FormattingEnabled = true;
            this.dw_Cplx.Location = new System.Drawing.Point(121, 78);
            this.dw_Cplx.Name = "dw_Cplx";
            this.dw_Cplx.NullValue = "";
            this.dw_Cplx.PopupGridAutoSize = false;
            this.dw_Cplx.RowFilterVisible = false;
            this.dw_Cplx.sDisplayField = "";
            this.dw_Cplx.sDisplayMember = "";
            this.dw_Cplx.SeparatorChar = "|";
            this.dw_Cplx.Size = new System.Drawing.Size(121, 20);
            this.dw_Cplx.sKeyWords = "";
            this.dw_Cplx.sValueMember = "";
            this.dw_Cplx.TabIndex = 3;
            this.dw_Cplx.Value = "";
            // 
            // dw_Cpxh
            // 
            this.dw_Cpxh.FormattingEnabled = true;
            this.dw_Cpxh.Location = new System.Drawing.Point(121, 32);
            this.dw_Cpxh.Name = "dw_Cpxh";
            this.dw_Cpxh.NullValue = "";
            this.dw_Cpxh.PopupGridAutoSize = false;
            this.dw_Cpxh.RowFilterVisible = false;
            this.dw_Cpxh.sDisplayField = "";
            this.dw_Cpxh.sDisplayMember = "";
            this.dw_Cpxh.SeparatorChar = "|";
            this.dw_Cpxh.Size = new System.Drawing.Size(121, 20);
            this.dw_Cpxh.sKeyWords = "";
            this.dw_Cpxh.sValueMember = "";
            this.dw_Cpxh.TabIndex = 0;
            this.dw_Cpxh.Value = "";
            // 
            // frm_gllx_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.but_Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dw_Cplx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dw_Cpxh);
            this.Name = "frm_gllx_2";
            this.Text = "路线关联二";
            this.Load += new System.EventHandler(this.frm_gllx_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataWindow dw_Cpxh;
        private System.Windows.Forms.Label label1;
        private DataWindow dw_Cplx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_Save;
    }
}