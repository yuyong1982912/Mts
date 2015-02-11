namespace MTS
{
    partial class frm_Zzbd
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
            this.com_Model = new System.Windows.Forms.ComboBox();
            this.lab_Model = new System.Windows.Forms.Label();
            this.tex_Sn = new System.Windows.Forms.TextBox();
            this.lab_Sn = new System.Windows.Forms.Label();
            this.lab_Zzsn = new System.Windows.Forms.Label();
            this.tex_Zzsn = new System.Windows.Forms.TextBox();
            this.tex_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // com_Model
            // 
            this.com_Model.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_Model.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_Model.FormattingEnabled = true;
            this.com_Model.Location = new System.Drawing.Point(117, 25);
            this.com_Model.Name = "com_Model";
            this.com_Model.Size = new System.Drawing.Size(121, 20);
            this.com_Model.TabIndex = 1;
            this.com_Model.TabStop = false;
            // 
            // lab_Model
            // 
            this.lab_Model.AutoSize = true;
            this.lab_Model.Location = new System.Drawing.Point(40, 33);
            this.lab_Model.Name = "lab_Model";
            this.lab_Model.Size = new System.Drawing.Size(59, 12);
            this.lab_Model.TabIndex = 6;
            this.lab_Model.Text = "成品型号:";
            // 
            // tex_Sn
            // 
            this.tex_Sn.Location = new System.Drawing.Point(117, 76);
            this.tex_Sn.Name = "tex_Sn";
            this.tex_Sn.Size = new System.Drawing.Size(163, 21);
            this.tex_Sn.TabIndex = 2;
            this.tex_Sn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex_Sn_KeyDown);
            // 
            // lab_Sn
            // 
            this.lab_Sn.AutoSize = true;
            this.lab_Sn.Location = new System.Drawing.Point(42, 84);
            this.lab_Sn.Name = "lab_Sn";
            this.lab_Sn.Size = new System.Drawing.Size(71, 12);
            this.lab_Sn.TabIndex = 5;
            this.lab_Sn.Text = "成品序列号:";
            // 
            // lab_Zzsn
            // 
            this.lab_Zzsn.AutoSize = true;
            this.lab_Zzsn.Location = new System.Drawing.Point(44, 133);
            this.lab_Zzsn.Name = "lab_Zzsn";
            this.lab_Zzsn.Size = new System.Drawing.Size(0, 12);
            this.lab_Zzsn.TabIndex = 4;
            // 
            // tex_Zzsn
            // 
            this.tex_Zzsn.Location = new System.Drawing.Point(117, 124);
            this.tex_Zzsn.Name = "tex_Zzsn";
            this.tex_Zzsn.Size = new System.Drawing.Size(163, 21);
            this.tex_Zzsn.TabIndex = 3;
            this.tex_Zzsn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex_Zzsn_KeyDown);
            this.tex_Zzsn.Enter += new System.EventHandler(this.tex_Zzsn_Enter);
            // 
            // tex_Result
            // 
            this.tex_Result.Location = new System.Drawing.Point(286, 25);
            this.tex_Result.Multiline = true;
            this.tex_Result.Name = "tex_Result";
            this.tex_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tex_Result.Size = new System.Drawing.Size(574, 209);
            this.tex_Result.TabIndex = 7;
            // 
            // frm_Zzbd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 266);
            this.Controls.Add(this.tex_Result);
            this.Controls.Add(this.tex_Zzsn);
            this.Controls.Add(this.lab_Zzsn);
            this.Controls.Add(this.lab_Sn);
            this.Controls.Add(this.tex_Sn);
            this.Controls.Add(this.lab_Model);
            this.Controls.Add(this.com_Model);
            this.Name = "frm_Zzbd";
            this.Text = "组装站";
            this.Load += new System.EventHandler(this.frm_Zzbd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.ComboBox com_Model;
        private System.Windows.Forms.Label lab_Model;
        private System.Windows.Forms.TextBox tex_Sn;
        private System.Windows.Forms.Label lab_Sn;
        private System.Windows.Forms.Label lab_Zzsn;
        private System.Windows.Forms.TextBox tex_Zzsn;
        private System.Windows.Forms.TextBox tex_Result;
    }
}