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
    public partial class UserSignC : UserControl {
        public UserSignC() {
            InitializeComponent();
            panelSchool.Visible = false;
            panelKgd.Visible = false;

        }

        private void cbxChd_CheckedChanged(object sender, EventArgs e) {
            
            if (cbxChd.Checked) {
                cbxElm.Checked = false;

                panelKgd.Visible = true;
                panelKgd.Location = new Point(19, 380);
            }
            else {
                panelKgd.Visible = false;
            }


        }

        private void cbxElm_CheckedChanged(object sender, EventArgs e) {

            panelKgd.Visible = false;

            if (cbxElm.Checked) {
                cbxChd.Checked = false;

                panelSchool.Visible = true;
                panelSchool.Location = new Point(19, 380);
            }
            else {
                panelSchool.Visible = false; 
            }




        }
    }
}
