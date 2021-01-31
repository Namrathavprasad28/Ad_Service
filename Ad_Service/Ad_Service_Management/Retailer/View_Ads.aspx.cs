using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Ad_Service_Management.Retailer
{
    public partial class View_Ads : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetResult();
            }
        }

        AppsCode.BLL b = new AppsCode.BLL();

        public void GetResult()
        {
            int rid = b.Get_Retailer_Id_Em(Session["User"].ToString());
            DataTable dt = b.Get_Ret_Videos(rid);
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