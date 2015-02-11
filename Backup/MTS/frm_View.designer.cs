namespace MTS
{
    partial class frm_View
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tim_View = new System.Windows.Forms.Timer(this.components);
            this.dat_View = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dat_View)).BeginInit();
            this.SuspendLayout();
            // 
            // tim_View
            // 
            this.tim_View.Interval = 5000;
            this.tim_View.Tick += new System.EventHandler(this.tim_View_Tick);
            // 
            // dat_View
            // 
            this.dat_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_View.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dat_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dat_View.Location = new System.Drawing.Point(0, 0);
            this.dat_View.Name = "dat_View";
            this.dat_View.RowTemplate.Height = 23;
            this.dat_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dat_View.Size = new System.Drawing.Size(292, 262);
            this.dat_View.TabIndex = 1;
            this.dat_View.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_View_CellDoubleClick);
            this.dat_View.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dat_View_RowPrePaint);
            // 
            // frm_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.dat_View);
            this.Name = "frm_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "显示";
            this.Load += new System.EventHandler(this.frm_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tim_View;
        private System.Windows.Forms.DataGridView dat_View;
    }
}

