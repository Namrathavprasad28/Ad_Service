using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Ad_Service_Management.Visitor
{
    public partial class Retailer_Reg : System.Web.UI.Page
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

        protected void ddlCty_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cid = int.Parse(ddlCty.SelectedItem.Value);
            DataTable dt = b.Get_Area_Ct(cid);
            ddlAr.DataSource = dt;
            ddlAr.DataTextField = "Area";
            ddlAr.DataValueField = "Ar_Id";
            ddlAr.DataBind();
            ddlAr.Items.Insert(0, "--Select Area--");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nm = Request.Form["username"];
                string lstname = Request.Form["lstname"];
                string mobile = Request.Form["mobile"];
                string email = Request.Form["email"];
                string password = Request.Form["password"];
                string gender = Request.Form["gender"];
                string mnth = Request.Form["mnth"];
                string day = Request.Form["day"];
                string year = Request.Form["year"];
                int a_Id = int.Parse(ddlAr.SelectedItem.Value);
                string dob = ddlMnt.SelectedItem.Text + "/" + ddlDate.SelectedItem.Text + "/" + ddlYear.SelectedItem.Text;
                string gen = null;
                if (rdbMale.Checked)
                {
                    gen = "Male";
                }
                else
                {
                    gen = "Female";
                }

                string ps = txtPas.Text;
                if (b.Retailer_Reg(txtName.Text, txtLstNm.Text, a_Id, txtMob.Text, txtEmail.Text, ps, gen, dob, "Pending") > 0)
                {
                    Response.Write("<script>alert('Registration Sucessfull..')</script>");
                }
                Clear();
            }
            catch
            { 
            }
        }

        public void Clear()
        {
            txtEmail.Text = "";
            txtLstNm.Text = "";
            txtMob.Text = "";
            txtName.Text = "";
            txtPas.Text = "";
            ddlAr.ClearSelection();
            ddlCty.ClearSelection();
            ddlDate.ClearSelection();
            ddlMnt.ClearSelection();
            ddlYear.ClearSelection();
        }
    }
}