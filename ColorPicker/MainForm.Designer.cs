namespace ColorPicker
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.pantoneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iTextBox = new System.Windows.Forms.TextBox();
            this.sTextBox = new System.Windows.Forms.TextBox();
            this.hTextBox = new System.Windows.Forms.TextBox();
            this.iLabel = new System.Windows.Forms.Label();
            this.sLabel = new System.Windows.Forms.Label();
            this.hLabel = new System.Windows.Forms.Label();
            this.kTextBox = new System.Windows.Forms.TextBox();
            this.mTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.kLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.mLabel = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.gTextBox = new System.Windows.Forms.TextBox();
            this.rTextBox = new System.Windows.Forms.TextBox();
            this.bLabel = new System.Windows.Forms.Label();
            this.gLabel = new System.Windows.Forms.Label();
            this.rLabel = new System.Windows.Forms.Label();
            this.hexTextBox = new System.Windows.Forms.TextBox();
            this.hexLabel = new System.Windows.Forms.Label();
            this.getColorGroupBox = new System.Windows.Forms.GroupBox();
            this.showPictureBox = new System.Windows.Forms.PictureBox();
            this.getPictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hisPictureBox5 = new System.Windows.Forms.PictureBox();
            this.hisPictureBox4 = new System.Windows.Forms.PictureBox();
            this.hisPictureBox3 = new System.Windows.Forms.PictureBox();
            this.hisPictureBox2 = new System.Windows.Forms.PictureBox();
            this.hisPictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.colorGroupBox.SuspendLayout();
            this.getColorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hisPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hisPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hisPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hisPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hisPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(369, 83);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(175, 175);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(410, 33);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(108, 16);
            this.checkBox.TabIndex = 1;
            this.checkBox.Text = "始终显示在前面";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.pantoneTextBox);
            this.colorGroupBox.Controls.Add(this.label1);
            this.colorGroupBox.Controls.Add(this.iTextBox);
            this.colorGroupBox.Controls.Add(this.sTextBox);
            this.colorGroupBox.Controls.Add(this.hTextBox);
            this.colorGroupBox.Controls.Add(this.iLabel);
            this.colorGroupBox.Controls.Add(this.sLabel);
            this.colorGroupBox.Controls.Add(this.hLabel);
            this.colorGroupBox.Controls.Add(this.kTextBox);
            this.colorGroupBox.Controls.Add(this.mTextBox);
            this.colorGroupBox.Controls.Add(this.yTextBox);
            this.colorGroupBox.Controls.Add(this.cTextBox);
            this.colorGroupBox.Controls.Add(this.kLabel);
            this.colorGroupBox.Controls.Add(this.yLabel);
            this.colorGroupBox.Controls.Add(this.mLabel);
            this.colorGroupBox.Controls.Add(this.cLabel);
            this.colorGroupBox.Controls.Add(this.bTextBox);
            this.colorGroupBox.Controls.Add(this.gTextBox);
            this.colorGroupBox.Controls.Add(this.rTextBox);
            this.colorGroupBox.Controls.Add(this.bLabel);
            this.colorGroupBox.Controls.Add(this.gLabel);
            this.colorGroupBox.Controls.Add(this.rLabel);
            this.colorGroupBox.Controls.Add(this.hexTextBox);
            this.colorGroupBox.Controls.Add(this.hexLabel);
            this.colorGroupBox.Location = new System.Drawing.Point(12, 93);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(265, 165);
            this.colorGroupBox.TabIndex = 2;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "颜色值";
            // 
            // pantoneTextBox
            // 
            this.pantoneTextBox.Location = new System.Drawing.Point(152, 24);
            this.pantoneTextBox.Name = "pantoneTextBox";
            this.pantoneTextBox.Size = new System.Drawing.Size(107, 21);
            this.pantoneTextBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "Pantone";
            // 
            // iTextBox
            // 
            this.iTextBox.Location = new System.Drawing.Point(93, 125);
            this.iTextBox.Name = "iTextBox";
            this.iTextBox.Size = new System.Drawing.Size(60, 21);
            this.iTextBox.TabIndex = 21;
            // 
            // sTextBox
            // 
            this.sTextBox.Location = new System.Drawing.Point(93, 93);
            this.sTextBox.Name = "sTextBox";
            this.sTextBox.Size = new System.Drawing.Size(60, 21);
            this.sTextBox.TabIndex = 20;
            // 
            // hTextBox
            // 
            this.hTextBox.Location = new System.Drawing.Point(93, 61);
            this.hTextBox.Name = "hTextBox";
            this.hTextBox.Size = new System.Drawing.Size(60, 21);
            this.hTextBox.TabIndex = 19;
            // 
            // iLabel
            // 
            this.iLabel.AutoSize = true;
            this.iLabel.Location = new System.Drawing.Point(76, 129);
            this.iLabel.Name = "iLabel";
            this.iLabel.Size = new System.Drawing.Size(11, 12);
            this.iLabel.TabIndex = 18;
            this.iLabel.Text = "I";
            // 
            // sLabel
            // 
            this.sLabel.AutoSize = true;
            this.sLabel.Location = new System.Drawing.Point(76, 98);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(11, 12);
            this.sLabel.TabIndex = 17;
            this.sLabel.Text = "S";
            // 
            // hLabel
            // 
            this.hLabel.AutoSize = true;
            this.hLabel.Location = new System.Drawing.Point(76, 67);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(11, 12);
            this.hLabel.TabIndex = 16;
            this.hLabel.Text = "H";
            // 
            // kTextBox
            // 
            this.kTextBox.Location = new System.Drawing.Point(186, 134);
            this.kTextBox.Name = "kTextBox";
            this.kTextBox.Size = new System.Drawing.Size(60, 21);
            this.kTextBox.TabIndex = 15;
            // 
            // mTextBox
            // 
            this.mTextBox.Location = new System.Drawing.Point(186, 80);
            this.mTextBox.Name = "mTextBox";
            this.mTextBox.Size = new System.Drawing.Size(60, 21);
            this.mTextBox.TabIndex = 13;
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(186, 107);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(60, 21);
            this.yTextBox.TabIndex = 14;
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(186, 53);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(60, 21);
            this.cTextBox.TabIndex = 12;
            // 
            // kLabel
            // 
            this.kLabel.AutoSize = true;
            this.kLabel.Location = new System.Drawing.Point(169, 138);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(11, 12);
            this.kLabel.TabIndex = 11;
            this.kLabel.Text = "K";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(169, 111);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(11, 12);
            this.yLabel.TabIndex = 10;
            this.yLabel.Text = "Y";
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(169, 85);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(11, 12);
            this.mLabel.TabIndex = 9;
            this.mLabel.Text = "M";
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Location = new System.Drawing.Point(169, 58);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(11, 12);
            this.cLabel.TabIndex = 8;
            this.cLabel.Text = "C";
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(30, 125);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(30, 21);
            this.bTextBox.TabIndex = 7;
            // 
            // gTextBox
            // 
            this.gTextBox.Location = new System.Drawing.Point(30, 93);
            this.gTextBox.Name = "gTextBox";
            this.gTextBox.Size = new System.Drawing.Size(30, 21);
            this.gTextBox.TabIndex = 6;
            // 
            // rTextBox
            // 
            this.rTextBox.Location = new System.Drawing.Point(30, 61);
            this.rTextBox.Name = "rTextBox";
            this.rTextBox.Size = new System.Drawing.Size(30, 21);
            this.rTextBox.TabIndex = 5;
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(13, 129);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(11, 12);
            this.bLabel.TabIndex = 4;
            this.bLabel.Text = "B";
            // 
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.Location = new System.Drawing.Point(13, 98);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(11, 12);
            this.gLabel.TabIndex = 3;
            this.gLabel.Text = "G";
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.Location = new System.Drawing.Point(13, 67);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(11, 12);
            this.rLabel.TabIndex = 2;
            this.rLabel.Text = "R";
            // 
            // hexTextBox
            // 
            this.hexTextBox.Location = new System.Drawing.Point(35, 25);
            this.hexTextBox.Name = "hexTextBox";
            this.hexTextBox.Size = new System.Drawing.Size(58, 21);
            this.hexTextBox.TabIndex = 1;
            // 
            // hexLabel
            // 
            this.hexLabel.AutoSize = true;
            this.hexLabel.Location = new System.Drawing.Point(11, 29);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(23, 12);
            this.hexLabel.TabIndex = 0;
            this.hexLabel.Text = "HEX";
            // 
            // getColorGroupBox
            // 
            this.getColorGroupBox.Controls.Add(this.showPictureBox);
            this.getColorGroupBox.Controls.Add(this.getPictureBox);
            this.getColorGroupBox.Location = new System.Drawing.Point(40, 12);
            this.getColorGroupBox.Name = "getColorGroupBox";
            this.getColorGroupBox.Size = new System.Drawing.Size(209, 75);
            this.getColorGroupBox.TabIndex = 0;
            this.getColorGroupBox.TabStop = false;
            this.getColorGroupBox.Text = "取色";
            // 
            // showPictureBox
            // 
            this.showPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showPictureBox.Location = new System.Drawing.Point(138, 20);
            this.showPictureBox.Name = "showPictureBox";
            this.showPictureBox.Size = new System.Drawing.Size(45, 45);
            this.showPictureBox.TabIndex = 1;
            this.showPictureBox.TabStop = false;
            // 
            // getPictureBox
            // 
            this.getPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.getPictureBox.Image = global::ColorPicker.Resource.Cursor40;
            this.getPictureBox.Location = new System.Drawing.Point(38, 20);
            this.getPictureBox.Name = "getPictureBox";
            this.getPictureBox.Size = new System.Drawing.Size(45, 45);
            this.getPictureBox.TabIndex = 0;
            this.getPictureBox.TabStop = false;
            this.getPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.getPictureBox_MouseDown);
            this.getPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.getPictureBox_MouseUp);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hisPictureBox5);
            this.groupBox1.Controls.Add(this.hisPictureBox4);
            this.groupBox1.Controls.Add(this.hisPictureBox3);
            this.groupBox1.Controls.Add(this.hisPictureBox2);
            this.groupBox1.Controls.Add(this.hisPictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(291, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(64, 246);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "历史";
            // 
            // hisPictureBox5
            // 
            this.hisPictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hisPictureBox5.Location = new System.Drawing.Point(17, 201);
            this.hisPictureBox5.Name = "hisPictureBox5";
            this.hisPictureBox5.Size = new System.Drawing.Size(30, 30);
            this.hisPictureBox5.TabIndex = 4;
            this.hisPictureBox5.TabStop = false;
            // 
            // hisPictureBox4
            // 
            this.hisPictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hisPictureBox4.Location = new System.Drawing.Point(17, 156);
            this.hisPictureBox4.Name = "hisPictureBox4";
            this.hisPictureBox4.Size = new System.Drawing.Size(30, 30);
            this.hisPictureBox4.TabIndex = 3;
            this.hisPictureBox4.TabStop = false;
            // 
            // hisPictureBox3
            // 
            this.hisPictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hisPictureBox3.Location = new System.Drawing.Point(17, 111);
            this.hisPictureBox3.Name = "hisPictureBox3";
            this.hisPictureBox3.Size = new System.Drawing.Size(30, 30);
            this.hisPictureBox3.TabIndex = 2;
            this.hisPictureBox3.TabStop = false;
            // 
            // hisPictureBox2
            // 
            this.hisPictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hisPictureBox2.Location = new System.Drawing.Point(17, 66);
            this.hisPictureBox2.Name = "hisPictureBox2";
            this.hisPictureBox2.Size = new System.Drawing.Size(30, 30);
            this.hisPictureBox2.TabIndex = 1;
            this.hisPictureBox2.TabStop = false;
            // 
            // hisPictureBox1
            // 
            this.hisPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hisPictureBox1.Location = new System.Drawing.Point(17, 21);
            this.hisPictureBox1.Name = "hisPictureBox1";
            this.hisPictureBox1.Size = new System.Drawing.Size(30, 30);
            this.hisPictureBox1.TabIndex = 0;
            this.hisPictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 270);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.getColorGroupBox);
            this.Controls.Add(this.colorGroupBox);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Picker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.colorGroupBox.ResumeLayout(false);
            this.colorGroupBox.PerformLayout();
            this.getColorGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hisPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hisPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hisPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hisPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hisPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.GroupBox getColorGroupBox;
        private System.Windows.Forms.PictureBox getPictureBox;
        private System.Windows.Forms.PictureBox showPictureBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox rTextBox;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label gLabel;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.TextBox hexTextBox;
        private System.Windows.Forms.Label hexLabel;
        private System.Windows.Forms.TextBox gTextBox;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.TextBox kTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox cTextBox;
        private System.Windows.Forms.Label kLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.TextBox mTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox hisPictureBox5;
        private System.Windows.Forms.PictureBox hisPictureBox4;
        private System.Windows.Forms.PictureBox hisPictureBox3;
        private System.Windows.Forms.PictureBox hisPictureBox2;
        private System.Windows.Forms.PictureBox hisPictureBox1;
        private System.Windows.Forms.TextBox iTextBox;
        private System.Windows.Forms.TextBox sTextBox;
        private System.Windows.Forms.TextBox hTextBox;
        private System.Windows.Forms.Label iLabel;
        private System.Windows.Forms.Label sLabel;
        private System.Windows.Forms.Label hLabel;
        private System.Windows.Forms.TextBox pantoneTextBox;
        private System.Windows.Forms.Label label1;
    }
}

