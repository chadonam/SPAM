using SPAM.Common;
using SPAM.Manage;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;

namespace SPAM.MainWork
{
    public partial class ucWorkReportQry : UserControl
    {
        public ucWorkReportQry()
        {
            InitializeComponent();
            InitControl();
            DefaultControl();
            SetFpSpread();

        }

        #region Control 초기화
        private void InitControl()
        {
            BaseDisplay.AdminBtn(btnSearch, BaseDisplay.BtnType.Search);
            /*BaseDisplay.AdminBtn(btnSave, BaseDisplay.BtnType.Save);
            BaseDisplay.AdminBtn(btnDel, BaseDisplay.BtnType.Delete);
            BaseDisplay.AdminBtn(btnNew, BaseDisplay.BtnType.New);*/

            BaseDisplay.AdminTxt(txtItemSeqQ, BaseDisplay.TxtType.CodeHelp);

            BaseDisplay.SetLabelStyle(lblWorkDateQ, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblItemSeqQ, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblProcSeqQ, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblOrderSeqQ, BaseDisplay.LabelType.Menu);
            /*BaseDisplay.SetLabelStyle(lblOutDate, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblOutClss, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblItemSeq, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblProcSeq, BaseDisplay.LabelType.Item);*/

            BaseDisplay.ChangeText(lblWorkDateQ);
            BaseDisplay.ChangeText(lblItemSeqQ);
            BaseDisplay.ChangeText(lblProcSeqQ);
            BaseDisplay.ChangeText(lblOrderSeqQ);
            BaseDisplay.ChangeText(groupbox2);
            BaseDisplay.ChangeText(groupBox1);
            



        }

