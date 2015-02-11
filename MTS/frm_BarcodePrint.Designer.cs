namespace MTS
{
    partial class frm_BarcodePrint
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
            this.textSN = new System.Windows.Forms.TextBox();
            this.labelSN = new System.Windows.Forms.Label();
            this.labelXH = new System.Windows.Forms.Label();
            this.textXH = new System.Windows.Forms.TextBox();
            this.butPrint = new System.Windows.Forms.Button();
            this.lab_Bzbom = new System.Windows.Forms.Label();
            this.dat_bzbom = new System.Windows.Forms.DataGridView();
            this.com_bzbom = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dat_bzbom)).BeginInit();
            this.SuspendLayout();
            // 
            // textSN
            // 
            this.textSN.Location = new System.Drawing.Point(113, 21);
            this.textSN.Name = "textSN";
            this.textSN.Size = new System.Drawing.Size(167, 21);
            this.textSN.TabIndex = 0;
            this.textSN.TextChanged += new System.EventHandler(this.textSN_TextChanged);
            this.textSN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSN_KeyDown);
            // 
            // labelSN
            // 
            this.labelSN.AutoSize = true;
            this.labelSN.Location = new System.Drawing.Point(21, 24);
            this.labelSN.Name = "labelSN";
            this.labelSN.Size = new System.Drawing.Size(47, 12);
            this.labelSN.TabIndex = 1;
            this.labelSN.Text = "序列号:";
            // 
            // labelXH
            // 
            this.labelXH.AutoSize = true;
            this.labelXH.Location = new System.Drawing.Point(21, 58);
            this.labelXH.Name = "labelXH";
            this.labelXH.Size = new System.Drawing.Size(35, 12);
            this.labelXH.TabIndex = 3;
            this.labelXH.Text = "型号:";
            // 
            // textXH
            // 
            this.textXH.Location = new System.Drawing.Point(113, 49);
            this.textXH.Name = "textXH";
            this.textXH.Size = new System.Drawing.Size(167, 21);
            this.textXH.TabIndex = 2;
            // 
            // butPrint
            // 
            this.butPrint.Location = new System.Drawing.Point(23, 383);
            this.butPrint.Name = "butPrint";
            this.butPrint.Size = new System.Drawing.Size(75, 23);
            this.butPrint.TabIndex = 4;
            this.butPrint.Text = "打印";
            this.butPrint.UseVisualStyleBackColor = true;
            this.butPrint.Click += new System.EventHandler(this.butPrint_Click);
            // 
            // lab_Bzbom
            // 
            this.lab_Bzbom.AutoSize = true;
            this.lab_Bzbom.Location = new System.Drawing.Point(21, 84);
            this.lab_Bzbom.Name = "lab_Bzbom";
            this.lab_Bzbom.Size = new System.Drawing.Size(59, 12);
            this.lab_Bzbom.TabIndex = 6;
            this.lab_Bzbom.Text = "包装BOM：";
            // 
            // dat_bzbom
            // 
            this.dat_bzbom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_bzbom.Location = new System.Drawing.Point(23, 110);
            this.dat_bzbom.Name = "dat_bzbom";
            this.dat_bzbom.RowTemplate.Height = 23;
            this.dat_bzbom.Size = new System.Drawing.Size(302, 252);
            this.dat_bzbom.TabIndex = 7;
            this.dat_bzbom.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_bzbom_CellEndEdit);
            // 
            // com_bzbom
            // 
            this.com_bzbom.FormattingEnabled = true;
            this.com_bzbom.Location = new System.Drawing.Point(114, 81);
            this.com_bzbom.Name = "com_bzbom";
            this.com_bzbom.Size = new System.Drawing.Size(166, 20);
            this.com_bzbom.TabIndex = 8;
            this.com_bzbom.SelectedIndexChanged += new System.EventHandler(this.com_bzbom_SelectedIndexChanged);
            this.com_bzbom.Enter += new System.EventHandler(this.com_bzbom_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 22);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg.ForeColor = System.Drawing.Color.Blue;
            this.lblMsg.Location = new System.Drawing.Point(121, 380);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(183, 29);
            this.lblMsg.TabIndex = 14;
            this.lblMsg.Text = " ";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMsg.Click += new System.EventHandler(this.lblMsg_Click);
            // 
            // frm_BarcodePrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 418);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.com_bzbom);
            this.Controls.Add(this.dat_bzbom);
            this.Controls.Add(this.lab_Bzbom);
            this.Controls.Add(this.butPrint);
            this.Controls.Add(this.labelXH);
            this.Controls.Add(this.textXH);
            this.Controls.Add(this.labelSN);
            this.Controls.Add(this.textSN);
            this.Name = "frm_BarcodePrint";
            this.Text = "包装条码打印";
            this.Load += new System.EventHandler(this.frm_BarcodePrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_bzbom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSN;
        private System.Windows.Forms.Label labelSN;
        private System.Windows.Forms.Label labelXH;
        private System.Windows.Forms.TextBox textXH;
        private System.Windows.Forms.Button butPrint;
        private System.Windows.Forms.Label lab_Bzbom;
        private System.Windows.Forms.DataGridView dat_bzbom;
        private System.Windows.Forms.ComboBox com_bzbom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMsg;
    }
}