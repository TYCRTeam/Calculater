using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Diagnostics;
using System.Data;

namespace Calculate
{
    static class Program
    {
        //用于描述当前使用的是文件数据库还是数据库服务器
        public static bool FileDatabase = true;
        //用于保存所有数据信息的文件地址
        public static string DataFileName = "\\data\\OMISv3.sdf";
        //用于存储当前全局的难易程度：1.初级；2.中级；3.高级
        public static int HardID = 1;
        //登录用户信息：
        public static string UserID = "";
        public static string UaerName = "";
        //数据库连接字段：
        public static string ServerIP = "127.0.0.1"; 
        public static string DBName = "OMISv3"; 
        public static string DBUser = "sa";
        public static string DBPass = "sa"; 
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }

        /// <summary>
        /// 题目生成函数
        /// 1.根据调用函数提供的hardid生成对应的题目，hardid取值：1.初级；2.中级；3.高级
        /// 2.返回值以字符串形式呈现："公式"+","+"计算结果"
        /// 作者：饶龙龙
        /// 最后修改时间：2016-10-11
        /// </summary>
        static string MakeQuestion(int hardid)
        {
            return "";
        }
    }

    /// <summary>
    /// 数据库连接类
    /// 作者：田强
    /// 最后修改时间：2016-10-11
    /// </summary>
    public class DataBase
    {

        //服务器数据库连接对象
        public static SqlConnection scon;

        //数据库是否处于连接状态
        public static Boolean IsConnect;

        /// <summary>
        /// 链接文件数据库
        /// 作者：田强
        /// 最后修改时间：2016-10-11
        /// </summary>
        public static void ConnectFileDataBase()
        {
            OleDbConnection conn = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5;Data Source=." + Program.DataFileName + ";");
            try
            {
                conn.Open();
                OleDbCommand comm = new OleDbCommand();
                OleDbDataAdapter odda = new OleDbDataAdapter();
                comm.Connection = conn;
                IsConnect = true;

            }
            catch (Exception ex)
            {
                IsConnect = false;
                Debug.WriteLine("ConnectFileDataBase : " + ex.Message);
            }
            //finally 
            //{
            //    conn.Close();
            //}
        }

        /// <summary>
        /// 连接数据库服务器
        /// 作者：田强
        /// 最后修改时间：2016-10-11
        /// </summary>
        public static void ConnectServerDataBase()
        {
            scon = new SqlConnection("Persist Security Info=False;User ID=" + Program.DBUser + ";password=" + Program.DBPass + ";Initial Catalog=" + Program.DBName + ";Data Source=" + Program.ServerIP + ";connection timeout=10");
            try
            {
                scon.Open();
                IsConnect = true;
            }
            catch (Exception ex)
            {
                IsConnect = false;
                Debug.WriteLine("ConnectServerDataBase : " + ex.Message);
            }
            finally
            {
                scon.Close();
            }
        }


        /// <summary>
        /// 获取数据填充table返回
        /// 作者：田强
        /// 最后修改时间：2016-10-11
        /// </summary>
        public static DataTable TableResult(String Sql)
        {
            //Debug.WriteLine("TableResult : " + Sql);
            DataTable table = new DataTable();
            try
            {
                if (Program.FileDatabase)
                {
                    System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5;Data Source=." + Program.DataFileName + ";");
                    OleDbCommand comm = new OleDbCommand();
                    comm.CommandText = Sql;
                    comm.Connection = conn;
                    OleDbDataAdapter odda = new OleDbDataAdapter();
                    odda.SelectCommand = comm;
                    conn.Open();
                    try
                    {
                        odda.Fill(table);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("文件数据库：" + ex.Message + " SQL:" + Sql);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    using (scon = new SqlConnection("Persist Security Info=False;User ID=" + Program.DBUser + ";password=" + Program.DBPass + ";Initial Catalog=" + Program.DBName + ";Data Source=" + Program.ServerIP + ";connection timeout=10"))
                    {
                        scon.Open();
                        SqlCommand com = new SqlCommand(Sql, scon);
                        SqlDataAdapter oda = new SqlDataAdapter();
                        oda.SelectCommand = com;
                        oda.Fill(table);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("sql:" + Sql);
                Debug.WriteLine("TableResult : " + ex.Message);
            }
            return table;
        }

        /// <summary>
        /// 执行sql命令，不返回任何结果
        /// 作者：田强
        /// 最后修改时间：2016-10-11
        /// </summary>
        public static void ExecuteNonQuery(String sql)
        {
            try
            {
                if (Program.FileDatabase)
                {
                    System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5;Data Source=." + Program.DataFileName + ";");
                    OleDbCommand comm = new OleDbCommand();
                    comm.Connection = conn;
                    comm.CommandText = sql;
                    conn.Open();
                    try
                    {
                        Debug.WriteLine(sql);
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("文件数据库：" + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    using (scon = new SqlConnection("Persist Security Info=False;User ID=" + Program.DBUser + ";password=" + Program.DBPass + ";Initial Catalog=" + Program.DBName + ";Data Source=" + Program.ServerIP + ";connection timeout=10"))
                    {
                        scon.Open();
                        SqlCommand com = new SqlCommand(sql, scon);
                        com.ExecuteNonQuery();
                        scon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ExecuteNonQuery : " + ex.Message);
            }
        }

    }
}
