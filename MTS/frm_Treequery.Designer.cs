namespace MTS
{
    partial class frm_Treequery
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
            this.lab_Des = new System.Windows.Forms.Label();
            this.lab_Sn = new System.Windows.Forms.Label();
            this.tex_Sn = new System.Windows.Forms.TextBox();
            this.tab_Query = new System.Windows.Forms.TabControl();
            this.tabp_Cpzt = new System.Windows.Forms.TabPage();
            this.dat_Cpzt = new System.Windows.Forms.DataGridView();
            this.tabp_Cpbd = new System.Windows.Forms.TabPage();
            this.dat_Cpbd = new System.Windows.Forms.DataGridView();
            this.tabp_Wxjl = new System.Windows.Forms.TabPage();
            this.dat_Wxjl = new System.Windows.Forms.DataGridView();
            this.tab_Bljl = new System.Windows.Forms.TabPage();
            this.dat_Bljl = new System.Windows.Forms.DataGridView();
            this.tab_sjcx = new System.Windows.Forms.TabPage();
            this.dat_sjcx = new System.Windows.Forms.DataGridView();
            this.tab_Query.SuspendLayout();
            this.tabp_Cpzt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_Cpzt)).BeginInit();
            this.tabp_Cpbd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_Cpbd)).BeginInit();
            this.tabp_Wxjl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_Wxjl)).BeginInit();
            this.tab_Bljl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_Bljl)).BeginInit();
            this.tab_sjcx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_sjcx)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_Des
            // 
            this.lab_Des.AutoSize = true;
            this.lab_Des.Location = new System.Drawing.Point(294, 27);
            this.lab_Des.Name = "lab_Des";
            this.lab_Des.Size = new System.Drawing.Size(65, 12);
            this.lab_Des.TabIndex = 1;
            this.lab_Des.Text = "请按回车键";
            // 
            // lab_Sn
            // 
            this.lab_Sn.AutoSize = true;
            this.lab_Sn.Location = new System.Drawing.Point(13, 27);
            this.lab_Sn.Name = "lab_Sn";
            this.lab_Sn.Size = new System.Drawing.Size(65, 12);
            this.lab_Sn.TabIndex = 2;
            this.lab_Sn.Text = "请输入条码";
            // 
            // tex_Sn
            // 
            this.tex_Sn.Location = new System.Drawing.Point(84, 18);
            this.tex_Sn.Name = "tex_Sn";
            this.tex_Sn.Size = new System.Drawing.Size(199, 21);
            this.tex_Sn.TabIndex = 3;
            this.tex_Sn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex_Sn_KeyDown);
            // 
            // tab_Query
            // 
            this.tab_Query.Controls.Add(this.tabp_Cpzt);
            this.tab_Query.Controls.Add(this.tabp_Cpbd);
            this.tab_Query.Controls.Add(this.tabp_Wxjl);
            this.tab_Query.Controls.Add(this.tab_Bljl);
            this.tab_Query.Controls.Add(this.tab_sjcx);
            this.tab_Query.Location = new System.Drawing.Point(15, 59);
            this.tab_Query.Name = "tab_Query";
            this.tab_Query.SelectedIndex = 0;
            this.tab_Query.Size = new System.Drawing.Size(788, 275);
            this.tab_Query.TabIndex = 4;
            // 
            // tabp_Cpzt
            // 
            this.tabp_Cpzt.Controls.Add(this.dat_Cpzt);
            this.tabp_Cpzt.Location = new System.Drawing.Point(4, 21);
            this.tabp_Cpzt.Name = "tabp_Cpzt";
            this.tabp_Cpzt.Padding = new System.Windows.Forms.Padding(3);
            this.tabp_Cpzt.Size = new System.Drawing.Size(780, 250);
            this.tabp_Cpzt.TabIndex = 0;
            this.tabp_Cpzt.Text = "经过工艺";
            this.tabp_Cpzt.UseVisualStyleBackColor = true;
            // 
            // dat_Cpzt
            // 
            this.dat_Cpzt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_Cpzt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dat_Cpzt.Location = new System.Drawing.Point(3, 3);
            this.dat_Cpzt.Name = "dat_Cpzt";
            this.dat_Cpzt.RowTemplate.Height = 23;
            this.dat_Cpzt.Size = new System.Drawing.Size(774, 244);
            this.dat_Cpzt.TabIndex = 0;
            // 
            // tabp_Cpbd
            // 
            this.tabp_Cpbd.Controls.Add(this.dat_Cpbd);
            this.tabp_Cpbd.Location = new System.Drawing.Point(4, 21);
            this.tabp_Cpbd.Name = "tabp_Cpbd";
            this.tabp_Cpbd.Padding = new System.Windows.Forms.Padding(3);
            this.tabp_Cpbd.Size = new System.Drawing.Size(780, 250);
            this.tabp_Cpbd.TabIndex = 1;
            this.tabp_Cpbd.Text = "产品绑定";
            this.tabp_Cpbd.UseVisualStyleBackColor = true;
            // 
            // dat_Cpbd
            // 
            this.dat_Cpbd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_Cpbd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dat_Cpbd.Location = new System.Drawing.Point(3, 3);
            this.dat_Cpbd.Name = "dat_Cpbd";
            this.dat_Cpbd.RowTemplate.Height = 23;
            this.dat_Cpbd.Size = new System.Drawing.Size(774, 244);
            this.dat_Cpbd.TabIndex = 0;
            // 
            // tabp_Wxjl
            // 
            this.tabp_Wxjl.Controls.Add(this.dat_Wxjl);
            this.tabp_Wxjl.Location = new System.Drawing.Point(4, 21);
            this.tabp_Wxjl.Name = "tabp_Wxjl";
            this.tabp_Wxjl.Padding = new System.Windows.Forms.Padding(3);
            this.tabp_Wxjl.Size = new System.Drawing.Size(780, 250);
            this.tabp_Wxjl.TabIndex = 2;
            this.tabp_Wxjl.Text = "维修记录";
            this.tabp_Wxjl.UseVisualStyleBackColor = true;
            // 
            // dat_Wxjl
            // 
            this.dat_Wxjl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_Wxjl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dat_Wxjl.Location = new System.Drawing.Point(3, 3);
            this.dat_Wxjl.Name = "dat_Wxjl";
            this.dat_Wxjl.RowTemplate.Height = 23;
            this.dat_Wxjl.Size = new System.Drawing.Size(774, 244);
            this.dat_Wxjl.TabIndex = 0;
            // 
            // tab_Bljl
            // 
            this.tab_Bljl.Controls.Add(this.dat_Bljl);
            this.tab_Bljl.Location = new System.Drawing.Point(4, 21);
            this.tab_Bljl.Name = "tab_Bljl";
            this.tab_Bljl.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Bljl.Size = new System.Drawing.Size(780, 250);
            this.tab_Bljl.TabIndex = 3;
            this.tab_Bljl.Text = "不良记录";
            this.tab_Bljl.UseVisualStyleBackColor = true;
            // 
            // dat_Bljl
            // 
            this.dat_Bljl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_Bljl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dat_Bljl.Location = new System.Drawing.Point(3, 3);
            this.dat_Bljl.Name = "dat_Bljl";
            this.dat_Bljl.RowTemplate.Height = 23;
            this.dat_Bljl.Size = new System.Drawing.Size(774, 244);
            this.dat_Bljl.TabIndex = 0;
            // 
            // tab_sjcx
            // 
            this.tab_sjcx.Controls.Add(this.dat_sjcx);
            this.tab_sjcx.Location = new System.Drawing.Point(4, 21);
            this.tab_sjcx.Name = "tab_sjcx";
            this.tab_sjcx.Padding = new System.Windows.Forms.Padding(3);
            this.tab_sjcx.Size = new System.Drawing.Size(780, 250);
            this.tab_sjcx.TabIndex = 4;
            this.tab_sjcx.Text = "烧机查询";
            this.tab_sjcx.UseVisualStyleBackColor = true;
            // 
            // dat_sjcx
            // 
            this.dat_sjcx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_sjcx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dat_sjcx.Location = new System.Drawing.Point(3, 3);
            this.dat_sjcx.Name = "dat_sjcx";
            this.dat_sjcx.RowTemplate.Height = 23;
            this.dat_sjcx.Size = new System.Drawing.Size(774, 244);
            this.dat_sjcx.TabIndex = 0;
            // 
            // frm_Treequery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 346);
            this.Controls.Add(this.tab_Query);
            this.Controls.Add(this.tex_Sn);
            this.Controls.Add(this.lab_Sn);
            this.Controls.Add(this.lab_Des);
            this.Name = "frm_Treequery";
            this.Text = "综合查询";
            this.tab_Query.ResumeLayout(false);
            this.tabp_Cpzt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dat_Cpzt)).EndInit();
            this.tabp_Cpbd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dat_Cpbd)).EndInit();
            this.tabp_Wxjl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dat_Wxjl)).EndInit();
            this.tab_Bljl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dat_Bljl)).EndInit();
            this.tab_sjcx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dat_sjcx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Des;
        private System.Windows.Forms.Label lab_Sn;
        private System.Windows.Forms.TextBox tex_Sn;
        private System.Windows.Forms.TabControl tab_Query;
        private System.Windows.Forms.TabPage tabp_Cpzt;
        private System.Windows.Forms.TabPage tabp_Cpbd;
        private System.Windows.Forms.TabPage tabp_Wxjl;
        private System.Windows.Forms.DataGridView dat_Cpzt;
        private System.Windows.Forms.DataGridView dat_Cpbd;
        private System.Windows.Forms.DataGridView dat_Wxjl;
        private System.Windows.Forms.TabPage tab_Bljl;
        private System.Windows.Forms.DataGridView dat_Bljl;
        private System.Windows.Forms.TabPage tab_sjcx;
        private System.Windows.Forms.DataGridView dat_sjcx;
    }
}