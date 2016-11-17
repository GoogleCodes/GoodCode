using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Window
{
    class DBClass
    {
        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <returns>返回SqlConnection对象</returns>
        public SqlConnection GetConnection()
        {
            string myStr = "Server=DESKTOP-JPPERF8;database=TestDB;UID=sa;password=root";
            SqlConnection myConn = new SqlConnection(myStr);
            myConn.Open();
            return myConn;
        }
      
        /// <summary>
        /// 执行Sql查询语句
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public SqlDataReader reDr(String str)
        {
            //连接数据库
            SqlConnection conn = GetConnection();
            //执行操作
            SqlCommand com = new SqlCommand(str, conn);
            //读取数据库
            SqlDataReader dr = com.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;//返回SqlDataReader 对象 dr
        }
    }
}
