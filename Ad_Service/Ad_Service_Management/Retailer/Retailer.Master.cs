using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Ad_Service_Management.Retailer
{
    public partial class Retailer : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetAds();
            }
        }

        AppsCode.BLL b = new AppsCode.BLL();

        public void GetAds()
        { 
            string em = Session["User"].ToString();
            int rid = b.Get_Retailer_Id_Em(em);
            int cnt = b.Get_Ads_Video_Count(rid);
            Label2.Text = cnt.ToString();
        }

        public void Videos()
        {
            //string em = Session["User"].ToString();
            //int aId = b.Get_Retailer_AId_Em(em);
            //DataTable dt = b.Get_Users_Aid_Busi(aId);
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    int uId = int.Parse(dt.Rows[i]["Usr_Id"].ToString());
            //    int amt = b.GetRet_Amount(aId);
            //    if (amt > 50)
            //    {
            //        int at = amt - 50;

            //        DataTable dtu = b.Get_User_Account(uId);

            //        int uAid = int.Parse(dtu.Rows[0]["Usr_Ac_Id"].ToString());
            //        if (uAid != null)
            //        {
            //            b.Update_Retailer_Account(at, aId);
            //            int uamt = b.GetUsr_Amount(uId);
            //            int utt = uamt + 50;
            //            b.Update_User_Account(utt, uAid);
            //        }
            //    }
            //}
        }
    }
}