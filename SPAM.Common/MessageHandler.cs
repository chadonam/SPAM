using System.Windows.Forms;

using SPAM.Common.Controls;

namespace SPAM.Common
{
    public class MessageHandler
    {
        public static DialogResult DisplayMessage(string msg, MessageType msgType)
        {
            msg = Utils.GetLanguage(msg);
            Controls.MessageBoxBig msgbox = new Controls.MessageBoxBig(msg);
            msgbox.MsgType = msgType;

            return msgbox.ShowDialog();

        }


    }
}
