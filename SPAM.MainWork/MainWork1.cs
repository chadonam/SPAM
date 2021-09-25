﻿using System.Windows.Forms;
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

            //DataSet ds = null;
            //using (CommonService svc = new CommonService())
            //{
            //    ds = svc.GetTest();
            //}

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
            CreateChart4();


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
            chart1.Series["Series1"].ChartType = SeriesChartType.Column; // 그래프를 라인으로 출력

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
            chart2.Series["Series1"].ChartType = SeriesChartType.Renko; // 그래프를 라인으로 출력

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
            chart3.Series["Series1"].ChartType = SeriesChartType.Pyramid; // 그래프를 라인으로 출력

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

        private void CreateChart4()
        {

            chart4.Series.Clear();
            chart4.Series.Add("Series1");
            chart4.Titles.Clear();
            chart4.Titles.Add("불량률");
            chart4.Series["Series1"].LegendText = "생산수량";   // 차트 이름을 "수학"으로 설정
            chart4.Series["Series1"].ChartType = SeriesChartType.Doughnut; // 그래프를 라인으로 출력

            DataSet ds = null;
            string From = "20210101";
            string To = "20210930";

            using (CommonService svc = new CommonService())
            {
                ds = svc.GetProcChart(From, To);
            }

            if (ds != null)
            {

                chart4.DataSource = ds;
                chart4.Series["Series1"].XValueMember = "WorkDate";
                chart4.Series["Series1"].YValueMembers = "ProdQty";

            }

        }

        #endregion

    }
}
