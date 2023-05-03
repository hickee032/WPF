namespace winform1219.ui
{
    partial class ViewUser
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.memLView = new System.Windows.Forms.ListView();
            this.lvNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvNickname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memGView = new Sunny.UI.UIDataGridView();
            this.uiSmoothLabel1 = new Sunny.UI.UISmoothLabel();
            ((System.ComponentModel.ISupportInitialize)(this.memGView)).BeginInit();
            this.SuspendLayout();
            // 
            // memLView
            // 
            this.memLView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvNum,
            this.lvName,
            this.lvNickname,
            this.lvBirth,
            this.lvGender,
            this.lvTel,
            this.lvEmail});
            this.memLView.FullRowSelect = true;
            this.memLView.HideSelection = false;
            this.memLView.Location = new System.Drawing.Point(33, 115);
            this.memLView.Name = "memLView";
            this.memLView.Size = new System.Drawing.Size(613, 275);
            this.memLView.TabIndex = 0;
            this.memLView.UseCompatibleStateImageBehavior = false;
            this.memLView.View = System.Windows.Forms.View.Details;
            // 
            // lvNum
            // 
            this.lvNum.Text = "번호";
            // 
            // lvName
            // 
            this.lvName.Text = "이름";
            // 
            // lvNickname
            // 
            this.lvNickname.Text = "닉네임";
            // 
            // lvBirth
            // 
            this.lvBirth.Text = "생년월일";
            // 
            // lvGender
            // 
            this.lvGender.Text = "성별";
            // 
            // lvTel
            // 
            this.lvTel.Text = "전화";
            // 
            // lvEmail
            // 
            this.lvEmail.Text = "이메일";
            // 
            // memGView
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.memGView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.memGView.BackgroundColor = System.Drawing.Color.White;
            this.memGView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.memGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.memGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.memGView.DefaultCellStyle = dataGridViewCellStyle8;
            this.memGView.EnableHeadersVisualStyles = false;
            this.memGView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.memGView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.memGView.Location = new System.Drawing.Point(33, 438);
            this.memGView.Name = "memGView";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.memGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.memGView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.memGView.RowTemplate.Height = 23;
            this.memGView.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.memGView.SelectedIndex = -1;
            this.memGView.Size = new System.Drawing.Size(613, 259);
            this.memGView.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.memGView.Style = Sunny.UI.UIStyle.Custom;
            this.memGView.TabIndex = 1;
            this.memGView.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSmoothLabel1
            // 
            this.uiSmoothLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSmoothLabel1.Location = new System.Drawing.Point(196, 22);
            this.uiSmoothLabel1.Name = "uiSmoothLabel1";
            this.uiSmoothLabel1.Size = new System.Drawing.Size(257, 49);
            this.uiSmoothLabel1.TabIndex = 27;
            this.uiSmoothLabel1.Text = "회원정보 보기";
            this.uiSmoothLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ViewUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.uiSmoothLabel1);
            this.Controls.Add(this.memGView);
            this.Controls.Add(this.memLView);
            this.Name = "ViewUser";
            this.Size = new System.Drawing.Size(708, 772);
            this.Load += new System.EventHandler(this.ViewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView memLView;
        private Sunny.UI.UIDataGridView memGView;
        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private System.Windows.Forms.ColumnHeader lvNum;
        private System.Windows.Forms.ColumnHeader lvName;
        private System.Windows.Forms.ColumnHeader lvNickname;
        private System.Windows.Forms.ColumnHeader lvBirth;
        private System.Windows.Forms.ColumnHeader lvGender;
        private System.Windows.Forms.ColumnHeader lvTel;
        private System.Windows.Forms.ColumnHeader lvEmail;
    }
}
