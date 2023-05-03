using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMain {
    public partial class FormStart : MetroFramework.Forms.MetroForm {

        ToolTip ttip = new ToolTip();

        public FormStart() {
            InitializeComponent();


        }

        private void loginTeacher_Click(object sender, EventArgs e) {
            FormLogin LoginForm = new FormLogin();
            LoginForm.ShowDialog();
        }

        private void loginChild_Click(object sender, EventArgs e) {
            FormLogin LoginForm = new FormLogin(1);
            LoginForm.ShowDialog();
        }



        private void loginTeacher_MouseHover(object sender, EventArgs e) {
            this.ttip.SetToolTip(this.loginTeacher, "선생님 메뉴입니다");
        }

        private void loginChild_MouseHover(object sender, EventArgs e) {

            this.ttip.SetToolTip(this.loginChild, "아이들 메뉴입니다");
        }
    }
}
