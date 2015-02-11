namespace MTS
{
    partial class frm_GllxCpxh
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
            this.dat_GllxCpxh = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dat_GllxCpxh)).BeginInit();
            this.SuspendLayout();
            // 
            // dat_GllxCpxh
            // 
            this.dat_GllxCpxh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_GllxCpxh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dat_GllxCpxh.Location = new System.Drawing.Point(0, 0);
            this.dat_GllxCpxh.Name = "dat_GllxCpxh";
            this.dat_GllxCpxh.RowTemplate.Height = 23;
            this.dat_GllxCpxh.Size = new System.Drawing.Size(292, 266);
            this.dat_GllxCpxh.TabIndex = 0;
            this.dat_GllxCpxh.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_GllxCpxh_CellContentDoubleClick);
            // 
            // frm_GllxCpxh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.dat_GllxCpxh);
            this.Name = "frm_GllxCpxh";
            this.Text = "关联路线产品型号";
            this.Load += new System.EventHandler(this.frm_GllxCpxh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_GllxCpxh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dat_GllxCpxh;
    }
}