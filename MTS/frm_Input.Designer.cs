namespace MTS
{
    partial class frm_Input
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
            this.com_Zd = new System.Windows.Forms.ComboBox();
            this.lab_Zd = new System.Windows.Forms.Label();
            this.tex_Barcode = new System.Windows.Forms.TextBox();
            this.lab_Barcode = new System.Windows.Forms.Label();
            this.gro_POF = new System.Windows.Forms.GroupBox();
            this.rad_Fail = new System.Windows.Forms.RadioButton();
            this.rad_Pass = new System.Windows.Forms.RadioButton();
            this.but_Save = new System.Windows.Forms.Button();
            this.lab_Err = new System.Windows.Forms.Label();
            this.tex_Memo = new System.Windows.Forms.TextBox();
            this.lab_Memo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lis_Result = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dW_Err = new MTS.DataWindow();
            this.dw_xh = new MTS.DataWindow();
            this.chartlet1 = new FanG.Chartlet();
            this.but_Refresh = new System.Windows.Forms.Button();
            this.gro_POF.SuspendLayout();
            this.SuspendLayout();
            // 
            // com_Zd
            // 
            this.com_Zd.FormattingEnabled = true;
            this.com_Zd.Location = new System.Drawing.Point(69, 26);
            this.com_Zd.Name = "com_Zd";
            this.com_Zd.Size = new System.Drawing.Size(121, 20);
            this.com_Zd.TabIndex = 0;
            this.com_Zd.SelectedIndexChanged += new System.EventHandler(this.com_Zd_SelectedIndexChanged);
            // 
            // lab_Zd
            // 
            this.lab_Zd.AutoSize = true;
            this.lab_Zd.Location = new System.Drawing.Point(12, 33);
            this.lab_Zd.Name = "lab_Zd";
            this.lab_Zd.Size = new System.Drawing.Size(35, 12);
            this.lab_Zd.TabIndex = 1;
            this.lab_Zd.Text = "站点:";
            // 
            // tex_Barcode
            // 
            this.tex_Barcode.Location = new System.Drawing.Point(69, 91);
            this.tex_Barcode.Name = "tex_Barcode";
            this.tex_Barcode.Size = new System.Drawing.Size(121, 21);
            this.tex_Barcode.TabIndex = 2;
            // 
            // lab_Barcode
            // 
            this.lab_Barcode.AutoSize = true;
            this.lab_Barcode.Location = new System.Drawing.Point(12, 99);
            this.lab_Barcode.Name = "lab_Barcode";
            this.lab_Barcode.Size = new System.Drawing.Size(35, 12);
            this.lab_Barcode.TabIndex = 3;
            this.lab_Barcode.Text = "条码:";
            // 
            // gro_POF
            // 
            this.gro_POF.Controls.Add(this.rad_Fail);
            this.gro_POF.Controls.Add(this.rad_Pass);
            this.gro_POF.Enabled = false;
            this.gro_POF.Location = new System.Drawing.Point(13, 127);
            this.gro_POF.Name = "gro_POF";
            this.gro_POF.Size = new System.Drawing.Size(200, 76);
            this.gro_POF.TabIndex = 4;
            this.gro_POF.TabStop = false;
            this.gro_POF.Text = "Pass Or Fail";
            // 
            // rad_Fail
            // 
            this.rad_Fail.AutoSize = true;
            this.rad_Fail.Location = new System.Drawing.Point(56, 44);
            this.rad_Fail.Name = "rad_Fail";
            this.rad_Fail.Size = new System.Drawing.Size(47, 16);
            this.rad_Fail.TabIndex = 1;
            this.rad_Fail.Text = "Fail";
            this.rad_Fail.UseVisualStyleBackColor = true;
            this.rad_Fail.CheckedChanged += new System.EventHandler(this.rad_Fail_CheckedChanged);
            // 
            // rad_Pass
            // 
            this.rad_Pass.AutoSize = true;
            this.rad_Pass.Checked = true;
            this.rad_Pass.Location = new System.Drawing.Point(56, 21);
            this.rad_Pass.Name = "rad_Pass";
            this.rad_Pass.Size = new System.Drawing.Size(47, 16);
            this.rad_Pass.TabIndex = 0;
            this.rad_Pass.TabStop = true;
            this.rad_Pass.Text = "Pass";
            this.rad_Pass.UseVisualStyleBackColor = true;
            // 
            // but_Save
            // 
            this.but_Save.Location = new System.Drawing.Point(11, 222);
            this.but_Save.Name = "but_Save";
            this.but_Save.Size = new System.Drawing.Size(75, 23);
            this.but_Save.TabIndex = 5;
            this.but_Save.Text = "Save";
            this.but_Save.UseVisualStyleBackColor = true;
            this.but_Save.Click += new System.EventHandler(this.but_Save_Click);
            // 
            // lab_Err
            // 
            this.lab_Err.AutoSize = true;
            this.lab_Err.Location = new System.Drawing.Point(217, 34);
            this.lab_Err.Name = "lab_Err";
            this.lab_Err.Size = new System.Drawing.Size(59, 12);
            this.lab_Err.TabIndex = 7;
            this.lab_Err.Text = "错误代码:";
            // 
            // tex_Memo
            // 
            this.tex_Memo.Enabled = false;
            this.tex_Memo.Location = new System.Drawing.Point(219, 92);
            this.tex_Memo.Multiline = true;
            this.tex_Memo.Name = "tex_Memo";
            this.tex_Memo.Size = new System.Drawing.Size(179, 112);
            this.tex_Memo.TabIndex = 8;
            // 
            // lab_Memo
            // 
            this.lab_Memo.AutoSize = true;
            this.lab_Memo.Location = new System.Drawing.Point(219, 74);
            this.lab_Memo.Name = "lab_Memo";
            this.lab_Memo.Size = new System.Drawing.Size(35, 12);
            this.lab_Memo.TabIndex = 9;
            this.lab_Memo.Text = "备注:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "请先选择型号和站点";
            // 
            // lis_Result
            // 
            this.lis_Result.FormattingEnabled = true;
            this.lis_Result.ItemHeight = 12;
            this.lis_Result.Location = new System.Drawing.Point(112, 210);
            this.lis_Result.Name = "lis_Result";
            this.lis_Result.Size = new System.Drawing.Size(286, 52);
            this.lis_Result.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "型号：";
            // 
            // dW_Err
            // 
            this.dW_Err.Enabled = false;
            this.dW_Err.FormattingEnabled = true;
            this.dW_Err.Location = new System.Drawing.Point(277, 34);
            this.dW_Err.Name = "dW_Err";
            this.dW_Err.NullValue = "";
            this.dW_Err.PopupGridAutoSize = false;
            this.dW_Err.RowFilterVisible = false;
            this.dW_Err.sDisplayField = "";
            this.dW_Err.sDisplayMember = "";
            this.dW_Err.SeparatorChar = "|";
            this.dW_Err.Size = new System.Drawing.Size(121, 20);
            this.dW_Err.sKeyWords = "";
            this.dW_Err.sValueMember = "";
            this.dW_Err.TabIndex = 14;
            this.dW_Err.Value = "";
            // 
            // dw_xh
            // 
            this.dw_xh.Enabled = false;
            this.dw_xh.FormattingEnabled = true;
            this.dw_xh.Location = new System.Drawing.Point(69, 56);
            this.dw_xh.Name = "dw_xh";
            this.dw_xh.NullValue = "";
            this.dw_xh.PopupGridAutoSize = false;
            this.dw_xh.RowFilterVisible = false;
            this.dw_xh.sDisplayField = "";
            this.dw_xh.sDisplayMember = "";
            this.dw_xh.SeparatorChar = "|";
            this.dw_xh.Size = new System.Drawing.Size(121, 20);
            this.dw_xh.sKeyWords = "";
            this.dw_xh.sValueMember = "";
            this.dw_xh.TabIndex = 13;
            this.dw_xh.Value = "";
            // 
            // chartlet1
            // 
            this.chartlet1.Alpha3D = ((byte)(255));
            this.chartlet1.AppearanceStyle = FanG.Chartlet.AppearanceStyles.Bar_2D_Aurora_FlatCrystal_Glow_NoBorder;
            this.chartlet1.AutoBarWidth = true;
            this.chartlet1.Background.Highlight = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(238)))));
            this.chartlet1.Background.Lowlight = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.chartlet1.Background.Paper = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chartlet1.ChartTitle.BackColor = System.Drawing.Color.White;
            this.chartlet1.ChartTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.chartlet1.ChartTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.chartlet1.ChartTitle.OffsetY = 0;
            this.chartlet1.ChartTitle.Show = true;
            this.chartlet1.ChartTitle.Text = "Please bind a data source with BindChartData()!";
            this.chartlet1.ChartType = FanG.Chartlet.ChartTypes.Bar;
            this.chartlet1.ClientClick = "";
            this.chartlet1.ClientMouseMove = "";
            this.chartlet1.ClientMouseOut = "";
            this.chartlet1.ClientMouseOver = "";
            this.chartlet1.ClientUseMap = "";
            this.chartlet1.Colorful = true;
            this.chartlet1.ColorGuider.BackColor = System.Drawing.Color.White;
            this.chartlet1.ColorGuider.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.chartlet1.ColorGuider.ForeColor = System.Drawing.Color.Black;
            this.chartlet1.ColorGuider.Show = true;
            this.chartlet1.CopyrightText = "Provided by Chartlet.cn";
            this.chartlet1.Crystal.Contraction = 1;
            this.chartlet1.Crystal.CoverFull = true;
            this.chartlet1.Crystal.Direction = FanG.Chartlet.Direction.TopBottom;
            this.chartlet1.Crystal.Enable = true;
            this.chartlet1.Depth3D = 10;
            this.chartlet1.Dimension = FanG.Chartlet.ChartDimensions.Chart2D;
            this.chartlet1.Fill.Color1 = System.Drawing.Color.Empty;
            this.chartlet1.Fill.Color2 = System.Drawing.Color.Empty;
            this.chartlet1.Fill.Color3 = System.Drawing.Color.Empty;
            this.chartlet1.Fill.ColorStyle = FanG.Chartlet.ColorStyles.Aurora;
            this.chartlet1.Fill.ShiftStep = 0;
            this.chartlet1.Fill.TextureEnable = false;
            this.chartlet1.Fill.TextureStyle = System.Drawing.Drawing2D.HatchStyle.DarkUpwardDiagonal;
            this.chartlet1.GroupSize = 0;
            this.chartlet1.ImageBorder = 0;
            this.chartlet1.ImageFolder = "Chartlet";
            this.chartlet1.ImageStyle = "";
            this.chartlet1.InflateBottom = 0;
            this.chartlet1.InflateLeft = 0;
            this.chartlet1.InflateRight = 0;
            this.chartlet1.InflateTop = 0;
            this.chartlet1.LineConnectionRadius = 10;
            this.chartlet1.LineConnectionType = FanG.Chartlet.LineConnectionTypes.Round;
            this.chartlet1.Location = new System.Drawing.Point(404, 9);
            this.chartlet1.MaxValueY = 0;
            this.chartlet1.MinValueY = 0;
            this.chartlet1.Name = "chartlet1";
            this.chartlet1.OutputFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            this.chartlet1.RootPath = "C:\\\\";
            this.chartlet1.RoundRadius = 2;
            this.chartlet1.RoundRectangle = false;
            this.chartlet1.Shadow.Alpha = ((byte)(192));
            this.chartlet1.Shadow.Angle = 60F;
            this.chartlet1.Shadow.Color = System.Drawing.Color.Black;
            this.chartlet1.Shadow.Distance = 0;
            this.chartlet1.Shadow.Enable = true;
            this.chartlet1.Shadow.Hollow = false;
            this.chartlet1.Shadow.Radius = 3;
            this.chartlet1.ShowCopyright = false;
            this.chartlet1.ShowErrorInfo = true;
            this.chartlet1.Size = new System.Drawing.Size(527, 335);
            this.chartlet1.Stroke.Color1 = System.Drawing.Color.Empty;
            this.chartlet1.Stroke.Color2 = System.Drawing.Color.Empty;
            this.chartlet1.Stroke.Color3 = System.Drawing.Color.Empty;
            this.chartlet1.Stroke.ColorStyle = FanG.Chartlet.ColorStyles.None;
            this.chartlet1.Stroke.ShiftStep = 0;
            this.chartlet1.Stroke.TextureEnable = false;
            this.chartlet1.Stroke.TextureStyle = System.Drawing.Drawing2D.HatchStyle.DarkUpwardDiagonal;
            this.chartlet1.Stroke.Width = 0;
            this.chartlet1.TabIndex = 15;
            this.chartlet1.Tips.BackColor = System.Drawing.Color.White;
            this.chartlet1.Tips.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.chartlet1.Tips.ForeColor = System.Drawing.Color.Black;
            this.chartlet1.Tips.Show = true;
            this.chartlet1.XLabels.BackColor = System.Drawing.Color.White;
            this.chartlet1.XLabels.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.chartlet1.XLabels.ForeColor = System.Drawing.Color.Black;
            this.chartlet1.XLabels.RotateAngle = 30F;
            this.chartlet1.XLabels.SampleSize = 1;
            this.chartlet1.XLabels.Show = true;
            this.chartlet1.XLabels.UnitFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.chartlet1.XLabels.UnitText = "XLabelsUnit";
            this.chartlet1.XLabels.ValueFormat = "0.0";
            this.chartlet1.YLabels.BackColor = System.Drawing.Color.White;
            this.chartlet1.YLabels.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.chartlet1.YLabels.ForeColor = System.Drawing.Color.Black;
            this.chartlet1.YLabels.Show = true;
            this.chartlet1.YLabels.UnitFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.chartlet1.YLabels.UnitText = "YLabelsUnit";
            this.chartlet1.YLabels.ValueFormat = "0.0";
            // 
            // but_Refresh
            // 
            this.but_Refresh.Location = new System.Drawing.Point(323, 268);
            this.but_Refresh.Name = "but_Refresh";
            this.but_Refresh.Size = new System.Drawing.Size(75, 23);
            this.but_Refresh.TabIndex = 16;
            this.but_Refresh.Text = "Refresh";
            this.but_Refresh.UseVisualStyleBackColor = true;
            this.but_Refresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 353);
            this.Controls.Add(this.but_Refresh);
            this.Controls.Add(this.chartlet1);
            this.Controls.Add(this.dW_Err);
            this.Controls.Add(this.dw_xh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lis_Result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_Memo);
            this.Controls.Add(this.tex_Memo);
            this.Controls.Add(this.lab_Err);
            this.Controls.Add(this.but_Save);
            this.Controls.Add(this.gro_POF);
            this.Controls.Add(this.lab_Barcode);
            this.Controls.Add(this.tex_Barcode);
            this.Controls.Add(this.lab_Zd);
            this.Controls.Add(this.com_Zd);
            this.Name = "frm_Input";
            this.Text = "frm_Input";
            this.Load += new System.EventHandler(this.frm_Input_Load);
            this.gro_POF.ResumeLayout(false);
            this.gro_POF.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox com_Zd;
        private System.Windows.Forms.Label lab_Zd;
        private System.Windows.Forms.TextBox tex_Barcode;
        private System.Windows.Forms.Label lab_Barcode;
        private System.Windows.Forms.GroupBox gro_POF;
        private System.Windows.Forms.RadioButton rad_Fail;
        private System.Windows.Forms.RadioButton rad_Pass;
        private System.Windows.Forms.Button but_Save;
        private System.Windows.Forms.Label lab_Err;
        private System.Windows.Forms.TextBox tex_Memo;
        private System.Windows.Forms.Label lab_Memo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lis_Result;
        private System.Windows.Forms.Label label2;
        private DataWindow dw_xh;
        private DataWindow dW_Err;
        private FanG.Chartlet chartlet1;
        private System.Windows.Forms.Button but_Refresh;
    }
}