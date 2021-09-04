﻿using System;
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

        #region User 저장     
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

        #region 계획 코드헬프
        public DataSet GetPlanCodeHelp( string PlanNo, string StartDate, string EndDate)
        {
            DataSet dsResult = null;

            string spName = string.Empty;

            SqlParameter[] param = null;
            try
            {
                spName = "SPlanCodeHelp";

                param = new SqlParameter[3];
                param[0] = new SqlParameter("@PlanNo", PlanNo);
                param[1] = new SqlParameter("@StartDate", StartDate);
                param[2] = new SqlParameter("@EndDate", EndDate);

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

        #region 프로그램 저장
        public DataSet SetPgm(string workingTag, string pgmSeq, string pgmID, string pgmName)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SProgramSave";

                param = new SqlParameter[4];
                param[0] = new SqlParameter("@WorkingTag", workingTag);
                param[1] = new SqlParameter("@PgmSeq", pgmSeq);
                param[2] = new SqlParameter("@PgmID", pgmID);
                param[3] = new SqlParameter("@PgmName", pgmName);





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

        #region 프로그램 조회
        public DataSet GetPgm(string pgmId, string pgmName)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SProgramListQry";

                param = new SqlParameter[2];
                param[0] = new SqlParameter("@PgmID", pgmId);
                param[1] = new SqlParameter("@PgmName", pgmName);

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

        #region 공정 저장
        public DataSet SetProc(string workingTag, string procSeq, string procID, string procName)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SProcSave";

                param = new SqlParameter[4];
                param[0] = new SqlParameter("@WorkingTag", workingTag);
                param[1] = new SqlParameter("@ProcSeq", procSeq);
                param[2] = new SqlParameter("@ProcID", procID);
                param[3] = new SqlParameter("@ProcName", procName);





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

        #region 공정 조회
        public DataSet Getproc(string procId, string procName)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SProcListQry";

                param = new SqlParameter[2];
                param[0] = new SqlParameter("@ProcID", procId);
                param[1] = new SqlParameter("@ProcName", procName);


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

        #region BOM 조회
        public DataSet GetBom(string bomName)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SBomListQry";

                param = new SqlParameter[1];
                param[0] = new SqlParameter("@ItemNo", bomName);




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

        #region Proc Combo 조회        
        public DataSet GetProcCombo()
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            //SqlParameter[] param = null;
            try
            {
                spName = "SProcComboQry";

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

        #region MatOut 조회        
        public DataSet GetMatOut(string From, string To, string ItemNo, string LOTID)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SMatOutQry";

                param = new SqlParameter[4];
                param[0] = new SqlParameter("@From", From);
                param[1] = new SqlParameter("@To", To);
                param[2] = new SqlParameter("@ItemNo", ItemNo);
                param[3] = new SqlParameter("@LOTID", LOTID);

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

        #region MatOut 저장     
        public DataSet SetMatOut(string workingTag, string OutSeq, string ItemSeq, string LOTID, string Qty, string OutDate, string OutClss)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SMatOutSave";

                param = new SqlParameter[7];
                param[0] = new SqlParameter("@WorkingTag", workingTag);
                param[1] = new SqlParameter("@OutSeq", OutSeq);
                param[2] = new SqlParameter("@ItemSeq", ItemSeq);
                param[3] = new SqlParameter("@LOTID", LOTID);
                param[4] = new SqlParameter("@Qty", Qty);
                param[5] = new SqlParameter("@OutDate", OutDate);
                param[6] = new SqlParameter("@OutClss", OutClss);




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

        #region OutClss Combo 조회        
        public DataSet GetOutClssCombo()
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            //SqlParameter[] param = null;
            try
            {
                spName = "SOutClssComboQry";

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

        #region Auth 조회        
        public DataSet GetAuth(string GroupName)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SAuthorityListQry";

                param = new SqlParameter[1];
                param[0] = new SqlParameter("@GroupName", GroupName);

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

        #region Auth 저장     
        public DataSet SetAuth(string workingTag, string GroupSeq, string PgmSeq)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SAuthoritySave";

                param = new SqlParameter[3];
                param[0] = new SqlParameter("@WorkingTag", workingTag);
                param[1] = new SqlParameter("@GroupSeq", GroupSeq);
                param[2] = new SqlParameter("@PgmSeq", PgmSeq);


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

        #region PGM Combo 조회        
        public DataSet GetPGMCombo()
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            //SqlParameter[] param = null;
            try
            {
                spName = "SPGMComboQry";

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

        #region ItemProc 조회        
        public DataSet GetItemProc(string itemNo)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SItemProcQry";

                param = new SqlParameter[1];
                param[0] = new SqlParameter("@ItemNo", itemNo);

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

        #region Item 조회        
        public DataSet GetItem(string itemNo)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SItemQry";

                param = new SqlParameter[1];
                param[0] = new SqlParameter("@ItemNo", itemNo);

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

        #region Item 연동        
        public DataSet GetItemLink()
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SItemSync";


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


        #region Mach 조회        
        public DataSet GetMach(string MachID, string MachName)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SMachQry";

                param = new SqlParameter[2];
                param[0] = new SqlParameter("@MachID", MachID);
                param[1] = new SqlParameter("@MachName", MachName);

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

        #region Mach 저장     
        public DataSet SetMach(string workingTag, string MachSeq, string MachID, string MachName, string ProcSeq)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SMachSave";

                param = new SqlParameter[5];
                param[0] = new SqlParameter("@WorkingTag", workingTag);
                param[1] = new SqlParameter("@MachSeq", MachSeq);
                param[2] = new SqlParameter("@MachID", MachID);
                param[3] = new SqlParameter("@MachName", MachName);
                param[4] = new SqlParameter("@ProcSeq", ProcSeq);




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

        #region ItemProc 저장     
        public DataSet SetItemProc(string workingTag, string itemSeq, string procSeq, string seq, string preSeq, string isLast)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SItemProcSave";

                param = new SqlParameter[6];
                param[0] = new SqlParameter("@WorkingTag", workingTag);
                param[1] = new SqlParameter("@ItemSeq", itemSeq);
                param[2] = new SqlParameter("@ProcSeq", procSeq);
                param[3] = new SqlParameter("@Seq", seq);
                param[4] = new SqlParameter("@PreSeq", preSeq);
                param[5] = new SqlParameter("@IsLast", isLast);




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


        #region BOM 연동
        public DataSet GetSync()
        {
            DataSet dsResult = null;

            string spName = string.Empty;

            try
            {
                spName = "SBOMSync";

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


        public DataSet GetOrder(string startDate, string endDate,string itemNo,string proSeq,string wo)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SWoOrder2";

                param = new SqlParameter[4];
                param[0] = new SqlParameter("@From", startDate);
                param[1] = new SqlParameter("@To", endDate);
                param[2] = new SqlParameter("@ItemNo", itemNo);
                param[3] = new SqlParameter("@ProSeq", proSeq);
                param[4] = new SqlParameter("Wo", wo);


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

        public DataSet GetPlan(string planno, string startDate, string endDate)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SPlanListQry";

                param = new SqlParameter[3];
                param[0] = new SqlParameter("@ItemNo", planno);
                param[1] = new SqlParameter("@StartDate", startDate);
                param[2] = new SqlParameter("@EndDate", endDate);

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

        public DataSet GetProcList(string itemSeq)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SProcIdQry";

                param = new SqlParameter[1];
                param[0] = new SqlParameter("@ItemSeq", itemSeq);

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

        public DataSet SetPlan(string workingTag, string planSeq, string planNo, string itemSeq, string qty, string startDate, string endDate, string procSeq, string remark)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SPlanSave";

                param = new SqlParameter[8];
                param[0] = new SqlParameter("@WorkingTag", workingTag);
                param[1] = new SqlParameter("@PlanSeq", planSeq);
                param[2] = new SqlParameter("@PlanNo", planNo);
                param[3] = new SqlParameter("@ItemSeq", itemSeq);
                param[4] = new SqlParameter("@Qty", qty);
                param[5] = new SqlParameter("@StartDate", startDate);
                param[6] = new SqlParameter("@EndDate", endDate);
                param[7] = new SqlParameter("@Remark", remark);





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


        #region 차트 테스트       
        public DataSet GetTest()
        {
            DataSet dsResult = null;

            string spName = string.Empty;
           // SqlParameter[] param = null;
            try
            {
                spName = "TESTChart";

                //param = new SqlParameter[2];
               // param[0] = new SqlParameter("@MachID", MachID);
                //param[1] = new SqlParameter("@MachName", MachName);

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


    }
}
