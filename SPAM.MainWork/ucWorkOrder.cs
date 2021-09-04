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
    public partial class ucWorkOrder : UserControl
    {
        public ucWorkOrder()
        {
            InitializeComponent();
            InitControl();
            DefaultControl();
            SetFpSpread();
        }

        #region Action

        #region 신규버튼클릭
        private void btnNew_Click(object sender, EventArgs e)
        {
            DefaultControl();


        }
        #endregion

        #region 저장버튼 Click
        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            Save("A");
            btnSave.Enabled = true;
            DefaultControl();
            Search();

        }
        #endregion

        #region 삭제버튼 Click
        private void btnDel_Click(object sender, EventArgs e)
        {
            btnDel.Enabled = false;
            Save("D");
            btnDel.Enabled = true;
            DefaultControl();
            Search();
        }
        #endregion

        #region 조회버튼 Click
        private void btnQry_Click(object sender, EventArgs e)
        {
            Search();
        }
        #endregion

        #endregion

        #region Control 초기화
        private void InitControl()
        {
            BaseDisplay.AdminBtn(btnSearch, BaseDisplay.BtnType.Search);
            BaseDisplay.AdminBtn(btnSave, BaseDisplay.BtnType.Save);
            BaseDisplay.AdminBtn(btnDel, BaseDisplay.BtnType.Delete);
            BaseDisplay.AdminBtn(btnNew, BaseDisplay.BtnType.New);

            BaseDisplay.AdminTxt(txtItemNoQ, BaseDisplay.TxtType.CodeHelp);
            BaseDisplay.AdminTxt(txtPlanNo, BaseDisplay.TxtType.CodeHelp);
            BaseDisplay.AdminTxt(txtItemNo, BaseDisplay.TxtType.CodeHelp);

            BaseDisplay.SetLabelStyle(lblOrderSeq, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblPlanSeq, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblProcSeq, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblQty, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblRemark, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblWorkDate, BaseDisplay.LabelType.Item);
        }
        #endregion

        #region FpSpread 설정
        private void SetFpSpread()
        {


            ParamPack param = new ParamPack();


            param.Add(FpSpread.SetSheetColumns("계획번호", "PlanSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 100, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("WO번호", "OrderSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 100, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("제품내부코드", "ItemSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 150, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("제품품번", "ItemNo", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 100, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("WO수량", "Qty", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 100, Color.White, true, false, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("작업일자", "WorkDate", FpSpread.FpCellType.DateTime, FontStyle.Regular, FpSpread.FpAlignment.Left, 150, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("공정", "ProcSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 100, Color.White, false, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("공정ID", "ProcID", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 100, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("지시사항", "Remark", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));

            FpSpread.FpSpreadFrame(this.fpSpread1);
            FpSpread.SetSheetColumn(this.fpSpread1.Sheets[0], param, 1);


        }
        #endregion

        #region 스프레드 추가
        private void AddSpread(string PlanSeq, string OrderSeq, string ItemSeq, string Qty, string WorkDate, string ProcSeq, string Remark)
        {
            int rowCnt = fpSpread1.Sheets[0].Rows.Count;
            fpSpread1.Sheets[0].Rows.Count = rowCnt + 1;
            fpSpread1.Sheets[0].Cells[rowCnt, 0].Value = PlanSeq;
            fpSpread1.Sheets[0].Cells[rowCnt, 1].Value = OrderSeq;
            fpSpread1.Sheets[0].Cells[rowCnt, 2].Value = ItemSeq;
            fpSpread1.Sheets[0].Cells[rowCnt, 3].Value = Qty;
            fpSpread1.Sheets[0].Cells[rowCnt, 4].Value = WorkDate;
            fpSpread1.Sheets[0].Cells[rowCnt, 5].Value = ProcSeq;
            fpSpread1.Sheets[0].Cells[rowCnt, 6].Value = Remark;

        }
        #endregion

        #region Sheet Cell 클릭
        private void fpSpread1_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0)
            {
                return;
            }
            //SetSpreadRowColor(fpSpread1);
            //fpSpread1.Sheets[0].Rows[e.Row].BackColor = Color.FromKnownColor(KnownColor.Pink);
            txtPlanNo.Text = fpSpread1.Sheets[0].Cells[e.Row, 0].Value.ToString();
            txtOrderSeq.Text = fpSpread1.Sheets[0].Cells[e.Row, 1].Value.ToString();
            txtItemNo.Text = fpSpread1.Sheets[0].Cells[e.Row, 2].Value.ToString();
            txtQty.Text = fpSpread1.Sheets[0].Cells[e.Row, 3].Value.ToString();
            //txtWorkDate.Text = fpSpread1.Sheets[0].Cells[e.Row, 4].Value.ToString();
            cmbItemProc.Text = fpSpread1.Sheets[0].Cells[e.Row, 5].Value.ToString();
            txtRemark.Text = fpSpread1.Sheets[0].Cells[e.Row, 6].Value.ToString();
        }
        #endregion

        #region Data처리 

        #region 저장

        private void Save(string WorkingTag)
        {
            int status;
            string result;
            DataSet ds = null;


            try
            {
                string OrderSeq;
                string PlanSeq;
                string ItemSeq;
                string OrderNo;
                string ProcSeq;
                string WorkDate;
                string Qty;
                string Remark;

                OrderSeq = txtOrderSeq.Text;
                PlanSeq = txtPlanNo.Text;
                ItemSeq = txtItemSeq.Text;
                OrderNo = txtOrderNo.Text;
                ProcSeq = cmbItemProc.SelectedValue.ToString();
                WorkDate = dateTimePicker1.Text.Trim().Replace("-", string.Empty);
                Qty = txtQty.Text;
                Remark = txtRemark.Text;


                using (CommonService svc = new CommonService())
                {
                    ds = svc.SetWoOrder(WorkingTag, OrderSeq, PlanSeq, ItemSeq, OrderNo, ProcSeq, WorkDate, Qty, Remark);
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

        #region 조회

        private void Search()
        {

            DataSet ds = null;
            string ItemNo = txtItemNoQ.Text;
            string Proc = cmbProc.SelectedValue.ToString();
            string From = calendarDouble1.ValueStartDate.ToString();
            string To = calendarDouble1.ValueEndDate.ToString();

            if (Proc == "" )
            {
                Proc = "0";
            }

            fpSpread1.Sheets[0].Rows.Count = 0;
            try
            {

                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetWoOrder(From,To,ItemNo, Proc);

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

        #endregion

        #region 기타 메소드
        private void DefaultControl()
        {
            txtOrderSeq.Text = "0";
            txtOrderSeq.ReadOnly = true;
            txtPlanSeq.ReadOnly = true;
            txtItemSeq.ReadOnly = true;
            SetCombo_Proc(0);
            //txtWorkDate.Text = string.Empty;
            txtQty.Text = "0";
            txtRemark.Text = "";


            //SetSpreadRowColor(fpSpread1);
        }

        /*
        #region [색상 초기화]
        private void SetSpreadRowColor(FarPoint.Win.Spread.FpSpread fps)
        {
            for (int i = 0; i < fps.Sheets[0].Rows.Count; i++)
            {
                fps.Sheets[0].Rows[i].BackColor = Color.White;
                if (fps.Sheets[0].Rows[i].ForeColor != Color.Blue)
                {
                    fps.Sheets[0].Rows[i].ForeColor = Color.Black;
                }
            }
        }
        #endregion
        */

        private void SetCombo_Proc(int flag)
        {

            DataSet ds = null;
            try
            {
                string itemNo = "";

                if (flag == 0)
                {
                    itemNo = txtItemNoQ.Text;
                }
                else
                {
                    itemNo = txtItemNo.Text;
                }



                    using (CommonService svc = new CommonService())
                {
                    ds = svc.GetItemProcCombo(itemNo);
                }

                if (ds != null)
                {
                    if (flag == 0)
                    {
                        Utils.SetComboBox(cmbProc, ds.Tables[0], "ProcID", "ProcSeq", "공정선택");
                        cmbProc.SelectedIndex = 0;
                    }

                    else
                    {
                        Utils.SetComboBox(cmbItemProc, ds.Tables[0], "ProcID", "ProcSeq", "공정선택");
                        cmbItemProc.SelectedIndex = 0;
                    }


                }

            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }
        }



        #endregion



        #region 버튼클릭
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            DefaultControl();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            Save("A");
            btnSave.Enabled = true;
            DefaultControl();
            Search();
        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            btnDel.Enabled = false;
            Save("D");
            btnDel.Enabled = true;
            DefaultControl();
            Search();
        }
        #endregion

        private void ItemNameSearch()
        {
            SPAM.CommonUI.Popup.frmItemCdQry frm = new CommonUI.Popup.frmItemCdQry(txtItemNoQ.Text);
            frm.StartPosition = FormStartPosition.CenterScreen;

            if (frm.ShowDialog() == DialogResult.Yes)
            {
                txtItemNoQ.Text = frm.ItemNo;
                SetCombo_Proc(0);
                //txtItemSeqQ.Text = frm.ItemSeq;
            }

        }

        private void ItemNameSearch2()
        {
            SPAM.CommonUI.Popup.frmItemCdQry frm = new CommonUI.Popup.frmItemCdQry(txtItemNo.Text);
            frm.StartPosition = FormStartPosition.CenterScreen;

            if (frm.ShowDialog() == DialogResult.Yes)
            {
                txtItemNo.Text = frm.ItemNo;
                SetCombo_Proc(1);
                txtItemSeq.Text = frm.ItemSeq;
            }

        }

        private void PlanNoSearch()
        {
            SPAM.CommonUI.Popup.frmMonthlyPlan frm = new CommonUI.Popup.frmMonthlyPlan(txtPlanNo.Text);
            frm.StartPosition = FormStartPosition.CenterScreen;

            if (frm.ShowDialog() == DialogResult.Yes)
            {
                txtPlanNo.Text = frm.PlanNo;
                //SetCombo_Proc();
                txtPlanSeq.Text = frm.PlanSeq;
            }

        }

        private void txtItemNoQ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ItemNameSearch();
                txtItemNo.Text = txtItemNoQ.Text;
            }


        }

        private void txtItemSeq_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ItemNameSearch2();
            }
        }

        private void txtPlanSeq_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PlanNoSearch();
            }
        }

        private void fpSpread1_CellClick_1(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0)
            {
                return;
            }

            txtPlanNo.Text = fpSpread1.Sheets[0].Cells[e.Row, 0].Value.ToString();
            txtOrderNo.Text = fpSpread1.Sheets[0].Cells[e.Row, 1].Value.ToString();
            txtOrderSeq.Text = fpSpread1.Sheets[0].Cells[e.Row, 2].Value.ToString();
            txtItemNo.Text = fpSpread1.Sheets[0].Cells[e.Row, 3].Value.ToString();
            txtQty.Text = fpSpread1.Sheets[0].Cells[e.Row, 4].Value.ToString();
            dateTimePicker1.Text = fpSpread1.Sheets[0].Cells[e.Row, 5].Value.ToString();
            cmbItemProc.Text = fpSpread1.Sheets[0].Cells[e.Row, 7].Value.ToString();
            txtRemark.Text = fpSpread1.Sheets[0].Cells[e.Row, 8].Value.ToString();

        }
    }
}

#endregion
