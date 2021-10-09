using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SPAM.Common.Controls
{
    public partial class WorkHeader : UserControl
    {

        public event StartClickHandler StartButtonClick;
        public delegate void StartClickHandler(object sender, EventArgs e);

        public event EndClickHandler EndButtonClick;
        public delegate void EndClickHandler(object sender, EventArgs e);

        private string itemSeq;
        private string orderSeq;
        private string procSeq;
        

        public string ItemSeq { get => itemSeq; set => itemSeq = value; }
        public string OrderSeq { get => orderSeq; set => orderSeq = value; }
        public string ProcSeq { get => procSeq; set => procSeq = value; }

        public WorkHeader()
        {
            InitializeComponent();
            initControl();


        }

        private void WorkHeader_StartButtonClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void initControl()
        {
            BaseDisplay.AdminBtn(btnStart, BaseDisplay.BtnType.Etc);
            BaseDisplay.AdminBtn(btnEnd, BaseDisplay.BtnType.Etc);


            BaseDisplay.SetLabelStyle(lblMach, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblWO, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblItemNo, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblProcID, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblRemark, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lnlWoker, BaseDisplay.LabelType.Menu);

            btnEnd.Visible = false;

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
            string MachSeq = cmbMach.SelectedValue.ToString();
            if (cmbMach.SelectedIndex > 0)
            {
                try {
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

                        itemSeq = ds.Tables[0].Rows[0]["ItemSeq"].ToString();
                        orderSeq = ds.Tables[0].Rows[0]["orderSeq"].ToString();
                        procSeq = ds.Tables[0].Rows[0]["procSeq"].ToString();

                    }
                 }
                catch (Exception ex)
                {
                    MessageHandler.DisplayMessage("설비가 배정되지 않았습니다.", Common.Controls.MessageType.Warning);

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

        private void btnEnd_Click(object sender, EventArgs e)
        {
            btnStart.Visible = true;
            btnEnd.Visible = false;

            if (this.EndButtonClick != null)
            {
                this.EndButtonClick(sender, e);
            }

        }

       private void btnStart_Click(object sender, EventArgs e)
        {

            if(cmbMach.SelectedIndex <= 0)
            {
                MessageHandler.DisplayMessage("설비를 선택해야 합니다.", Common.Controls.MessageType.Warning);
                return;
            }

            btnEnd.Visible = true;
            btnStart.Visible = false;

            if (this.StartButtonClick != null)
            {
                this.StartButtonClick(sender, e);
            }
        }

        public string ValueOfMachSeq
        {
            get { return cmbMach.SelectedValue.ToString(); }
        }
    }

}
