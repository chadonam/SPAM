using System;
using System.Windows.Forms;

namespace SPAM.Common.Controls
{
    public partial class CalendarDouble : UserControl
    {
        //이벤트 설정
        public delegate void DateChange(object sender, DateChangeEventArgs e);
        public event DateChange ValueChangedEvent;


        //시작일 설정
        public string ValueStartDate
        {
            get { return dtpStartDate.Text.Trim().Replace("-", string.Empty); }
            set { dtpStartDate.Text = InputDate(value); }
        }
        //종료일 설정
        public string ValueEndDate
        {
            get { return dtpEndDate.Text.Trim().Replace("-", string.Empty); }
            set { dtpEndDate.Text = InputDate(value); }
        }

        private int monthDistinction = 0;

        public int StartMonthDistinction
        {
            get { return monthDistinction; }
            set { monthDistinction = value; }
        }

        public int DiffDays
        {
            get { return DateDiff(); }
        }

        public CalendarDouble()
        {
            InitializeComponent();
        }

        private void CalendarDouble_Load(object sender, EventArgs e)
        {
            int iYear = DateTime.Today.Year;
            int iMonth = DateTime.Today.Month;
            int iDay = DateTime.Today.Day;

            this.dtpEndDate.Value = new System.DateTime(iYear, iMonth, iDay);

            if (monthDistinction > 0)
            {
                int add = -1 * monthDistinction;

                int iYear2 = DateTime.Today.AddMonths(add).Year;
                int iMonth2 = DateTime.Today.AddMonths(add).Month;
                int iDay2 = DateTime.Today.AddMonths(add).Day;


                this.dtpStartDate.Value = new System.DateTime(iYear2, iMonth2, iDay2);
            }
            else
            {
                this.dtpStartDate.Value = new System.DateTime(iYear, iMonth, iDay);
            }

            this.dtpStartDate.ValueChanged += new System.EventHandler(dtpDate_ValueChanged);
            this.dtpEndDate.ValueChanged += new System.EventHandler(dtpDate_ValueChanged);
        }

        private string InputDate(string date)
        {
            string reVal = string.Empty;
            date = date.Trim().Replace("-", string.Empty);
            if (date.Length > 7)
            {
                reVal = date.Substring(0, 4) + "-" + date.Substring(4, 2) + "-" + date.Substring(6, 2);
            }

            return reVal;
        }

        private int DateDiff()
        {
            int reDays = 0;

            TimeSpan ts = this.dtpEndDate.Value - this.dtpStartDate.Value;

            reDays = ts.Days;

            return reDays;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            
        }


        void SetChangeCondition(DateChangeEventArgs args)
        {
            args._StartDate = dtpStartDate.Text.Trim().Replace("-", string.Empty);
            args._EndDate = dtpEndDate.Text.Trim().Replace("-", string.Empty);
        }
        /// <summary>
        /// 품목정보를 저장할 EventArgs 클래스

        /// </summary>
        public class DateChangeEventArgs : EventArgs
        {
            public string _StartDate = string.Empty;
            public string _EndDate = string.Empty;
            public DateChangeEventArgs() : base() { }
        }

        private void dtpStartDate_CloseUp(object sender, EventArgs e)
        {
            DateChangeEventArgs args = new DateChangeEventArgs();	// 품목정보를 담을 개체를 생성한다.
            SetChangeCondition(args);
            try
            {
                //ValueChangedEvent(this, args);
            }
            catch {
            }
        }

    }



}
