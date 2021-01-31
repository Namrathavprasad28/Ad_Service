using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Ad_Service_Management.AppsCode
{
    public class BLL
    {
        SqlConn Obj = new SqlConn();

        public int Login(string typ, string em, string pas)
        {
            if (typ == "Admin")
            {
                string Sql = string.Format("select count(*) from tblAdmin where Admin_Id='{0}' and Password='{1}'", em, pas);
                return Obj.Aggregate(Sql);
            }
            else if (typ == "Retailer")
            {
                string Sql = string.Format("select count(*) from tblRetailer where Email_Id='{0}' and Password='{1}' and Status='Approved'", em, pas);
                return Obj.Aggregate(Sql);
            }
            else
            {
                string Sql = string.Format("select count(*) from tblUser where Email_Id='{0}' and Password='{1}'", em, pas);
                return Obj.Aggregate(Sql);
            }
        }

        #region City
        public int Insert_City(string cty)
        {
            string Sql = string.Format("insert into tblCity values('{0}')", cty);
            return Obj.DoTransaction(Sql);
        }

        public DataTable Get_City()
        {
            string Sql = string.Format("select * from tblCity");
            return Obj.DoNonTransaction(Sql);
        }

        public int Update_City(string cty, int id)
        {
            string Sql = string.Format("update tblCity set City='{0}' where Cty_Id={1}", cty,id);
            return Obj.DoTransaction(Sql);
        }

        public int Delete_City(int id)
        {
            string Sql = string.Format("delete from tblCity where Cty_Id={0}", id);
            return Obj.DoTransaction(Sql);
        }

        public int City_Count()
        {
            string Sql = string.Format("select count(*) from tblCity");
            return Obj.Aggregate(Sql);
        }
        #endregion

        #region Area
        public int Insert_Area(string ar, int cid)
        {
            string Sql = string.Format("insert into tblArea values('{0}','{1}')", ar,cid);
            return Obj.DoTransaction(Sql);
        }

        public DataTable Get_Area()
        {
            string Sql = string.Format("select tblArea.*,tblCity.City from tblArea inner join tblCity on tblArea.Cty_Id=tblCity.Cty_Id");
            return Obj.DoNonTransaction(Sql);
        }

        public int Update_Area(string ar, int ct, int id)
        {
            string Sql = string.Format("update tblArea set Area='{0}',Cty_Id={1} where Ar_Id={2}", ar,ct, id);
            return Obj.DoTransaction(Sql);
        }

        public int Delete_Area(int id)
        {
            string Sql = string.Format("delete from tblArea where Ar_Id={0}", id);
            return Obj.DoTransaction(Sql);
        }

        public DataTable Get_Area_Ct(int cId)
        {
            string Sql = string.Format("select * from tblArea where Cty_Id={0}",cId);
            return Obj.DoNonTransaction(Sql);
        }

        public int GetArea()
        {
            string Sql = string.Format("select count(*) from tblArea");
            return Obj.Aggregate(Sql);
 
        }
        #endregion

        #region Retailer
        public int Retailer_Reg(string nm, string lnm, int aid, string mob, string em, string pas, string gen, string dob, string sts)
        {
            string Sql = string.Format("insert into tblRetailer values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", nm, lnm, aid, mob, em, pas, gen, dob, sts);
            return Obj.DoTransaction(Sql);
        }

        public DataTable Retailer_Pending()
        {
            string Sql = string.Format("SELECT tblRetailer.*, tblCity.City, tblArea.Area FROM tblArea INNER JOIN tblCity ON tblArea.Cty_Id = tblCity.Cty_Id INNER JOIN tblRetailer ON tblArea.Ar_Id = tblRetailer.Ar_Id where tblRetailer.Status='Pending'");
            return Obj.DoNonTransaction(Sql);
        }

        public DataTable Retailer_Approved()
        {
            string Sql = string.Format("SELECT tblRetailer.*, tblCity.City, tblArea.Area FROM tblArea INNER JOIN tblCity ON tblArea.Cty_Id = tblCity.Cty_Id INNER JOIN tblRetailer ON tblArea.Ar_Id = tblRetailer.Ar_Id where tblRetailer.Status='Approved'");
            return Obj.DoNonTransaction(Sql);
        }

        public int Update_Retailer_App(int id)
        {
            string Sql = string.Format("update tblRetailer set Status='Approved' where Ret_Id={0}", id);
            return Obj.DoTransaction(Sql);
        }

        public int Update_Retailer_Rej(int id)
        {
            string Sql = string.Format("update tblRetailer set Status='Rejected' where Ret_Id={0}", id);
            return Obj.DoTransaction(Sql);
        }

        public int Get_Retailer_Id_Em(string em)
        {
            string Sql = string.Format("select Ret_Id from tblRetailer where Email_Id='{0}'", em);
            return Obj.Aggregate(Sql);
        }

        public int Get_Retailer_AId_Em(string em)
        {
            string Sql = string.Format("select Ar_Id from tblRetailer where Email_Id='{0}'", em);
            return Obj.Aggregate(Sql);
        }

        public DataTable Get_Ret_Profile(string em)
        {
            string Sql = string.Format("select * from tblRetailer where Email_Id='{0}'", em);
            return Obj.DoNonTransaction(Sql);
        }

        public int Update_Ret_Profile(string nm, string lnm, string mob, string em)
        {
            string Sql = string.Format("update tblRetailer set Name='{0}',Last_Name='{1}',Mobile='{2}' where Email_Id='{3}'", nm, lnm, mob, em);
            return Obj.DoTransaction(Sql);
        }

        public int Update_Ret_Password(string pas, string em)
        {
            string Sql = string.Format("update tblRetailer set Password='{0}' where Email_Id='{1}'", pas, em);
            return Obj.DoTransaction(Sql);
        }

        public int Get_Ret_Pen_Count()
        {
            string Sql = string.Format("select count(*) from tblRetailer where Status='Pending'");
            return Obj.Aggregate(Sql);
        }

        public int GetRet_Count()
        {
            string Sql = string.Format("select count(*) from tblRetailer where Status='Approved'");
            return Obj.Aggregate(Sql);
        }
        #endregion

        #region User
        public int User_Reg(string nm, int aid, string mob, string em, string pas, string gen, string pth)
        {
            string Sql = string.Format("insert into tblUser values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", nm, aid, mob, em, pas, gen, pth);
            return Obj.DoTransaction(Sql);
        }

        public int Get_User_a_Id(string em)
        {
            string Sql = string.Format("select Ar_Id from tblUser where Email_Id='{0}'", em);
            return Obj.Aggregate(Sql);
        }

        public int Get_User_Id_Em(string em)
        {
            string Sql = string.Format("select Usr_Id from tblUser where Email_Id='{0}'", em);
            return Obj.Aggregate(Sql);
        }

        public DataTable Get_Users_Aid_Busi(int aid)
        {
            string Sql = string.Format("SELECT tblUser.*, tblAccount_User.Usr_Ac_Id FROM tblAccount_User INNER JOIN tblUser ON tblAccount_User.Usr_Id = tblUser.Usr_Id where tblUser.Ar_Id = {0}", aid);
            return Obj.DoNonTransaction(Sql);
        }

        public DataTable Get_User_Em(string em)
        {
            string Sql = string.Format("select * from tblUser where Email_Id = '{0}'", em);
            return Obj.DoNonTransaction(Sql);
        }

        public int Update_User_Profile(string nm, string mob, string em)
        {
            string Sql = string.Format("update tblUser set Name='{0}',Mobile='{1}' where Email_Id='{2}'", nm, mob, em);
            return Obj.DoTransaction(Sql);
        }

        public int Update_User_Password(string pas, string em)
        {
            string Sql = string.Format("update tblUser set Password='{0}' where Email_Id='{1}'", pas, em);
            return Obj.DoTransaction(Sql);
        }

        public DataTable Get_Users_Share(string em)
        {
            string Sql = string.Format("select * from tblUser where Email_Id != '{0}'", em);
            return Obj.DoNonTransaction(Sql);
        }

        public DataTable Get_User()
        {
            string Sql = string.Format("SELECT tblUser.*, tblCity.City, tblArea.Area FROM tblArea INNER JOIN tblCity ON tblArea.Cty_Id = tblCity.Cty_Id INNER JOIN tblUser ON tblArea.Ar_Id = tblUser.Ar_Id");
            return Obj.DoNonTransaction(Sql);
        }

        public int Get_Users_Count()
        {
            string Sql = string.Format("select count(*) from tblUser");
            return Obj.Aggregate(Sql);
        }
        #endregion

        #region Video_Ad's
        public int Insert_Video_ad(int rid, string url, string des, string dt)
        {
            string Sql = string.Format("insert into tblVideo_Ad values('{0}','{1}','{2}','{3}')", rid, url, des, dt);
            return Obj.DoTransaction(Sql);
        }

        public DataTable View_Ads_List_to_User(int aID)
        {
            string Sql = string.Format("SELECT tblVideo_Ad.*, tblRetailer.Name FROM tblRetailer INNER JOIN tblVideo_Ad ON tblRetailer.Ret_Id = tblVideo_Ad.Ret_Id where tblRetailer.Ar_Id='{0}'", aID);
            return Obj.DoNonTransaction(Sql);
        }

        public DataTable View_Ads_List_to_User7(int uID)
        {
            string Sql = string.Format("SELECT tblBs_Pst_Video.*, tblRetailer.Name FROM tblBs_Pst_Video INNER JOIN tblRetailer ON tblBs_Pst_Video.Ret_Id = tblRetailer.Ret_Id where tblBs_Pst_Video.Usr_Id='{0}'", uID);
            return Obj.DoNonTransaction(Sql);
        }

        public DataTable View_Ad_to_Play(int id)
        {
            string Sql = string.Format("select * from tblVideo_Ad where Ad_v_Id={0}", id);
            return Obj.DoNonTransaction(Sql);
        }

        public int Get_Video_Max_Id()
        {
            string Sql = string.Format("select max(Ad_v_Id) from tblVideo_Ad");
            return Obj.Aggregate(Sql);
        }

        public int Get_RetID_Vid(int vid)
        {
            string Sql = string.Format("select Ret_Id from tblVideo_Ad where Ad_v_Id={0}", vid);
            return Obj.Aggregate(Sql);
        }

        public DataTable Get_Ret_Videos(int rid)
        {
            string Sql = string.Format("select * from tblVideo_Ad where Ret_Id={0}", rid);
            return Obj.DoNonTransaction(Sql);
        }

        public int Get_Ads_Video_Count(int rid)
        {
            string Sql = string.Format("select count(*) from tblVideo_Ad where Ret_Id={0}", rid);
            return Obj.Aggregate(Sql);
        }

        public int GetUser_Ads_Count(int uid)
        {
            string Sql = string.Format("SELECT count(*) FROM tblBs_Pst_Video INNER JOIN tblRetailer ON tblBs_Pst_Video.Ret_Id = tblRetailer.Ret_Id where tblBs_Pst_Video.Usr_Id={0}", uid);
            return Obj.Aggregate(Sql);
        }
        #endregion

        #region Parent Comment
        public int Insert_Parent_Comment(int uId, int vId, string cmt, string dt)
        {
            string Sql = string.Format("insert into tblComment_Parent values('{0}','{1}','{2}','{3}')", uId, vId, cmt, dt);
            return Obj.DoTransaction(Sql);
        }

        public DataTable Get_Parent_Comment(int vId)
        {
            string Sql = string.Format("SELECT tblComment_Parent.*, tblUser.Name, tblUser.Email_Id FROM tblComment_Parent INNER JOIN tblUser ON tblComment_Parent.Usr_Id = tblUser.Usr_Id where tblComment_Parent.Ad_v_Id={0}", vId);
            return Obj.DoNonTransaction(Sql);
        }

        public DataTable Get_Child_Comment(int vId, int ctPid)
        {
            string Sql = string.Format("SELECT tblComment_Child.*, tblUser.Name, tblUser.Email_Id FROM tblComment_Child INNER JOIN tblUser ON tblComment_Child.Usr_Id = tblUser.Usr_Id where tblComment_Child.Ad_v_Id={0} and tblComment_Child.Cmt_Pr_Id{1}", vId, ctPid);
            return Obj.DoNonTransaction(Sql);
        }
        #endregion

        #region Child Comment
        public int Insert_Child_Comment(int uId, int av_id, int pId, string cmt, string dt)
        {
            string Sql = string.Format("insert into tblComment_Child values('{0}','{1}','{2}','{3}', '{4}')", uId, av_id, pId, cmt, dt);
            return Obj.DoTransaction(Sql);
        }
        #endregion

        #region Retailer Amount
        public int Insert_Retailer_Amount(int rt,int amt)
        {
            string Sql = string.Format("insert into tblAccount_Retailer (Ret_Id,Amount) values({0},{1})",rt,amt);
            return Obj.DoTransaction(Sql);
        }

        public DataTable Get_Retailer_Amount(int id)
        {
            string Sql = string.Format("select * from tblAccount_Retailer where Ret_Ac_Id='{0}'",id);
            return Obj.DoNonTransaction(Sql);
        }

        public int Check_Retailer_Account(int id)
        {
            string Sql = string.Format("select count(*) from tblAccount_Retailer where Ret_Ac_Id='{0}'", id);
            return Obj.Aggregate(Sql);
        }

        public int Update_Retailer_Account(int amt,int id)
        {
            string Sql = string.Format("update tblAccount_Retailer set Amount='{0}' where Ret_Ac_Id='{1}'", amt,id);
            return Obj.DoTransaction(Sql);
        }

        public int GetRet_Amount(int rId)
        {
            string Sql = string.Format("select Amount from tblAccount_Retailer where Ret_Id='{0}'", rId);
            return Obj.Aggregate(Sql);
        }

        public DataTable Get_Ret_Ammount_Cht(int id)
        {
            string Sql = string.Format("select Amount,Deduction from tblAccount_Retailer where Ret_Ac_Id='{0}'", id);
            return Obj.DoNonTransaction(Sql);
        }

        public int Get_Ret_Deduction_Amt(int rId)
        {
            string Sql = string.Format("select Deduction from tblAccount_Retailer where Ret_Id='{0}'", rId);
            return Obj.Aggregate(Sql);
        }

        public int Update_Ret_Deduction(int ded, int rid)
        {
            string Sql = string.Format("update tblAccount_Retailer set Deduction='{0}' where Ret_Id='{1}'", ded, rid);
            return Obj.DoTransaction(Sql);
        }
        #endregion

        #region User account
        public int Insert_User_Account(int uid, int at)
        {
            string Sql = string.Format("insert into tblAccount_User (Usr_Id,Amount) values({0},{1})", uid, at);
            return Obj.DoTransaction(Sql);
        }

        public DataTable Get_User_Account(int Usr_Id)
        {
            string Sql = string.Format("select * from tblAccount_User where Usr_Id='{0}'", Usr_Id);
            return Obj.DoNonTransaction(Sql);
        }

        public int GetUsr_Amount(int uId)
        {
            string Sql = string.Format("select Amount from tblAccount_User where Usr_Id='{0}'", uId);
            return Obj.Aggregate(Sql);
        }

        public int Update_User_Account(int amt, int id)
        {
            string Sql = string.Format("update tblAccount_User set Amount='{0}' where Usr_Ac_Id='{1}'", amt, id);
            return Obj.DoTransaction(Sql);
        }

        public int Check_User_Account(int id)
        {
            string Sql = string.Format("select count(*) from tblAccount_User where Usr_Id='{0}'", id);
            return Obj.Aggregate(Sql);
        }
        #endregion

        #region Business to User Ad's
        public int Insert_Bus_T_Usr_Ad(int rid, int uid, int aid, string url, string des, string dt)
        {
            string Sql = string.Format("insert into tblBs_Pst_Video values({0},{1},'{2}','{3}','{4}','{5}')", rid, uid, aid, url, des, dt);
            return Obj.DoTransaction(Sql);
        }
        #endregion

        #region Share Ad
        public int Insert_Share(int uid, int vid, string em, string dt)
        {
            string Sql = string.Format("insert into tblShare values({0},{1},'{2}','{3}')", uid, vid, em, dt);
            return Obj.DoTransaction(Sql);
        }

        public int Check_Exist(int uid, int vid, string em)
        {
            string Sql = string.Format("select count(*) from tblShare where Usr_Id='{0}' and Ad_v_Id={1} and Email_Id='{2}'", uid, vid, em);
            return Obj.Aggregate(Sql);
        }

        public DataTable Get_Shared_Msg(int uid)
        {
            string Sql = string.Format("SELECT tblShare.*, tblVideo_Ad.V_Url FROM tblShare INNER JOIN tblVideo_Ad ON tblShare.Ad_v_Id = tblVideo_Ad.Ad_v_Id where tblShare.Usr_Id='{0}'", uid);
            return Obj.DoNonTransaction(Sql);
        }

        public int GetUsr_Msg_Count(int uid)
        {
            string Sql = string.Format("SELECT count(*) FROM tblShare INNER JOIN tblVideo_Ad ON tblShare.Ad_v_Id = tblVideo_Ad.Ad_v_Id where tblShare.Usr_Id={0}", uid);
            return Obj.Aggregate(Sql);
        }
        #endregion
    }
}