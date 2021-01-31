using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Ad_Service_Management.Admin
{
    public partial class Area : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Get_City();
                GetData();
            }
        }
        AppsCode.BLL b = new AppsCode.BLL();
        protected void Button1_Click(object sender, EventArgs e)
        {
            int ctId = int.Parse(ddlCt.SelectedItem.Value);
            if (Button1.Text == "ADD")
            {
                if (b.Insert_Area(txtAr.Text,ctId) > 0)
                {
                    Response.Write("<script>alert('Record Inserted..')</script>");
                }
            }
            else
            {
                if (b.Update_Area(txtAr.Text,ctId, id) > 0)
                {
                    Response.Write("<script>alert('Record Updated..')</script>");
                }
                Button1.Text = "ADD";
            }
            txtAr.Text = "";
            ddlCt.ClearSelection();
            GetData();
        }

        public void Get_City()
        {
            DataTable dt = b.Get_City();
            ddlCt.DataSource = dt;
            ddlCt.DataTextField = "City";
            ddlCt.DataValueField = "Cty_Id";
            ddlCt.DataBind();
            ddlCt.Items.Insert(0, "--Select City--");
        }

        public void GetData()
        {
            DataTable dt = b.Get_Area();
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                GridView1.DataSource = null;
                GridView1.DataBind();
            }
        }

        static int id;
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            GridViewRow r = (GridViewRow)((ImageButton)sender).Parent.Parent;
            id = int.Parse(((ImageButton)sender).CommandArgument);
            string cid = ((ImageButton)sender).ToolTip;
            ListItem li = new ListItem(r.Cells[0].Text, cid);
            int ind = ddlCt.Items.IndexOf(li);
            ddlCt.SelectedIndex = ind;
            txtAr.Text = r.Cells[1].Text;
            Button1.Text = "Update";
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            id = int.Parse(((ImageButton)sender).CommandArgument);
            if (b.Delete_Area(id) > 0)
            {
                Response.Write("<script>alert('Record Deleted.')</script>");
            }
            GetData();
        }
    }
}