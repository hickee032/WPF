namespace emp_Manager.UI {
    partial class UCView {
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.listEmpView = new System.Windows.Forms.ListView();
            this.lvID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvSp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvHdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listEmpView
            // 
            this.listEmpView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvID,
            this.lvEno,
            this.lvEname,
            this.lvSp,
            this.lvJob,
            this.lvHdate,
            this.lvDno});
            this.listEmpView.HideSelection = false;
            this.listEmpView.Location = new System.Drawing.Point(0, 192);
            this.listEmpView.Name = "listEmpView";
            this.listEmpView.Size = new System.Drawing.Size(532, 353);
            this.listEmpView.TabIndex = 1;
            this.listEmpView.UseCompatibleStateImageBehavior = false;
            this.listEmpView.View = System.Windows.Forms.View.Details;
            // 
            // lvID
            // 
            this.lvID.Text = "아이디";
            this.lvID.Width = 63;
            // 
            // lvEno
            // 
            this.lvEno.Text = "사원번호";
            this.lvEno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvEno.Width = 70;
            // 
            // lvEname
            // 
            this.lvEname.Text = "이름";
            this.lvEname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvEname.Width = 69;
            // 
            // lvSp
            // 
            this.lvSp.Text = "상사";
            this.lvSp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvSp.Width = 64;
            // 
            // lvJob
            // 
            this.lvJob.Text = "담당업무";
            this.lvJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvJob.Width = 82;
            // 
            // lvHdate
            // 
            this.lvHdate.Text = "입사일";
            this.lvHdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvHdate.Width = 109;
            // 
            // lvDno
            // 
            this.lvDno.Text = "부서";
            this.lvDno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvDno.Width = 95;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(54, 26);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.UseSelectable = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroComboBox1);
            this.panel1.Controls.Add(this.listEmpView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 545);
            this.panel1.TabIndex = 3;
            // 
            // UCView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCView";
            this.Size = new System.Drawing.Size(535, 545);
            this.Load += new System.EventHandler(this.UCView_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listEmpView;
        private System.Windows.Forms.ColumnHeader lvID;
        private System.Windows.Forms.ColumnHeader lvEno;
        private System.Windows.Forms.ColumnHeader lvEname;
        private System.Windows.Forms.ColumnHeader lvJob;
        private System.Windows.Forms.ColumnHeader lvSp;
        private System.Windows.Forms.ColumnHeader lvHdate;
        private System.Windows.Forms.ColumnHeader lvDno;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.Panel panel1;
    }
}
