using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace Ad_Service_Management.AppsCode
{
    public class Users
    {
        public string Name { get; set; }
        public string Comment { get; set; }
        public string Date { get; set; }
        public string Image { get; set; }
    }
    public class DataAccess
    {
        public static List<Users> GetAllemployees(int ParebCommentID, int Ad_v_Id)
        {
            List<Users> listEmployee = new List<Users>();
            string cs = ConfigurationManager.ConnectionStrings["Ad_Conn"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                //SqlCommand cmd = new SqlCommand("select * from tblComment_Child where Cmt_Pr_Id=@ParebCommentID and Ad_v_Id=@Ad_v_Id", con);
                SqlCommand cmd = new SqlCommand("SELECT tblComment_Child.*, tblUser.Name, tblUser.Image FROM tblComment_Child INNER JOIN tblUser ON tblComment_Child.Usr_Id = tblUser.Usr_Id where tblComment_Child.Cmt_Pr_Id=@ParebCommentID and tblComment_Child.Ad_v_Id=@Ad_v_Id", con);
                cmd.Parameters.Add("ParebCommentID", ParebCommentID);
                cmd.Parameters.Add("Ad_v_Id", Ad_v_Id);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Users employee = new Users();
                    employee.Name = rdr["Name"].ToString();
                    employee.Comment = rdr["Comment"].ToString();
                    employee.Date = rdr["Date"].ToString();
                    employee.Image = rdr["Image"].ToString();
                    listEmployee.Add(employee);
                }


            }
            return listEmployee;
        }
    }
}