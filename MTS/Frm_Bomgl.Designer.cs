namespace MTS
{
    partial class Frm_Bomgl
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
            this.lab_cp = new System.Windows.Forms.Label();
            this.lab_Bzbom = new System.Windows.Forms.Label();
            this.but_Ok = new System.Windows.Forms.Button();
            this.dat_Bzbom = new MTS.DataWindow();
            this.dat_Cp = new MTS.DataWindow();
            this.SuspendLayout();
            // 
            // lab_cp
            // 
            this.lab_cp.AutoSize = true;
            this.lab_cp.Location = new System.Drawing.Point(41, 52);
            this.lab_cp.Name = "lab_cp";
            this.lab_cp.Size = new System.Drawing.Size(59, 12);
            this.lab_cp.TabIndex = 0;
            this.lab_cp.Text = "产品编号:";
            // 
            // lab_Bzbom
            // 
            this.lab_Bzbom.AutoSize = true;
            this.lab_Bzbom.Location = new System.Drawing.Point(43, 85);
            this.lab_Bzbom.Name = "lab_Bzbom";
            this.lab_Bzbom.Size = new System.Drawing.Size(53, 12);
            this.lab_Bzbom.TabIndex = 1;
            this.lab_Bzbom.Text = "包装BOM:";
            // 
            // but_Ok
            // 
            this.but_Ok.Location = new System.Drawing.Point(45, 139);
            this.but_Ok.Name = "but_Ok";
            this.but_Ok.Size = new System.Drawing.Size(75, 23);
            this.but_Ok.TabIndex = 2;
            this.but_Ok.Text = "OK";
            this.but_Ok.UseVisualStyleBackColor = true;
            this.but_Ok.Click += new System.EventHandler(this.but_Ok_Click);
            // 
            // dat_Bzbom
            // 
            this.dat_Bzbom.FormattingEnabled = true;
            this.dat_Bzbom.Location = new System.Drawing.Point(122, 77);
            this.dat_Bzbom.Name = "dat_Bzbom";
            this.dat_Bzbom.NullValue = "";
            this.dat_Bzbom.PopupGridAutoSize = false;
            this.dat_Bzbom.RowFilterVisible = false;
            this.dat_Bzbom.sDisplayField = "";
            this.dat_Bzbom.sDisplayMember = "";
            this.dat_Bzbom.SeparatorChar = "|";
            this.dat_Bzbom.Size = new System.Drawing.Size(121, 20);
            this.dat_Bzbom.sKeyWords = "";
            this.dat_Bzbom.sValueMember = "";
            this.dat_Bzbom.TabIndex = 4;
            this.dat_Bzbom.Value = "";
            // 
            // dat_Cp
            // 
            this.dat_Cp.FormattingEnabled = true;
            this.dat_Cp.Location = new System.Drawing.Point(122, 44);
            this.dat_Cp.Name = "dat_Cp";
            this.dat_Cp.NullValue = "";
            this.dat_Cp.PopupGridAutoSize = false;
            this.dat_Cp.RowFilterVisible = false;
            this.dat_Cp.sDisplayField = "";
            this.dat_Cp.sDisplayMember = "";
            this.dat_Cp.SeparatorChar = "|";
            this.dat_Cp.Size = new System.Drawing.Size(121, 20);
            this.dat_Cp.sKeyWords = "";
            this.dat_Cp.sValueMember = "";
            this.dat_Cp.TabIndex = 3;
            this.dat_Cp.Value = "";
            this.dat_Cp.SelectedIndexChanged += new System.EventHandler(this.dat_Cp_SelectedIndexChanged);
            // 
            // Frm_Bomgl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 213);
            this.Controls.Add(this.dat_Bzbom);
            this.Controls.Add(this.dat_Cp);
            this.Controls.Add(this.but_Ok);
            this.Controls.Add(this.lab_Bzbom);
            this.Controls.Add(this.lab_cp);
            this.Name = "Frm_Bomgl";
            this.Text = "产品与包装关联";
            this.Load += new System.EventHandler(this.Frm_Bomgl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_cp;
        private System.Windows.Forms.Label lab_Bzbom;
        private System.Windows.Forms.Button but_Ok;
        private DataWindow dat_Cp;
        private DataWindow dat_Bzbom;
    }
}