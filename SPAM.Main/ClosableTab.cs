
using System;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;


namespace SPAM.Main
{
    public delegate void TabDeleted(int idx);
    public delegate void TitleChanged(int idx);

    class ClosableTab : TabItem
    {
        public event TabDeleted OnTabDeleted;

        public int nIdx = -1;

        public Grid grd;

        // Constructor
        public ClosableTab()
        {
            // Create an instance of the usercontrol
            CloseableHeader closableTabHeader = new CloseableHeader();

            // Assign the usercontrol to the tab header
            this.Header = closableTabHeader;

            // Attach to the CloseableHeader events (Mouse Enter/Leave, Button Click, and Label resize)
            closableTabHeader.button_close.MouseUp += new MouseButtonEventHandler(button_close_MouseUp);

            grd = new Grid();

            this.Content = grd;
        }

        /// <summary>
        /// Property - Set the Title of the Tab
        /// </summary>
        public string Title
        {
            get
            {
                return ((CloseableHeader)this.Header).label_TabTitle.Content.ToString();
            }
            set
            {
                ((CloseableHeader)this.Header).label_TabTitle.Content = value;
            }
        }

        void button_close_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ((TabControl)this.Parent).Items.Remove(this);

            OnTabDeleted(nIdx);
        }
    }
}
