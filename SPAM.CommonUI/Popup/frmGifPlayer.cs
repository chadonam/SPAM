using AForge.Video;
using AForge.Video.DirectShow;
using System.Windows.Forms;

namespace SPAM.CommonUI.Popup
{
    public partial class frmGifPlayer : Form
    {        

        public frmGifPlayer(string gubun)
        {
            InitializeComponent();
            GifStart(gubun);


        }

        private void GifStart(string gubun)
        {

            string source= "";
            string path = System.IO.Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName;
            path = path.Replace("Main", "Binary");


            switch (gubun)
            {
                case "scriber":
                    source = path + "//" + "scriber.avi";
                    break;
                case "Grinder":
                    source = path + "//" + "CNC.avi";
                    break;
                case "POL":
                    source = path + "//" + "POL.avi";
                    break;
                case "Hybrid":
                    source = path + "//" + "DB.avi";
                    break;
                case "BLU":
                    source = path + "//" + "BLU.avi";
                    break;
                default:
                    break;
            }

            FileVideoSource fileVideoSource = new FileVideoSource(source);            
            OpenVideoSource(fileVideoSource);
        }

        private void OpenVideoSource(IVideoSource source)
        {
            

            //this.Cursor = Cursors.WaitCursor;

            //videoSourcePlayer1.SignalToStop();
            //videoSourcePlayer1.WaitForStop();

            videoSourcePlayer1.VideoSource = source;
            videoSourcePlayer1.Start();
            videoSourcePlayer1.PlayingFinished += VideoSourcePlayer1_PlayingFinished;
            
            //this.Cursor = Cursors.Default;
        }

        private void VideoSourcePlayer1_PlayingFinished(object sender, ReasonToFinishPlaying reason)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate()
                {
                    this.Close();
                }));

            }
            else
            {
                this.Close();
            }
        }

 

        
    }
}
