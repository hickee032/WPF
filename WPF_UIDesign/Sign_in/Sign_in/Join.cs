using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform1215 {
    public partial class Join : Form {
        string ORA_ADDR =
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
            "(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)" +
            "(SERVICE_NAME=XE)));" +
            "User Id=test;Password=1234;";
        // 오라클 접속, sql명령어 객체 생성
        OracleConnection conn;
        OracleCommand cmd;
        public Join() {
            InitializeComponent();
            conn = new OracleConnection(ORA_ADDR);
            cmd = new OracleCommand();
            connectDB();
        }

        private void button4_Click(object sender, EventArgs e) {
            string gender = string.Empty;
            if (radioButton1.Checked) { gender = "남자"; }
            else if (radioButton2.Checked) { gender = "여자"; }

            MessageBox.Show($"아이디:{textBox1.Text}\n" +
                $"비밀번호:{textBox2.Text}\n" +
                $"이름:{textBox4.Text}\n" +
                $"별명:{textBox5.Text}\n" +
                $"생년월일:{textBox6.Text}\n" +
                $"성별:{gender}\n" +
                $"전화:{textBox7.Text}");
        }

        private void connectDB() {
            // try ~ catch : 객체지향 프로그래밍에서 예외처리
            try {
                conn.Open(); // db 접속
                Console.WriteLine("오라클 접속 성공!");
            }
            catch (OracleException e) {
                Console.WriteLine("접속에러: " + e.Message);
            }
        }

        private void disconnectDB() {
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

        private void button3_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Join_FormClosing(object sender, FormClosingEventArgs e) {
            disconnectDB();
        }

        private void insertTable(string id, string pass, string name, string nick, string birth, string gender, string tel) {
            Console.WriteLine("테이블 데이터 추가");

            try {

                string sql = string.Format("insert into join_t values(" +
                    "'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", id, pass, name, nick, birth, gender, tel);

                Console.WriteLine(sql);

                cmd.Transaction = conn.BeginTransaction();

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                cmd.Transaction.Commit();
            }
            catch (Exception e) {

                Console.WriteLine("데이터 추가 오류 : " + e.Message);
            }
        }
    }
}
