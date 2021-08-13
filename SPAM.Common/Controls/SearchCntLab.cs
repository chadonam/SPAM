using System;
using System.Windows.Forms;

namespace SPAM.Common.Controls
{
    public partial class SearchCntLab : UserControl
    {
        public SearchCntLab()
        {
            InitializeComponent();
        }
        //조회카운터를 입력/ 조회
        //Convert.ToDouble("숫자").ToString("#,##0");
        public string CountValue
        {
            get
            {
                return lblListTotal.Text.Trim().Replace("전체 : ", string.Empty).Replace("건", string.Empty).Replace(",", string.Empty);
            }
            set 
            { 
                lblListTotal.Text = "전체 : " + Convert.ToDouble(value.Trim()).ToString("#,##0") + "건"; 
            }
        }
    }
}
