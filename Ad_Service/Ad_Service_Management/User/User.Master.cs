using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Ad_Service_Management.User
{
    public partial class User : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            em = Session["User"].ToString();
            if (!IsPostBack)
            {
                Profile();
                GetAds();
                GetMessage();
            }
        }

        static string em;
        AppsCode.BLL b = new AppsCode.BLL();

        public void Profile()
        {
            DataTable dt = b.Get_User_Em(em);
            Image1.ImageUrl = dt.Rows[0]["Image"].ToString();
            Label1.Text = dt.Rows[0]["Name"].ToString();
        }

        public void GetAds()
        {
            int Usr_Id = b.Get_User_Id_Em(Session["User"].ToString());
            int cnt = b.GetUser_Ads_Count(Usr_Id);
            Label2.Text = cnt.ToString();
        }

        public void GetMessage()
        {
            int Usr_Id = b.Get_User_Id_Em(Session["User"].ToString());
            int cnt = b.GetUsr_Msg_Count(Usr_Id);
            Label3.Text = cnt.ToString();
        }
    }
}