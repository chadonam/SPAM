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
    public partial class ucEQPWOAssign : UserControl
    {
        public ucEQPWOAssign()
        {
            InitializeComponent();
            InitControl();
            SetFpSpread();
        }


        #region 초기화
        private void InitControl()
        {
            
            //BaseDisplay.AdminBtn(btnNew, BaseDisplay.BtnType.Etc);
            //BaseDisplay.AdminTxt(txtItemNo, BaseDisplay.TxtType.CodeHelp);



            BaseDisplay.SetLabelStyle(lblDateQ, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblItemNo, BaseDisplay.LabelType.Menu);

            BaseDisplay.SetLabelStyle(lblProc, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblWo, BaseDisplay.LabelType.Menu);
            BaseDisplay.ChangeText(lblDateQ);
            BaseDisplay.ChangeText(lblItemNo);
            BaseDisplay.ChangeText(lblProc);
            BaseDisplay.ChangeText(lblWo);
            BaseDisplay.ChangeText(groupBox1);
            BaseDisplay.ChangeText(groupBox2);
            BaseDisplay.ChangeText(btnSave);
            BaseDisplay.ChangeText(btnDel);
            BaseDisplay.ChangeText(btnSearch);

            SetCombo_Proc();
        }


        #region Proc Combo 처리
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
                    string ProcSelect = Utils.GetLanguage("공정선택");
                    Utils.SetComboBox(cmbProc, ds.Tables[0], "ItemNm", "ItemCd", ProcSelect);
                    cmbProc.SelectedIndex = 0;


                }

            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }
        }
        #endregion
        #endregion

        #region SetSpread

        private void SetFpSpread()
        {
            ParamPack param = new ParamPack();
            ParamPack param2 = new ParamPack();

            param.Add(FpSpread.SetSheetColumns("Wo내부코드", "OrderSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("계획번호", "PlanSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("WO번호", "OrderNo", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("제품품번", "ItemSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("WO수량", "Qty", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 80, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("작업일자", "WorkDate", FpSpread.FpCellType.DateTime, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("공정내부코드", "ProcSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, false, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("공정ID", "ProcID", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("지시사항", "Remark", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 80, Color.White, true, true, FpSpread.FpSort.False, 1, null));


            param2.Add(FpSpread.SetSheetColumns("설비ID", "MachID", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param2.Add(FpSpread.SetSheetColumns("설비명", "MachName", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param2.Add(FpSpread.SetSheetColumns("WO번호", "OrderNo", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param2.Add(FpSpread.SetSheetColumns("설비코드", "MachSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, false, true, FpSpread.FpSort.False, 1, null));





            FpSpread.FpSpreadFrame(this.fpSpread1);
            FpSpread.SetSheetColumn(this.fpSpread1.Sheets[0], param, 1);

            FpSpread.FpSpreadFrame(this.fpSpread2);
            FpSpread.SetSheetColumn(this.fpSpread2.Sheets[0], param2, 1);




        }
        #endregion

        #region 조회
        private void Search()
        {


            DataSet ds = null;
            string itemNo = txtItemNo.Text;
            string wo = txtWo.Text;
            string proc = cmbProc.SelectedValue.ToString();
            string startDate = date.ValueStartDate.ToString();
            string endDate = date.ValueEndDate.ToString();

            if(proc=="")
            {
                proc = "0";
            }

            //MessageBox.Show(startDate);
            //MessageBox.Show(endDate);

            //return;

            fpSpread1.Sheets[0].Rows.Count = 0;
            try
            {



                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetOrder(startDate, endDate,itemNo,proc,wo);
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
        private void Search2(string procSeq)
        {


            DataSet ds = null;
            
         
            //MessageBox.Show(startDate);
            //MessageBox.Show(endDate);

            //return;

            fpSpread2.Sheets[0].Rows.Count = 0;
            try
            {

                

                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetOrder2(procSeq);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
            
        }

        private void fpSpread1_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0)
            {
                return;
            }
            //SetSpreadRowColor(fpSpread1);
            //fpSpread1.Sheets[0].Rows[e.Row].BackColor = Color.FromKnownColor(KnownColor.Pink);


           string procSeq = fpSpread1.Sheets[0].Cells[e.Row, 6].Value.ToString();

            Search2(procSeq);
        }

        private void Save(string orderSeq, string machSeq)
        {
            int status;
            string result;
            DataSet ds = null;

            try
            {
                

                using (CommonService svc = new CommonService())
                {
                    ds = svc.SetWo(orderSeq,machSeq);
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
                        MessageHandler.DisplayMessage("배정되었습니다.", Common.Controls.MessageType.Warning);
                    }
                }




            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string orderSeq = fpSpread1.Sheets[0].Cells[fpSpread1.Sheets[0].ActiveRow.Index, 0].Value.ToString();
            string machSeq = fpSpread2.Sheets[0].Cells[fpSpread2.Sheets[0].ActiveRow.Index, 3].Value.ToString();

            Save(orderSeq, machSeq);
            Search();
        }

        private void MachDel(string orderSeq, string machSeq)
        {
            int status;
            string result;
            DataSet ds = null;

            try
            {


                using (CommonService svc = new CommonService())
                {
                    ds = svc.DelMach(orderSeq, machSeq);
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
                        MessageHandler.DisplayMessage("배정취소 되었습니다.", Common.Controls.MessageType.Warning);
                    }
                }




            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string orderSeq = fpSpread1.Sheets[0].Cells[fpSpread1.Sheets[0].ActiveRow.Index, 0].Value.ToString();
            string machSeq = fpSpread1.Sheets[0].Cells[fpSpread2.Sheets[0].ActiveRow.Index, 3].Value.ToString();

            MachDel(orderSeq, machSeq);
        }
    }
}
