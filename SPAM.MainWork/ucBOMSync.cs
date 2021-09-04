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
    public partial class ucBOMSync : UserControl
    {
        public ucBOMSync()
        {
            InitializeComponent();
            InitControl();
            SetFpSpread();
        }
        #region Control 초기화
        private void InitControl()
        {
            BaseDisplay.AdminBtn(btnSearch, BaseDisplay.BtnType.Search);
          
            BaseDisplay.SetLabelStyle(lblBomNameQ, BaseDisplay.LabelType.Menu);

            //BaseDisplay.SetLabelStyle(lblPassword, BaseDisplay.LabelType.Item);

        }

        #region FpSpread 설정
        private void SetFpSpread()
        {

            ParamPack param = new ParamPack();


            param.Add(FpSpread.SetSheetColumns("제품품번", "ItemSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("제공품번", "ItemNo", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("자재품번", "MatItemSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("공정명", "ProcName", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 80, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("소요량", "NeedQty", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 80, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("연동일자", "RegDate", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 80, Color.White, true, true, FpSpread.FpSort.False, 1, null));


            FpSpread.FpSpreadFrame(this.fpSpread1);
            FpSpread.SetSheetColumn(this.fpSpread1.Sheets[0], param, 1);
        }


        #endregion
        #endregion
        private void Search()
        {

            DataSet ds = null;
            string pgmId = txtBomQ.Text;

            fpSpread1.Sheets[0].Rows.Count = 0;
            try
            {



                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetBom(pgmId);
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
        private void Sync()
        {
            
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            Sync();
        }
    }
}
