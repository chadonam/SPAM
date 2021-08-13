using System.Windows.Forms;

namespace SPAM.Common.Controls
{
    public partial class ucProgressBar : UserControl
    {
        public ucProgressBar()
        {
            InitializeComponent();
        }

        public int ProgressBarValue
        {
            get { return this.progressBar1.Value; }
            set { this.progressBar1.Value = value; }
        }

        public string StatusMessage
        {
            get { return this.lbMessage.Text; }
            set { this.lbMessage.Text = value; }
        }

    }
}
