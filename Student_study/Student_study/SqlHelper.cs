using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Student_study
{
 
    class SqlHelper
    {
        public static object ExcuteScalar(string sql, SqlParameter[] paras) 
        {
            SqlConnection conn = new SqlConnection(CommonData.SqlName);
            // 创建command对象
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddRange(paras);
            conn.Open();
            // 执行命令, 必须在打开状态
            //cmd.ExecuteNonQuery();//执行T-SQL命令，返回受影响的行数 
            //cmd.ExecuteReader() 返回受影响的数据流
            object o = cmd.ExecuteScalar();// 返回第一行第一列的值，忽略其他行和列 返回一个对象 
            conn.Close();// 关闭连接
            return o;
        }
        // 返回一个datatable
        public static DataTable GetDataTable(string sql,params SqlParameter[] paras) 
        {


            // 复杂方法, 有参数的话必须使用这个方法进行实现
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(CommonData.SqlName);
            // 创建command对象
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (paras != null)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(paras);
            }
            //conn.Open(); 这里如果显示打开 后面就需要出现close()操作
            // 使用断开式连接
            // 执行命令，一定是command进行实现的
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            // 数据填充
            da.Fill(dt);//这个操作已经关闭了

            // 执行命令, 必须在打开状态
            //object o = cmd.ExecuteScalar();// 返回第一行第一列的值，忽略其他行和列 返回一个对象 
            //conn.Close();// 关闭连接
            return dt;

            // 简单方法， 不需要创建command对象, 没有参数的情况下
            //DataTable dt = new DataTable();
            //SqlConnection conn = new SqlConnection(new CommonData().SqlName);
            //SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            //da.Fill(dt);
            //return dt;
        }

        // 返回受影响的行数
        public static int ExecuteNonQuery(string sql, SqlParameter[] paras) 
        {
            int Count = 0; // 设置初始值，返回受影响的行数

            SqlConnection conn = new SqlConnection(CommonData.SqlName);
            
            // 创建command对象
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddRange(paras);
            conn.Open();

            Count = cmd.ExecuteNonQuery();  // 返回受影响的行数

            return Count;
        }

        // 修改操作时，只读取一行，我感觉和我直接使用DataTable差不多
        public static SqlDataReader ExecuteReader(string sql, SqlParameter[] paras) 
        {
            SqlConnection conn = new SqlConnection(CommonData.SqlName);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddRange(paras);
            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;
            }
            catch(SqlException ex)
            {
                conn.Close();
                throw new Exception("查询异样",ex);
            }
            
        }
    }
}
