namespace monkey_demo_clr
{
    partial class VideoEngineTest
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
			this.videoPanel = new System.Windows.Forms.Panel();
			this.run_btn = new System.Windows.Forms.Button();
			this.videoDeviceComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.VideoCoderComboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.CapResComboBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.CapFrTrackBar = new System.Windows.Forms.TrackBar();
			this.label5 = new System.Windows.Forms.Label();
			this.codedBrTrackBar = new System.Windows.Forms.TrackBar();
			this.label6 = new System.Windows.Forms.Label();
			this.CodedResComboBox = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.CodedFrTrackBar = new System.Windows.Forms.TrackBar();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rtEncBrLabel = new System.Windows.Forms.Label();
			this.rtEncFrLabel = new System.Windows.Forms.Label();
			this.rtCapFrLabel = new System.Windows.Forms.Label();
			this.rtCapResLabel = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.init_btn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.CapFrTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.codedBrTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CodedFrTrackBar)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// videoPanel
			// 
			this.videoPanel.BackColor = System.Drawing.SystemColors.Desktop;
			this.videoPanel.Location = new System.Drawing.Point(12, 12);
			this.videoPanel.Name = "videoPanel";
			this.videoPanel.Size = new System.Drawing.Size(920, 744);
			this.videoPanel.TabIndex = 0;
			// 
			// run_btn
			// 
			this.run_btn.Location = new System.Drawing.Point(1111, 517);
			this.run_btn.Name = "run_btn";
			this.run_btn.Size = new System.Drawing.Size(150, 38);
			this.run_btn.TabIndex = 1;
			this.run_btn.Text = "开始";
			this.run_btn.UseVisualStyleBackColor = true;
			this.run_btn.Click += new System.EventHandler(this.Run_btn_Click);
			// 
			// videoDeviceComboBox
			// 
			this.videoDeviceComboBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.videoDeviceComboBox.FormattingEnabled = true;
			this.videoDeviceComboBox.Location = new System.Drawing.Point(951, 33);
			this.videoDeviceComboBox.Name = "videoDeviceComboBox";
			this.videoDeviceComboBox.Size = new System.Drawing.Size(310, 28);
			this.videoDeviceComboBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(948, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "视频设备";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(948, 220);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "视频编码器";
			// 
			// VideoCoderComboBox
			// 
			this.VideoCoderComboBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.VideoCoderComboBox.FormattingEnabled = true;
			this.VideoCoderComboBox.Location = new System.Drawing.Point(951, 241);
			this.VideoCoderComboBox.Name = "VideoCoderComboBox";
			this.VideoCoderComboBox.Size = new System.Drawing.Size(310, 28);
			this.VideoCoderComboBox.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(951, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "采集分辨率";
			// 
			// CapResComboBox
			// 
			this.CapResComboBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.CapResComboBox.FormattingEnabled = true;
			this.CapResComboBox.Location = new System.Drawing.Point(951, 98);
			this.CapResComboBox.Name = "CapResComboBox";
			this.CapResComboBox.Size = new System.Drawing.Size(310, 28);
			this.CapResComboBox.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(948, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "采集帧率";
			// 
			// CapFrTrackBar
			// 
			this.CapFrTrackBar.Location = new System.Drawing.Point(951, 164);
			this.CapFrTrackBar.Name = "CapFrTrackBar";
			this.CapFrTrackBar.Size = new System.Drawing.Size(310, 56);
			this.CapFrTrackBar.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(948, 438);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 15);
			this.label5.TabIndex = 10;
			this.label5.Text = "编码后码率";
			// 
			// codedBrTrackBar
			// 
			this.codedBrTrackBar.Location = new System.Drawing.Point(951, 459);
			this.codedBrTrackBar.Name = "codedBrTrackBar";
			this.codedBrTrackBar.Size = new System.Drawing.Size(310, 56);
			this.codedBrTrackBar.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(948, 288);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(97, 15);
			this.label6.TabIndex = 12;
			this.label6.Text = "编码后分辨率";
			// 
			// CodedResComboBox
			// 
			this.CodedResComboBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.CodedResComboBox.FormattingEnabled = true;
			this.CodedResComboBox.Location = new System.Drawing.Point(951, 310);
			this.CodedResComboBox.Name = "CodedResComboBox";
			this.CodedResComboBox.Size = new System.Drawing.Size(310, 28);
			this.CodedResComboBox.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(948, 361);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 15);
			this.label7.TabIndex = 14;
			this.label7.Text = "编码后帧率";
			// 
			// CodedFrTrackBar
			// 
			this.CodedFrTrackBar.Location = new System.Drawing.Point(951, 381);
			this.CodedFrTrackBar.Name = "CodedFrTrackBar";
			this.CodedFrTrackBar.Size = new System.Drawing.Size(310, 56);
			this.CodedFrTrackBar.TabIndex = 15;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rtEncBrLabel);
			this.groupBox1.Controls.Add(this.rtEncFrLabel);
			this.groupBox1.Controls.Add(this.rtCapFrLabel);
			this.groupBox1.Controls.Add(this.rtCapResLabel);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Location = new System.Drawing.Point(951, 578);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(310, 178);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "统计信息";
			// 
			// rtEncBrLabel
			// 
			this.rtEncBrLabel.AutoSize = true;
			this.rtEncBrLabel.BackColor = System.Drawing.SystemColors.InfoText;
			this.rtEncBrLabel.Location = new System.Drawing.Point(140, 103);
			this.rtEncBrLabel.Name = "rtEncBrLabel";
			this.rtEncBrLabel.Size = new System.Drawing.Size(63, 15);
			this.rtEncBrLabel.TabIndex = 7;
			this.rtEncBrLabel.Text = "label12";
			// 
			// rtEncFrLabel
			// 
			this.rtEncFrLabel.AutoSize = true;
			this.rtEncFrLabel.BackColor = System.Drawing.SystemColors.InfoText;
			this.rtEncFrLabel.Location = new System.Drawing.Point(140, 78);
			this.rtEncFrLabel.Name = "rtEncFrLabel";
			this.rtEncFrLabel.Size = new System.Drawing.Size(63, 15);
			this.rtEncFrLabel.TabIndex = 6;
			this.rtEncFrLabel.Text = "label12";
			// 
			// rtCapFrLabel
			// 
			this.rtCapFrLabel.AutoSize = true;
			this.rtCapFrLabel.BackColor = System.Drawing.SystemColors.InfoText;
			this.rtCapFrLabel.Location = new System.Drawing.Point(140, 52);
			this.rtCapFrLabel.Name = "rtCapFrLabel";
			this.rtCapFrLabel.Size = new System.Drawing.Size(63, 15);
			this.rtCapFrLabel.TabIndex = 5;
			this.rtCapFrLabel.Text = "label12";
			// 
			// rtCapResLabel
			// 
			this.rtCapResLabel.AutoSize = true;
			this.rtCapResLabel.BackColor = System.Drawing.SystemColors.InfoText;
			this.rtCapResLabel.Location = new System.Drawing.Point(140, 24);
			this.rtCapResLabel.Name = "rtCapResLabel";
			this.rtCapResLabel.Size = new System.Drawing.Size(63, 15);
			this.rtCapResLabel.TabIndex = 4;
			this.rtCapResLabel.Text = "label12";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(22, 103);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(112, 15);
			this.label11.TabIndex = 3;
			this.label11.Text = "实时编码码率：";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(22, 78);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(112, 15);
			this.label10.TabIndex = 2;
			this.label10.Text = "实时编码帧率：";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(22, 52);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(112, 15);
			this.label9.TabIndex = 1;
			this.label9.Text = "实时采集帧率：";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(7, 25);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(127, 15);
			this.label8.TabIndex = 0;
			this.label8.Text = "实时采集分辨率：";
			// 
			// init_btn
			// 
			this.init_btn.Location = new System.Drawing.Point(951, 517);
			this.init_btn.Name = "init_btn";
			this.init_btn.Size = new System.Drawing.Size(150, 38);
			this.init_btn.TabIndex = 17;
			this.init_btn.Text = "初始化";
			this.init_btn.UseVisualStyleBackColor = true;
			this.init_btn.Click += new System.EventHandler(this.Init_btn_Click);
			// 
			// VideoEngineTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1273, 768);
			this.Controls.Add(this.init_btn);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.CodedFrTrackBar);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.CodedResComboBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.codedBrTrackBar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.CapFrTrackBar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.CapResComboBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.VideoCoderComboBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.videoDeviceComboBox);
			this.Controls.Add(this.run_btn);
			this.Controls.Add(this.videoPanel);
			this.Name = "VideoEngineTest";
			this.Text = "VideoEngineTest";
			this.Load += new System.EventHandler(this.VideoEngineTest_Load);
			((System.ComponentModel.ISupportInitialize)(this.CapFrTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.codedBrTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CodedFrTrackBar)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel videoPanel;
        private System.Windows.Forms.Button run_btn;
        private System.Windows.Forms.ComboBox videoDeviceComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox VideoCoderComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CapResComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar CapFrTrackBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar codedBrTrackBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CodedResComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar CodedFrTrackBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label rtEncBrLabel;
        private System.Windows.Forms.Label rtEncFrLabel;
        private System.Windows.Forms.Label rtCapFrLabel;
        private System.Windows.Forms.Label rtCapResLabel;
        private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button init_btn;
	}
}

