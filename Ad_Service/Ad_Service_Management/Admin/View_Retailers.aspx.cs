using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Ad_Service_Management.Admin
{
    public partial class View_Retailers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Result();
            }
        }

        AppsCode.BLL b = new AppsCode.BLL();

        public void Result()
        {
            DataTable dt = b.Retailer_Approved();
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                GridView1.EmptyDataText = "Norecor found..";
                GridView1.DataSource = null;
                GridView1.DataBind();
            }
        }
    }
}