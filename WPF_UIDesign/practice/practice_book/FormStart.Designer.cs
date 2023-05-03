namespace BookMain {
    partial class FormStart {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.picture_child = new System.Windows.Forms.PictureBox();
            this.loginChild = new MetroFramework.Controls.MetroButton();
            this.loginTeacher = new MetroFramework.Controls.MetroButton();
            this.picture_teacher = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_child)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_teacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picture_child);
            this.panel1.Controls.Add(this.loginChild);
            this.panel1.Controls.Add(this.loginTeacher);
            this.panel1.Controls.Add(this.picture_teacher);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 298);
            this.panel1.TabIndex = 5;
            // 
            // picture_child
            // 
            this.picture_child.BackgroundImage = global::BookMain.Properties.Resources.student;
            this.picture_child.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picture_child.Location = new System.Drawing.Point(67, 44);
            this.picture_child.Name = "picture_child";
            this.picture_child.Size = new System.Drawing.Size(120, 120);
            this.picture_child.TabIndex = 4;
            this.picture_child.TabStop = false;
            // 
            // loginChild
            // 
            this.loginChild.BackColor = System.Drawing.Color.Transparent;
            this.loginChild.BackgroundImage = global::BookMain.Properties.Resources.loginYellow;
            this.loginChild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginChild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginChild.Location = new System.Drawing.Point(67, 188);
            this.loginChild.Name = "loginChild";
            this.loginChild.Size = new System.Drawing.Size(124, 39);
            this.loginChild.TabIndex = 0;
            this.loginChild.UseSelectable = true;
            this.loginChild.Click += new System.EventHandler(this.loginChild_Click);
            this.loginChild.MouseHover += new System.EventHandler(this.loginChild_MouseHover);
            // 
            // loginTeacher
            // 
            this.loginTeacher.BackColor = System.Drawing.Color.Transparent;
            this.loginTeacher.BackgroundImage = global::BookMain.Properties.Resources.loginBlue;
            this.loginTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginTeacher.Location = new System.Drawing.Point(225, 188);
            this.loginTeacher.Name = "loginTeacher";
            this.loginTeacher.Size = new System.Drawing.Size(124, 39);
            this.loginTeacher.TabIndex = 1;
            this.loginTeacher.UseSelectable = true;
            this.loginTeacher.Click += new System.EventHandler(this.loginTeacher_Click);
            this.loginTeacher.MouseHover += new System.EventHandler(this.loginTeacher_MouseHover);
            // 
            // picture_teacher
            // 
            this.picture_teacher.BackgroundImage = global::BookMain.Properties.Resources.teacher;
            this.picture_teacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picture_teacher.Location = new System.Drawing.Point(229, 44);
            this.picture_teacher.Name = "picture_teacher";
            this.picture_teacher.Size = new System.Drawing.Size(120, 120);
            this.picture_teacher.TabIndex = 3;
            this.picture_teacher.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::BookMain.Properties.Resources.Title_Login;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(23, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 40);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 378);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Name = "StartForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_child)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_teacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton loginChild;
        private MetroFramework.Controls.MetroButton loginTeacher;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox picture_teacher;
        private System.Windows.Forms.PictureBox picture_child;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}