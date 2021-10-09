using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SPAM.Common
{
    /// <summary>
    /// Util�� ���� ��� �����Դϴ�.
    /// </summary>
    public class Utils
	{
        //����Ÿ���̺�� ȣ��Ǵ� �޺��ڽ� ���ε�
        public static void SetComboBox(ComboBox cb, DataTable dt, string displayColumn, string valueColumn, string strTxt)
        {
            ClientGlobal.FlagEnable = false;
            //�޺��ڽ� ���ε��� ���� �ӽ����̺��� �����.
            DataTable cdDt = new DataTable();
            cdDt.Columns.Add("Display", typeof(string));
            cdDt.Columns.Add("Value", typeof(string));

            if (!strTxt.Equals(string.Empty))
            {
                cdDt.Rows.Add(strTxt, string.Empty);
            }

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cdDt.Rows.Add(dt.Rows[i][displayColumn].ToString(), dt.Rows[i][valueColumn].ToString());
                }
            }

            cb.DataSource = null;
            //�޺��ڽ��� ������ ����
            cb.DataSource = cdDt;
            cb.DisplayMember = "Display";
            cb.ValueMember = "Value";

            if (cb.Items.Count > 0)
                cb.SelectedIndex = 0;

            ClientGlobal.FlagEnable = true;
        }

        //ParamPack��ü�� ���������� �޺��ڽ� ���ε�
        public static void SetComboBox(ComboBox cb, ParamPack param, string strTxt)
        {
            //�޺��ڽ� ���ε��� ���� �ӽ����̺��� �����.
            DataTable cdDt = new DataTable();
            cdDt.Columns.Add("Display", typeof(string));
            cdDt.Columns.Add("Value", typeof(string));

            if (!strTxt.Equals(string.Empty))
            {
                cdDt.Rows.Add(strTxt, string.Empty);
            }

            if (param.Count > 0)
            {
                for (int i = 0; i < param.Count; i++)
                {
                    cdDt.Rows.Add(param.Items[i].ToString(), param.Params[i].ToString());
                }
            }

            cb.DataSource = null;
            //�޺��ڽ��� ������ ����
            cb.DataSource = cdDt;
            cb.DisplayMember = "Display";
            cb.ValueMember = "Value";

            if (cb.Items.Count > 0)
                cb.SelectedIndex = 0;
        }

        //������
        public static string ChgString(object val)
        {
            string reVal = string.Empty;
            try
            {
                reVal = val.ToString();
            }
            catch
            {
                reVal = string.Empty;
            }

            return reVal;

        }

        //DataTable Pivot ��ȯ
        public static DataTable DataPivot(DataTable dt)
        {
            DataTable newDt = new DataTable();

            int dtColCnt = dt.Columns.Count;
            int dtRowCnt = dt.Rows.Count;

            newDt.Columns.Add(dt.Columns[0].ColumnName, typeof(string));

            for (int i = 0; i < dtRowCnt; i++)
            {
                newDt.Columns.Add(dt.Rows[i][0].ToString(), typeof(string));
            }

            //�÷��� �����ϰ� ��迭�� �Է�
            for (int i = 1; i < dtColCnt; i++)
            {
                DataRow dr = newDt.NewRow();

                dr[0] = dt.Columns[i].ColumnName;

                for (int j = 0; j < dtRowCnt; j++)
                {
                    dr[j + 1] = dt.Rows[j][i].ToString();
                }
                newDt.Rows.Add(dr);
            }

            return newDt;
        }

        //123,456.6 ������ �ѹ�����
        public static string ChgNumber(string number)
        {
            string reVal = string.Empty;
            try
            {
                reVal = Convert.ToDouble(number).ToString("###,###,##0.0");
            }
            catch 
            {
                reVal = number;
            }

            return reVal;

        }

        //123,456 ������ �ѹ�����
        public static string ChgCount(string number)
        {
            string reVal = string.Empty;
            try
            {
                reVal = Convert.ToInt32(number).ToString("###,###,##0");
            }
            catch
            {
                reVal = number;
            }

            return reVal;

        }

        #region [NULL �� ó�� ���� �߰� - 2015.02.04 ���¿�]
        /// <summary>
        /// NULL�� ó�� ����
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="def"></param>
        /// <returns></returns>
        public static string nvlString(object obj, string def = "")
        {
            if (obj == null)
                return def;

            if (obj == DBNull.Value)
                return def;

            if (obj.ToString() == "")
                return def;

            return obj.ToString().Trim();
        }

        public static double nvlInt(object obj, double def = 0)
        {
            if (obj == null)
                return def;

            if (obj == DBNull.Value)
                return def;

            if (obj.ToString() == "")
                return def;

            return Convert.ToInt32(obj);
        }

        public static double nvlDouble(object obj, double def = 0.0)
        {
            if (obj == null)
                return def;

            if (obj == DBNull.Value)
                return def;

            if (obj.ToString() == "")
                return def;

            return Convert.ToDouble(obj);
        }

        public static bool nvlBoolean(object obj, bool def = false)
        {
            if (obj == null)
                return def;

            if (obj == DBNull.Value)
                return def;

            if (obj.ToString() == "")
                return def;

            return Convert.ToBoolean(obj);
        }

        public static DateTime nvlDateTime(object obj)
        {
            try
            {
                if (obj == null)
                    return Convert.ToDateTime("2000-01-01 00:00:00");

                if (obj == DBNull.Value)
                    return Convert.ToDateTime("2000-01-01 00:00:00");

                if (obj.ToString() == "")
                    return Convert.ToDateTime("2000-01-01 00:00:00");

                return Convert.ToDateTime(obj);
            }
            catch (Exception)
            {
                return DateTime.Now;
            }
        }
        #endregion

        #region ���� ó��
        public static string GetLanguage(string msg)
        {
            string rtnString = "";

            DataSet dsResult = null;

            string spName = string.Empty;
            SqlParameter[] param = null;
            try
            {
                spName = "SGetDictionary";

                param = new SqlParameter[2];
                param[0] = new SqlParameter("@Language", ClientGlobal.Language);
                param[1] = new SqlParameter("@Message", msg);

                dsResult = SqlHelper.Fill(spName, param);

                rtnString = dsResult.Tables[0].Rows[0][0].ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dsResult != null) { dsResult.Dispose(); dsResult = null; }
            }

            return rtnString;
        }

        #endregion
    }
}
