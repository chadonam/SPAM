
using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using SPAM.Common;
using SPAM.Manage;

namespace SPAM.Main
{
    /// <summary>
    /// Login.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Login : Window
    {
        private ArrayList lstButtons = new ArrayList();
        private int nButtonIndex = -1;

        public Login()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtID.Text = ClientGlobal.UserID;

            SetImage(imgBack, "login_admin");

            InitButton();

            if (txtID.Text.Length > 0)
            {
                txtPassword.Focus();
            }
            else
            {
                txtID.Focus();
            }
        }

        private void InitButton()
        {
            lstButtons.Add(new System.Drawing.Rectangle(793, 464, 119, 45));
            lstButtons.Add(new System.Drawing.Rectangle(918, 464, 119, 45));
        }

        public static void SetImage(System.Windows.Controls.Image ctrImage, string name)
        {
            System.Drawing.Image img = SPAM.Common.ResourceImage.GetImage(name);

            MemoryStream imgStream = new MemoryStream();

            img.Save(imgStream, System.Drawing.Imaging.ImageFormat.Png);

            imgStream.Seek(0, SeekOrigin.Begin);

            BitmapFrame newimg = BitmapFrame.Create(imgStream);

            ctrImage.Source = newimg;
        }

        private void imgBack_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (nButtonIndex == -1)
            {
                return;
            }

            switch (nButtonIndex)
            {
                case 0:
                    SetLogin();
                    break;
                case 1:
                    if (MessageHandler.DisplayMessage("프로그램을 종료하시겠습니까?", Common.Controls.MessageType.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Application.Current.Shutdown();
                    }
                    break;
            }
        }

        private void SetLogin()
        {
            DataSet ds = null;

            try
            {
                if (txtID.Text.Length < 1)
                {
                    txtID.Focus();
                    throw new Exception("아이디를 입력하세요.");
                }

                if (txtPassword.Password.Length < 1)
                {
                    txtPassword.Focus();
                    throw new Exception("비밀번호를 입력하세요.");
                }

                using (CommonService svc = new CommonService())
                {
                    ds = svc.GetLoginList(txtID.Text, txtPassword.Password);
                }

                if (ds.Tables[0].Rows.Count <= 0)
                {
                    throw new Exception("ID나 Password를 확인하세요.");
                }


                ClientGlobal.UserID = txtID.Text;
                string UserSeq = ds.Tables[0].Rows[0]["UserSeq"].ToString();
                ClientGlobal.UserSeq = Int32.Parse(UserSeq);


                UpdateUserID();

                DialogResult = true;
            }
            catch (Exception ex)
            {
                MessageHandler.DisplayMessage(ex.Message, Common.Controls.MessageType.Warning);
            }
        }

        private void UpdateUserID()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("KEY");
                dt.Columns.Add("VALUE");

                DataRow dr = dt.NewRow();
                dr["KEY"] = "UserID";
                dr["VALUE"] = txtID.Text;
                dt.Rows.Add(dr);

                ConfigHelper.SaveUpdateFile(dt, ClientGlobal.AppConfigFile);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int GetButtonIndex(double dX, double dY)
        {
            System.Drawing.Rectangle rc;

            for (int i = 0; i < lstButtons.Count; i++)
            {
                rc = (System.Drawing.Rectangle)lstButtons[i];
                if (rc.Contains(Convert.ToInt16(dX), Convert.ToInt16(dY)))
                {
                    return i;
                }
            }

            return -1;
        }

        private void imgBack_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            nButtonIndex = GetButtonIndex(e.GetPosition(imgBack).X, e.GetPosition(imgBack).Y);

            if (nButtonIndex == -1)
            {
                return;
            }
        }

        private void txtID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SetLogin();
            }
        }
    }
}
