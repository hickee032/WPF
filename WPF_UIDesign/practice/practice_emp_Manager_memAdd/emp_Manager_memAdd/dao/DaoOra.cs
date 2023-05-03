using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winform1219.model;

namespace winform1219.dao
{
    internal class DaoOra
    {
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

        static DaoOra inst;

        public static DaoOra getInst()
        {
            if (inst == null)
            {
                inst = new DaoOra();
            }
            return inst;
        }
        public DaoOra()
        {
            conn = new OracleConnection(ORA_ADDR);
            cmd = new OracleCommand();
            connectDB();
        }

        ~DaoOra()
        {
            disconnectDB();
        }

        public void connectDB()
        {
            // try ~ catch : 객체지향 프로그래밍에서 예외처리
            try
            {
                conn.Open(); // db 접속
                Console.WriteLine("오라클 접속 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("접속에러: " + e.Message);
            }
        }

        public void disconnectDB()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                    Console.WriteLine("오라클 해제 성공!");
                }
            }
            catch (OracleException e)
            {
                Console.WriteLine("종료 에러:" + e.Message);
            }
        }

        public void insertData(string id, string passwd, string name, string nick,
            string birth, string gender, string tel)
        {
            try
            {
                string sql = "insert into join_t values " +
                    $"('{id}', '{passwd}', '{name}', '{nick}', " +
                    $"'{birth}', '{gender}', '{tel}', '이메일')";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("데이터 추가 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        public void insertData(Member mem)
        {
            try
            {
                string sql = "insert into join_t values " +
                    $"('{mem.Id}', '{mem.Passwd}', '{mem.Name}', " +
                    $"'{mem.NickName}', '{mem.Birth}', '{mem.Gender}', " +
                    $"'{mem.Tel}', '{mem.Email}')";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("데이터 추가 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        public List<Member> dataShow()
        {
            string query = "select * from join_t";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Member> memList = new List<Member>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine($"ID:{dr["id"]}");
                    Console.WriteLine($"이름:{dr["name"]}");
                    Console.WriteLine($"별명:{dr["nick_name"]}");
                    Console.WriteLine($"생년월일:{dr["birth"]}");
                    Console.WriteLine($"성별:{dr["gender"]}");
                    Console.WriteLine($"전화번호:{dr["tel"]}");
                    Console.WriteLine($"이메일:{dr["email"]}");
                    Console.WriteLine("-------------------");
                    memList.Add(new Member(
                        dr["name"].ToString(),
                        dr["nick_name"].ToString(), 
                        dr["birth"].ToString(),
                        dr["gender"].ToString(), 
                        dr["tel"].ToString(), 
                        dr["email"].ToString()));
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않음!");
            }
            dr.Close();
            return memList;
        }
    }
}
