using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Ad_Service_Management.AppsCode;

namespace Ad_Service_Management.User
{
    public partial class Play_Ad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Result();
                Comment();
            }
        }
        AppsCode.BLL b = new AppsCode.BLL();
        public void Result()
        {
            string uID = Request.QueryString["uID"];
            DataTable dt = b.View_Ad_to_Play(int.Parse(uID));
            GridView3.DataSource = dt;
            GridView3.DataBind();
        }

        public void Comment()
        {
            string uID = Request.QueryString["uID"];
            //DataTable dt = b.Get_Parent_Comment(int.Parse(uID));
            GridView1.DataSource = ParentComment.GetAllDepartmentsandEmployee(int.Parse(uID));
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string em = Session["User"].ToString();
            int u_Id = b.Get_User_Id_Em(em);
            string uID = Request.QueryString["uID"];
            string dt = System.DateTime.Now.ToString("d");

            if (b.Insert_Parent_Comment(u_Id, int.Parse(uID), TextBox1.Text, dt) > 0)
            {
                Response.Write("<script>alert('Record Inserted..')</script>");
            }
            Comment();
        }

        protected void btnReplyParent_Click(object sender, EventArgs e)
        {
            string em = Session["User"].ToString();
            int u_Id = b.Get_User_Id_Em(em);
            string uID = Request.QueryString["uID"];
            string dt = System.DateTime.Now.ToString("d");

            GridViewRow row = (sender as Button).NamingContainer as GridViewRow;
            Label lblchildCommentid = (Label)row.FindControl("lb1COmmenId");
            TextBox txtCommentParent = (TextBox)row.FindControl("textCommentReplyParent");

            if (b.Insert_Child_Comment(u_Id, int.Parse(uID), int.Parse(lblchildCommentid.Text), txtCommentParent.Text, dt) > 0)
            {
                Response.Write("<script>alert('Replayed Sucessfully..')</script>");
            }
            Comment();
        }
    }
}