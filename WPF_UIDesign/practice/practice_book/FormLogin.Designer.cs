namespace BookMain {
    partial class FormLogin {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signupBtn = new MetroFramework.Controls.MetroButton();
            this.loginBtn = new MetroFramework.Controls.MetroButton();
            this.cancelBtn = new MetroFramework.Controls.MetroButton();
            this.passTexB = new System.Windows.Forms.TextBox();
            this.idTexB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.signupBtn);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.passTexB);
            this.panel1.Controls.Add(this.idTexB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 204);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BookMain.Properties.Resources.PASS;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(155, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 39);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BookMain.Properties.Resources.ID;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(155, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 39);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // signupBtn
            // 
            this.signupBtn.BackgroundImage = global::BookMain.Properties.Resources.BTN_SignUp;
            this.signupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.signupBtn.Location = new System.Drawing.Point(200, 148);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(106, 42);
            this.signupBtn.TabIndex = 9;
            this.signupBtn.UseSelectable = true;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackgroundImage = global::BookMain.Properties.Resources.BTN_OK;
            this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginBtn.Location = new System.Drawing.Point(119, 148);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 42);
            this.loginBtn.TabIndex = 8;
            this.loginBtn.UseSelectable = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackgroundImage = global::BookMain.Properties.Resources.BTN_NO;
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelBtn.Location = new System.Drawing.Point(312, 148);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 42);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.UseSelectable = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // passTexB
            // 
            this.passTexB.Location = new System.Drawing.Point(200, 89);
            this.passTexB.Name = "passTexB";
            this.passTexB.Size = new System.Drawing.Size(165, 21);
            this.passTexB.TabIndex = 2;
            // 
            // idTexB
            // 
            this.idTexB.Location = new System.Drawing.Point(200, 40);
            this.idTexB.Name = "idTexB";
            this.idTexB.Size = new System.Drawing.Size(165, 21);
            this.idTexB.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 284);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "LOGIN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passTexB;
        private System.Windows.Forms.TextBox idTexB;
        private MetroFramework.Controls.MetroButton cancelBtn;
        private MetroFramework.Controls.MetroButton signupBtn;
        private MetroFramework.Controls.MetroButton loginBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

