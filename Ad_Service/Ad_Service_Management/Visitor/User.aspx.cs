using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

namespace Ad_Service_Management.Visitor
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetCity();
            }
        }
        AppsCode.BLL b = new AppsCode.BLL();

        public void GetCity()
        {
            DataTable dt = b.Get_City();
            ddlCty.DataSource = dt;
            ddlCty.DataTextField = "City";
            ddlCty.DataValueField = "Cty_Id";
            ddlCty.DataBind();
            ddlCty.Items.Insert(0, "--Select City--");
        }

        //protected void ddlCty_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int cid = int.Parse(ddlCty.SelectedItem.Value);
        //    DataTable dt = b.Get_Area_Ct(cid);
        //    ddlAr.DataSource = dt;
        //    ddlAr.DataTextField = "Area";
        //    ddlAr.DataValueField = "Ar_Id";
        //    ddlAr.DataBind();
        //    ddlAr.Items.Insert(0, "--Select Area--");
        //}

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a_Id = int.Parse(ddlAr.SelectedItem.Value);
                string gen = ddlGender.SelectedItem.Text;
                string name = Request.Form["name"];
                string Mobile = Request.Form["Mobile"];
                string email = Request.Form["email"];
                string password = Request.Form["password"];
                string path = "~/Visitor/img/" + FileUpload1.FileName;
                FileUpload1.SaveAs(MapPath(path));


                if (b.User_Reg(name, a_Id, Mobile, email, password, gen, path) > 0)
                {
                    Response.Write("<script>alert('Registration Sucessfull..')</script>");
                }
            }
            catch
            { 
            }
        }

        protected void ddlCty_SelectedIndexChanged1(object sender, EventArgs e)
        {
            int cid = int.Parse(ddlCty.SelectedItem.Value);
            DataTable dt = b.Get_Area_Ct(cid);
            ddlAr.DataSource = dt;
            ddlAr.DataTextField = "Area";
            ddlAr.DataValueField = "Ar_Id";
            ddlAr.DataBind();
            ddlAr.Items.Insert(0, "--Select Area--");
        }
    }
}