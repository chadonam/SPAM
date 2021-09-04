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
            Random r = new Random();   // 차트를 랜덤으로 출력할 랜덤객체 생성
            chart1.Titles.Add("설비별 가동율");
            chart1.Series["Series1"].LegendText = "가동율";   // 차트 이름을 "수학"으로 설정
            chart1.Series["Series1"].ChartType = SeriesChartType.Column; // 그래프를 라인으로 출력

            DataSet ds = null;
            using (CommonService svc = new CommonService())
            {
                ds = svc.GetTest();
            }

            if (ds != null)
            {

                chart1.DataSource = ds;
                chart1.Series["Series1"].XValueMember = "MachID";
                chart1.Series["Series1"].YValueMembers = "RunRate";

            }
            /*
            chart1.Series["Series1"].Points.AddXY("설비1",r.Next(100)); // 차트 한줄 출력해주는 코드
            chart1.Series["Series1"].Points.AddXY("설비2", r.Next(100)); // 차트 한줄 출력해주는 코드
            chart1.Series["Series1"].Points.AddXY("설비3", r.Next(100)); // 차트 한줄 출력해주는 코드
            chart1.Series["Series1"].Points.AddXY("설비4", r.Next(100)); // 차트 한줄 출력해주는 코드
            chart1.Series["Series1"].Points.AddXY("설비5", r.Next(100)); // 차트 한줄 출력해주는 코드
            */




        }

        #endregion

    }
}
