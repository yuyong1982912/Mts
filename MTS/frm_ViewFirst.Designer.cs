namespace MTS
{
    partial class frm_ViewFirst
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
            this.butOK = new System.Windows.Forms.Button();
            this.butCANCEL = new System.Windows.Forms.Button();
            this.labNUM = new System.Windows.Forms.Label();
            this.texNUM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(34, 135);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(75, 23);
            this.butOK.TabIndex = 0;
            this.butOK.Text = "确定";
            this.butOK.UseVisualStyleBackColor = true;
            // 
            // butCANCEL
            // 
            this.butCANCEL.Location = new System.Drawing.Point(145, 135);
            this.butCANCEL.Name = "butCANCEL";
            this.butCANCEL.Size = new System.Drawing.Size(75, 23);
            this.butCANCEL.TabIndex = 1;
            this.butCANCEL.Text = "取消";
            this.butCANCEL.UseVisualStyleBackColor = true;
            // 
            // labNUM
            // 
            this.labNUM.AutoSize = true;
            this.labNUM.Location = new System.Drawing.Point(32, 70);
            this.labNUM.Name = "labNUM";
            this.labNUM.Size = new System.Drawing.Size(77, 12);
            this.labNUM.TabIndex = 2;
            this.labNUM.Text = "烧机室编号：";
            // 
            // texNUM
            // 
            this.texNUM.Location = new System.Drawing.Point(120, 70);
            this.texNUM.Name = "texNUM";
            this.texNUM.Size = new System.Drawing.Size(100, 21);
            this.texNUM.TabIndex = 3;
            // 
            // frm_ViewFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 212);
            this.Controls.Add(this.texNUM);
            this.Controls.Add(this.labNUM);
            this.Controls.Add(this.butCANCEL);
            this.Controls.Add(this.butOK);
            this.Name = "frm_ViewFirst";
            this.Text = "烧机室";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butCANCEL;
        private System.Windows.Forms.Label labNUM;
        private System.Windows.Forms.TextBox texNUM;
    }
}