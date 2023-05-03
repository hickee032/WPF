using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp_Manager.model {
    internal class Employee {

        string id, passwd;
        string eno, ename, job, manger, hiredate, salary, commission, dno;

        public Employee(string id, string passwd, string eno, string ename, string job, string manager, string hiredate, string salary, string commission, string dno) {
            this.id = id;
            this.passwd = passwd;
            this.eno = eno;
            this.ename = ename;
            this.job = job;
            this.manger = manager;
            this.hiredate = hiredate;
            this.salary = salary;
            this.commission = commission;
            this.dno = dno;
        }


        public string Id { get => id; set => id = value; }
        public string Passwd { get => passwd; set => passwd = value; }
        public string Eno { get => eno; set => eno = value; }
        public string Ename { get => ename; set => ename = value; }
        public string Job { get => job; set => job = value; }
        public string Manger { get => manger; set => manger = value; }
        public string Hiredate { get => hiredate; set => hiredate = value; }
        public string Salary { get => salary; set => salary = value; }
        public string Commission { get => commission; set => commission = value; }
        public string Dno { get => dno; set => dno = value; }

    }
}
