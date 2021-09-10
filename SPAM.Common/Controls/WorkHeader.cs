using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SPAM.Common.Controls
{
    public partial class WorkHeader : UserControl
    {
        public WorkHeader()
        {
            InitializeComponent();
        }

        public void SetMachCombo(string ProcSeq)
        {
            SetCombo_Mach(ProcSeq);
        }

        #region 설비Combo 처리
        private void SetCombo_Mach(string ProcSeq)
        {

            DataSet ds = null;
            try
            {



                ds = this.GetMachCombo(ProcSeq);

                if (ds != null)
                {
                    Utils.SetComboBox(cmbMach, ds.Tables[0], "ItemNm", "ItemCd", "설비선택");
                    cmbMach.SelectedIndex = 0;


                }

            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }
        }
        #endregion

        #region Mach 콤보 조회        
        public DataSet GetMachCombo(string ProcSeq)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SMachComboQry";

                param = new SqlParameter[1];
                param[0] = new SqlParameter("@ProcSeq", ProcSeq);

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

        #region 설비 선택 Event
        private void cmbMach_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = null;
            //string MachSeq = cmbMach.SelectedValue.ToString();
            string MachSeq = "10";
            if (cmbMach.SelectedIndex > 0)
            {
                ds = this.GetAssyWo(MachSeq, ClientGlobal.UserSeq.ToString());

                if (ds != null)
                {
                    txtItemNo.Text = ds.Tables[0].Rows[0]["ItemNo"].ToString();
                    txtProcID.Text = ds.Tables[0].Rows[0]["ProcID"].ToString();
                    txtWO.Text = ds.Tables[0].Rows[0]["OrderNo"].ToString();
                    txtWoker.Text = ds.Tables[0].Rows[0]["UserID"].ToString();
                    txtOK.Text = ds.Tables[0].Rows[0]["OKQty"].ToString();
                    txtNG.Text = ds.Tables[0].Rows[0]["BadQty"].ToString();
                    txtRemark.Text = ds.Tables[0].Rows[0]["Remark"].ToString();
                }
            }

        }
        #endregion

        #region WO정보조회
        public DataSet GetAssyWo(string MachSeq, string UserSeq)
        {
            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SMachAssignWOQry";

                param = new SqlParameter[2];
                param[0] = new SqlParameter("@MachSeq", MachSeq);
                param[1] = new SqlParameter("@UserSeq", UserSeq);

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
