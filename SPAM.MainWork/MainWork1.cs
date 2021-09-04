using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System;

using SPAM.Common;
using SPAM.Manage;

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
        }

        #endregion 

    }
}
