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
    public partial class UCView : UserControl {

        BaseAdapter ba;

        string id, passwd, eno, ename, job, manger, hiredate, salary, commission, dno;

        public UCView() {
            InitializeComponent();
        }

        public UCView(BaseAdapter ba) {
            InitializeComponent();
            this.ba = ba;
            attachListView();

        }

        private void UCView_Load(object sender, EventArgs e) {
            attachListView();
        }

        //리스트뷰
        private void attachListView() {

            List<Employee> empList = ba.Ora.ShowEmp();

            int n = 1;

            foreach (var i in empList) {

                listEmpView.Items.Add(new ListViewItem(new string[] {
                    i.Id.ToString(),
                    i.Eno.ToString(),
                    i.Ename.ToString(),
                    i.Manger.ToString(),
                    i.Job.ToString(),
                    i.Hiredate.ToString().Substring(0,10),
                    i.Dno.ToString()
                    }));
                Console.WriteLine(i.Hiredate.ToString());
                Console.WriteLine(i.Hiredate.ToString().Length);
                n++;
            }

        }
    }
}
