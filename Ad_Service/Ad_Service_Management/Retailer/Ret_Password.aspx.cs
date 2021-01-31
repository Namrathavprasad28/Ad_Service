using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ad_Service_Management.Retailer
{
    public partial class Ret_Password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        AppsCode.BLL b = new AppsCode.BLL();
        protected void Button1_Click(object sender, EventArgs e)
        {
            string eId = Session["User"].ToString();
            string pas = Session["Pasw"].ToString();

            if (txtOld.Text.Equals(pas))
            {
                if (b.Update_Ret_Password(txtNew.Text, eId) > 0)
                {
                    Response.Write("<script>alert('Record Updated.')</script>");
                }
                txtConf.Text = "";
                txtNew.Text = "";
                txtOld.Text = "";
            }
            else
            {
                Response.Write("<script>alert('Error in Old Password.')</script>");
            }
        }
    }
}