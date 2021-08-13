namespace SPAM.Common
{
    public enum ServiceName
    {
        GetTDAMinorList,
        UpdateTDAMinor
    }

    public class ClientGlobal
	{
        public static string UserID;
        public static string ExecutingDir;
        public static string AppConfigFile;
        //public static string Version;
        //public static string IP;
        public static string DBAccess;
        public static string DB_Url;
        public static string DB_ID;
        public static string DB_PW;
        public static string DB_Cat;
        public static bool FlagEnable;
        public static int UserSeq;
    } 
}
