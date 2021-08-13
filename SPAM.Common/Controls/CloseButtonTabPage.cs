using System;
using System.Drawing;
using System.Windows.Forms;

namespace SPAM.Common.Controls
{
    public partial class CloseButtonTabPage : TabControl
    {
        private Image close_Image;
        private const int imageSize = 16; // 16 X 16 짜리 이미지.

        public CloseButtonTabPage(): base()
        {
            this.SizeMode = TabSizeMode.Fixed;                  // TabPage 의 이름부분의 크기를 지정하려면 sizeMode 를 Fixed 로 해야한다.
            this.ItemSize = new Size(80, imageSize + 4);        // 기본 값은 Auto 임.
            this.DrawMode = TabDrawMode.OwnerDrawFixed;         // TabPage 의 이름부분에 사용자가 지정하는 것을 그리려면..
                                                                // DrawMode 를 OwnerDrawFixed 로 해줘야 한다.

            this.DrawItem += new DrawItemEventHandler(CloseButtonTabPage_DrawItem); // TabPage 의 이름부분을 그리는 이벤트 핸들러


            String curDir = System.IO.Directory.GetCurrentDirectory();
            System.Drawing.Image img = SPAM.Common.Resource.Icon_X2.ToBitmap();
            close_Image = img;   // 이미지를 가져온다.
            this.MouseDown += new MouseEventHandler(CloseButtonTabPage_MouseDown);       // 이미지를 마우스로 클릭했을때 이벤트 핸들러

        }

        private void CloseButtonTabPage_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font font = new Font(this.Font.FontFamily, 12.0f);

            Brush backBrush;
            Brush foreBrush;

            Rectangle rect;
            StringFormat sf_Text = new StringFormat();
            sf_Text.Alignment = StringAlignment.Near;
            sf_Text.LineAlignment = StringAlignment.Center;

            StringFormat sf_X = new StringFormat();
            sf_X.Alignment = StringAlignment.Far;
            sf_X.LineAlignment = StringAlignment.Center;

            if (e.Index == this.SelectedIndex)
            {
                font = new Font(e.Font, FontStyle.Bold | FontStyle.Bold);
                backBrush = new SolidBrush(System.Drawing.SystemColors.ControlLightLight);
                foreBrush = new SolidBrush(System.Drawing.SystemColors.ControlText);
            }
            else
            {
                font = new Font(e.Font, FontStyle.Regular);
                backBrush = new SolidBrush(System.Drawing.SystemColors.Control);
                foreBrush = new SolidBrush(System.Drawing.SystemColors.ControlText);
            }


            rect = this.GetTabRect(e.Index);
            e.Graphics.FillRectangle(backBrush, rect);

            if (this.TabPages[e.Index].Tag != null && this.TabPages[e.Index].Tag.ToString() == "X")                //&& (e.Index == this.SelectedIndex) 
            {
                e.Graphics.DrawImage(close_Image, rect.Right - 4 - close_Image.Width, rect.Top + imageSize / 2);                        //이미지를 그림. (닫힘버튼)
                //e.Graphics.DrawString("X", font, foreBrush, (RectangleF)(this.GetTabRect(e.Index)), sf_X);   
            }

            e.Graphics.DrawString(this.TabPages[e.Index].Text, font, foreBrush, (RectangleF)(this.GetTabRect(e.Index)), sf_Text);        // 이건 TabPage 이름을 그림
        }

        private void CloseButtonTabPage_MouseDown(object sender, MouseEventArgs e) 
        {
            if ((sender as TabControl).TabPages[this.SelectedIndex].Tag != null
                && (sender as TabControl).TabPages[this.SelectedIndex].Tag.ToString() == "X")
            {
                Rectangle rect;

                for (int i = 0; i < this.TabCount; i++)
                {
                    rect = GetImageRect(this.GetTabRect(i));       // 아까 이미지를 뿌린 좌표를 다시 계산
                    if (rect.Contains(new Point(e.X, e.Y)))       // 클릭한 좌표가 이미지 위인지 검사

                    {
                        TabPage tmp = this.TabPages[i];            // TabControl 에서 제거
                        this.TabPages.RemoveAt(i);
                        tmp.Dispose();
                    }
                }
            }            
        }

        private Rectangle GetImageRect(Rectangle rect)
        {
            Rectangle myRect = new Rectangle(rect.Right - 4 - imageSize, rect.Top + imageSize / 2, imageSize, imageSize);
            return myRect;
        }
    }
}
