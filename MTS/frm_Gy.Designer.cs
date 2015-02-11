namespace MTS
{
    partial class frm_Gy
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
            this.che_Sfjy = new System.Windows.Forms.CheckBox();
            this.but_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tex_Gysn = new System.Windows.Forms.TextBox();
            this.tex_Gymc = new System.Windows.Forms.TextBox();
            this.lab_SuoMing = new System.Windows.Forms.Label();
            this.dat_Gy = new System.Windows.Forms.DataGridView();
            this.che_sfyzxh = new System.Windows.Forms.CheckBox();
            this.che_sfcs = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dat_Gy)).BeginInit();
            this.SuspendLayout();
            // 
            // che_Sfjy
            // 
            this.che_Sfjy.AutoSize = true;
            this.che_Sfjy.Location = new System.Drawing.Point(39, 117);
            this.che_Sfjy.Name = "che_Sfjy";
            this.che_Sfjy.Size = new System.Drawing.Size(96, 16);
            this.che_Sfjy.TabIndex = 0;
            this.che_Sfjy.Text = "是否需要检验";
            this.che_Sfjy.UseVisualStyleBackColor = true;
            // 
            // but_Save
            // 
            this.but_Save.Location = new System.Drawing.Point(39, 231);
            this.but_Save.Name = "but_Save";
            this.but_Save.Size = new System.Drawing.Size(75, 23);
            this.but_Save.TabIndex = 1;
            this.but_Save.Text = "Save";
            this.but_Save.UseVisualStyleBackColor = true;
            this.but_Save.Click += new System.EventHandler(this.but_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "工艺编号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "工艺名称:";
            // 
            // tex_Gysn
            // 
            this.tex_Gysn.Location = new System.Drawing.Point(102, 63);
            this.tex_Gysn.Name = "tex_Gysn";
            this.tex_Gysn.Size = new System.Drawing.Size(100, 21);
            this.tex_Gysn.TabIndex = 4;
            this.tex_Gysn.Leave += new System.EventHandler(this.tex_Gysn_Leave);
            // 
            // tex_Gymc
            // 
            this.tex_Gymc.Location = new System.Drawing.Point(102, 90);
            this.tex_Gymc.Name = "tex_Gymc";
            this.tex_Gymc.Size = new System.Drawing.Size(100, 21);
            this.tex_Gymc.TabIndex = 5;
            // 
            // lab_SuoMing
            // 
            this.lab_SuoMing.AutoSize = true;
            this.lab_SuoMing.Location = new System.Drawing.Point(37, 28);
            this.lab_SuoMing.Name = "lab_SuoMing";
            this.lab_SuoMing.Size = new System.Drawing.Size(185, 12);
            this.lab_SuoMing.TabIndex = 6;
            this.lab_SuoMing.Text = "工艺编号请使用如下格式:001,002";
            // 
            // dat_Gy
            // 
            this.dat_Gy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_Gy.Location = new System.Drawing.Point(228, 28);
            this.dat_Gy.Name = "dat_Gy";
            this.dat_Gy.RowTemplate.Height = 23;
            this.dat_Gy.Size = new System.Drawing.Size(602, 226);
            this.dat_Gy.TabIndex = 7;
            // 
            // che_sfyzxh
            // 
            this.che_sfyzxh.AutoSize = true;
            this.che_sfyzxh.Location = new System.Drawing.Point(39, 139);
            this.che_sfyzxh.Name = "che_sfyzxh";
            this.che_sfyzxh.Size = new System.Drawing.Size(120, 16);
            this.che_sfyzxh.TabIndex = 8;
            this.che_sfyzxh.Text = "是否需要验证型号";
            this.che_sfyzxh.UseVisualStyleBackColor = true;
            // 
            // che_sfcs
            // 
            this.che_sfcs.AutoSize = true;
            this.che_sfcs.Location = new System.Drawing.Point(39, 161);
            this.che_sfcs.Name = "che_sfcs";
            this.che_sfcs.Size = new System.Drawing.Size(120, 16);
            this.che_sfcs.TabIndex = 9;
            this.che_sfcs.Text = "是否可以多次扫描";
            this.che_sfcs.UseVisualStyleBackColor = true;
            // 
            // frm_Gy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 267);
            this.Controls.Add(this.che_sfcs);
            this.Controls.Add(this.che_sfyzxh);
            this.Controls.Add(this.dat_Gy);
            this.Controls.Add(this.lab_SuoMing);
            this.Controls.Add(this.tex_Gymc);
            this.Controls.Add(this.tex_Gysn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_Save);
            this.Controls.Add(this.che_Sfjy);
            this.Name = "frm_Gy";
            this.Text = "产品工艺";
            this.Load += new System.EventHandler(this.frm_Gy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_Gy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox che_Sfjy;
        private System.Windows.Forms.Button but_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tex_Gysn;
        private System.Windows.Forms.TextBox tex_Gymc;
        private System.Windows.Forms.Label lab_SuoMing;
        private System.Windows.Forms.DataGridView dat_Gy;
        private System.Windows.Forms.CheckBox che_sfyzxh;
        private System.Windows.Forms.CheckBox che_sfcs;
    }
}