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
    public partial class ucLotHistoryQry : UserControl
    {
        public ucLotHistoryQry()
        {
            InitializeComponent();
            InitControl();
            SetFpSpread();
        }

        private void InitControl()
        {
            BaseDisplay.AdminBtn(btnSearch, BaseDisplay.BtnType.Search);
          
            BaseDisplay.SetLabelStyle(lblLotIDQ, BaseDisplay.LabelType.Menu);

            //BaseDisplay.AdminTxt(txtLotIDQ, BaseDisplay.TxtType.CodeHelp);

        }

        #region FpSpread 설정
        private void SetFpSpread()
        {

            ParamPack param = new ParamPack();

            param.Add(FpSpread.SetSheetColumns("LOTID", "LOTID", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 150, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("공정", "ProcID", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 200, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("설비", "MachID", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("판정", "Judge", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("수량", "Qty", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("제품번호", "ItemNO", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("계획번호", "PlanNo", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 200, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("WO번호", "OrderNo", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 200, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("등록일시", "RegDate", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 200, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("이벤트", "Event", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 200, Color.White, true, true, FpSpread.FpSort.False, 1, null));


            FpSpread.FpSpreadFrame(this.fpSpread1);
            FpSpread.SetSheetColumn(this.fpSpread1.Sheets[0], param, 1);


        }
        #endregion

        private void Search()
        {
            
            DataSet ds = null;
            string lotId = txtLotIDQ.Text;

            if (string.Empty.Equals(lotId))
            {
                MessageHandler.DisplayMessage("LOTID를 입력해주세요.", Common.Controls.MessageType.Warning);
                return;
            }

            fpSpread1.Sheets[0].Rows.Count = 0;
            try
            {
               
                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetHistory(lotId);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
