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
            try
            {
                Search();
				lblDate.Text = "현재시간: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
				grid.CurrentCell = null;
                timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }
        }

        #endregion 

        #region DataBind 메소드

        #region 조회

        private void Search()
        {

            DataSet ds = null;

            grid.Rows.Clear();
            try
            {



               


            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }

        }

        #endregion

        #endregion

        #region timer 처리
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            try
            {
				lblDate.Text = "현재시간: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
				Search(); 
                grid.CurrentCell = null;
                timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }
            finally
            {
                timer1.Enabled = true;
            }


        }
        #endregion

        #region grid Header 번호부여
        private void grid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grids = sender as DataGridView;            
            var rowIdx = (e.RowIndex + 1).ToString();
            var centerFormat = new StringFormat();

            centerFormat.Alignment = StringAlignment.Center;
            centerFormat.LineAlignment = StringAlignment.Center;
                        
            Font ft = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grids.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, ft, SystemBrushes.ControlText, headerBounds, centerFormat);            

        }
        #endregion
    }
}
