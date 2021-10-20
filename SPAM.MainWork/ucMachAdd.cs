using SPAM.Common;
using SPAM.Manage;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;

namespace SPAM.MainWork
{
    public partial class ucMachAdd : UserControl
    {
        public ucMachAdd()
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

            BaseDisplay.SetLabelStyle(lblMachIDQ, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblMachNameQ, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblMachSeq, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblMachID, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblMachName, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblProcSeq, BaseDisplay.LabelType.Item);

            BaseDisplay.ChangeText(lblMachIDQ);
            BaseDisplay.ChangeText(lblMachNameQ);
            BaseDisplay.ChangeText(groupBox1);
            BaseDisplay.ChangeText(lblMachSeq);
            BaseDisplay.ChangeText(lblMachID);
            BaseDisplay.ChangeText(lblMachName);
            BaseDisplay.ChangeText(lblProcSeq);
            BaseDisplay.ChangeText(groupbox2);



        }

        #region Proc Combo 처리
        private void SetCombo_Proc()
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
                    Utils.SetComboBox(cmbProc, ds.Tables[0], "ItemNm", "ItemCd", ProcSelect);
                    cmbProc.SelectedIndex = 0;


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

            
            param.Add(FpSpread.SetSheetColumns("설비내부코드", "MachSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("설비ID", "MachID", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("설비명", "MachName", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 180, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("공정", "ProcSeq", FpSpread.FpCellType.ComboBox, FontStyle.Regular, FpSpread.FpAlignment.Right, 180, Color.White, true, false, FpSpread.FpSort.False, 1, Proc));



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
            txtMachSeq.Text = fpSpread1.Sheets[0].Cells[e.Row, 0].Value.ToString();
            txtMachID.Text = fpSpread1.Sheets[0].Cells[e.Row, 1].Value.ToString();
            txtMachName.Text = fpSpread1.Sheets[0].Cells[e.Row, 2].Value.ToString();
            cmbProc.SelectedValue = fpSpread1.Sheets[0].Cells[e.Row, 3].Value.ToString();
            txtMachID.ReadOnly = true;
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
                string MachSeq;
                string MachID;
                string MachName;
                string ProcSeq;

                MachSeq = txtMachSeq.Text;
                MachID = txtMachID.Text;
                MachName = txtMachName.Text;
                ProcSeq = cmbProc.SelectedValue.ToString();


                using (CommonService svc = new CommonService())
                {
                    ds = svc.SetMach(WorkingTag,MachSeq,MachID,MachName,ProcSeq);
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
            string MachID = txtMachIDQ.Text;
            string MachName = txtMachNameQ.Text;

            fpSpread1.Sheets[0].Rows.Count = 0;
            try
            {



                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetMach(MachID, MachName);
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
            txtMachSeq.Text = "0";
            txtMachSeq.ReadOnly = true;
            txtMachID.Text = string.Empty;
            txtMachID.ReadOnly = false;
            txtMachName.Text = string.Empty;
            SetCombo_Proc();
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
