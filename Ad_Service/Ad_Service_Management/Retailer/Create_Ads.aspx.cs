using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

namespace Ad_Service_Management.Retailer
{
    public partial class Create_Ads : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        AppsCode.BLL b = new AppsCode.BLL();
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string dtts = System.DateTime.Now.ToString();
                string em = Session["User"].ToString();
                int R_ID = b.Get_Retailer_Id_Em(em);
                int aID = b.Get_Retailer_AId_Em(em);
                //string vid = txtUrl.Text;
                //string vide = "https://youtube.com/embed/" + vid.Remove(0, 17);  //Character trim.

                BinaryReader br = new BinaryReader(FileUpload1.PostedFile.InputStream);
                byte[] bytes = br.ReadBytes((int)FileUpload1.PostedFile.InputStream.Length);
                FileUpload1.SaveAs(Server.MapPath("~/User/Video/") + Path.GetFileName(FileUpload1.FileName));
                FileUpload1.SaveAs(Server.MapPath("~/Retailer/Video/") + Path.GetFileName(FileUpload1.FileName));
                string path = "Video/" + Path.GetFileName(FileUpload1.FileName);
                path = "<video width=400 controls><source src=" + path + " type=video/mp4></video>";

                if (b.Insert_Video_ad(R_ID, path, txtDes.Text, dtts) > 0)
                {
                    //Response.Write("<script>alert('Ad Created Sucessfully..')</script>");

                    DataTable dt = b.Get_Users_Aid_Busi(aID);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int uId = int.Parse(dt.Rows[i]["Usr_Id"].ToString());
                        int amt = b.GetRet_Amount(R_ID);
                        if (amt > 50)
                        {
                            int at = amt - 50;

                            DataTable dtu = b.Get_User_Account(uId);

                            string ac_id = dtu.Rows[0]["Usr_Ac_Id"].ToString();
                            int uAid = 0;
                            if (ac_id != null)
                            {
                                uAid = int.Parse(dtu.Rows[0]["Usr_Ac_Id"].ToString());
                            }
                            if (uAid != 0)
                            {
                                b.Update_Retailer_Account(at, R_ID);
                                int uamt = b.GetUsr_Amount(uId);
                                int utt = uamt + 50;
                                b.Update_User_Account(utt, uAid);

                                int ded_Amt = b.Get_Ret_Deduction_Amt(R_ID);
                                int R_ded_Amt = ded_Amt + 50;
                                b.Update_Ret_Deduction(R_ded_Amt, R_ID);

                                int m_vId = b.Get_Video_Max_Id();
                                b.Insert_Bus_T_Usr_Ad(R_ID, uId, m_vId, path, txtDes.Text, dtts);
                            }
                        }
                    }
                    Response.Write("<script>alert('Ad Created Sucessfully..')</script>");
                }
            }
            catch
            { 
            }
        }
    }
}