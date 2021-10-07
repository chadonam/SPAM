using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.IO.Ports;
using System.Windows.Threading;
using SPAM.Common;



namespace SPAM.Main
{

    public delegate void MyTabSerialReceived(int nIdx, string Data);

    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        
        List<int> lstKey = new List<int>();
        Dictionary<int, int> lstIdx = new Dictionary<int, int>();
        private int nIdx = 0;
        string caption;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Login.SetImage(imgBack, "top_bg");
            Login.SetImage(imgLogo, "logo");

            InitImage();

            imgMenu1_MouseUp(null, null);
            imgLogo_MouseUp(null, null);

        }

        private void InitImage()
        {

            if (ClientGlobal.Language == "KO")
            {
                SetImage(imgMenu1, "ad_menu01_new");
                SetImage(imgMenu2, "ad_menu02_new");
                SetImage(imgMenu3, "ad_menu03_new");
                SetImage(imgMenu4, "ad_menu04");
                SetImage(imgMenu5, "ad_menu06");
            }
            else
            {
                SetImage(imgMenu1, "ad_menu01_new_vt");
                SetImage(imgMenu2, "ad_menu02_new_vt");
                SetImage(imgMenu3, "ad_menu03_new_vt");
                SetImage(imgMenu4, "ad_menu04_new_vt");
                SetImage(imgMenu5, "ad_menu06_new_vt");
            }
            //if (ClientGlobal.UserID == "Admin")
            //{
            //    SetImage(imgMenu2, "ad_menu02");
            //}
            //SetImage(imgMenu3, "ad_menu03");
            //SetImage(imgMenu4, "ad_menu04");
            //SetImage(imgMenu5, "ad_menu05");            

        }

        private void imgLogo_MouseUp(object sender, MouseButtonEventArgs e)
        {
            string title = "메인화면";

            for (int i = 0; i < tabBody.Items.Count; i++)
            {
                if ((tabBody.Items[i] as ClosableTab).Title == title)
                {
                    (tabBody.Items[i] as ClosableTab).Focus();
                    return;
                }
            }

            if (tabBody.Items.Count > 9)
            {
                MessageHandler.DisplayMessage("최대 10개까지 화면을 열 수 있습니다.", Common.Controls.MessageType.Warning);
                return;
            }

            System.Windows.Forms.Integration.WindowsFormsHost host =
                new System.Windows.Forms.Integration.WindowsFormsHost();

            ClosableTab theTabItem = new ClosableTab();
            theTabItem.nIdx = nIdx;
            theTabItem.OnTabDeleted += new TabDeleted(theTabItem_OnTabDeleted);
            theTabItem.Title = title;

            
            SPAM.MainWork.MainWork1 ctl = new MainWork.MainWork1();

            host.Child = ctl;

            theTabItem.grd.Children.Add(host);

            tabBody.Items.Add(theTabItem);
            theTabItem.Focus();

            lstKey.Add(nIdx);
            lstIdx.Add(nIdx, tabBody.Items.Count - 1);
            
            nIdx++;
        }


        private void imgMenu1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            InitImage();
            if (ClientGlobal.Language == "KO")
            {
                Login.SetImage(imgMenu1, "ad_menu01_on_new");
            }
            else
            {
                Login.SetImage(imgMenu1, "ad_menu01_on_new_vt");
            }

            Dictionary<string, string> menus = new Dictionary<string, string>();


            caption = Utils.GetLanguage("품목마스터 연동");
            menus.Add(caption, "SPAM.MainWork.ucItemSync");
            caption = Utils.GetLanguage("품목별 공정순서");
            menus.Add(caption, "SPAM.MainWork.ucItemProc");
            caption = Utils.GetLanguage("공정등록");
            menus.Add(caption, "SPAM.MainWork.ucProcAdd");
            caption = Utils.GetLanguage("BOM연동");
            menus.Add(caption, "SPAM.MainWork.ucBOMSync");
            caption = Utils.GetLanguage("설비등록");
            menus.Add(caption, "SPAM.MainWork.ucMachAdd");
            caption = Utils.GetLanguage("자재입고처리");
            menus.Add(caption, "SPAM.MainWork.ucMatIn");
            caption = Utils.GetLanguage("자재출고처리");
            menus.Add(caption, "SPAM.MainWork.ucMatOutAdd");
            

            //menus.Add("바코드조회", "SPAM.MainWork.ucMenu2");
            //if (ClientGlobal.QCYn == "1")
            //{
            //    menus.Add("NG품양품전환", "SPAM.MainWork.ucQCBarcodeNG");
            //    menus.Add("NG품양품전환조회", "SPAM.MainWork.ucQCBarcodeNGQry");                

            //}
            //menus.Add("완성검사", "SPAM.MainWork.ucLastProc");
            //menus.Add("수기Rework입력", "SPAM.MainWork.ucMenu5");


            SetLeftMeun(menus);

            gdBody.ColumnDefinitions[0].Width = new GridLength(150);
            btnArrow.Content = "◀";
        }

        private void imgMenu2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            InitImage();

            if (ClientGlobal.Language == "KO")
            {
                Login.SetImage(imgMenu2, "ad_menu02_on_new");
            }
            else
            {
                Login.SetImage(imgMenu2, "ad_menu02_on_new_vt");
            }

            Dictionary<string, string> menus = new Dictionary<string, string>();

            caption = Utils.GetLanguage("월생산계획등록");
            menus.Add(caption, "SPAM.MainWork.ucMonthlyPlan");
            caption = Utils.GetLanguage("WorkOrder등록");
            menus.Add(caption, "SPAM.MainWork.ucWorkOrder");
            caption = Utils.GetLanguage("설비WO배정");
            menus.Add(caption, "SPAM.MainWork.ucEQPWOAssign");


            //menus.Add("라인관리", "SPAM.MainWork.ucMenu6");
            //menus.Add("공정관리", "SPAM.MainWork.ucMenu3");
            //menus.Add("공정순번관리", "SPAM.MainWork.ucMenu4");
            //menus.Add("품질정보관리", "SPAM.MainWork.ucMenu7");
            //menus.Add("사용자관리", "SPAM.MainWork.ucSystemManage");

            SetLeftMeun(menus);

            gdBody.ColumnDefinitions[0].Width = new GridLength(150);
            btnArrow.Content = "◀";
        }

        private void imgMenu3_MouseUp(object sender, MouseButtonEventArgs e)
        {
            InitImage();

            if (ClientGlobal.Language == "KO")
            {
                Login.SetImage(imgMenu3, "ad_menu03_on_new");
            }
            else
            {
                Login.SetImage(imgMenu3, "ad_menu03_on_new_vt");
            }

            Dictionary<string, string> menus = new Dictionary<string, string>();

            caption = Utils.GetLanguage("Scriber");
            menus.Add(caption, "SPAM.MainWork.ucScriber");

            SetLeftMeun(menus);

            gdBody.ColumnDefinitions[0].Width = new GridLength(150);
            btnArrow.Content = "◀";
        }

        private void imgMenu4_MouseUp(object sender, MouseButtonEventArgs e)
        {
            InitImage();

            if (ClientGlobal.Language == "KO")
            {
                Login.SetImage(imgMenu4, "ad_menu04_on");
            }
            else
            {
                Login.SetImage(imgMenu4, "ad_menu04_on_new_vt");
            }

            Dictionary<string, string> menus = new Dictionary<string, string>();

            caption = Utils.GetLanguage("일자별생산실적조회");
            menus.Add(caption, "SPAM.MainWork.ucWorkReportQry");
            caption = Utils.GetLanguage("공정별재공조회");
            menus.Add(caption, "SPAM.MainWork.ucProcStockQry");
            caption = Utils.GetLanguage("설비별가동률조회");
            menus.Add(caption, "SPAM.MainWork.ucMachReportQry");
            caption = Utils.GetLanguage("LOT이력조회");
            menus.Add(caption, "SPAM.MainWork.ucLotHistoryQry");
            
            
            SetLeftMeun(menus);

            gdBody.ColumnDefinitions[0].Width = new GridLength(150);
            btnArrow.Content = "◀";
        }

        private void imgMenu5_MouseUp(object sender, MouseButtonEventArgs e)
        {
            InitImage();

            if (ClientGlobal.Language == "KO")
            {
                Login.SetImage(imgMenu5, "ad_menu06_on");
            }
            else
            {
                Login.SetImage(imgMenu5, "ad_menu06_on_new_vt");
            }

            Dictionary<string, string> menus = new Dictionary<string, string>();
            caption = Utils.GetLanguage("사용자등록");
            menus.Add(caption, "SPAM.MainWork.ucUserAdd");
            caption = Utils.GetLanguage("그룹등록");
            menus.Add(caption, "SPAM.MainWork.ucGroupAdd");
            caption = Utils.GetLanguage("프로그램등록");
            menus.Add(caption, "SPAM.MainWork.ucProgramAdd");
            caption = Utils.GetLanguage("권한등록");
            menus.Add(caption, "SPAM.MainWork.ucAuthAdd");

            SetLeftMeun(menus);

            gdBody.ColumnDefinitions[0].Width = new GridLength(150);
            btnArrow.Content = "◀";
        }



        private void SetLeftMeun(Dictionary<string, string> menus)
        {
            gdLeft.Children.Clear();

            int i = 0;
            foreach (string name in menus.Keys)
            {
                RowDefinition row = new RowDefinition();
                row.Height = new GridLength(50);
                gdLeft.RowDefinitions.Add(row);

                Label btn = new Label();
                btn.Content = name;
                btn.Width = 150;
                btn.Height = 30;
                btn.Tag = menus[name];
                btn.Margin = new Thickness(20, 0, 0, 0);
                btn.MouseDown += new MouseButtonEventHandler(btn_MouseDown);
                Grid.SetRow(btn, i);

                gdLeft.Children.Add(btn);
                i++;
            }
        }

        void btn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string title = (sender as Label).Content.ToString();

            for (int i = 0; i < tabBody.Items.Count; i++)
            {
                if ((tabBody.Items[i] as ClosableTab).Title == title)
                {
                    (tabBody.Items[i] as ClosableTab).Focus();
                    return;
                }
            }

            if (tabBody.Items.Count > 9)
            {
                MessageHandler.DisplayMessage("최대 10개까지 화면을 열 수 있습니다.", Common.Controls.MessageType.Warning);
                return;
            }

            System.Windows.Forms.Integration.WindowsFormsHost host =
                new System.Windows.Forms.Integration.WindowsFormsHost();

            ClosableTab theTabItem = new ClosableTab();
            theTabItem.nIdx = nIdx;
            theTabItem.OnTabDeleted += new TabDeleted(theTabItem_OnTabDeleted);
            
            if (title.Length > 19) //베트남어로 너무 길면 줄여줌
            {
                title = title.Substring(0, 19);
            }

            theTabItem.Title = title;

            string ucName = (sender as Label).Tag.ToString();
            int idxAssembly = ucName.LastIndexOf(".");
            string dllName = ucName.Substring(0, idxAssembly) + ".dll";

            Assembly asmPlant = Assembly.LoadFrom(dllName);

            object obj = asmPlant.CreateInstance(ucName);

            host.Child = obj as System.Windows.Forms.Control;           


            theTabItem.grd.Children.Add(host);

            tabBody.Items.Add(theTabItem);
            theTabItem.Tag = nIdx;
            theTabItem.Focus();
                    
            lstKey.Add(nIdx);
            lstIdx.Add(nIdx, tabBody.Items.Count - 1);

            nIdx++;
        }

        void theTabItem_OnTabDeleted(int idx)
        {
            lstKey.Remove(idx);

            lstIdx.Clear();
            for (int i = 0; i < lstKey.Count; i++)
            {
                lstIdx.Add(lstKey[i], i);
            }
        }

        void ctl_OnMachineChanged(int idx, string machineName)
        {
            (tabBody.Items[lstIdx[idx]] as ClosableTab).Title = machineName;
        }

        private void SetImage(System.Windows.Controls.Image ctrImage, string name)
        {
            System.Drawing.Image img = SPAM.Common.ResourceImage.GetImage(name);

            MemoryStream imgStream = new MemoryStream();

            img.Save(imgStream, System.Drawing.Imaging.ImageFormat.Png);

            imgStream.Seek(0, SeekOrigin.Begin);

            BitmapFrame newimg = BitmapFrame.Create(imgStream);

            ctrImage.Source = newimg;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageHandler.DisplayMessage("프로그램을 종료하시겠습니까?", Common.Controls.MessageType.Question) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Current.Shutdown();
            }
        }

        private void btnArrow_Click(object sender, RoutedEventArgs e)
        {
            if (btnArrow.Content.ToString() == "◀")
            {
                gdBody.ColumnDefinitions[0].Width = new GridLength(0);
                btnArrow.Content = "▶";
            }
            else
            {
                gdBody.ColumnDefinitions[0].Width = new GridLength(150);
                btnArrow.Content = "◀";
            }
        }

        void ctl_TabOpen(string ctlCode,string ctlName,string param1)
        {
            //InitImage();
            //Login.SetImage(imgMenu1, "menu01_on");

            foreach (var item in tabBody.Items)
            {
                if (item is ClosableTab)
                {
                    if ((item as ClosableTab).Title.Contains(ctlName))
                    {
                        tabBody.Items.Remove(item);
                        theTabItem_OnTabDeleted((int)(item as ClosableTab).Tag);
                        break;
                    }
                }
            }

            if (tabBody.Items.Count > 9)
            {
                MessageHandler.DisplayMessage("최대 10개까지 화면을 열 수 있습니다.", Common.Controls.MessageType.Warning);
                return;
            }

            System.Windows.Forms.Integration.WindowsFormsHost host =
                new System.Windows.Forms.Integration.WindowsFormsHost();

            ClosableTab theTabItem = new ClosableTab();
            theTabItem.nIdx = nIdx;
            theTabItem.OnTabDeleted += new TabDeleted(theTabItem_OnTabDeleted);


            theTabItem.grd.Children.Add(host);

            tabBody.Items.Add(theTabItem);
            theTabItem.Title = ctlName;
            theTabItem.Tag = nIdx;
            theTabItem.Focus();

            lstKey.Add(nIdx);
            lstIdx.Add(nIdx, tabBody.Items.Count - 1);
                                      
            
            nIdx++;
        }

    }
}
