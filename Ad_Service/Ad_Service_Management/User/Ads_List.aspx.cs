using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Ad_Service_Management.User
{
    public partial class Ads_List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Load_Ads();
                Usr_Id = b.Get_User_Id_Em(Session["User"].ToString());
            }
        }
        AppsCode.BLL b = new AppsCode.BLL();
        public static int Usr_Id;
        public void Load_Ads()
        {
            string em = Session["User"].ToString();
            int a_Id = b.Get_User_a_Id(em);
            int uID = b.Get_User_Id_Em(em);
            //DataTable dt = b.View_Ads_List_to_User(a_Id);
            DataTable dt = b.View_Ads_List_to_User7(uID);
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                GridView1.EmptyDataText = "Norecord found..";
                GridView1.DataSource = null;
                GridView1.DataBind();
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int uID = int.Parse(((LinkButton)sender).CommandArgument);
            Response.Redirect("Play_Ad.aspx?uID=" + uID);
        }

        public void GetUsers()
        {
            string em = Session["User"].ToString();
            DataTable dt = b.Get_Users_Share(em);
            if (dt.Rows.Count > 0)
            {
                GridView2.DataSource = dt;
                GridView2.DataBind();
            }
            else
            {
                GridView2.EmptyDataText = "Norecord found..";
                GridView2.DataSource = null;
                GridView2.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GetUsers();
            Button2.Visible = true;
            GridView2.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            try
            {
                for (int i = 0; i < GridView1.Rows.Count; i++)
                {
                    CheckBox cb = (CheckBox)GridView1.Rows[i].FindControl("CheckBox2");
                    if (cb.Checked)
                    {
                        int a_vId = int.Parse(cb.ToolTip);
                        for (int j = 0; j < GridView2.Rows.Count; j++)
                        {
                            CheckBox cbx = (CheckBox)GridView2.Rows[j].FindControl("CheckBox1");
                            if (cbx.Checked)
                            {
                                int uId = int.Parse(cbx.ToolTip);
                                string em = Session["User"].ToString();
                                string dt = System.DateTime.Now.ToString();

                                if (b.Check_Exist(uId, a_vId, em) == 0)
                                {
                                    int R_ID = b.Get_RetID_Vid(a_vId);

                                    int amt = b.GetRet_Amount(R_ID);
                                    if (amt > 10)
                                    {
                                        int at = amt - 10;

                                        DataTable dtu = b.Get_User_Account(Usr_Id);

                                        string ac_id = dtu.Rows[0]["Usr_Ac_Id"].ToString();
                                        int uAid = 0;
                                        if (ac_id != null)
                                        {
                                            uAid = int.Parse(dtu.Rows[0]["Usr_Ac_Id"].ToString());
                                        }
                                        if (uAid != 0)
                                        {
                                            b.Update_Retailer_Account(at, R_ID);
                                            int uamt = b.GetUsr_Amount(Usr_Id);
                                            int utt = uamt + 10;
                                            b.Update_User_Account(utt, uAid);

                                            int ded_Amt = b.Get_Ret_Deduction_Amt(R_ID);
                                            int R_ded_Amt = ded_Amt + 10;
                                            b.Update_Ret_Deduction(R_ded_Amt, R_ID);

                                            cnt = b.Insert_Share(uId, a_vId, em, dt);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            { 
            }
            if (cnt > 0)
            {
                Response.Write("<script>alert('Shared Sucessfully..')</script>");
            }
            Button2.Visible = false;
            GridView2.Visible = false;
        }
    }
}