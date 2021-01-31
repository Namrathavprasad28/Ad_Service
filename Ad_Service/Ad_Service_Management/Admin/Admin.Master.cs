using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ad_Service_Management.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Get_Ret_Count();
                Get_Users_Count();
            }
        }

        AppsCode.BLL b = new AppsCode.BLL();

        public void Get_Ret_Count()
        {
            int cnt = b.Get_Ret_Pen_Count();
            Label2.Text = cnt.ToString();
        }

        public void Get_Users_Count()
        {
            int cnt = b.Get_Users_Count();
            Label3.Text = cnt.ToString();
        }
    }
}