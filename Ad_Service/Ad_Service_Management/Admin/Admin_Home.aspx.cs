using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ad_Service_Management.Admin
{
    public partial class Admin_Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetCity();
                GetArea();
                GetRetailer();
                GetUser_Cnt();                                                                                                                                                                                                   
            }
        }
        AppsCode.BLL b = new AppsCode.BLL();
        public void GetCity()
        {
            int cnt = b.City_Count();
            Label1.Text = cnt.ToString();
        }

        public void GetArea()
        {
            int cnt = b.GetArea();
            Label2.Text = cnt.ToString();
        }

        public void GetRetailer()
        {
            int cnt = b.GetRet_Count();
            Label3.Text = cnt.ToString();
        }

        public void GetUser_Cnt()
        {
            int cnt = b.Get_Users_Count();
            Label4.Text = cnt.ToString();
        }
    }
}