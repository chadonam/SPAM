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
    public partial class ucMatIn : UserControl
    {
        public ucMatIn()
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

            BaseDisplay.SetLabelStyle(lblMatin, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblMatinName, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblMatinLOTID, BaseDisplay.LabelType.Menu);

            BaseDisplay.SetLabelStyle(lblCode, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblMatin1, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblMatinName1, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblDate, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblLotid1, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblMatinNum, BaseDisplay.LabelType.Item);

            BaseDisplay.ChangeText(lblMatin);
            BaseDisplay.ChangeText(lblMatinName);
            BaseDisplay.ChangeText(groupBox3);
            BaseDisplay.ChangeText(groupBox1);
            BaseDisplay.ChangeText(groupbox2);
            BaseDisplay.ChangeText(lblCode);
            BaseDisplay.ChangeText(lblMatin1);
            BaseDisplay.ChangeText(lblMatinName1);
            BaseDisplay.ChangeText(lblDate);
            BaseDisplay.ChangeText(lblLotid1);
            BaseDisplay.ChangeText(lblMatinNum);

        }
        #endregion

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


            param.Add(FpSpread.SetSheetColumns("입고내부코드", "InSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 150, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("자재번호", "ItemNo", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("LOTID", "LotID", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("수량", "Qty", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, false, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("의뢰일자", "InDate", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));

            FpSpread.FpSpreadFrame(this.fpSpread1);
            FpSpread.SetSheetColumn(this.fpSpread1.Sheets[0], param, 1);


        }
        #endregion

        #region 스프레드 추가
        private void AddSpread(string itemNo, string itemName, string itemSeq)
        {
            int rowCnt = fpSpread1.Sheets[0].Rows.Count;
            fpSpread1.Sheets[0].Rows.Count = rowCnt + 1;
            fpSpread1.Sheets[0].Cells[rowCnt, 0].Value = itemSeq;
            fpSpread1.Sheets[0].Cells[rowCnt, 1].Value = itemNo;
            fpSpread1.Sheets[0].Cells[rowCnt, 2].Value = itemName;

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
            txtMatin.Text = fpSpread1.Sheets[0].Cells[e.Row, 0].Value.ToString();
            txtItemName.Text = fpSpread1.Sheets[0].Cells[e.Row, 1].Value.ToString();
            txtLOTID.Text = fpSpread1.Sheets[0].Cells[e.Row, 2].Value.ToString();
            txtMatinNum.Text = fpSpread1.Sheets[0].Cells[e.Row, 3].Value.ToString();
            txtDate.Text = fpSpread1.Sheets[0].Cells[e.Row, 4].Value.ToString();
            txtLOTID.ReadOnly = true;
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
                string InSeq;
                string ItemSeq;
                string LOTID;
                string InDate;
                string Qty;
                
                InSeq = txtMatin.Text;
                ItemSeq = txtItemSeq.Text;
                LOTID = txtLOTID.Text;
                InDate = txtDate.Text;
                Qty = txtMatinNum.Text;


                using (CommonService svc = new CommonService())
                {
                    ds = svc.SetMatIn(WorkingTag, InSeq, ItemSeq, LOTID, InDate, Qty);
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
            string MatinName = txtMatinName.Text;
            string LOTID = txtMatinLOTID.Text;
            string From = calendarDouble1.ValueStartDate.ToString();
            string To = calendarDouble1.ValueEndDate.ToString();

            fpSpread1.Sheets[0].Rows.Count = 0;
            try
            {

                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetMatIn(MatinName, LOTID, From, To);
                    
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

        private void Search2(string itemNo)
        {

            DataSet ds = null;
            //string MatinName = txtMatinName.Text;
            //string LOTID = txtMatinLOTID.Text;

            fpSpread1.Sheets[0].Rows.Count = 0;
            try
            {

                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetItem(itemNo);

                }

                if (ds != null)
                {
                    //fpSpread1.Sheets[0].DataSource = ds;
                    //FpSpread.SetSheetDataBind(this.fpSpread1.Sheets[0], ds.Tables[0]);
                    txtItemName.Text = ds.Tables[0].Rows[0]["ItemName"].ToString();
                    txtItemSeq.Text = ds.Tables[0].Rows[0]["ItemSeq"].ToString();


                }


            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }

        }
        #endregion

        #endregion

        #region 기타 메소드
        private void DefaultControl()
        {
            txtMatin.Text = "0";
            txtMatin.ReadOnly = true;
            txtItemName.Text = string.Empty;
            txtItemName.ReadOnly = true;
            txtItemSeq.Text = "0";
            txtItemSeq.ReadOnly = true;
            txtDate.Text = string.Empty;
            txtDate.ReadOnly = true;
            txtLOTID.Text = string.Empty;
            txtLOTID.ReadOnly = true;
            txtMatinNum.Text = "0";
            txtMatinNum.ReadOnly = true;


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

        #region 엔터클릭

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

                string barCode = txtCode.Text;
                String[] bar = barCode.Split('$');
                txtDate.Text = bar[1].ToString();
                txtLOTID.Text = bar[2].ToString();
                txtMatinNum.Text = bar[3].ToString();

                Search2(bar[0]);


            };
        }

        #endregion
    }
}
