namespace MTS
{
    partial class frm_GllxCplx
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
            this.dat_Luxian = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dat_Luxian)).BeginInit();
            this.SuspendLayout();
            // 
            // dat_Luxian
            // 
            this.dat_Luxian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dat_Luxian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_Luxian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dat_Luxian.Location = new System.Drawing.Point(0, 0);
            this.dat_Luxian.Name = "dat_Luxian";
            this.dat_Luxian.RowTemplate.Height = 23;
            this.dat_Luxian.Size = new System.Drawing.Size(724, 364);
            this.dat_Luxian.TabIndex = 1;
            // 
            // frm_GllxCplx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 364);
            this.Controls.Add(this.dat_Luxian);
            this.Name = "frm_GllxCplx";
            this.Text = "路线关联产品路线";
            this.Load += new System.EventHandler(this.frm_GllxCplx_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_Luxian)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dat_Luxian;


    }
}