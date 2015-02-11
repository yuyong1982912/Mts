namespace MTS
{
    partial class frm_Luxian
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
            this.Col_Luxian = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lab_LuXianId = new System.Windows.Forms.Label();
            this.tex_LuXianId = new System.Windows.Forms.TextBox();
            this.but_Luxian = new System.Windows.Forms.Button();
            this.dat_Xiancun = new System.Windows.Forms.DataGridView();
            this.lab_SuoMing = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dat_Luxian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dat_Xiancun)).BeginInit();
            this.SuspendLayout();
            // 
            // dat_Luxian
            // 
            this.dat_Luxian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_Luxian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Luxian});
            this.dat_Luxian.Location = new System.Drawing.Point(30, 99);
            this.dat_Luxian.Name = "dat_Luxian";
            this.dat_Luxian.RowTemplate.Height = 23;
            this.dat_Luxian.Size = new System.Drawing.Size(164, 285);
            this.dat_Luxian.TabIndex = 0;
            // 
            // Col_Luxian
            // 
            this.Col_Luxian.HeaderText = "工艺路线";
            this.Col_Luxian.Name = "Col_Luxian";
            // 
            // lab_LuXianId
            // 
            this.lab_LuXianId.AutoSize = true;
            this.lab_LuXianId.Location = new System.Drawing.Point(12, 63);
            this.lab_LuXianId.Name = "lab_LuXianId";
            this.lab_LuXianId.Size = new System.Drawing.Size(59, 12);
            this.lab_LuXianId.TabIndex = 1;
            this.lab_LuXianId.Text = "路线编号:";
            // 
            // tex_LuXianId
            // 
            this.tex_LuXianId.Location = new System.Drawing.Point(94, 63);
            this.tex_LuXianId.Name = "tex_LuXianId";
            this.tex_LuXianId.Size = new System.Drawing.Size(100, 21);
            this.tex_LuXianId.TabIndex = 2;
            // 
            // but_Luxian
            // 
            this.but_Luxian.Location = new System.Drawing.Point(30, 406);
            this.but_Luxian.Name = "but_Luxian";
            this.but_Luxian.Size = new System.Drawing.Size(75, 23);
            this.but_Luxian.TabIndex = 3;
            this.but_Luxian.Text = "Save";
            this.but_Luxian.UseVisualStyleBackColor = true;
            this.but_Luxian.Click += new System.EventHandler(this.but_Luxian_Click);
            // 
            // dat_Xiancun
            // 
            this.dat_Xiancun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dat_Xiancun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_Xiancun.Location = new System.Drawing.Point(200, 99);
            this.dat_Xiancun.Name = "dat_Xiancun";
            this.dat_Xiancun.RowTemplate.Height = 23;
            this.dat_Xiancun.Size = new System.Drawing.Size(705, 285);
            this.dat_Xiancun.TabIndex = 4;
            // 
            // lab_SuoMing
            // 
            this.lab_SuoMing.AutoSize = true;
            this.lab_SuoMing.Location = new System.Drawing.Point(12, 19);
            this.lab_SuoMing.Name = "lab_SuoMing";
            this.lab_SuoMing.Size = new System.Drawing.Size(155, 12);
            this.lab_SuoMing.TabIndex = 5;
            this.lab_SuoMing.Text = "路线编号格式为001,002,003";
            // 
            // frm_Luxian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 438);
            this.Controls.Add(this.lab_SuoMing);
            this.Controls.Add(this.dat_Xiancun);
            this.Controls.Add(this.but_Luxian);
            this.Controls.Add(this.tex_LuXianId);
            this.Controls.Add(this.lab_LuXianId);
            this.Controls.Add(this.dat_Luxian);
            this.Name = "frm_Luxian";
            this.Text = "路线";
            this.Load += new System.EventHandler(this.frm_Luxian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_Luxian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dat_Xiancun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dat_Luxian;
        private System.Windows.Forms.Label lab_LuXianId;
        private System.Windows.Forms.TextBox tex_LuXianId;
        private System.Windows.Forms.Button but_Luxian;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col_Luxian;
        private System.Windows.Forms.DataGridView dat_Xiancun;
        private System.Windows.Forms.Label lab_SuoMing;
    }
}