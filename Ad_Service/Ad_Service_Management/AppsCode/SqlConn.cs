using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Ad_Service_Management.AppsCode
{
    public class SqlConn
    {
        string conn = ConfigurationManager.ConnectionStrings["Ad_Conn"].ConnectionString;
        SqlConnection con;

        public SqlConn()
        {
            con = new SqlConnection(conn);
            con.Open();
        }

        public int DoTransaction(string SqlQry)
        {
            SqlCommand cmd = new SqlCommand(SqlQry, con);
            return int.Parse(cmd.ExecuteNonQuery().ToString());
        }

        public DataTable DoNonTransaction(string SqlQry)
        {
            SqlDataAdapter adp = new SqlDataAdapter(SqlQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public int Aggregate(string SqlQry)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(SqlQry, con);
                return int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch
            {
                return 0;
            }
        }
    }
}