        #region ProcSeq Combo 처리
        private void SetCombo_ProcSeq()
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
                    Utils.SetComboBox(cmbProcSeq, ds.Tables[0], "ItemNm", "ItemCd", ProcSelect);
                    cmbProcSeq.SelectedIndex = 0;


                }

            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }
        }

        #endregion

        #region FpSpread 설정
        private void SetFpSpread()
        {
            ParamPack Proc = new ParamPack();

            using (CommonService svc = new CommonService())
            {
                DataTable dt1 = svc.GetProcCombo().Tables[0];
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    Proc.Add(dt1.Rows[i]["ItemNm"].ToString(), dt1.Rows[i]["ItemCd"].ToString());
                }
            }

            ParamPack param = new ParamPack();

            param.Add(FpSpread.SetSheetColumns("번호", "WorkReportSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, false, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("계획번호", "PlanNo", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("계획내부코드", "PlanSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, false, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("WO번호", "OrderNo", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("WO내부코드", "OrderSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, false, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("제품품번", "ItemNo", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("제품품번내부코드", "ItemSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, false, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("작업일자", "WorkDate", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 80, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("공정", "ProcSeq", FpSpread.FpCellType.ComboBox, FontStyle.Regular, FpSpread.FpAlignment.Right, 120, Color.White, true, false, FpSpread.FpSort.False, 1, Proc));
            param.Add(FpSpread.SetSheetColumns("설비명", "MachName", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("설비ID", "MachID", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("설비내부코드", "MachSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Right, 120, Color.White, false, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("생산수량", "ProdQty", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("양품수량", "OKQty", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("불량수량", "BadQty", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("작업자내부코드", "UserSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, false, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("작업자", "ID", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));


            FpSpread.FpSpreadFrame(this.fpSpread1);
            FpSpread.SetSheetColumn(this.fpSpread1.Sheets[0], param, 1);


        }
        #endregion

        #endregion


        #region Action

        /*#region 신규버튼클릭
        private void btnNew_Click(object sender, EventArgs e)
        {
            DefaultControl();


        }
        #endregion*/

        /*#region 저장버튼 Click
        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            Save("A");
            btnSave.Enabled = true;
            DefaultControl();
            Search();

        }
        #endregion*/

        /*#region 삭제버튼 Click
        private void btnDel_Click(object sender, EventArgs e)
        {
            btnDel.Enabled = false;
            Save("D");
            btnDel.Enabled = true;
            DefaultControl();
            Search();
        }
        #endregion*/

        #region 조회버튼 Click
        private void btnQry_Click(object sender, EventArgs e)
        {
            Search();
        }
        #endregion

        /*#region Sheet Cell 클릭
        private void fpSpread1_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            try
            {
                if (e.Row < 0)
                {
                    return;
                }
                //SetSpreadRowColor(fpSpread1);
                //fpSpread1.Sheets[0].Rows[e.Row].BackColor = Color.FromKnownColor(KnownColor.Pink);
                *//*txtWorkReportSeq.Text = fpSpread1.Sheets[0].Cells[e.Row, 0].Value.ToString();
                txtItemNo.Text = fpSpread1.Sheets[0].Cells[e.Row, 1].Value.ToString();
                txtOutDate.Text = fpSpread1.Sheets[0].Cells[e.Row, 5].Value.ToString();
                txtItemSeq.Text = fpSpread1.Sheets[0].Cells[e.Row, 2].Value.ToString();
                txtLOTID.Text = fpSpread1.Sheets[0].Cells[e.Row, 3].Value.ToString();
                txtQty.Text = fpSpread1.Sheets[0].Cells[e.Row, 4].Value.ToString();
                cmbOutClss.SelectedValue = fpSpread1.Sheets[0].Cells[e.Row, 6].Value.ToString();*//*
                cmbProcSeq.SelectedValue = fpSpread1.Sheets[0].Cells[e.Row, 5].Value.ToString();
            }
            catch(Exception ex)
            {
                return;
            }
            //txtReq.ReadOnly = true;
        }
        #endregion*/

        #endregion

        #region Data처리

        /*#region 저장

        private void Save(string WorkingTag)
        {
            int status;
            string result;
            DataSet ds = null;


            try
            {
                string OutSeq;
                string ItemSeq;
                string LOTID;
                string Qty;
                string OutDate;
                string OutClss;

                OutSeq = txtOutSeq.Text;
                ItemSeq = txtItemSeq.Text;
                LOTID = txtLOTID.Text;
                Qty = txtQty.Text;
                OutDate = txtOutDate.Text.Trim().Replace("-",string.Empty);
                OutClss = cmbOutClss.SelectedValue.ToString();


                using (CommonService svc = new CommonService())
                {
                    ds = svc.SetMatOut(WorkingTag,OutSeq,ItemSeq,LOTID,Qty,OutDate,OutClss);
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

        #endregion*/

        #region 조회

        private void Search()
        {

            DataSet ds = null;
            string From = calWorkDate.ValueStartDate.ToString();
            string To = calWorkDate.ValueEndDate.ToString();
            string ProcSeq = cmbProcSeq.SelectedIndex.ToString();
            string ItemNo = txtItemSeqQ.Text;
            string OrderNo = txtOrderNoQ.Text;

            fpSpread1.Sheets[0].Rows.Count = 0;
            try
            {



                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetWorkReportQry(From, To, ProcSeq, ItemNo, OrderNo);
                }

                if (ds != null)
                {
                    //fpSpread1.Sheets[0].DataSource = ds;
                    FpSpread.SetSheetDataBind(this.fpSpread1.Sheets[0], ds.Tables[0]);
                    CreateChart();

                }


            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }

        }

        private void CreateChart()
        {

            chart1.Series.Clear();
            chart1.Series.Add("Series1");
            chart1.Titles.Clear();
            chart1.Titles.Add("일자별 누적 생산수량");
            chart1.Series["Series1"].LegendText = "생산수량";   // 차트 이름을 "수학"으로 설정
            chart1.Series["Series1"].ChartType = SeriesChartType.Column; // 그래프를 라인으로 출력

            DataSet ds = null;
            string From = calWorkDate.ValueStartDate.ToString();
            string To = calWorkDate.ValueEndDate.ToString();

            using (CommonService svc = new CommonService())
            {
                ds = svc.GetProcChart(From, To);
            }

            if (ds != null)
            {

                chart1.DataSource = ds;
                chart1.Series["Series1"].XValueMember = "WorkDate";
                chart1.Series["Series1"].YValueMembers = "ProdQty";

            }

        }

        /*private void Search2(string ProcSeq)
        {

            DataSet ds = null;
            //ItemSeq = txtItemSeqQ.Text;


            fpSpread1.Sheets[0].Rows.Count = 0;
            try
            {



                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetProcCombo();
                }

                if (ds != null)
                {
                    txtItemSeqQ.Text = ds.Tables[0].Rows[0]["ProcSeq"].ToString();
                    *//*txtItemNo.Text = ds.Tables[0].Rows[0]["ItemName"].ToString();*//*
                    //txtItemName.Text = ds.Tables[0].Columns["ItemName"].ToString();
                    //fpSpread1.Sheets[0].DataSource = ds;
                    //FpSpread.SetSheetDataBind(this.fpSpread1.Sheets[0], ds.Tables[0]);


                }


            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }

        }*/

        #endregion

        #endregion

        #region 기타 메소드
        private void DefaultControl()
        {
            /*txtOutSeq.Text = "0";
            txtOutSeq.ReadOnly = true;
            txtReq.Text = string.Empty;
            txtReq.ReadOnly = false;
            txtItemNo.Text = string.Empty;*/
            SetCombo_ProcSeq();
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

        /*private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string bar = txtBarcode.Text;
                //String[] barcode = bar.Split(@"$");
                //search2()
            }
        }*/

        /*private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barCode = txtBarcode.Text;
                String[] bar = barCode.Split('$');
                txtLOTID.Text = bar[2].ToString();
                txtQty.Text = bar[3].ToString();
                string reqDate = "";
                reqDate = bar[1].Substring(0, 4) + "-" + bar[1].Substring(4, 2) + "-" + bar[1].Substring(6, 2);
                txtReq.Text = reqDate;
                txtItemNo.Text = bar[0].ToString();
                Search2(bar[0]);
            }

        }*/
        private void ItemNameSearch()
        {
            SPAM.CommonUI.Popup.frmItemCdQry frm = new CommonUI.Popup.frmItemCdQry(txtItemSeqQ.Text);
            frm.StartPosition = FormStartPosition.CenterScreen;

            if (frm.ShowDialog() == DialogResult.Yes)
            {
                txtItemSeqQ.Text = frm.ItemNo;
                /*txtItemSeq.Text = frm.ItemSeq;*/
            }

        }
        private void txtItemNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ItemNameSearch();
            }

        }

        private void Init_Proc()
        {



        }
    }
}
