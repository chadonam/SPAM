using System.Windows;

using SPAM.Common;

namespace SPAM.Main
{

    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            

            ShutdownMode = System.Windows.ShutdownMode.OnExplicitShutdown;

            string codebase = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.Replace(@"file:///", "");

            ClientGlobal.ExecutingDir = System.IO.Path.GetDirectoryName(codebase);
            ClientGlobal.AppConfigFile = ClientGlobal.ExecutingDir + @"\AppConfig.ini";
            ClientGlobal.DBAccess = ConfigHelper.AppSettings(ClientGlobal.AppConfigFile)["DBAccess"].ToString().ToUpper();          
            ClientGlobal.UserID = ConfigHelper.AppSettings(ClientGlobal.AppConfigFile)["UserID"].ToString();
            ClientGlobal.DB_Url = ConfigHelper.AppSettings(ClientGlobal.AppConfigFile)["DB_Url"].ToString();
            ClientGlobal.DB_ID = ConfigHelper.AppSettings(ClientGlobal.AppConfigFile)["DB_ID"].ToString();
            ClientGlobal.DB_PW = ConfigHelper.AppSettings(ClientGlobal.AppConfigFile)["DB_PW"].ToString();
            ClientGlobal.DB_Cat = ConfigHelper.AppSettings(ClientGlobal.AppConfigFile)["DB_Cat"].ToString();


            bool bCreatedNew;
            System.Threading.Mutex mtx = new System.Threading.Mutex(true, "ADMIN", out bCreatedNew);

            if (bCreatedNew)
            {
                Login frm = new Login();
                frm.ShowDialog();

                if (frm.DialogResult.HasValue && frm.DialogResult.Value)
                {
                    MainWindow mw = new MainWindow();
                    mw.Show();
                }
            }
            else
            {
                MessageHandler.DisplayMessage("관리자 프로그램이 이미 실행중입니다.", Common.Controls.MessageType.Warning);
                System.Windows.Application.Current.Shutdown();
            }

            

                          
        }

    }
}
