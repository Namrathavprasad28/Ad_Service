using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace Ad_Service_Management.AppsCode
{
    public class ParentCommentAccess
    {
        public int Cmt_Pr_Id { get; set; }
        public int Ad_v_Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public string Date { get; set; }
        public string Image { get; set; }
        public List<Users> Empl
        {
            get
            {
                return DataAccess.GetAllemployees(this.Cmt_Pr_Id, this.Ad_v_Id);
            }
        }
    }

    public class ParentComment
    {
        public static List<ParentCommentAccess> GetAllDepartmentsandEmployee(int ParebCommentID)
        {
            List<ParentCommentAccess> listDepartments = new List<ParentCommentAccess>();
            string cs = ConfigurationManager.ConnectionStrings["Ad_Conn"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                //SqlCommand cmd = new SqlCommand("Select * from tblComment_Parent where Ad_v_Id=@Ad_v_Id", con);
                SqlCommand cmd = new SqlCommand("SELECT tblComment_Parent.*, tblUser.Name, tblUser.Image FROM tblComment_Parent INNER JOIN tblUser ON tblComment_Parent.Usr_Id = tblUser.Usr_Id where tblComment_Parent.Ad_v_Id=@Ad_v_Id", con);
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Ad_v_Id";
                parameter.Value = ParebCommentID;
                cmd.Parameters.Add(parameter);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ParentCommentAccess parent = new ParentCommentAccess();
                    parent.Cmt_Pr_Id = Convert.ToInt32(rdr["Cmt_Pr_Id"]);
                    parent.Ad_v_Id = Convert.ToInt32(rdr["Ad_v_Id"]);
                    parent.Name = rdr["Name"].ToString();
                    parent.Comment = rdr["Comment"].ToString();
                    parent.Date = rdr["Date"].ToString();
                    parent.Image = rdr["Image"].ToString();
                    listDepartments.Add(parent);
                }
            }
            return listDepartments;
        }
    }
}