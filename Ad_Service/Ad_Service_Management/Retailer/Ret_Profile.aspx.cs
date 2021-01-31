using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Ad_Service_Management.AppsCode;

namespace Ad_Service_Management.Retailer
{
    public partial class Ret_Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            em = Session["User"].ToString();
            if (!this.IsPostBack)
            {
                GetData();
                txtAdrs.ReadOnly = true;
                txtMob.ReadOnly = true;
                txtName.ReadOnly = true;
                //txtCty.ReadOnly = true;
            }
        }
        static string em;
        BLL b = new BLL();
        private void GetData()
        {
            try
            {
                //dto.inc_Em = Session["User"].ToString();
                //dto.status = "SELECT_P";
                //DataTable dt = bll.Select_Member_P(dto);
                DataTable dt = b.Get_Ret_Profile(em);
                txtName.Text = dt.Rows[0]["Name"].ToString();
                txtAdrs.Text = dt.Rows[0]["Last_Name"].ToString();
                //ListItem l = new ListItem(dt.Rows[0]["City"].ToString(), dt.Rows[0]["Cty_Id"].ToString());
                //int index = ddlCty.Items.IndexOf(l);
                //ddlCty.SelectedIndex = index;
                //txtCty.Text = dt.Rows[0]["City"].ToString();
                txtMob.Text = dt.Rows[0]["Mobile"].ToString();
            }
            catch
            {
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            txtAdrs.ReadOnly = false;
            txtMob.ReadOnly = false;
            txtName.ReadOnly = false;
            //txtCty.ReadOnly = false;
            GetData();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtAdrs.ReadOnly = true;
            txtMob.ReadOnly = true;
            txtName.ReadOnly = true;
            //txtCty.ReadOnly = true;
            GetData();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                int Res = b.Update_Ret_Profile(txtName.Text, txtAdrs.Text, txtMob.Text, em);
                if (Res > 0)
                {
                    Response.Write("<script>alert('Record Updated.')</script>");
                    txtAdrs.ReadOnly = true;
                    txtMob.ReadOnly = true;
                    txtName.ReadOnly = true;
                    //txtCty.ReadOnly = true;
                    GetData();
                }
                else
                {
                    Response.Write("<script>alert('Error in Record Updating.')</script>");
                }
            }
            catch
            {
            }
        }
    }
}