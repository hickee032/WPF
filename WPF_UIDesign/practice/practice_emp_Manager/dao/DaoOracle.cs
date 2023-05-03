using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using emp_Manager.model;

namespace emp_Manager.dao {
    internal class DaoOracle {

        string ORA_ADDR =
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
            "(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)" +
            "(SERVICE_NAME=XE)));" +
            "User Id=projtest;Password=1234;";

        OracleConnection conn;
        OracleCommand cmd;

        public DaoOracle() {
            conn = new OracleConnection(ORA_ADDR);
            cmd = new OracleCommand();
            connectDB();
        }

        //소멸자
        ~DaoOracle() {
            disconnectDB();
        }

        static DaoOracle inst;

        public static DaoOracle getInst() {
            if (inst == null) {
                inst = new DaoOracle();
            }
            return inst;
        }



        public void connectDB() {
            // try ~ catch : 객체지향 프로그래밍에서 예외처리
            try {
                conn.Open(); // db 접속
                Console.WriteLine("오라클 접속 성공!");
            }
            catch (OracleException e) {
                Console.WriteLine("접속에러: " + e.Message);
            }
        }

        public void disconnectDB() {
            try {
                if (conn != null) {
                    conn.Close();
                    Console.WriteLine("오라클 해제 성공!");
                }
            }
            catch (OracleException e) {
                Console.WriteLine("종료 에러:" + e.Message);
            }
        }




        public List<Employee> ShowEmp() {

            string query = "select * from employee";          
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            List<Employee> empList = new List<Employee>();

            if (dr.HasRows) {
                while (dr.Read()) {

                    //Console.WriteLine($"사번 : {dr["eno"]}");

                    empList.Add(new Employee(
                        dr["id"].ToString(),
                        dr["passwd"].ToString(),
                        dr["eno"].ToString(),
                        dr["ename"].ToString(),
                        dr["job"].ToString(),
                        dr["manager"].ToString(),
                        dr["hiredate"].ToString(),
                        dr["salary"].ToString(),
                        dr["commission"].ToString(),
                        dr["dno"].ToString()
                        ));
                }
            }
            else {

                Console.WriteLine("데이터가 존재하지 않습니다");

            }
            return empList;
        }

        public List<Notice> ShowNotice() {

            Console.WriteLine("2222");

            string query = "select * from notice_t";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            List<Notice> list = new List<Notice>();

            if (dr.HasRows) {
                while (dr.Read()) {

                    list.Add(new Notice(
                        dr["notice"].ToString()
                        ));
                }
            }
            else {
                Console.WriteLine("데이터가 존재하지 않습니다");
            }
            return list;
        }





    }
}
