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
    public partial class ucAuthAdd : UserControl
    {
        public ucAuthAdd()
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

            BaseDisplay.SetLabelStyle(lblAuthGroupQ, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblAuthGroup, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblAuthProgram, BaseDisplay.LabelType.Item);

            SetCombo_Group();
            SetCombo_Pgm();

            BaseDisplay.ChangeText(lblAuthGroupQ);
            BaseDisplay.ChangeText(groupBox1);
            BaseDisplay.ChangeText(txtAuthSeq);
            BaseDisplay.ChangeText(lblAuthGroup);
            BaseDisplay.ChangeText(lblAuthProgram);
            BaseDisplay.ChangeText(btnSearch);




        }

        #region Group Combo 처리
        private void SetCombo_Group()
        {

            DataSet ds = null;
            try
            {


                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetGroupCombo();
                }

                if (ds != null)
                {
                    string GroupSelect = Utils.GetLanguage("그룹선택");
                    Utils.SetComboBox(cmbGroup, ds.Tables[0], "ItemNm", "ItemCd", GroupSelect);
                    cmbGroup.SelectedIndex = 0;


                }

            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }
        }

        private void SetCombo_Pgm()
        {

            DataSet ds = null;
            try
            {


                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetPGMCombo();
                }

                if (ds != null)
                {
                    string ProgramSelect = Utils.GetLanguage("프로그램선택");
                    Utils.SetComboBox(cmbProgram, ds.Tables[0], "ItemNm", "ItemCd", ProgramSelect);
                    cmbProgram.SelectedIndex = 0;


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
            ParamPack group = new ParamPack();
            ParamPack pgm = new ParamPack();

            using (CommonService svc = new CommonService())
            {
                DataTable dt1 = svc.GetGroupCombo().Tables[0];
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    group.Add(dt1.Rows[i]["ItemNm"].ToString(), dt1.Rows[i]["ItemCd"].ToString());
                }

                DataTable dt2 = svc.GetPGMCombo().Tables[0];
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    pgm.Add(dt2.Rows[i]["ItemNm"].ToString(), dt2.Rows[i]["ItemCd"].ToString());
                }
            }

            ParamPack param = new ParamPack();


            param.Add(FpSpread.SetSheetColumns("그룹명", "GroupSeq", FpSpread.FpCellType.ComboBox, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, group));
            param.Add(FpSpread.SetSheetColumns("프로그램명", "PgmSeq", FpSpread.FpCellType.ComboBox, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, pgm));




            FpSpread.FpSpreadFrame(this.fpSpread1);
            FpSpread.SetSheetColumn(this.fpSpread1.Sheets[0], param, 1);


        }
        #endregion

        #endregion

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

        #region 조회버튼 Click
        private void btnQry_Click(object sender, EventArgs e)
        {
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

        #region Data처리 

        #region 저장

        private void Save(string WorkingTag)
        {
            int status;
            string result;
            DataSet ds = null;


            try
            {
                string GroupSeq;
                string PgmSeq;

                GroupSeq = cmbGroup.SelectedValue.ToString();
                PgmSeq = cmbProgram.SelectedValue.ToString();


                using (CommonService svc = new CommonService())
                {
                    ds = svc.SetAuth(WorkingTag, GroupSeq, PgmSeq);
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
            string GroupName = txtAuthGroupQ.Text;

            fpSpread1.Sheets[0].Rows.Count = 0;

            try
            {



                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetAuth(GroupName);
                }

                if (ds != null)
                {
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
            cmbGroup.Text = string.Empty;
            cmbProgram.Text = string.Empty;
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

        private void fpSpread1_CellClick_1(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0)
            {
                return;
            }

            cmbGroup.SelectedValue = fpSpread1.Sheets[0].Cells[e.Row, 0].Value.ToString();
            cmbProgram.SelectedValue = fpSpread1.Sheets[0].Cells[e.Row, 1].Value.ToString();
        }


        private void ucAuthAdd_Load(object sender, EventArgs e)
        {

        }

        private void txtUserSeq_Enter(object sender, EventArgs e)
        {

        }

    }
}
