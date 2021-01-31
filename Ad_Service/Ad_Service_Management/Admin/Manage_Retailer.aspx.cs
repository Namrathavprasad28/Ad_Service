using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Ad_Service_Management.Admin
{
    public partial class Manage_Retailer : System.Web.UI.Page
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
            DataTable dt = b.Retailer_Pending();
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
                Button1.Visible = true;
                Button2.Visible = true;
            }
            else
            {
                GridView1.EmptyDataText = "Norecor found..";
                GridView1.DataSource = null;
                GridView1.DataBind();
                Button1.Visible = false;
                Button2.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int ct = 0, res = 0;
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                CheckBox cb = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
                if (cb.Checked)
                {
                    int id = int.Parse(cb.ToolTip);
                    ct++;
                    res = b.Update_Retailer_App(id);
                }
            }
            if (ct == 0)
            {
                Response.Write("<script>alert('Select Record..')</script>");
            }
            if (res > 0)
            {
                Response.Write("<script>alert('Record Updated..')</script>");
            }
            GetResult();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int ct = 0, res = 0;
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                CheckBox cb = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
                if (cb.Checked)
                {
                    int id = int.Parse(cb.ToolTip);
                    ct++;
                    res = b.Update_Retailer_Rej(id);
                }
            }
            if (ct == 0)
            {
                Response.Write("<script>alert('Select Record..')</script>");
            }
            if (res > 0)
            {
                Response.Write("<script>alert('Record Updated..')</script>");
            }
            GetResult();
        }
    }
}