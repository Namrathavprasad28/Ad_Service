using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Ad_Service_Management.Admin
{
    public partial class City : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetData();
            }
        }
        AppsCode.BLL b = new AppsCode.BLL();
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Button1.Text == "ADD")
            {
                if (b.Insert_City(txtCty.Text) > 0)
                {
                    Response.Write("<script>alert('Record Inserted..')</script>");
                }
            }
            else
            {
                if (b.Update_City(txtCty.Text, id) > 0)
                {
                    Response.Write("<script>alert('Record Updated..')</script>");
                }
                Button1.Text = "ADD";
            }
            txtCty.Text = "";
            GetData();
        }

        public void GetData()
        {
            DataTable dt = b.Get_City();
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
            txtCty.Text = r.Cells[0].Text;
            Button1.Text = "Update";
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            id = int.Parse(((ImageButton)sender).CommandArgument);
            if (b.Delete_City(id) > 0)
            {
                Response.Write("<script>alert('Record Deleted.')</script>");
            }
            GetData();
        }
    }
}