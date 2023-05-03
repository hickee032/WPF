using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform1219.adapter;
using winform1219.dao;
using winform1219.model;

namespace winform1219.ui
{
    partial class ViewUser : UserControl
    {
        BaseAdapter ba;
        public ViewUser()
        {
            InitializeComponent();
        }

        public ViewUser(BaseAdapter ba)
        {
            InitializeComponent();
            this.ba = ba;
        }

        private void initTListView()
        {
            for (int i=0; i<100; i++)
            {
                memLView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+1).ToString(), "홍길동", "홍두께",
                        "1945년8월15일", "남자", 
                        "010-1234-4567", "hong@naver.com"
                    }));
            }            
        }

        private void initListView()
        {
            // DB에서 가져온 데이터 출력
            //DaoOra ora = DaoOra.getInst();
            DaoOra ora = ba.Ora;
            List<Member> list = ora.dataShow();
            for(int i=0; i<list.Count; i++)
            {
                memLView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+1)+"",
                        list[i].Name,
                        list[i].NickName,
                        list[i].Birth, 
                        list[i].Gender,
                        list[i].Tel,
                        list[i].Email
                    }));
            }
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
            //initTListView();
            initListView();
        }
    }
}
