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
    public partial class ucProcAdd : UserControl
    {
        public ucProcAdd()
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

            BaseDisplay.SetLabelStyle(lblProcIDQ, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblProcNameQ, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblProcSeq, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblProcID, BaseDisplay.LabelType.Item);
            BaseDisplay.SetLabelStyle(lblProcName, BaseDisplay.LabelType.Item);
            //BaseDisplay.SetLabelStyle(lblPassword, BaseDisplay.LabelType.Item);

            BaseDisplay.ChangeText(lblProcIDQ);
            BaseDisplay.ChangeText(lblProcNameQ);
            BaseDisplay.ChangeText(lblProcSeq);
            BaseDisplay.ChangeText(lblProcID);
            BaseDisplay.ChangeText(lblProcName);
            BaseDisplay.ChangeText(groupBox1);
            BaseDisplay.ChangeText(groupbox2);

        }
        #endregion

        #region FpSpread 설정
        private void SetFpSpread()
        {

            ParamPack param = new ParamPack();


            param.Add(FpSpread.SetSheetColumns("공정내부코드", "ProcSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("공정ID", "ProcID", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("공정명", "ProcName", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 80, Color.White, true, true, FpSpread.FpSort.False, 1, null));



            FpSpread.FpSpreadFrame(this.fpSpread1);
            FpSpread.SetSheetColumn(this.fpSpread1.Sheets[0], param, 1);


        }
        #endregion



        private void DefaultControl()
        {
            txtProcSeq.Text = "0";
            txtProcSeq.ReadOnly = true;
            txtProcID.Text = string.Empty;
            txtProcID.ReadOnly = false;
            txtProcName.Text = string.Empty;
            txtProcName.ReadOnly = false;
            //SetSpreadRowColor(fpSpread1);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DefaultControl();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            Save("A");
            btnSave.Enabled = true;
            DefaultControl();
            Search();
        }

        #region 조회
        private void Search()
        {

            DataSet ds = null;
            string procId = txtProcIDQ.Text;
            string procName = txtProcNameQ.Text;

            fpSpread1.Sheets[0].Rows.Count = 0;
            try
            {



                using (CommonService svc = new CommonService())
                {
                    ds = svc.Getproc(procId, procName);
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
        private void Save(string WorkingTag)
        {
            int status;
            string result;
            DataSet ds = null;


            try
            {
                string procID;
                string procSeq;
                string procName;

                procID = txtProcID.Text;
                procSeq = txtProcSeq.Text;
                procName = txtProcName.Text;
               



                using (CommonService svc = new CommonService())
                {
                    ds = svc.SetProc(WorkingTag, procSeq, procID, procName);
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
            #endregion
        }

        #region Sheet Cell 클릭
        private void fpSpread1_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
           
        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
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

        private void fpSpread1_CellClick_1(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0)
            {
                return;
            }
            //SetSpreadRowColor(fpSpread1);
            //fpSpread1.Sheets[0].Rows[e.Row].BackColor = Color.FromKnownColor(KnownColor.Pink);
            txtProcSeq.Text = fpSpread1.Sheets[0].Cells[e.Row, 0].Value.ToString();
            txtProcID.Text = fpSpread1.Sheets[0].Cells[e.Row, 1].Value.ToString();
            txtProcName.Text = fpSpread1.Sheets[0].Cells[e.Row, 2].Value.ToString();
            txtProcID.ReadOnly = true;
        }
    }

}
