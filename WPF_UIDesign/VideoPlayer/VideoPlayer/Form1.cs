using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoPlayer {
    public partial class Form1 : Form {

        string videoPath, videoTitle;

        public Form1() {
            InitializeComponent();
            wmpVideo.uiMode = "none";
        }

        private void btnPlay_Click(object sender, EventArgs e) {
            wmpVideo.Ctlcontrols.play();
        }

        private void btnStop_Click(object sender, EventArgs e) {
            wmpVideo.Ctlcontrols.stop();
        }

        private void btnPause_Click(object sender, EventArgs e) {
            wmpVideo.Ctlcontrols.pause();
        }

        private void btnOpenVideo_Click(object sender, EventArgs e) {

            OpenFileDialog openFileDialog= new OpenFileDialog() {Multiselect=false, Filter="MP4 File|*.mp4|All File|*.*" };
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                videoPath= openFileDialog.FileName;
                videoTitle = openFileDialog.SafeFileName;
                wmpVideo.URL = videoPath;
                lblTitle.Text = videoTitle;
            }
        }
    }
}
