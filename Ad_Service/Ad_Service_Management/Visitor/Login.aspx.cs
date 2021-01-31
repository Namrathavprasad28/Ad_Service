using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Ad_Service_Management.Visitor
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        AppsCode.BLL b = new AppsCode.BLL();
        protected void Button1_Click(object sender, EventArgs e)
        {
            string typ = Request.Form["typ"];
            string em = Request.Form["email"];
            string pas = Request.Form["password"];

            if (b.Login(typ, em, pas) > 0)
            {
                if (typ == "Admin")
                {
                    Response.Redirect("~/Admin/Admin_Home.aspx");
                }
                else if (typ == "Retailer")
                {
                    Session["User"] = em; 
                    Session["Pasw"] = pas;
                    Response.Redirect("~/Retailer/Retailer_Home.aspx");
                }
                else if (typ == "User")
                {
                    Session["User"] = em;
                    Session["Pasw"] = pas;
                    Response.Redirect("~/User/User_Home.aspx");
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid Id/Password..')</script>");
            }
        }
    }
}