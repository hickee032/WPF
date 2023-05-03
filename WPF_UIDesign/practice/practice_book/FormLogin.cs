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
    public partial class FormLogin : MetroFramework.Forms.MetroForm {

        int n = 0;
        
        //어른이
        public FormLogin() {
            InitializeComponent();
        }

        //어린이
        public FormLogin(int JD) {
            InitializeComponent();
            loginBtn.BackgroundImage = Properties.Resources.BTN_OK1;
            signupBtn.BackgroundImage = Properties.Resources.BTN_SignUp1;
            cancelBtn.BackgroundImage = Properties.Resources.BTN_NO1;
            n= JD;
        }

        private void loginBtn_Click(object sender, EventArgs e) {

        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void signupBtn_Click(object sender, EventArgs e) {

            if (n!=0) {
                FormSignIn sif = new FormSignIn(1);
                sif.ShowDialog();
            }
            else {
                FormSignIn sif = new FormSignIn();
                sif.ShowDialog();
            }

        }
    }
}
