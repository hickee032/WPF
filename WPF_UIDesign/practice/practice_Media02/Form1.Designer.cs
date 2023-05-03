namespace Project_Media {
    partial class Form1 {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.controlBox = new System.Windows.Forms.Panel();
            this.passButton = new System.Windows.Forms.Button();
            this.backjButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.playPauseButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mediaPanel = new System.Windows.Forms.Panel();
            this.controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlBox
            // 
            this.controlBox.Controls.Add(this.passButton);
            this.controlBox.Controls.Add(this.backjButton);
            this.controlBox.Controls.Add(this.stopButton);
            this.controlBox.Controls.Add(this.playPauseButton);
            this.controlBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlBox.Location = new System.Drawing.Point(0, 395);
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(800, 55);
            this.controlBox.TabIndex = 0;
            // 
            // passButton
            // 
            this.passButton.Location = new System.Drawing.Point(171, 3);
            this.passButton.Name = "passButton";
            this.passButton.Size = new System.Drawing.Size(50, 50);
            this.passButton.TabIndex = 3;
            this.passButton.Text = "앞으로";
            this.passButton.UseVisualStyleBackColor = true;
            // 
            // backjButton
            // 
            this.backjButton.Location = new System.Drawing.Point(115, 3);
            this.backjButton.Name = "backjButton";
            this.backjButton.Size = new System.Drawing.Size(50, 50);
            this.backjButton.TabIndex = 2;
            this.backjButton.Text = "뒤로";
            this.backjButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(59, 3);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(50, 50);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "정지";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // playPauseButton
            // 
            this.playPauseButton.Location = new System.Drawing.Point(3, 3);
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.Size = new System.Drawing.Size(50, 50);
            this.playPauseButton.TabIndex = 0;
            this.playPauseButton.Text = "재생";
            this.playPauseButton.UseVisualStyleBackColor = true;
            this.playPauseButton.Click += new System.EventHandler(this.playPauseButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Project_Media.Properties.Resources.intro;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 395);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mediaPanel
            // 
            this.mediaPanel.Location = new System.Drawing.Point(0, 0);
            this.mediaPanel.Name = "mediaPanel";
            this.mediaPanel.Size = new System.Drawing.Size(800, 395);
            this.mediaPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mediaPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.controlBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MediaPlayer";
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlBox;
        private System.Windows.Forms.Button playPauseButton;
        private System.Windows.Forms.Button passButton;
        private System.Windows.Forms.Button backjButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel mediaPanel;
    }
}

