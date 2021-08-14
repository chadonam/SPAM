using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

using SPAM.Common;

namespace SPAM.Manage
{
    public class CommonService : IDisposable
    {
        public void Dispose()
        { }


        #region 로그인조회
        //로그인 조회
        public DataSet GetLoginList(string id, string password)
        {
            DataSet dsResult = null;

            string spName = string.Empty;

            SqlParameter[] param = null;
            try
            {
                spName = "SLoginList";

                param = new SqlParameter[2];
                param[0] = new SqlParameter("@UserId", id);
                param[1] = new SqlParameter("@Password", password);

                dsResult = SqlHelper.Fill(spName, param);

                return dsResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dsResult != null) { dsResult.Dispose(); dsResult = null; }
            }
        }
        #endregion


        #region Group 조회        
        public DataSet GetGroup(string groupName)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SGroupQry";

                param = new SqlParameter[1];
                param[0] = new SqlParameter("@GroupName", groupName);

                dsResult = SqlHelper.Fill(spName, param);

                return dsResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dsResult != null) { dsResult.Dispose(); dsResult = null; }
            }
        }
        #endregion

        #region Group 저장     
        public DataSet SetGroup(string workingTag,string groupSeq, string groupName)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SGroupSave";

                param = new SqlParameter[3];
                param[0] = new SqlParameter("@WorkingTag", workingTag);
                param[1] = new SqlParameter("@GroupSeq", groupSeq);
                param[2] = new SqlParameter("@GroupName", groupName);
 



                dsResult = SqlHelper.Fill(spName, param);

                return dsResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dsResult != null) { dsResult.Dispose(); dsResult = null; }
            }
        }
        #endregion

        #region Group Combo 조회        
        public DataSet GetGroupCombo()
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            //SqlParameter[] param = null;
            try
            {
                spName = "SGroupComboQry";

                dsResult = SqlHelper.Fill(spName);

                return dsResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dsResult != null) { dsResult.Dispose(); dsResult = null; }
            }
        }
        #endregion

        #region User 조회        
        public DataSet GetUser(string userId)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SUserQry";

                param = new SqlParameter[1];
                param[0] = new SqlParameter("@UserID", userId);

                dsResult = SqlHelper.Fill(spName, param);

                return dsResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dsResult != null) { dsResult.Dispose(); dsResult = null; }
            }
        }
        #endregion

        #region Group 저장     
        public DataSet SetUser(string workingTag, string userSeq, string userID,string password, string groupSeq)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SUserSave";

                param = new SqlParameter[5];
                param[0] = new SqlParameter("@WorkingTag", workingTag);
                param[1] = new SqlParameter("@UserSeq", userSeq);
                param[2] = new SqlParameter("@UserID", userID);
                param[3] = new SqlParameter("@Password", password);
                param[4] = new SqlParameter("@GroupSeq", groupSeq);




                dsResult = SqlHelper.Fill(spName, param);

                return dsResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dsResult != null) { dsResult.Dispose(); dsResult = null; }
            }
        }
        #endregion

        #region 품목 코드헬프
        public DataSet GetItemCodeHelp(string itemNm, string itemNo)
        {
            DataSet dsResult = null;

            string spName = string.Empty;

            SqlParameter[] param = null;
            try
            {
                spName = "SItemCodeHelp";

                param = new SqlParameter[2];
                param[0] = new SqlParameter("@ItemNm", itemNm);
                param[1] = new SqlParameter("@ItemNo", itemNo);

                dsResult = SqlHelper.Fill(spName, param);

                return dsResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dsResult != null) { dsResult.Dispose(); dsResult = null; }
            }
        }

        #endregion

    }
}
