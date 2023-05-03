using emp_Manager.adapter;
using emp_Manager.ui;
using emp_Manager.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emp_Manager {
    public partial class FormMain : MetroFramework.Forms.MetroForm {


        BaseAdapter ba = new BaseAdapter();

        const string UC_HOMEUSER = "UCHome";
        const string UC_SIGNUSER = "UCSign";
        const string UC_GRADEUSER = "UCGrade";
        const string UC_VIEWUSER = "UCView";
        const string UC_MAILUSER = "UCMail";
        const string UC_SETTINGUSER = "UCSetting";
        const string UC_ADMINUSER = "UCAdmin";
        const string UC_HELPUSER = "UCHelp";


        public FormMain() {

            InitializeComponent();

            controllView(new UCHome(ba), UC_HOMEUSER);
        }

        //패널에 유저 컨트롤 세팅
        private void controllView(UserControl uc, string viewName) {

            centerLayout.Controls.Clear();

            if (!centerLayout.Controls.ContainsKey(viewName)) {
                uc.Dock = DockStyle.Fill;
                centerLayout.Controls.Add(uc);
            }
        }

        #region Main 버튼 클릭 이벤트

        private void btnHome_Click(object sender, EventArgs e) {
            //home
            this.ResetText();
            this.Text = "사원 관리 프로그램";
            controllView(new UCHome(ba), UC_HOMEUSER);
        }

        private void btnAddUser_Click(object sender, EventArgs e) {
            //adduser
            this.ResetText();
            this.Text = "사원 추가";
            controllView(new UCSign(), UC_SIGNUSER);
           
        }

        private void btnGrade_Click(object sender, EventArgs e) {
            //grade
            this.ResetText();
            this.Text = "급여 등급 보기";
            controllView(new UCGrade(), UC_GRADEUSER);
        }

        private void btnShowEmp_Click(object sender, EventArgs e) {
            //show
            this.ResetText();
            this.Text = "사원 보기";
            controllView(new UCView(ba), UC_VIEWUSER);
        }

        private void btnSetting_Click(object sender, EventArgs e) {
            //setting
            this.ResetText();
            this.Text = "환경 설정";
            controllView(new UCSetting(), UC_SETTINGUSER);
        }

        private void btnMail_Click(object sender, EventArgs e) {
            //mail
            this.ResetText();
            this.Text = "쪽지 보내기";
            controllView(new UCMail(), UC_MAILUSER);
        }

        private void btnAdmin_Click(object sender, EventArgs e) {
            //admin
            this.ResetText();
            this.Text = "관리자 모드";
            controllView(new UCAdmin(), UC_ADMINUSER);
        }

        private void btnHelp_Click(object sender, EventArgs e) {
            //help
            this.ResetText();
            this.Text = "도움말";
            controllView(new UCHelp(), UC_HELPUSER);
        }


        #endregion

        private void btnLogin_Click(object sender, EventArgs e) {
            FormLogin formlogin = new FormLogin();
            formlogin.ShowDialog();
        }
    }
}
