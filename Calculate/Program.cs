using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Diagnostics;
using System.Data;
using Calculate.Calculator;
using System.Text;

namespace Calculate
{
    static class Program
    {
       //用于描述当前使用的是文件数据库还是数据库服务器
        public static bool FileDatabase = false;
        //用于保存所有数据信息的文件地址
        public static string DataFileName = "\\data\\OMISv3.sdf";
        //用于存储当前全局的难易程度：1.初级；2.中级；3.高级
        public static int HardID = 1;
        //登录用户信息：
        public static string UserID = "";
        public static string UserName = "";
        //数据库连接字段：
        public static string ServerIP = "59.67.78.68";
        public static string DBName = "calculate"; 
        public static string DBUser = "sa";
        public static string DBPass = "TJNUoffice2012"; 

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());

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

    /// <summary>
    /// 生成四则运算算式类
    /// 作者：饶龙
    /// 最后修改时间：2016-10-12
    /// </summary>
    public class CreateFormula
    {
        static Random ran = new Random(GetRandomSeed());//产生不重复的随机数

        //生成算式，complexity表示题的难易程度，范围（0、1、2）
        public static string CFormula(int complexity)
        {
            string formula;

            char[] operators = { '+', '-', '*', '/' };
            int[] operands = new int[4];

            for (int i = 0; i < operands.Length; i++)
            {
                operands[i] = ran.Next(1, 10);//构造四个操作数
                if (i > 0)
                {
                    while (operands[i] == operands[i - 1])
                    {
                        operands[i] = ran.Next(1, 10);//确保操作数不相同
                    }
                }
            }

            if (0 == complexity)
            {
                formula = CEasyFormula(operands, operators);
            }
            else if (1 == complexity)
            {
                formula = CMediumFormula(operands, operators);
            }
            else
            {
                formula = CDifficultFormula(operands, operators);
            }

            double? num = CalculatorCore.Calculate(formula);//计算算式的结果

            return formula + "=" + num;
        }


        //初级难度算式构造，包含两个操作数，操作符不包括“/”，减法结果不能为负
        private static string CEasyFormula(int[] opds, char[] ops)
        {
            string formula = null;
            int temp;
            char op = ops[ran.Next(0, 3)];
            if (op == '-')
                CompareAndChange(ref opds[0], ref opds[1]);

            formula = opds[0].ToString() + op + opds[1].ToString();

            return formula;
        }


        //中级难度算式构造，包含加、减、乘的任意两个，当结果出现负号时，用括号将结果纠正
        private static string CMediumFormula(int[] opds, char[] ops)
        {
            string formula = null;

            char op1 = ops[ran.Next(0, 3)];
            char op2 = ops[ran.Next(0, 3)];

            if (op1 == '-')
            {
                CompareAndChange(ref opds[0], ref opds[1]);
            }

            formula = opds[0].ToString() + op1 + opds[1].ToString() + op2 + opds[2].ToString();

            if (CalculatorCore.Calculate(formula) < 0)
            {
                if (op1 == '-')
                {
                    CompareAndChange(ref opds[0], ref opds[1]);
                    formula = "(" + opds[0].ToString() + op1 + opds[1].ToString() + ")" + op2 + opds[2].ToString();
                    if (CalculatorCore.Calculate(formula) < 0)
                    {
                        formula = opds[2].ToString() + op2 + "(" + opds[0].ToString() + op1 + opds[1].ToString() + ")";
                    }
                }
                else
                {
                    CompareAndChange(ref opds[1], ref opds[2]);
                    formula = opds[0].ToString() + op1 + "(" + opds[1].ToString() + op2 + opds[2].ToString() + ")";
                }
            }

            return formula;
        }


        //高级难度算式构造，整数与分数、分数与分数的混合运算
        private static string CDifficultFormula(int[] opds, char[] ops)
        {
            string formula = null;
            string fraction1;
            string fraction2;

            char op1 = ops[ran.Next(0, 3)];
            char op2 = ops[3];

            CompareAndChange(ref opds[0], ref opds[1]);
            fraction1 = opds[1].ToString() + op2 + opds[0].ToString();

            CompareAndChange(ref opds[2], ref opds[3]);
            fraction2 = opds[3].ToString() + op2 + opds[2].ToString();

            if (0 == ran.Next(1, 100) % 2)//余数为0，分数与整数运算，为1，分数与分数运算
            {
                formula = fraction1 + op1 + opds[2].ToString();
                if (CalculatorCore.Calculate(formula) < 0)
                {
                    formula = opds[2].ToString() + op1 + fraction1;
                }
            }
            else
            {
                formula = fraction1 + op1 + fraction2;
                if (CalculatorCore.Calculate(formula) < 0)
                {
                    formula = fraction2 + op1 + fraction1;
                }
            }

            return formula;
        }


        private static void CompareAndChange(ref int a, ref int b)
        {
            int t;
            if (a < b)
            {
                t = a;
                a = b;
                b = t;
            }
        }


        //确保随机数不重复
        private static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }

    }
}
