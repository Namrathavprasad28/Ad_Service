using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ad_Service_Management.User
{
    public partial class User_Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetAds();
                GetMessage();
            }
        }

        AppsCode.BLL b = new AppsCode.BLL();

        public void GetAds()
        {
            int Usr_Id = b.Get_User_Id_Em(Session["User"].ToString());
            int cnt = b.GetUser_Ads_Count(Usr_Id);
            Label1.Text = cnt.ToString();
        }

        public void GetMessage()
        {
            int Usr_Id = b.Get_User_Id_Em(Session["User"].ToString());
            int cnt = b.GetUsr_Msg_Count(Usr_Id);
            Label2.Text = cnt.ToString();
        }
    }
}