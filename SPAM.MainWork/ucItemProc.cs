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

            BaseDisplay.ChangeText(lblItemProcNoQ);
            BaseDisplay.ChangeText(groupbox2);

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

            param.Add(FpSpread.SetSheetColumns("Sel", "Sel", FpSpread.FpCellType.Number, FontStyle.Regular, FpSpread.FpAlignment.Left, 150, Color.White, false, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("품목내부코드", "ItemSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 150, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("품목번호", "ItemNo", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 200, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("품목명", "ItemName", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("공정", "ProcSeq", FpSpread.FpCellType.ComboBox, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, false, FpSpread.FpSort.False, 1, proc));
            param.Add(FpSpread.SetSheetColumns("순번", "Seq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("이전공정", "PreSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("최종공정여부", "IsLast", FpSpread.FpCellType.CheckBox, FontStyle.Regular, FpSpread.FpAlignment.Center, 200, Color.White, true, false, FpSpread.FpSort.False, 1, null));


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

        #region 저장

        private void Save(string WorkingTag, int lngRow)
        {
            int status;
            string result;
            DataSet ds = null;


            try
            {
                string itemSeq;
                string procSeq;
                string seq;
                string isLast;
                string preSeq;


                itemSeq = fpSpread1.Sheets[0].Cells[lngRow, 1].Value.ToString();
                procSeq = fpSpread1.Sheets[0].Cells[lngRow, 4].Value.ToString();
                seq = fpSpread1.Sheets[0].Cells[lngRow, 5].Text.ToString();
                preSeq = fpSpread1.Sheets[0].Cells[lngRow, 6].Value.ToString();
                isLast = fpSpread1.Sheets[0].Cells[lngRow, 7].Text.ToString();


                try
                {

                    if (fpSpread1.Sheets[0].Cells[lngRow, 7].Value.ToString().Equals("True"))
                    {
                        isLast = "1";
                    }
                    else
                    {
                        isLast = "0";
                    }
                }
                catch(Exception eex)
                {
                    isLast = "0";
                }


                using (CommonService svc = new CommonService())
                {
                    ds = svc.SetItemProc(WorkingTag, itemSeq, procSeq, seq, preSeq, isLast);
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
                        if (WorkingTag == "A")
                        {
                            MessageHandler.DisplayMessage("저장되었습니다.", Common.Controls.MessageType.Warning);
                        }
                        else if (WorkingTag == "D")
                        {
                            MessageHandler.DisplayMessage("삭제되었습니다.", Common.Controls.MessageType.Warning);
                        }
                    }

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
            int maxRow = fpSpread1.Sheets[0].Rows.Count;
            string seq = "0";
            

            if(maxRow!=0)
            {
                string sSeq = fpSpread1.Sheets[0].Cells[maxRow - 1,5].Value.ToString();
                int iSeq = Int32.Parse(sSeq);
                iSeq++;
                seq = iSeq.ToString();
                

            }
            else
            {
                seq = "1";
                
            }


            itemNo = txtItemNoQ.Text;
            itemName = txtItemNameQ.Text;
            itemSeq = txtItemSeqQ.Text;

            AddSpread(itemNo, itemName, itemSeq, seq);




        }

        private void AddSpread(string itemNo,string itemName, string itemSeq,string seq)
        {
            int rowCnt = fpSpread1.Sheets[0].Rows.Count;
            fpSpread1.Sheets[0].Rows.Count = rowCnt + 1;
            fpSpread1.Sheets[0].Cells[rowCnt, 0].Value = 0;
            fpSpread1.Sheets[0].Cells[rowCnt, 1].Value = itemSeq;
            fpSpread1.Sheets[0].Cells[rowCnt, 2].Value = itemNo;
            fpSpread1.Sheets[0].Cells[rowCnt, 3].Value = itemName;
            fpSpread1.Sheets[0].Cells[rowCnt, 5].Value = seq;
            fpSpread1.Sheets[0].Cells[rowCnt, 6].Value = (Int32.Parse(seq) - 1).ToString();



        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int lngRow = fpSpread1.Sheets[0].ActiveRow.Index;
            Save("D", lngRow);
            /*string itemSeq = fpSpread1.Sheets[0].Cells[lngRow, 1].ToString();
            string ProcSeq = fpSpread1.Sheets[0].Cells[lngRow, 4].ToString();*/
            
            Search();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            foreach (FarPoint.Win.Spread.Row lngRow in fpSpread1.Sheets[0].Rows)
            {
                 string A = fpSpread1.Sheets[0].Cells[lngRow.Index, 0].Text.ToString();
                if ( A == "0")
                {
                    Save("A", lngRow.Index);
                    A = "1";
                }
            }
            
            Search();
        }

        #region 기타 메소드


        

        #endregion

        private void ItemNameSearch()
        {
            SPAM.CommonUI.Popup.frmItemCdQry frm = new CommonUI.Popup.frmItemCdQry(txtItemNoQ.Text);
            frm.StartPosition = FormStartPosition.CenterScreen;

            if (frm.ShowDialog() == DialogResult.Yes)
            {
                txtItemNoQ.Text = frm.ItemNo;
                txtItemSeqQ.Text = frm.ItemSeq;
                txtItemNameQ.Text = frm.ItemName;
            }
            //SPAM.CommonUI.Popup.frmMonthlyPlan frm = new CommonUI.Popup.frmMonthlyPlan(txtItemNoQ.Text);
            //frm.StartPosition = FormStartPosition.CenterScreen;

            //if (frm.ShowDialog() == DialogResult.Yes)
            //{
            //    txtItemNoQ.Text = frm.PlanSeq;
            //    //txtItemSeqQ.Text = frm.ItemSeq;
            //    txtItemNameQ.Text = frm.PlanNo;
            //}




            //if (!string.Empty.Equals(txtItemNoQ.Text))
            //{

            //}
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
