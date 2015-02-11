namespace MTS
{
    partial class frm_querytmcs
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
            this.dat_Tmcs = new System.Windows.Forms.DataGridView();
            this.but_Save = new System.Windows.Forms.Button();
            this.tex_Password = new System.Windows.Forms.TextBox();
            this.lab_Password = new System.Windows.Forms.Label();
            this.lab_Rwdh = new System.Windows.Forms.Label();
            this.tex_Rwdh = new System.Windows.Forms.TextBox();
            this.but_Search = new System.Windows.Forms.Button();
            this.but_Export = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.labStart = new System.Windows.Forms.Label();
            this.labEnd = new System.Windows.Forms.Label();
            this.but_searchall = new System.Windows.Forms.Button();
            this.labAll = new System.Windows.Forms.Label();
            this.butEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dat_Tmcs)).BeginInit();
            this.SuspendLayout();
            // 
            // dat_Tmcs
            // 
            this.dat_Tmcs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dat_Tmcs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dat_Tmcs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_Tmcs.Location = new System.Drawing.Point(0, 0);
            this.dat_Tmcs.Name = "dat_Tmcs";
            this.dat_Tmcs.RowTemplate.Height = 23;
            this.dat_Tmcs.Size = new System.Drawing.Size(1071, 405);
            this.dat_Tmcs.TabIndex = 0;
            // 
            // but_Save
            // 
            this.but_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.but_Save.Location = new System.Drawing.Point(183, 426);
            this.but_Save.Name = "but_Save";
            this.but_Save.Size = new System.Drawing.Size(75, 23);
            this.but_Save.TabIndex = 1;
            this.but_Save.Text = "删除";
            this.but_Save.UseVisualStyleBackColor = true;
            this.but_Save.Click += new System.EventHandler(this.but_Save_Click);
            // 
            // tex_Password
            // 
            this.tex_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tex_Password.Location = new System.Drawing.Point(77, 426);
            this.tex_Password.Name = "tex_Password";
            this.tex_Password.PasswordChar = '*';
            this.tex_Password.Size = new System.Drawing.Size(100, 21);
            this.tex_Password.TabIndex = 2;
            // 
            // lab_Password
            // 
            this.lab_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lab_Password.AutoSize = true;
            this.lab_Password.Location = new System.Drawing.Point(12, 426);
            this.lab_Password.Name = "lab_Password";
            this.lab_Password.Size = new System.Drawing.Size(59, 12);
            this.lab_Password.TabIndex = 3;
            this.lab_Password.Text = "删除密码:";
            // 
            // lab_Rwdh
            // 
            this.lab_Rwdh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lab_Rwdh.AutoSize = true;
            this.lab_Rwdh.Location = new System.Drawing.Point(264, 432);
            this.lab_Rwdh.Name = "lab_Rwdh";
            this.lab_Rwdh.Size = new System.Drawing.Size(59, 12);
            this.lab_Rwdh.TabIndex = 4;
            this.lab_Rwdh.Text = "任务单号:";
            // 
            // tex_Rwdh
            // 
            this.tex_Rwdh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tex_Rwdh.Location = new System.Drawing.Point(329, 426);
            this.tex_Rwdh.Name = "tex_Rwdh";
            this.tex_Rwdh.Size = new System.Drawing.Size(100, 21);
            this.tex_Rwdh.TabIndex = 5;
            // 
            // but_Search
            // 
            this.but_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.but_Search.Location = new System.Drawing.Point(825, 426);
            this.but_Search.Name = "but_Search";
            this.but_Search.Size = new System.Drawing.Size(75, 23);
            this.but_Search.TabIndex = 6;
            this.but_Search.Text = "查找";
            this.but_Search.UseVisualStyleBackColor = true;
            this.but_Search.Click += new System.EventHandler(this.but_Search_Click);
            // 
            // but_Export
            // 
            this.but_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.but_Export.Location = new System.Drawing.Point(984, 427);
            this.but_Export.Name = "but_Export";
            this.but_Export.Size = new System.Drawing.Size(75, 23);
            this.but_Export.TabIndex = 7;
            this.but_Export.Text = "导出";
            this.but_Export.UseVisualStyleBackColor = true;
            this.but_Export.Click += new System.EventHandler(this.but_Export_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpStart.Location = new System.Drawing.Point(518, 426);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(106, 21);
            this.dtpStart.TabIndex = 8;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpEnd.Location = new System.Drawing.Point(713, 429);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(106, 21);
            this.dtpEnd.TabIndex = 9;
            // 
            // labStart
            // 
            this.labStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labStart.AutoSize = true;
            this.labStart.Location = new System.Drawing.Point(435, 432);
            this.labStart.Name = "labStart";
            this.labStart.Size = new System.Drawing.Size(77, 12);
            this.labStart.TabIndex = 10;
            this.labStart.Text = "导出开始时间";
            // 
            // labEnd
            // 
            this.labEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labEnd.AutoSize = true;
            this.labEnd.Location = new System.Drawing.Point(630, 432);
            this.labEnd.Name = "labEnd";
            this.labEnd.Size = new System.Drawing.Size(77, 12);
            this.labEnd.TabIndex = 11;
            this.labEnd.Text = "导出结束时间";
            // 
            // but_searchall
            // 
            this.but_searchall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.but_searchall.Location = new System.Drawing.Point(906, 426);
            this.but_searchall.Name = "but_searchall";
            this.but_searchall.Size = new System.Drawing.Size(75, 23);
            this.but_searchall.TabIndex = 12;
            this.but_searchall.Text = "查找全部";
            this.but_searchall.UseVisualStyleBackColor = true;
            this.but_searchall.Click += new System.EventHandler(this.but_searchall_Click);
            // 
            // labAll
            // 
            this.labAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labAll.AutoSize = true;
            this.labAll.Location = new System.Drawing.Point(940, 411);
            this.labAll.Name = "labAll";
            this.labAll.Size = new System.Drawing.Size(35, 12);
            this.labAll.TabIndex = 13;
            this.labAll.Text = "共 页";
            // 
            // butEnd
            // 
            this.butEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butEnd.Location = new System.Drawing.Point(984, 407);
            this.butEnd.Name = "butEnd";
            this.butEnd.Size = new System.Drawing.Size(75, 20);
            this.butEnd.TabIndex = 14;
            this.butEnd.Text = "末页";
            this.butEnd.UseVisualStyleBackColor = true;
            this.butEnd.Visible = false;
            this.butEnd.Click += new System.EventHandler(this.butEnd_Click);
            // 
            // frm_querytmcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 453);
            this.Controls.Add(this.butEnd);
            this.Controls.Add(this.labAll);
            this.Controls.Add(this.but_searchall);
            this.Controls.Add(this.labEnd);
            this.Controls.Add(this.labStart);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.but_Export);
            this.Controls.Add(this.but_Search);
            this.Controls.Add(this.tex_Rwdh);
            this.Controls.Add(this.lab_Rwdh);
            this.Controls.Add(this.lab_Password);
            this.Controls.Add(this.tex_Password);
            this.Controls.Add(this.but_Save);
            this.Controls.Add(this.dat_Tmcs);
            this.Name = "frm_querytmcs";
            this.Text = "产生条码查询";
            this.Load += new System.EventHandler(this.frm_querytmcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_Tmcs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dat_Tmcs;
        private System.Windows.Forms.Button but_Save;
        private System.Windows.Forms.TextBox tex_Password;
        private System.Windows.Forms.Label lab_Password;
        private System.Windows.Forms.Label lab_Rwdh;
        private System.Windows.Forms.TextBox tex_Rwdh;
        private System.Windows.Forms.Button but_Search;
        private System.Windows.Forms.Button but_Export;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label labStart;
        private System.Windows.Forms.Label labEnd;
        private System.Windows.Forms.Button but_searchall;
        private System.Windows.Forms.Label labAll;
        private System.Windows.Forms.Button butEnd;
    }
}