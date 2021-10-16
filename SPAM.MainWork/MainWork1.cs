using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System;
using SPAM.Common;
using SPAM.Manage;
using System.Windows.Forms.DataVisualization.Charting;

namespace SPAM.MainWork
{
    public delegate void ParentTabName(int nIdx, string MachCd);
    public partial class MainWork1 : UserControl
    {
        #region Init
        public event ParentTabName TabName;
        int nIdx = 0;
        public MainWork1()
        {
            InitializeComponent();
        }
        public MainWork1(int nIdx)
        {
            this.nIdx = nIdx;
            InitializeComponent();
        }

        private void MainWork1_Load(object sender, System.EventArgs e)
        {
            Init_Proc();

        }

        private void Init_Proc()
        {
            //chart1.Series.Clear();
            //chart1.Series.Add("Series1");
            //chart1.Titles.Add("설비별 가동율");
            //chart1.Series["Series1"].LegendText = "가동율";   // 차트 이름을 "수학"으로 설정
            //chart1.Series["Series1"].ChartType = SeriesChartType.Column; // 그래프를 라인으로 출력

            DataSet ds = null;
            using (CommonService svc = new CommonService())
            {
                //ds = svc.GetTest();
            }

            //if (ds != null)
            //{

            //    chart1.DataSource = ds;
            //    chart1.Series["Series1"].XValueMember = "MachID";
            //    chart1.Series["Series1"].YValueMembers = "RunRate";

            //}
            /*
            chart1.Series["Series1"].Points.AddXY("설비1",r.Next(100)); // 차트 한줄 출력해주는 코드
            chart1.Series["Series1"].Points.AddXY("설비2", r.Next(100)); // 차트 한줄 출력해주는 코드
            chart1.Series["Series1"].Points.AddXY("설비3", r.Next(100)); // 차트 한줄 출력해주는 코드
            chart1.Series["Series1"].Points.AddXY("설비4", r.Next(100)); // 차트 한줄 출력해주는 코드
            chart1.Series["Series1"].Points.AddXY("설비5", r.Next(100)); // 차트 한줄 출력해주는 코드
            */

            CreateChart1();
            CreateChart2();
            CreateChart3();
            //CreateChart4();

            SetFpSpread();


        }

        #endregion


