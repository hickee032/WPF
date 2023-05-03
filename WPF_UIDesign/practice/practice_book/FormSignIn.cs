using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookMain {
    public partial class FormSignIn : MetroFramework.Forms.MetroForm {

        //로그인 패널 A 성인 C 어린이

        const string UCSIGN_AD = "UserSignA";
        const string UCSIGN_CD = "UserSignC";

        public FormSignIn() {
            InitializeComponent();
            controlView(new UserSignA(), UCSIGN_AD);

        }

        public FormSignIn(int JD) {
            InitializeComponent();
            controlView(new UserSignC(), UCSIGN_CD);

        }
        /*
       #region 텍스트 박스 컨트롤

        //id 입력 텍스트 박스
        private void idSignTbx_Leave(object sender, EventArgs e) {

            idCheckLa.Visible = true;

            int length = idSignTbx.Text.Length;

            if (length < 5) {
                idCheckLa.Text = "5글자 이상이어야 합니다.";
                this.ActiveControl = idSignTbx;

            }
            else if (length >= 10) {
                idCheckLa.Text = "10글자 이내여야 합니다";
                this.ActiveControl = idSignTbx;
            }
            else {
                idCheckLa.Text = "중복확인이 필요합니다.";
            }
        }


        #endregion
        */

        #region 패널 뷰 컨트롤

        void controlView(UserControl uc, string viewName) {

            //centerLayout에 정보가 없으면 도킹함
            if (!panelSignIn.Controls.ContainsKey(viewName)) {
                uc.Dock = DockStyle.Fill;
                panelSignIn.Controls.Add(uc);
            }
            //centerLayout에 정보가 있으면 맨위로
            panelSignIn.Controls[viewName].BringToFront();
        }
        #endregion


    }
}
