using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Ad_Service_Management.User
{
    public partial class Share_Msg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Load_Ads();
                //Usr_Id = b.Get_User_Id_Em(Session["User"].ToString());
            }
        }
        AppsCode.BLL b = new AppsCode.BLL();
        public static int Usr_Id;
        public void Load_Ads()
        {
            Usr_Id = b.Get_User_Id_Em(Session["User"].ToString());
            DataTable dt = b.Get_Shared_Msg(Usr_Id);
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                GridView1.EmptyDataText = "Norecord found..";
                GridView1.DataSource = null;
                GridView1.DataBind();
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int uID = int.Parse(((LinkButton)sender).CommandArgument);
            Response.Redirect("Play_Ad.aspx?uID=" + uID);
        }
    }
}