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
using System.Windows.Forms.DataVisualization.Charting;

namespace SPAM.MainWork
{
    public partial class ucMachReportQry : UserControl
    {
        public ucMachReportQry()
        {
            InitializeComponent();
            InitControl();
            SetCombo_Proc();
            SetFpSpread();
        }

        #region Control 초기화
        private void InitControl()
        {
            BaseDisplay.AdminBtn(btnSearch, BaseDisplay.BtnType.Search);


            BaseDisplay.SetLabelStyle(lblDateQ, BaseDisplay.LabelType.Menu);
            BaseDisplay.SetLabelStyle(lblProcQ, BaseDisplay.LabelType.Menu);

        }
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


            param.Add(FpSpread.SetSheetColumns("번호", "MachSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("작업일자", "WorkDate", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("설비명", "MachName", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Center, 120, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("설비ID", "MachID", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Right, 120, Color.White, true, false, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("작업시간", "WorkTime", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Right, 120, Color.White, true, false, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("가동률", "RunRate", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Right, 120, Color.White, true, false, FpSpread.FpSort.False, 1, null));



            FpSpread.FpSpreadFrame(this.fpSpread1);
            FpSpread.SetSheetColumn(this.fpSpread1.Sheets[0], param, 1);


        }
        #endregion
        #endregion
        #region 조회

        private void Search()
        {

            DataSet ds = null;
            
            string ProcSeq = cmbProc.SelectedIndex.ToString();
            string From = calendarDouble1.ValueStartDate;
            string To = calendarDouble1.ValueEndDate;

            fpSpread1.Sheets[0].Rows.Count = 0;
            try
            {



                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetMachReport(ProcSeq, From, To);
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
                    Utils.SetComboBox(cmbProc, ds.Tables[0], "ItemNm", "ItemCd", "공정선택");
                    cmbProc.SelectedIndex = 0;


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
            Init_Proc();
        }

        private void Init_Proc()
        {

            string ProcSeq = cmbProc.SelectedIndex.ToString();
            string From = calendarDouble1.ValueStartDate;
            string To = calendarDouble1.ValueEndDate;
            Random r = new Random();   // 차트를 랜덤으로 출력할 랜덤객체 생성
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Series.Add("Series1");
            chart1.Titles.Add("설비별 가동율");
            chart1.Series["Series1"].LegendText = "가동율";   // 차트 이름을 "수학"으로 설정
            chart1.Series["Series1"].ChartType = SeriesChartType.Column; // 그래프를 라인으로 출력

            DataSet ds = null;
            using (CommonService svc = new CommonService())
            {
                ds = svc.GetMachReprotChart(ProcSeq, From, To);
            }

            if (ds != null)
            {

                chart1.DataSource = ds;
                chart1.Series["Series1"].XValueMember = "MachName";
                chart1.Series["Series1"].YValueMembers = "RunRate";

            }
            
        }


    }
}
