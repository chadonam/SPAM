using SPAM.Common;
using SPAM.Manage;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace SPAM.MainWork
{
    public partial class ucPOL : UserControl
    {
        public ucPOL()
        {
            InitializeComponent();

            InitControl();
            DefaultControl();
            SetFpSpread();

            workHeader1.StartButtonClick += WorkHeader1_StartButtonClick;
            workHeader1.EndButtonClick += WorkHeader1_EndButtonClick;
        }




        #region Control 초기화
        private void InitControl()
        {


            workHeader1.SetMachCombo("3");
            //BaseDisplay.AdminBtn(btnOK, BaseDisplay.BtnType.OK);
            //BaseDisplay.AdminBtn(btnNG, BaseDisplay.BtnType.NG);


            BaseDisplay.SetLabelStyle(lblID, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblBarcode, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblConsumableLot, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblMachStatus, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblWorkStatus, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblQuilStatus, BaseDisplay.LabelType.Menu);

            BaseDisplay.ChangeText(lblMachStatus);
            BaseDisplay.ChangeText(lblWorkStatus);
            BaseDisplay.ChangeText(lblQuilStatus);
            BaseDisplay.ChangeText(lblConsumableLot);

        }


        #region FpSpread 설정
        private void SetFpSpread()
        {
            ParamPack param = new ParamPack();
            ParamPack param1 = new ParamPack();
            ParamPack param2 = new ParamPack();


            param.Add(FpSpread.SetSheetColumns("원자재LOTID", "ConsumableLotID", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("품번", "ItemNo", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("투입수량", "QTy", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 80, Color.White, true, true, FpSpread.FpSort.False, 1, null));

            FpSpread.FpSpreadFrame(this.fpSpread1);
            FpSpread.SetSheetColumn(this.fpSpread1.Sheets[0], param, 1);

            param1.Add(FpSpread.SetSheetColumns("LOTID", "LotID", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param1.Add(FpSpread.SetSheetColumns("판정", "Judge", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 80, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param1.Add(FpSpread.SetSheetColumns("TIMEKEY", "Timekey", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 80, Color.White, true, true, FpSpread.FpSort.False, 1, null));

            FpSpread.FpSpreadFrame(this.fpSpread2);
            FpSpread.SetSheetColumn(this.fpSpread2.Sheets[0], param1, 1);

            param2.Add(FpSpread.SetSheetColumns("LOTID", "LotID", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 250, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param2.Add(FpSpread.SetSheetColumns("판정", "Judge", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 80, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param2.Add(FpSpread.SetSheetColumns("TIMEKEY", "Timekey", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 80, Color.White, true, true, FpSpread.FpSort.False, 1, null));

            FpSpread.FpSpreadFrame(this.fpSpread3);
            FpSpread.SetSheetColumn(this.fpSpread3.Sheets[0], param2, 1);




        }
        #endregion

        #endregion

        #region 기타 메소드
        private void DefaultControl()
        {
            //txtPgmSeq.Text = "0";
            //txtPgmSeq.ReadOnly = true;
            //txtPgmID.Text = string.Empty;
            //txtPgmID.ReadOnly = false;
            //txtPgmName.Text = string.Empty;
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

        #region 작업시작 및 종료
        private void WorkHeader1_EndButtonClick(object sender, EventArgs e)
        {
            txtBarcode.Enabled = true;
            WorkEnd();
            ChangePic(picMachStatus, "red");
            ChangePic(picQuilStatus, "red");
            ChangePic(picWorkStatus, "red");
        }

        private void WorkHeader1_StartButtonClick(object sender, EventArgs e)
        {
            txtBarcode.ReadOnly = false;
            ChangePic(picMachStatus, "green");
            ChangePic(picQuilStatus, "green");
            ChangePic(picWorkStatus, "yellow");

            WorkStart();
            Search();
            Search2("OK");
            Search2("NG");

            

        }

        #endregion

        #region 작업 그래프변경
        private void ChangePic(PictureBox p, string type)
        {
            if (type.Equals("green"))
            {
                p.Image = ResourceImage.GetImage("st_back_green");
            }

            if (type.Equals("red"))
            {
                p.Image = ResourceImage.GetImage("st_back_red");
            }

            if (type.Equals("yellow"))
            {
                p.Image = ResourceImage.GetImage("st_back_yellow");
            }
        }

        #endregion

        #region 작업시작
        private void WorkStart()
        {
            int status;
            string result;
            DataSet ds = null;

            string MachSeq = workHeader1.ValueOfMachSeq;
            string workDate = DateTime.Now.ToString("yyyyMMdd");

            try
            {




                using (CommonService svc = new CommonService())
                {
                    ds = svc.SetMachRun(MachSeq, workDate, "1");
                }


                if (ds != null)
                {
                    status = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                    result = ds.Tables[0].Rows[0][1].ToString();
                    if (status == 0)
                    {
                        MessageHandler.DisplayMessage(result, Common.Controls.MessageType.Warning);
                    }
                }




            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }
        }
        #endregion

        #region 작업종료
        private void WorkEnd()
        {
            int status;
            string result;
            DataSet ds = null;

            string MachSeq = workHeader1.ValueOfMachSeq;
            string workDate = DateTime.Now.ToString("yyyyMMdd");

            try
            {




                using (CommonService svc = new CommonService())
                {
                    ds = svc.SetMachRun(MachSeq, workDate, "2");
                }


                if (ds != null)
                {
                    status = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                    result = ds.Tables[0].Rows[0][1].ToString();
                    if (status == 0)
                    {
                        MessageHandler.DisplayMessage(result, Common.Controls.MessageType.Warning);
                    }
                }




            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }
        }
        #endregion

        #region 바코드 처리
        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InputBarcode(txtBarcode.Text);
                
            }


            
        }

        


        private void InputBarcode(string barcode)
        {
            //ConsumableLot 입력됨
            if (barcode.IndexOf("MAT") == 0)
            {
                SetConsumableLot(barcode);
            }
            //Lot ID 입력됨
            else
            {
                txtID.Text = barcode;
                ChangePic(picWorkStatus, "green");
                txtBarcode.ReadOnly = true;
                //애니메이션 시작

                SetWorkLot(barcode);
                Search2("OK");
                Search2("NG");

                ChangePic(picWorkStatus, "yellow");
                txtBarcode.ReadOnly = false;

                txtBarcode.Text = "";
                txtID.Text = "";

            }

        }

        #endregion

        #region 원자재 투입 처리
        private void SetConsumableLot(string barcode)
        {
            /*barcode = "MAT$ALBL123269010$CONA1234568$100";*/

            string[] s = barcode.Split('$'); // # 기준으로 자른다.

            string itemNo = s[1];
            string consumableLotID = s[2];
            string qty = s[3];
            string MachSeq = workHeader1.ValueOfMachSeq;
            string workDate = DateTime.Now.ToString("yyyyMMdd");
            DataSet ds = null;
            int status;
            string result;

            try
            {

                using (CommonService svc = new CommonService())
                {
                    ds = svc.SetConsumableLot("A", workDate, workHeader1.OrderSeq, MachSeq, workHeader1.ProcSeq, itemNo, consumableLotID, qty);
                }


                if (ds != null)
                {
                    status = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                    result = ds.Tables[0].Rows[0][1].ToString();
                    if (status == 0)
                    {
                        MessageHandler.DisplayMessage(result, Common.Controls.MessageType.Warning);
                    }
                }

                Search();

            }
            catch (Exception ex)
            {

            }

            

        }

        #endregion

        #region 원자재투입조회

        private void Search()
        {

            DataSet ds = null;
            string MachSeq = workHeader1.ValueOfMachSeq;
            string workDate = DateTime.Now.ToString("yyyyMMdd");

            fpSpread1.Sheets[0].Rows.Count = 0;
            try
            {



                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetWorkConsumableLot(MachSeq,workDate,workHeader1.ProcSeq);
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

        #region LOT 투입 처리
        private void SetWorkLot(string barcode)
        {
            
            string workDate = DateTime.Now.ToString("yyyyMMdd");
            string MachSeq = workHeader1.ValueOfMachSeq;
            DataSet ds = null;
            int status;
            string result;

            try
            {

                using (CommonService svc = new CommonService())
                {
                    ds = svc.SetWorkLot("A",workDate,workHeader1.OrderSeq, MachSeq, workHeader1.ProcSeq,
                        workHeader1.ItemSeq,barcode,"1","OK",ClientGlobal.UserSeq,"");
                }


                if (ds != null)
                {
                    status = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                    result = ds.Tables[0].Rows[0][1].ToString();
                    if (status == 0)
                    {
                        MessageHandler.DisplayMessage(result, Common.Controls.MessageType.Warning);
                    }
                }

                Search();

            }
            catch (Exception ex)
            {

            }



        }

        #endregion

        #region LOT조회

        private void Search2(string gubun)
        {


            DataSet ds = null;
            string MachSeq = workHeader1.ValueOfMachSeq;
            string workDate = DateTime.Now.ToString("yyyyMMdd");

            fpSpread1.Sheets[0].Rows.Count = 0;
            try
            {



                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetWorkLot(workHeader1.ItemSeq,workDate,workHeader1.ProcSeq,MachSeq, gubun);
                }

                if (ds != null)
                {
                    if (gubun.Equals("OK"))
                    {
                        //fpSpread1.Sheets[0].DataSource = ds;
                        FpSpread.SetSheetDataBind(this.fpSpread2.Sheets[0], ds.Tables[0]);
                    }
                    else
                    {
                        FpSpread.SetSheetDataBind(this.fpSpread3.Sheets[0], ds.Tables[0]);
                    }


                }


            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }

        }





        #endregion

        private void btnDelOK_Click(object sender, EventArgs e)
        {
            int lngRow = fpSpread2.Sheets[0].ActiveRow.Index;
            Save("D", lngRow);
            Search2("OK");
            Search2("NG");

        }

        private void Save(string WorkingTag, int lngRow)
        {
            int status;
            string result;
            DataSet ds = null;


            try
            {
                string LotID;
                string OrderSeq;
                string ItemSeq;
                string ProcSeq;
                string MachSeq;
                string Judge;
                string Qty;
                string WorkDate;
                int UserSeq;
                string TimeKey;


                if (fpSpread2.Sheets[0].Cells[lngRow, 0].Value.ToString() == "")
                {
                    LotID = fpSpread3.Sheets[0].Cells[lngRow, 0].Value.ToString();
                    TimeKey = fpSpread3.Sheets[0].Cells[lngRow, 2].Value.ToString();
                }
                else
                {
                    LotID = fpSpread2.Sheets[0].Cells[lngRow, 0].Value.ToString();
                    TimeKey = fpSpread2.Sheets[0].Cells[lngRow, 2].Value.ToString();
                }

                OrderSeq = workHeader1.OrderSeq;
                ItemSeq = workHeader1.ItemSeq;
                ProcSeq = workHeader1.ProcSeq;
                MachSeq = workHeader1.ValueOfMachSeq;
                WorkDate = DateTime.Now.ToString("yyyyMMdd");
                UserSeq = ClientGlobal.UserSeq;
                Judge = "";
                Qty = "1";






                using (CommonService svc = new CommonService())
                {
                    ds = svc.SetWorkLot(WorkingTag, WorkDate, OrderSeq, MachSeq, ProcSeq, ItemSeq, LotID, Qty, Judge, UserSeq, TimeKey);
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
                        MessageHandler.DisplayMessage("취소되었습니다.", Common.Controls.MessageType.Warning);
                    }
                }




            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }

        }

        private void btnDelNG_Click(object sender, EventArgs e)
        {
            int lngRow = fpSpread3.Sheets[0].ActiveRow.Index;
            Save("D", lngRow);
            Search2("OK");
            Search2("NG");
        }
    }
}
