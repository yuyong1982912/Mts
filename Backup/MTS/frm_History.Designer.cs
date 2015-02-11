namespace MTS
{
    partial class frm_History
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
            this.tex_History = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tex_History
            // 
            this.tex_History.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tex_History.Location = new System.Drawing.Point(0, 0);
            this.tex_History.Multiline = true;
            this.tex_History.Name = "tex_History";
            this.tex_History.ReadOnly = true;
            this.tex_History.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tex_History.Size = new System.Drawing.Size(781, 262);
            this.tex_History.TabIndex = 0;
            // 
            // frm_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 262);
            this.Controls.Add(this.tex_History);
            this.Name = "frm_History";
            this.Text = "更新历史";
            this.Load += new System.EventHandler(this.frm_History_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tex_History;
    }
}