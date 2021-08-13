using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Xml;

namespace SPAM.Common
{
    /// <summary>
    /// Config에 대한 요약 설명입니다.
    /// </summary>
    public class ConfigHelper
	{
		private const string sectionTag = "appSettings";
        //private static string connStringReal = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\SPAM\\SPAM.accdb;";
        //private static string connStringTest = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\SPAM\\SPAM_Test.accdb;";
        //const string connString = "Data Source=MSDN-SPECIAL;Initial Catalog=localhost;Persist Security Info=True;User ID=sa;pwd=kfa123";
        //const string connString = @"Data Source = 192.168.0.237,14233; Initial Catalog = SPAM; Persist Security Info=True;User ID = neo; Password=p@ssWord";

        //public static Hashtable AppSettings()
        //{
        //    return AppSettings(ClientGlobal.AppConfigFile);
        //}

        public static Hashtable AppSettings(string configFile)
		{
			try
			{
				Hashtable settings = new Hashtable();

				XmlDocument cfgDoc = new XmlDocument();
				FileStream fs = new FileStream(configFile, FileMode.Open, FileAccess.Read);
				cfgDoc.Load(new XmlTextReader(fs));
				fs.Close();

				XmlNodeList nodes = cfgDoc.GetElementsByTagName(sectionTag);

				foreach (XmlNode node in nodes)
				{
					foreach (XmlNode childnode in node.ChildNodes)
					{
						XmlAttributeCollection attributes = childnode.Attributes;

						settings.Add(attributes["key"].Value, attributes["value"].Value);
					}
				}

				return settings;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        /// <summary>
        /// Connection String을 가져온다.
        /// </summary>
        public static string DBConnectionString()
        {
            string connString = @"Data Source = " + ClientGlobal.DB_Url + @"; Initial Catalog = " + ClientGlobal.DB_Cat + @"; Persist Security Info=True;User ID = "
                                + ClientGlobal.DB_ID + @"; Password=" + ClientGlobal.DB_PW;
            string conn = connString;
 
            return conn;
         }

		public static void SaveNewFile(DataTable dt, string configFile)
		{
			try
			{
				XmlDocument savedoc = new XmlDocument();

				XmlDeclaration dec = savedoc.CreateXmlDeclaration("1.0", "utf-8", null);

				savedoc.AppendChild(dec);

				XmlNode configuration = savedoc.AppendChild(savedoc.CreateElement("configuration"));

				XmlNode appsetting = configuration.AppendChild(savedoc.CreateElement("appSettings"));

				foreach(DataRow dr in dt.Rows)
				{
					XmlElement add = savedoc.CreateElement("add");

					XmlAttribute addkey = savedoc.CreateAttribute("key");
					addkey.Value = dr["KEY"].ToString();
					XmlAttribute addvalue = savedoc.CreateAttribute("value");
					addvalue.Value = dr["VALUE"].ToString();
					add.SetAttributeNode(addkey);
					add.SetAttributeNode(addvalue);
				
					appsetting.AppendChild(add);
				}

				savedoc.Save(configFile);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

		public static void SaveUpdateFile(DataTable dt, string configFile)
		{
			try
			{
				XmlDocument  savedoc = new XmlDocument();
				StreamReader xmlFile = new StreamReader(configFile);
				savedoc.Load(xmlFile);
				xmlFile.Close();

				foreach(DataRow dr in dt.Rows)
				{
					bool bExist = false;

					foreach(XmlElement item in savedoc.GetElementsByTagName("add"))
					{
						if (item.GetAttribute("key") == dr["KEY"].ToString())
						{
							bExist = true;
							item.SetAttribute("value", dr["VALUE"].ToString());
							break;
						}
					}

					if (!bExist)
					{
						XmlElement add = savedoc.CreateElement("add");

						XmlAttribute addkey = savedoc.CreateAttribute("key");
						addkey.Value = dr["KEY"].ToString();
						XmlAttribute addvalue = savedoc.CreateAttribute("value");
						addvalue.Value = dr["VALUE"].ToString();
						add.SetAttributeNode(addkey);
						add.SetAttributeNode(addvalue);

						XmlNode appsetting = savedoc.GetElementsByTagName("appSettings").Item(0);
				
						appsetting.AppendChild(add);
					}
				}

				savedoc.Save(configFile);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
	}
}
