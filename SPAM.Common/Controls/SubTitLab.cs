using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SPAM.Common.Controls
{
    public partial class SubTitLab : UserControl
    {
        public SubTitLab()
        {
            InitializeComponent();
        }

        #region 설정 속성

        /// <summary>
        /// Label값 지정

        /// </summary>
        /// <remarks>이미지의 활성값, 비활성값을 설정 한다</remarks>
        [Category("사용자 정의 항목"), Description("활성, 비활성 설정")]
        public string LableText
        {
            get { return labelCommon.Text.Replace("  ", string.Empty); }
            set
            {
                labelCommon.Text = "  " + value;
            }
        }
        #endregion

        private void SubTitLab_Load(object sender, EventArgs e)
        {
            BaseDisplay.SetLabelStyle(labelCommon, BaseDisplay.LabelType.Item);
        }
    }
}
