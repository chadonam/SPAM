﻿using SPAM.Common;
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
    public partial class ucProcStockQry : UserControl
    {
        public ucProcStockQry()
        {
            InitializeComponent();
            InitControl();
            SetCombo_Proc();
            SetFpSpread();
            SetFpSpread2();
        }

        #region 조회

        private void Search()
        {

            DataSet ds = null;
            string ItemNo = txtItemNo.Text;
            string PlanNo = txtPlanNo.Text;
            string Proc = cmbProc.SelectedValue.ToString();


            if (Proc == "")
            {
                Proc = "0";
            }

            fpSpread1.Sheets[0].Rows.Count = 0;
            try
            {

                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetProcStockQry(ItemNo, PlanNo, Proc);

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

        #region 조회2

        private void Search2()
        {

            DataSet ds = null;
            string PlanSeq = fpSpread1.Sheets[0].Cells[fpSpread1.Sheets[0].ActiveRow.Index, 5].Value.ToString();
            string ItemSeq = fpSpread1.Sheets[0].Cells[fpSpread1.Sheets[0].ActiveRow.Index, 6].Value.ToString();
            string WorkDate = fpSpread1.Sheets[0].Cells[fpSpread1.Sheets[0].ActiveRow.Index, 2].Value.ToString();
            string ProcSeq = fpSpread1.Sheets[0].Cells[fpSpread1.Sheets[0].ActiveRow.Index, 3].Value.ToString();
            

            if (ProcSeq == "")
            {
                ProcSeq = "0";
            }

            fpSpread2.Sheets[0].Rows.Count = 0;
            try
            {

                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetLOTHISTORY(ItemSeq, PlanSeq, ProcSeq, WorkDate);

                }

                if (ds != null)
                {
                    //fpSpread1.Sheets[0].DataSource = ds;
                    FpSpread.SetSheetDataBind(this.fpSpread2.Sheets[0], ds.Tables[0]);


                }


            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }

        }

#endregion

        #region 콤보

        private void SetCombo_Proc()
        {

            DataSet ds = null;
            try
            {

                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetProcCombo();
                }

                if (ds != null)
                {

                        Utils.SetComboBox(cmbProc, ds.Tables[0], "ItemNm", "ItemCd", "공정선택");
                        cmbProc.SelectedIndex = 0;
                   }



            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }
        }

        #endregion


        #region 조회버튼 Click
        private void btnQry_Click(object sender, EventArgs e)
        {
            Search();
        }
        #endregion

        #region Control 초기화
        private void InitControl()
        {
            BaseDisplay.AdminBtn(btnSearch, BaseDisplay.BtnType.Search);       

            /*BaseDisplay.AdminTxt(txtWOID, BaseDisplay.TxtType.CodeHelp);
            BaseDisplay.AdminTxt(txtPlanNo, BaseDisplay.TxtType.CodeHelp);
            BaseDisplay.AdminTxt(txtItemNo, BaseDisplay.TxtType.CodeHelp);

            BaseDisplay.SetLabelStyle(lblOrderSeq, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblPlanSeq, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblProcSeq, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblQty, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblRemark, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblWorkDate, BaseDisplay.LabelType.Item);*/
        }
        #endregion

        #region FpSpread 설정
        private void SetFpSpread()
        {
            ParamPack param = new ParamPack();

            param.Add(FpSpread.SetSheetColumns("계획번호", "PlanNo", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 100, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("제품품번", "ItemNo", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 100, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("작업일자", "WorkDate", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 150, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("공정", "ProcSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 100, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("공정ID", "ProcID", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 100, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("계획내부번호", "PlanSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 150, Color.White, true, false, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("제품내부번호", "ItemSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 150, Color.White, true, false, FpSpread.FpSort.False, 1, null));
           



            FpSpread.FpSpreadFrame(this.fpSpread1);
            FpSpread.SetSheetColumn(this.fpSpread1.Sheets[0], param, 1);
        }
        #endregion

        #region 스프레드 추가
        //PlanSeq ItemSeq Date Proc Qty
        private void AddSpread(string PlanNo, string ItemNo, string WorkDate, string ProcSeq, string ProdQty)
        {
            int rowCnt = fpSpread1.Sheets[0].Rows.Count;
            fpSpread1.Sheets[0].Rows.Count = rowCnt + 1;
            fpSpread1.Sheets[0].Cells[rowCnt, 0].Value = PlanNo;
            fpSpread1.Sheets[0].Cells[rowCnt, 1].Value = ItemNo;
            fpSpread1.Sheets[0].Cells[rowCnt, 2].Value = WorkDate;
            fpSpread1.Sheets[0].Cells[rowCnt, 3].Value = ProcSeq;
            fpSpread1.Sheets[0].Cells[rowCnt, 4].Value = ProdQty;

        }
        #endregion

        #region FpSpread 설정2
        private void SetFpSpread2()
        {
            ParamPack param = new ParamPack();

            param.Add(FpSpread.SetSheetColumns("LOTID", "LOTID", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 100, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("판정", "Judge", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 100, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("작업일자", "WorkDate", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 150, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("공정", "ProcSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 100, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("생산수량", "Qty", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 100, Color.White, true, false, FpSpread.FpSort.False, 1, null));

            FpSpread.FpSpreadFrame(this.fpSpread2);
            FpSpread.SetSheetColumn(this.fpSpread2.Sheets[0], param, 1);
        }
        #endregion

        #region 스프레드 추가2
        //PlanSeq ItemSeq Date Proc Qty
        private void AddSpread2(string LOTID, string Judge, string WorkDate, string ProcSeq, string Qty)
        {
            int rowCnt = fpSpread1.Sheets[0].Rows.Count;
            fpSpread1.Sheets[0].Rows.Count = rowCnt + 1;
            fpSpread1.Sheets[0].Cells[rowCnt, 0].Value = LOTID;
            fpSpread1.Sheets[0].Cells[rowCnt, 1].Value = Judge;
            fpSpread1.Sheets[0].Cells[rowCnt, 2].Value = WorkDate;
            fpSpread1.Sheets[0].Cells[rowCnt, 3].Value = ProcSeq;
            fpSpread1.Sheets[0].Cells[rowCnt, 4].Value = Qty;

        }
        #endregion

        private void fpSpread1_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            Search2();
        }
    }
}