﻿using DirectShowLib;
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
using System.Windows.Media;

namespace Project_Media {
    public partial class Form1 : Form {
        
        string filePath = "D:\\YesoRYes.wmv";

        IGraphBuilder pGrahpBuilder = null;
        IMediaControl pMediaControl = null;

        IMediaEvent pMediaEvent = null;
        EventCode eventCode;

        IVideoWindow pVideoWindow = null;

        int playFlag = 0;

        public Form1() {
            InitializeComponent();
        }


        private void playPauseButton_Click(object sender, EventArgs e) {

            if (playFlag == 1) {

                pMediaControl.Pause();

            }
            else {
                Test();
            }
        }

        private void stopButton_Click(object sender, EventArgs e) {

            Console.WriteLine(pMediaControl.Run());

            Marshal.ReleaseComObject(pGrahpBuilder);
            pGrahpBuilder = null;
            Marshal.ReleaseComObject(pMediaControl);
            pMediaControl = null;
            Marshal.ReleaseComObject(pMediaEvent);
            pMediaEvent = null;
            Marshal.ReleaseComObject(pVideoWindow);
            pVideoWindow = null;
        }

        private void Test() {
            this.Text = filePath;
            pGrahpBuilder = (IGraphBuilder)new FilterGraph();

            pMediaControl = (IMediaControl)pGrahpBuilder;

            pMediaEvent = (IMediaEvent)pGrahpBuilder;

            pVideoWindow = (IVideoWindow)pGrahpBuilder;

            pMediaControl.RenderFile(filePath);

            //재생
            pVideoWindow.put_Owner(mediaPanel.Handle);
            pVideoWindow.put_WindowStyle(WindowStyle.Child | WindowStyle.ClipSiblings);
            Rectangle rect = mediaPanel.ClientRectangle;
            pVideoWindow.SetWindowPosition(0, 0, rect.Right, rect.Bottom);
            pMediaControl.Run();
            Console.WriteLine(pMediaControl.Run());



        }




    }
}
