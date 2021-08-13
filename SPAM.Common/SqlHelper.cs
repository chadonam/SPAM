using System;
using System.Data;
using System.Data.SqlClient;

namespace SPAM.Common
{

    public class SqlHelper
    {


        public static DataSet Fill(string spName)
        {
            return Fill(spName, null);
        }

        public static DataSet Fill(string spName, SqlParameter[] param)
        {
            return Fill(spName, param, ConfigHelper.DBConnectionString());
        }

        public static DataSet Fill(string spName, SqlParameter[] param, string ConnectionString)
        {
            DataSet dsReturn = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection())
                using (SqlCommand command = new SqlCommand())
                {
                    using (System.Data.SqlClient.SqlDataAdapter sda
                        = new System.Data.SqlClient.SqlDataAdapter(command))
                    {
                        command.CommandTimeout = 3600;
                        connection.ConnectionString = ConnectionString;
                        if (param != null)
                            command.Parameters.AddRange(param);
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = spName;
                        command.Connection = connection;

                        sda.Fill(dsReturn);
                    }
                }
                return dsReturn;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dsReturn != null) { dsReturn.Dispose(); dsReturn = null; }
            }

        }


        public static void ExecuteNonQuery(string spName, SqlParameter[] param)
        {
            ExecuteNonQuery(spName, param, ConfigHelper.DBConnectionString());
        }


        /// <summary>
        /// 연결에 대한 SP를 실행한다.  
        /// </summary>
        /// <param name="spName">SP Name</param>
        /// <param name="param">SqlParameter </param>
        /// <param name="connectionString">DataBase Connection String</param>
        public static void ExecuteNonQuery(string spName, SqlParameter[] param, string connectionString)
        {
            try
            {
                using (System.Data.SqlClient.SqlConnection connection
                    = new System.Data.SqlClient.SqlConnection())
                {
                    using (System.Data.SqlClient.SqlCommand command
                        = new System.Data.SqlClient.SqlCommand())
                    {
                        command.CommandTimeout = 3600;
                        if (param != null)
                            command.Parameters.AddRange(param);
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = spName;
                        command.Connection = connection;
                        connection.ConnectionString = connectionString;
                        connection.Open();

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
