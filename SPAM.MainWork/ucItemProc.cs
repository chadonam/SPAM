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
    public partial class ucItemProc : UserControl
    {
        public ucItemProc()
        {
            InitializeComponent();
            InitControl();
            SetFpSpread();
        }

        private void InitControl()
        {
            BaseDisplay.AdminBtn(btnSearch, BaseDisplay.BtnType.Search);
            BaseDisplay.AdminBtn(btnDel, BaseDisplay.BtnType.Delete);
            BaseDisplay.AdminBtn(btnSave, BaseDisplay.BtnType.Save);
            BaseDisplay.AdminBtn(btnEtc, BaseDisplay.BtnType.Etc);

            BaseDisplay.SetLabelStyle(lblItemProcNoQ, BaseDisplay.LabelType.Menu);

            BaseDisplay.AdminTxt(txtItemNoQ, BaseDisplay.TxtType.CodeHelp);

        }

        #region FpSpread 설정
        private void SetFpSpread()
        {

            ParamPack proc = new ParamPack();

            using (CommonService svc = new CommonService())
            {

                DataTable dt1 = svc.GetProcCombo().Tables[0];
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    proc.Add(dt1.Rows[i]["ItemNm"].ToString(), dt1.Rows[i]["ItemCd"].ToString());
                }
            }

            ParamPack param = new ParamPack();


            param.Add(FpSpread.SetSheetColumns("품목내부코드", "ItemSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("품목번호", "ItemNo", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("품목명", "ItemName", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("공정", "ProcSeq", FpSpread.FpCellType.ComboBox, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, false, FpSpread.FpSort.False, 1, proc));
            param.Add(FpSpread.SetSheetColumns("순번", "Seq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("이전공정", "PreSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("최종공정여부", "IsLast", FpSpread.FpCellType.CheckBox, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, false, FpSpread.FpSort.False, 1, null));


            FpSpread.FpSpreadFrame(this.fpSpread1);
            FpSpread.SetSheetColumn(this.fpSpread1.Sheets[0], param, 1);


        }
        #endregion

        #region 조회

        private void Search()
        {

            DataSet ds = null;
            string itemNo = txtItemNoQ.Text;

            fpSpread1.Sheets[0].Rows.Count = 0;
            try
            {



                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetItemProc(itemNo);
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

        private void btnEtc_Click(object sender, EventArgs e)
        {
            string itemNo,itemSeq,itemName;
            //itemNo = txtItemNoQ.Text;
            itemNo = "LLAOU00002";
            itemName = "LABEL CARTON LGD";
            itemSeq = "28280";

            AddSpread(itemNo, itemName, itemSeq);



        }

        private void AddSpread(string itemNo,string itemName, string itemSeq)
        {
            int rowCnt = fpSpread1.Sheets[0].Rows.Count;
            fpSpread1.Sheets[0].Rows.Count = rowCnt + 1;
            fpSpread1.Sheets[0].Cells[rowCnt, 0].Value = itemSeq;
            fpSpread1.Sheets[0].Cells[rowCnt, 1].Value = itemNo;
            fpSpread1.Sheets[0].Cells[rowCnt, 2].Value = itemName;



        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void ItemNameSearch()
        {
            SPAM.CommonUI.Popup.frmItemCdQry frm = new CommonUI.Popup.frmItemCdQry(txtItemNoQ.Text);
            frm.StartPosition = FormStartPosition.CenterScreen;

            if (frm.ShowDialog() == DialogResult.Yes)
            {
                txtItemNoQ.Text = frm.ItemNo;
                txtItemSeqQ.Text = frm.ItemSeq;
            }

        }

        private void txtItemNoQ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ItemNameSearch();
            }
        }
    }
}
