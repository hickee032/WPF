using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using emp_Manager.adapter;
using emp_Manager.dao;
using emp_Manager.model;

namespace emp_Manager.UI {
    public partial class UCHome : UserControl {

        BaseAdapter ba;

        int count = 0;

        public UCHome() {
            InitializeComponent();
        }

        public UCHome(BaseAdapter ba) {
            Console.WriteLine("home");
            InitializeComponent();
            this.ba = ba;
            attachNoticeview();
            

        }

        private void UCHome_Load(object sender, EventArgs e) {       
            Console.WriteLine("load");
            attachNoticeview();
            posterChangerTimer.Interval = 5000;
            posterChangerTimer.Start();

        }

        private void attachNoticeview() {

            Console.WriteLine("1111");

            List<Notice> notList = ba.Ora.ShowNotice();
            
            int n = 1;

            foreach (var i in notList) {

                listNotView.Items.Add(new ListViewItem(new string[] {
                    n.ToString(),
                    i.Content.ToString(),
                    }));
                Console.WriteLine(i.Content.ToString());
                n++;
            }
        }

        private void posterChanger_Tick(object sender, EventArgs e) {

            if (count == 0) {
                pbPoster.BackgroundImage = Properties.Resources.poster1;
                count++;
            }
            else if (count == 1) {
                pbPoster.BackgroundImage = Properties.Resources.poster2;
                count++;
            }
            else {
                pbPoster.BackgroundImage = Properties.Resources.poster3;
                count = 0;
            }

        }


    }
}
