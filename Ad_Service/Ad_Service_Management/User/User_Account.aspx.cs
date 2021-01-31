using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Ad_Service_Management.User
{
    public partial class User_Account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetResult();
            }
        }
        AppsCode.BLL b = new AppsCode.BLL();
        protected void Button1_Click(object sender, EventArgs e)
        {
            string em = Session["User"].ToString();
            int id = b.Get_User_Id_Em(em);
            if (Button1.Text == "ADD")
            {
                if (b.Check_User_Account(id) == 0)
                {
                    if (b.Insert_User_Account(id, int.Parse(txtAmt.Text)) > 0)
                    {
                        Response.Write("<script>alert('Amount Inserted..')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Acount already created..')</script>");
                }
            }
            else
            {
                int amount = b.GetUsr_Amount(id);
                int tt = amount + int.Parse(txtAmt.Text);
                if (b.Update_User_Account(tt, id) > 0)
                {
                    Response.Write("<script>alert('Amount Updated..')</script>");
                }
                Button1.Text = "ADD";
            }
            GetResult();
            txtAmt.Text = "";
        }

        public void GetResult()
        {
            string em = Session["User"].ToString();
            int id = b.Get_User_Id_Em(em);
            DataTable dt = b.Get_User_Account(id);
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                GridView1.EmptyDataText = "No recor found..";
                GridView1.DataSource = null;
                GridView1.DataBind();
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Button1.Text = "Update";
        }
    }
}