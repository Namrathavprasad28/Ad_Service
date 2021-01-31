using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Ad_Service_Management.Retailer
{
    public partial class Retailer_Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetChart(); 
            }
        }
        AppsCode.BLL b = new AppsCode.BLL();
        public void GetChart()
        {
            string em = Session["User"].ToString();
            int id = b.Get_Retailer_Id_Em(em);
            DataTable dt = b.Get_Ret_Ammount_Cht(id);
            Chart1.DataSource = dt;
            Chart1.Series["Series1"].XValueMember = "Amount";
            Chart1.Series["Series1"].YValueMembers = "Deduction";
            Chart1.DataBind();
        }
    }
}