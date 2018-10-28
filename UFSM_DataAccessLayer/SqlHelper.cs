using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFSM_DataAccessLayer
{
    public class SqlHelper
    {

        private static readonly string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        /// <summary>
        /// 根据sql查询语句返回一个内存表
        /// </summary>
        /// <param name="T_sql">sql查询命令</param>
        /// <param name="pars">sql参数数组（可为空）</param>
        /// <returns></returns>
        public static DataTable GetDataTable(string T_sql,params SqlParameter[]pars)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(T_sql, conn))
                {
                    if(pars!=null)
                    {
                        adapter.SelectCommand.Parameters.AddRange(pars);
                    }
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        /// <summary>
        /// 执行非查询语句并返回受影响行数
        /// </summary>
        /// <param name="T_sql">sql非查询语句命令</param>
        /// <param name="pars">sql参数数组（可为空）</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string T_sql, params SqlParameter[] pars)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand sqlCmd = new SqlCommand(T_sql, conn))
                {
                    if(pars!=null)
                    {
                        sqlCmd.Parameters.AddRange(pars);
                    }
                    conn.Open();
                    return sqlCmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 执行查询sql命令，返回查询到的第一行第一列
        /// </summary>
        /// <param name="T_sql">sql查询命令</param>
        /// <param name="pars">sql参数数组（可为空）</param>
        /// <returns></returns>
        public static object ExecuteScalar(string T_sql, params SqlParameter[] pars)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using(SqlCommand sqlCmd=new SqlCommand (T_sql,conn))
                {
                    if(pars!=null)
                    {
                        sqlCmd.Parameters.AddRange(pars);
                    }
                    conn.Open();
                    return sqlCmd.ExecuteScalar();
                } 
            }
        }



        
    }
}
