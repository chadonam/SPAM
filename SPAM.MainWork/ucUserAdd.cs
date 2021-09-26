using SPAM.Common;
using SPAM.Manage;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;

namespace SPAM.MainWork
{
    public partial class ucUserAdd : UserControl
    {
        public ucUserAdd()
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

            BaseDisplay.SetLabelStyle(lblUserIDQ, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblUserSeq, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblUserID, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblPassword, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblGroupSeq, BaseDisplay.LabelType.Item);



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
                    Utils.SetComboBox(cmbGroup, ds.Tables[0], "ItemNm", "ItemCd", "그룹선택");
                    cmbGroup.SelectedIndex = 0;


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

            using (CommonService svc = new CommonService())
            {
                DataTable dt1 = svc.GetGroupCombo().Tables[0];
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    group.Add(dt1.Rows[i]["ItemNm"].ToString(), dt1.Rows[i]["ItemCd"].ToString());
                }
            }

            ParamPack param = new ParamPack();

            
            param.Add(FpSpread.SetSheetColumns("사용자내부코드", "UserSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("사용자ID", "UserID", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("패스워드", "Password", FpSpread.FpCellType.Password, FontStyle.Regular, FpSpread.FpAlignment.Center, 80, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("그룹", "GroupSeq", FpSpread.FpCellType.ComboBox, FontStyle.Regular, FpSpread.FpAlignment.Right, 120, Color.White, true, false, FpSpread.FpSort.False, 1, group));



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
            if(e.Row < 0)
            {
                return;
            }
            //SetSpreadRowColor(fpSpread1);
            //fpSpread1.Sheets[0].Rows[e.Row].BackColor = Color.FromKnownColor(KnownColor.Pink);
            txtUserSeq.Text = fpSpread1.Sheets[0].Cells[e.Row, 0].Value.ToString();
            txtUserID.Text = fpSpread1.Sheets[0].Cells[e.Row, 1].Value.ToString();
            txtPassword.Text = fpSpread1.Sheets[0].Cells[e.Row, 2].Value.ToString();
            cmbGroup.SelectedValue = fpSpread1.Sheets[0].Cells[e.Row, 3].Value.ToString();
            txtUserID.ReadOnly = true;
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
                string userID;
                string userSeq;
                string password;
                string groupSeq;

                userSeq = txtUserSeq.Text;
                userID = txtUserID.Text;
                password = txtPassword.Text;
                groupSeq = cmbGroup.SelectedValue.ToString();


                using (CommonService svc = new CommonService())
                {
                    ds = svc.SetUser(WorkingTag,userSeq,userID,password,groupSeq);
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
            string userID = txtUserIDQ.Text;

            fpSpread1.Sheets[0].Rows.Count = 0;
            try
            {



                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetUser(userID);
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
            txtUserSeq.Text = "0";
            txtUserSeq.ReadOnly = true;
            txtUserID.Text = string.Empty;
            txtUserID.ReadOnly = false;
            txtPassword.Text = string.Empty;
            SetCombo_Group();
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

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
