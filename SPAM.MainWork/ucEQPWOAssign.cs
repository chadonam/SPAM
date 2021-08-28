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
            BaseDisplay.AdminBtn(btnSearch, BaseDisplay.BtnType.Search);
            BaseDisplay.AdminBtn(btnDel, BaseDisplay.BtnType.Delete);
            BaseDisplay.AdminBtn(btnSave, BaseDisplay.BtnType.Save);
            //BaseDisplay.AdminBtn(btnNew, BaseDisplay.BtnType.Etc);
            //BaseDisplay.AdminTxt(txtItemNo, BaseDisplay.TxtType.CodeHelp);



            BaseDisplay.SetLabelStyle(lblDateQ, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblItemNo, BaseDisplay.LabelType.Menu);

            BaseDisplay.SetLabelStyle(lblProc, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblWo, BaseDisplay.LabelType.Menu);

          
        }
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
            param.Add(FpSpread.SetSheetColumns("공정", "ProcSeq", FpSpread.FpCellType.DateTime, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("지시사항", "Remark", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 80, Color.White, true, true, FpSpread.FpSort.False, 1, null));


            param2.Add(FpSpread.SetSheetColumns("설비ID", "MachID", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param2.Add(FpSpread.SetSheetColumns("설비명", "MachName", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param2.Add(FpSpread.SetSheetColumns("WO번호", "OrderNo", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));





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
            string proc = cmbProc.Text;
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
                    ds = svc.GetOrder(itemNo, startDate, endDate,proc,wo);
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
        private void Search2()
        {


            DataSet ds = null;
            string itemNo = txtItemNo.Text;
            string wo = txtWo.Text;
            string proc = cmbProc.Text;
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
                    ds = svc.GetOrder(itemNo, startDate, endDate, proc, wo);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