        #region CreateChart
        private void CreateChart1()
        {

            chart1.Series.Clear();
            chart1.Series.Add("Series1");
            chart1.Titles.Clear();
            chart1.Titles.Add("생산량");
            chart1.Series["Series1"].LegendText = "생산수량";   // 차트 이름을 "수학"으로 설정
            chart1.Series["Series1"].ChartType = SeriesChartType.Pie; // 그래프를 라인으로 출력

            DataSet ds = null;
            string From = "20210101";
            string To = "20210930";

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
        private void CreateChart2()
        {

            chart2.Series.Clear();
            chart2.Series.Add("Series1");
            chart2.Titles.Clear();
            chart2.Titles.Add("목표생산량");
            chart2.Series["Series1"].LegendText = "생산수량";   // 차트 이름을 "수학"으로 설정
            chart2.Series["Series1"].ChartType = SeriesChartType.Pie; // 그래프를 라인으로 출력

            DataSet ds = null;
            string From = "20210101";
            string To = "20210930";

            using (CommonService svc = new CommonService())
            {
                ds = svc.GetProcChart(From, To);
            }

            if (ds != null)
            {

                chart2.DataSource = ds;
                chart2.Series["Series1"].XValueMember = "WorkDate";
                chart2.Series["Series1"].YValueMembers = "ProdQty";

            }

        }

        private void CreateChart3()
        {

            chart3.Series.Clear();
            chart3.Series.Add("Series1");
            chart3.Titles.Clear();
            chart3.Titles.Add("가동률");
            chart3.Series["Series1"].LegendText = "생산수량";   // 차트 이름을 "수학"으로 설정
            chart3.Series["Series1"].ChartType = SeriesChartType.Pie; // 그래프를 라인으로 출력

            DataSet ds = null;
            string From = "20210101";
            string To = "20210930";

            using (CommonService svc = new CommonService())
            {
                ds = svc.GetProcChart(From, To);
            }

            if (ds != null)
            {

                chart3.DataSource = ds;
                chart3.Series["Series1"].XValueMember = "WorkDate";
                chart3.Series["Series1"].YValueMembers = "ProdQty";

            }

        }

        //private void CreateChart4()
        //{

        //    chart4.Series.Clear();
        //    chart4.Series.Add("Series1");
        //    chart4.Titles.Clear();
        //    chart4.Titles.Add("불량률");
        //    chart4.Series["Series1"].LegendText = "생산수량";   // 차트 이름을 "수학"으로 설정
        //    chart4.Series["Series1"].ChartType = SeriesChartType.Doughnut; // 그래프를 라인으로 출력

        //    DataSet ds = null;
        //    string From = "20210101";
        //    string To = "20210930";

        //    using (CommonService svc = new CommonService())
        //    {
        //        ds = svc.GetProcChart(From, To);
        //    }

        //    if (ds != null)
        //    {

        //        chart4.DataSource = ds;
        //        chart4.Series["Series1"].XValueMember = "WorkDate";
        //        chart4.Series["Series1"].YValueMembers = "ProdQty";

        //    }

        //}

        #region FpSpread 설정
        private void SetFpSpread()
        {
            ParamPack Proc = new ParamPack();

            ParamPack param = new ParamPack();
            ParamPack param2 = new ParamPack();

            param.Add(FpSpread.SetSheetColumns("품번", "ItemNo", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 100, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("계획번호", "PlanNo", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 100, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("공정ID", "ProcID", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 100, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param.Add(FpSpread.SetSheetColumns("수량합", "QtySum", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 150, Color.White, true, false, FpSpread.FpSort.False, 1, null));


            param2.Add(FpSpread.SetSheetColumns("WO번호", "OrderSeq", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 100, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param2.Add(FpSpread.SetSheetColumns("제품품번", "ItemNo", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 100, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param2.Add(FpSpread.SetSheetColumns("WO수량", "Qty", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 100, Color.White, true, false, FpSpread.FpSort.False, 1, null));
            param2.Add(FpSpread.SetSheetColumns("작업일자", "WorkDate", FpSpread.FpCellType.DateTime, FontStyle.Regular, FpSpread.FpAlignment.Left, 150, Color.White, true, true, FpSpread.FpSort.False, 1, null));
            param2.Add(FpSpread.SetSheetColumns("공정ID", "ProcID", FpSpread.FpCellType.Text, FontStyle.Regular, FpSpread.FpAlignment.Left, 100, Color.White, true, true, FpSpread.FpSort.False, 1, null));


            FpSpread.FpSpreadFrame(this.fpSpread1);
            FpSpread.SetSheetColumn(this.fpSpread1.Sheets[0], param, 1);

            FpSpread.FpSpreadFrame(this.fpSpread2);
            FpSpread.SetSheetColumn(this.fpSpread2.Sheets[0], param2, 1);

            Search();
            Search2();


        }
        #endregion

        #endregion

        #region 조회

        private void Search()
        {

            DataSet ds = null;


            fpSpread2.Sheets[0].Rows.Count = 0;
            try
            {

                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetWoOrder2();

                }

                if (ds != null)
                {
                    //fpSpread1.Sheets[0].DataSource = ds;
                    FpSpread.SetSheetDataBind(this.fpSpread2.Sheets[0], ds.Tables[0]);


                }


            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }

        }

        private void Search2()
        {

            DataSet ds = null;


            fpSpread1.Sheets[0].Rows.Count = 0;
            try
            {

                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetProcStockQry2();

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

    }
}
