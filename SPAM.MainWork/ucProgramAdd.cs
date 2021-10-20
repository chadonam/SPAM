using SPAM.Common;
using SPAM.Manage;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;

namespace SPAM.MainWork
{
    public partial class ucProgramAdd : UserControl
    {
        public ucProgramAdd()
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
            BaseDisplay.AdminBtn(btnSave, BaseDisplay.BtnType.Save);
            BaseDisplay.AdminBtn(btnDel, BaseDisplay.BtnType.Delete);
            BaseDisplay.AdminBtn(btnNew, BaseDisplay.BtnType.New);

            BaseDisplay.SetLabelStyle(lblPgmIDQ, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblPgmNameQ, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblPgmSeq, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblPgmID, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblPgmName, BaseDisplay.LabelType.Item);

            BaseDisplay.ChangeText(lblPgmIDQ);
            BaseDisplay.ChangeText(lblPgmNameQ);
            BaseDisplay.ChangeText(groupBox1);
            BaseDisplay.ChangeText(groupbox2);
            BaseDisplay.ChangeText(lblPgmSeq);
            BaseDisplay.ChangeText(lblPgmID);
            BaseDisplay.ChangeText(lblPgmName);




        }


        #region FpSpread 설정
        private void SetFpSpread()
        {
            ParamPack param = new ParamPack();


            param.Add(FpSpread.SetSheetColumns("프로그램코드", "PgmSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("프로그램ID", "PgmID", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("프로그램명", "PgmName", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 150, Color.White, true, true, FpSpread.FpSort.False, 1, null));




            FpSpread.FpSpreadFrame(this.fpSpread1);
            FpSpread.SetSheetColumn(this.fpSpread1.Sheets[0], param, 1);


        }
        #endregion

        #endregion


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

        #region Sheet Cell 클릭
        private void fpSpread1_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0)
            {
                return;
            }
            //SetSpreadRowColor(fpSpread1);
            //fpSpread1.Sheets[0].Rows[e.Row].BackColor = Color.FromKnownColor(KnownColor.Pink);
            txtPgmSeq.Text = fpSpread1.Sheets[0].Cells[e.Row, 0].Value.ToString();
            txtPgmID.Text = fpSpread1.Sheets[0].Cells[e.Row, 1].Value.ToString();
            txtPgmName.Text = fpSpread1.Sheets[0].Cells[e.Row, 2].Value.ToString();
            txtPgmID.ReadOnly = true;
        }
        #endregion

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
                string pgmID;
                string pgmSeq;
                string pgmName;


                pgmSeq = txtPgmSeq.Text;
                pgmName = txtPgmName.Text;
                pgmID = txtPgmID.Text;



                using (CommonService svc = new CommonService())
                {
                    ds = svc.SetPgm(WorkingTag, pgmSeq, pgmID, pgmName);
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
            string pgmId = txtPgmIDQ.Text;
            string pgmName = txtPgmNameQ.Text;

            fpSpread1.Sheets[0].Rows.Count = 0;
            try
            {



                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetPgm(pgmId, pgmName);
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

        #endregion

        #region 기타 메소드
        private void DefaultControl()
        {
            txtPgmSeq.Text = "0";
            txtPgmSeq.ReadOnly = true;
            txtPgmID.Text = string.Empty;
            txtPgmID.ReadOnly = false;
            txtPgmName.Text = string.Empty;
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

    }
}
