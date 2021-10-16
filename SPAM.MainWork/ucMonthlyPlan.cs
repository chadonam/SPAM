using SPAM.Common;
using SPAM.Manage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPAM.MainWork
{
    public partial class ucMonthlyPlan : UserControl
    {
        public ucMonthlyPlan()
        {
            InitializeComponent();
            InitControl();
            SetFpSpread();
        }

        #region 초기화
        private void InitControl()
        {
            BaseDisplay.AdminBtn(btnSearch, BaseDisplay.BtnType.Search);
            BaseDisplay.AdminBtn(btnDel, BaseDisplay.BtnType.Delete);
            BaseDisplay.AdminBtn(btnSave, BaseDisplay.BtnType.Save);
            BaseDisplay.AdminBtn(btnNew, BaseDisplay.BtnType.Etc);
            BaseDisplay.AdminTxt(txtItemNo, BaseDisplay.TxtType.CodeHelp);



            BaseDisplay.SetLabelStyle(lblDateQ, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblProNameQ, BaseDisplay.LabelType.Menu);

            BaseDisplay.SetLabelStyle(lblPlanSeq, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblPlanID, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblPgmName, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblStartD, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblEndD, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(label4, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(label5, BaseDisplay.LabelType.Item);

            txtPlanSeq.Text = "0";
            txtPlanSeq.ReadOnly = true;

            txtProcSeq.Text = "";
            txtProcSeq.ReadOnly = true;

        }
        #endregion

        #region SetSpread
        private void SetFpSpread()
        {
            ParamPack param = new ParamPack();


            param.Add(FpSpread.SetSheetColumns("번호", "PlanSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("계획번호", "PlanNo", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("제품품번", "ItemNo", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("제품내부코드", "ItemSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, false, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("수량", "Qty", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 80, Color.White, true, true, FpSpread.FpSort.False, 1, null));

            param.Add(FpSpread.SetSheetColumns("시작일자", "StartDate", FpSpread.FpCellType.DateTime, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("종료일자", "EndDate", FpSpread.FpCellType.DateTime, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("공정순서", "ProcList", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 80, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("비고", "Remark", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 80, Color.White, true, true, FpSpread.FpSort.False, 1, null));




            FpSpread.FpSpreadFrame(this.fpSpread1);
            FpSpread.SetSheetColumn(this.fpSpread1.Sheets[0], param, 1);


        }
        #endregion

        #region 조회
        private void Search()
        {


            DataSet ds = null;
            string itemNo = txtPlanNameQ.Text;
            string startDate = date.ValueStartDate.ToString();
            string endDate = date.ValueEndDate.ToString();

            //MessageBox.Show(startDate);
            //MessageBox.Show(endDate);

            //return;

            fpSpread1.Sheets[0].Rows.Count = 0;
            try
            {



                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetPlan(itemNo, startDate, endDate);
                }

                if (ds != null)
                {
                    //fpSpread1.Sheets[0].DataSource = ds;
                    FpSpread.SetSheetDataBind(this.fpSpread1.Sheets[0], ds.Tables[0]);


                }


            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }
        }

        private void Search2(string itemSeq)
        {
            DataSet ds = null;
            try
            {



                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetProcList(itemSeq);
                }

                if (ds != null)
                {
                    //fpSpread1.Sheets[0].DataSource = ds;
                    //FpSpread.SetSheetDataBind(this.fpSpread1.Sheets[0], ds.Tables[0]);
                    txtProcSeq.Text = ds.Tables[0].Rows[0]["ProcNoList"].ToString();


                }


            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }
        }
        #endregion

        #region 신규
        private void DefaultControl()
        {
            txtPlanSeq.Text = "0";
            txtPlanSeq.ReadOnly = true;
            txtPlanID.Text = string.Empty;
            txtProcSeq.Text = string.Empty;
            txtItemNo.Text = string.Empty;
            txtItemSeq.Text = string.Empty;
            txtProcSeq.Text = string.Empty;
            txtProcSeq.ReadOnly = true;

            dtp_StartDate.Text = string.Empty;
            dtp_EndDate.Text = string.Empty;
            txtQuan.Text = string.Empty;
            txtNote.Text = string.Empty;

            //SetSpreadRowColor(fpSpread1);
        }
        #endregion      

        #region KeyDown이벤트
        private void txtItemNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ItemNameSearch();
                Search2(txtItemSeq.Text);
            }
        }
        #endregion

        #region ItemNameSearch
        private void ItemNameSearch()
        {
            SPAM.CommonUI.Popup.frmItemCdQry frm = new CommonUI.Popup.frmItemCdQry("");
            frm.StartPosition = FormStartPosition.CenterScreen;

            if (frm.ShowDialog() == DialogResult.Yes)
            {
                txtItemNo.Text = frm.ItemNo;
                txtItemSeq.Text = frm.ItemSeq;
            }

        }
        #endregion

        #region 저장
        private void Save(string WorkingTag)
        {
            int status;
            string result;
            DataSet ds = null;


            try
            {
                string planNo;
                string itemSeq;
                string startDate;
                string endDate;
                string procSeq;
                string remark;
                string planSeq;
                string qty;

                planSeq = txtPlanSeq.Text;
                planNo = txtPlanID.Text;
                itemSeq = txtItemSeq.Text;
                startDate = dtp_StartDate.Text.Trim().Replace("-", string.Empty);
                endDate = dtp_EndDate.Text.Trim().Replace("-", string.Empty);
                procSeq = txtProcSeq.Text;
                remark = txtNote.Text;
                qty = txtQuan.Text;


                using (CommonService svc = new CommonService())
                {
                    ds = svc.SetPlan(WorkingTag, planSeq, planNo, itemSeq, qty, startDate, endDate, procSeq, remark);
                }


                if (ds != null)
                {
                    status = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                    result = ds.Tables[0].Rows[0][1].ToString();
                    if (status == 0)
                    {
                        MessageHandler.DisplayMessage(result, Common.Controls.MessageType.Warning);
                    }
                    else
                    {
                        MessageHandler.DisplayMessage("저장되었습니다.", Common.Controls.MessageType.Warning);
                    }
                }




            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }

        }
        #endregion        

        #region fpSpread 클릭
        private void fpSpread1_CellClick_1(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0)
            {
                return;
            }
            //SetSpreadRowColor(fpSpread1);
            //fpSpread1.Sheets[0].Rows[e.Row].BackColor = Color.FromKnownColor(KnownColor.Pink);


            txtPlanSeq.Text = fpSpread1.Sheets[0].Cells[e.Row, 0].Value.ToString();
            txtPlanID.Text = fpSpread1.Sheets[0].Cells[e.Row, 1].Value.ToString();
            txtItemNo.Text = fpSpread1.Sheets[0].Cells[e.Row, 2].Value.ToString();
            txtItemSeq.Text = fpSpread1.Sheets[0].Cells[e.Row, 3].Value.ToString();
            txtQuan.Text = fpSpread1.Sheets[0].Cells[e.Row, 4].Value.ToString();
            dtp_StartDate.Text = fpSpread1.Sheets[0].Cells[e.Row, 5].Value.ToString();
            dtp_EndDate.Text = fpSpread1.Sheets[0].Cells[e.Row, 6].Value.ToString();
            txtProcSeq.Text = fpSpread1.Sheets[0].Cells[e.Row, 7].Value.ToString();
            txtNote.Text = fpSpread1.Sheets[0].Cells[e.Row, 8].Value.ToString();

            txtPlanSeq.ReadOnly = true;
            txtProcSeq.ReadOnly = true;
        }
        #endregion

        #region 조회 클릭
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        #endregion

        #region 신규 클릭
        private void btnNew_Click(object sender, EventArgs e)
        {
            DefaultControl();
        }
        #endregion

        #region 저장버튼 클릭
        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            Save("A");
            btnSave.Enabled = true;
            DefaultControl();
            Search();
        }
        #endregion

        #region 삭제버튼
        private void btnDel_Click(object sender, EventArgs e)
        {
            btnDel.Enabled = false;
            Save("D");
            btnDel.Enabled = true;
            DefaultControl();
            Search();
        }
        #endregion


    }
}
