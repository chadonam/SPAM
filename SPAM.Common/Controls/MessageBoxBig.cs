using System;
using System.Windows.Forms;

namespace SPAM.Common.Controls
{
    public partial class MessageBoxBig : Form
    {
        private MessageType msgType;

        public MessageBoxBig(string msg)
        {
            InitializeComponent();

            lblMessage.Text = msg;
        }


        public MessageType MsgType
        {
            get { return msgType; }
            set
            {
                msgType = value;

                switch (value)
                {
                    case MessageType.Information:
                        btnOK.Visible = true;
                        btnCancel.Visible = false;
                        lblImage.Image = ResourceImage.GetImage("warning");

                        this.btnOK.Location = new System.Drawing.Point(252, 300);

                        break;
                    case MessageType.Warning:
                        btnOK.Visible = true;
                        btnCancel.Visible = false;
                        lblImage.Image = ResourceImage.GetImage("warning");

                        this.btnOK.Location = new System.Drawing.Point(252, 300);
                        break;
                    case MessageType.Question:
                        btnOK.Visible = true;
                        btnCancel.Visible = true;
                        lblImage.Image = ResourceImage.GetImage("question");

                        this.btnOK.Location = new System.Drawing.Point(193, 300);
                        this.btnCancel.Location = new System.Drawing.Point(311, 300);
                        break;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.msgType == MessageType.Question)
            {
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.msgType == MessageType.Question)
            {
                this.DialogResult = DialogResult.No;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }

            this.Close();
        }
    }
}
