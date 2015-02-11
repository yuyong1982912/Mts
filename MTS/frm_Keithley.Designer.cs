namespace MTS
{
    partial class frm_Keithley
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
            this.l_Sn = new System.Windows.Forms.Label();
            this.t_Sn = new System.Windows.Forms.TextBox();
            this.l_Config = new System.Windows.Forms.Label();
            this.t_Config = new System.Windows.Forms.TextBox();
            this.b_Print = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.t_Sn2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_Sn
            // 
            this.l_Sn.AutoSize = true;
            this.l_Sn.Location = new System.Drawing.Point(55, 74);
            this.l_Sn.Name = "l_Sn";
            this.l_Sn.Size = new System.Drawing.Size(23, 12);
            this.l_Sn.TabIndex = 0;
            this.l_Sn.Text = "SN:";
            // 
            // t_Sn
            // 
            this.t_Sn.Location = new System.Drawing.Point(88, 69);
            this.t_Sn.Name = "t_Sn";
            this.t_Sn.Size = new System.Drawing.Size(163, 21);
            this.t_Sn.TabIndex = 2;
            this.t_Sn.TextChanged += new System.EventHandler(this.t_Sn_TextChanged);
            this.t_Sn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t_Sn_KeyDown);
            // 
            // l_Config
            // 
            this.l_Config.AutoSize = true;
            this.l_Config.Location = new System.Drawing.Point(33, 34);
            this.l_Config.Name = "l_Config";
            this.l_Config.Size = new System.Drawing.Size(47, 12);
            this.l_Config.TabIndex = 2;
            this.l_Config.Text = "Config:";
            // 
            // t_Config
            // 
            this.t_Config.Location = new System.Drawing.Point(88, 29);
            this.t_Config.Name = "t_Config";
            this.t_Config.Size = new System.Drawing.Size(163, 21);
            this.t_Config.TabIndex = 1;
            this.t_Config.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t_Config_KeyDown);
            // 
            // b_Print
            // 
            this.b_Print.Location = new System.Drawing.Point(51, 277);
            this.b_Print.Name = "b_Print";
            this.b_Print.Size = new System.Drawing.Size(75, 23);
            this.b_Print.TabIndex = 6;
            this.b_Print.Text = "Print";
            this.b_Print.UseVisualStyleBackColor = true;
            this.b_Print.Visible = false;
            this.b_Print.Click += new System.EventHandler(this.b_Print_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "整箱打印";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.t_Config);
            this.groupBox1.Controls.Add(this.l_Config);
            this.groupBox1.Controls.Add(this.t_Sn);
            this.groupBox1.Controls.Add(this.l_Sn);
            this.groupBox1.Location = new System.Drawing.Point(21, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 115);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "内箱1/2";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "补打印";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.t_Sn2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(21, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 85);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "内箱2/2";
            // 
            // t_Sn2
            // 
            this.t_Sn2.Location = new System.Drawing.Point(88, 35);
            this.t_Sn2.Name = "t_Sn2";
            this.t_Sn2.Size = new System.Drawing.Size(163, 21);
            this.t_Sn2.TabIndex = 3;
            this.t_Sn2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t_Sn2_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "SN:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 22);
            this.button2.TabIndex = 12;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg.Location = new System.Drawing.Point(29, 271);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(312, 29);
            this.lblMsg.TabIndex = 13;
            this.lblMsg.Text = " ";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMsg.Click += new System.EventHandler(this.lblMsg_Click);
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(109, 12);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(163, 21);
            this.txtOrder.TabIndex = 14;
            this.txtOrder.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtOrder.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "订单号";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(97, 323);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(11, 12);
            this.lblNumber.TabIndex = 16;
            this.lblNumber.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "已包装数量:";
            // 
            // frm_Keithley
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(381, 350);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_Print);
            this.Name = "frm_Keithley";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "吉时利条码打印";
            this.Load += new System.EventHandler(this.frm_Keithley_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Sn;
        private System.Windows.Forms.TextBox t_Sn;
        private System.Windows.Forms.Label l_Config;
        private System.Windows.Forms.TextBox t_Config;
        private System.Windows.Forms.Button b_Print;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox t_Sn2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}