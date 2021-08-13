using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SPAM.Common
{
    /// <summary>
    /// Config�� ���� ��� �����Դϴ�.
    /// </summary>
    public class DataTableUtil
    {
        /// <summary>
        /// �ΰ��� Į�� �迭�� �������� ���θ� Ȯ���Ѵ�.
        /// </summary>
        /// <param name="A">ù��° Į���迭</param>
        /// <param name="B">�ι��� Į���迭</param>
        /// <returns></returns>
        private static bool ColumnEqual(object[] A, object[] B)
        {
            bool bResult = true;
            try
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == DBNull.Value && B[i] == DBNull.Value)
                        bResult = bResult && true;
                    if (A[i] == DBNull.Value || B[i] == DBNull.Value)
                        bResult = bResult && false;
                    if (A[i] == null && B[i] == null)
                        bResult = bResult && true;
                    if (A[i] == null || B[i] == null)
                        bResult = bResult && false;
                }

                if (!bResult) return false;

                for (int j = 0; j < A.Length; j++)
                {
                    if (A[j].Equals(B[j])) bResult = bResult && true;
                    else bResult = bResult && false;
                }

                return bResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// �ش�Į���� Distinct ����Ÿ�� �ҷ��´�.
        /// </summary>
        /// <param name="TableName">���̺��</param>
        /// <param name="SourceTable">��������Ÿ���̺�</param>
        /// <param name="FieldNames">Į����</param>
        /// <returns></returns>
        public static DataTable SelectDistinct(string TableName, DataTable SourceTable, string FieldNames)
        {
            string[] FieldName = null;
            object[] LastValue = null;
            object[] CurrValue = null;
            DataTable dt = null;
            try
            {
                FieldName = FieldNames.Split(',');
                dt = new DataTable(TableName);
                LastValue = new object[FieldName.Length];
                CurrValue = new object[FieldName.Length];

                for (int i = 0; i < FieldName.Length; i++)
                {
                    dt.Columns.Add(FieldName[i], SourceTable.Columns[FieldName[i]].DataType);
                }

                foreach (DataRow dr in SourceTable.Select("", FieldNames))
                {
                    for (int col = 0; col < FieldName.Length; col++)
                    {
                        CurrValue[col] = dr[FieldName[col]];
                    }

                    if (LastValue == null || !(ColumnEqual(LastValue, CurrValue)))
                    {
                        CurrValue.CopyTo(LastValue, 0);
                        dt.Rows.Add(LastValue);
                    }
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (FieldName != null) FieldName = null;
                if (LastValue != null) LastValue = null;
                if (CurrValue != null) CurrValue = null;
                if (dt != null) dt.Dispose();
            }
        }

        /// <summary>
        /// �ش�Į���� Distinct ����Ÿ�� ������ �ΰ� �ҷ��´�.
        /// </summary>
        /// <param name="TableName">���̺��</param>
        /// <param name="SourceTable">��������Ÿ���̺�</param>
        /// <param name="FieldNames">Į����</param>
        /// <param name="Order">����</param>
        /// <returns></returns>
        public static DataTable SelectDistinct(string TableName, DataTable SourceTable, string FieldNames, string Order)
        {
            string[] FieldName = null;
            object[] LastValue = null;
            object[] CurrValue = null;
            DataTable dt = null;
            DataTable dtOrder = null;
            try
            {
                dtOrder = DataTableUtil.SortDataTable(SourceTable, Order);

                FieldName = FieldNames.Split(',');
                dt = new DataTable(TableName);
                LastValue = new object[FieldName.Length];
                CurrValue = new object[FieldName.Length];

                for (int i = 0; i < FieldName.Length; i++)
                {
                    dt.Columns.Add(FieldName[i], dtOrder.Columns[FieldName[i]].DataType);
                }

                foreach (DataRow dr in dtOrder.Select("", FieldNames))
                {
                    for (int col = 0; col < FieldName.Length; col++)
                    {
                        CurrValue[col] = dr[FieldName[col]];
                    }

                    if (LastValue == null || !(ColumnEqual(LastValue, CurrValue)))
                    {
                        CurrValue.CopyTo(LastValue, 0);
                        dt.Rows.Add(LastValue);
                    }
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (FieldName != null) FieldName = null;
                if (LastValue != null) LastValue = null;
                if (CurrValue != null) CurrValue = null;
                if (dtOrder != null) { dtOrder.Dispose(); dtOrder = null; }
                if (dt != null) { dt.Dispose(); dt = null; }
            }
        }

        /// <summary>
        /// ����Ÿ���̺��� Filter�Ѵ�.
        /// </summary>
        /// <param name="dt">��������Ÿ���̺�</param>
        /// <param name="filter">����</param>
        /// <returns></returns>
        public static DataTable FilterDataTable(DataTable dt, string filter)
        {
            DataTable dtReturn = null;
            DataView dv = null;
            DataRowView drv = null;
            try
            {
                dtReturn = dt.Clone();

                dv = dt.DefaultView;
                dv.RowFilter = filter;

                for (int i = 0; i < dv.Count; i++)
                {
                    drv = dv[i];

                    dtReturn.ImportRow(drv.Row);
                }

                dtReturn.AcceptChanges();

                return dtReturn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dtReturn != null) dtReturn.Dispose();
            }
        }

        /// <summary>
        /// ����Ÿ���̺��� Sort�Ѵ�.
        /// </summary>
        /// <param name="dt">��������Ÿ���̺�</param>
        /// <param name="order">����</param>
        /// <returns></returns>
        public static DataTable SortDataTable(DataTable dt, string order)
        {
            DataTable dtReturn = null;
            DataView dv = null;
            DataRowView drv = null;
            try
            {
                dtReturn = dt.Clone();

                dv = dt.DefaultView;
                dv.Sort = order;

                for (int i = 0; i < dv.Count; i++)
                {
                    drv = dv[i];

                    dtReturn.ImportRow(drv.Row);
                }

                dtReturn.AcceptChanges();

                return dtReturn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dtReturn != null) dtReturn.Dispose();
            }
        }

        /// <summary>
        /// ����Ÿ���̺��� Filter �� Sort�Ѵ�.
        /// </summary>
        /// <param name="dt">��������Ÿ���̺�</param>
        /// <param name="filter">����</param>
        /// <param name="order">����</param>
        /// <returns></returns>
        public static DataTable FilterSortDataTable(DataTable dt, string filter, string order)
        {
            DataTable dtReturn = null;
            DataTable dtSort = null;
            try
            {
                dtSort = DataTableUtil.SortDataTable(dt, order);

                dtReturn = DataTableUtil.FilterDataTable(dtSort, filter);

                return dtReturn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dtReturn != null) { dtReturn.Dispose(); dtReturn = null; }
                if (dtSort != null) { dtSort.Dispose(); dtSort = null; }
            }
        }

        /// <summary>
        /// �ΰ��� ����Ÿ���̺��� �����Ѵ�.
        /// </summary>
        /// <param name="dtFirst">ù��° ����Ÿ���̺�</param>
        /// <param name="dtSecond">�ι�° ����Ÿ���̺�</param>
        /// <param name="dcFirst">ù��° ����ŸĮ���迭</param>
        /// <param name="dcSecond">�ι�° ����ŸĮ���迭</param>
        /// <param name="isOuter">Outer Join ����</param>
        /// <returns></returns>
        public static DataTable JoinDataTable(DataTable dtFirst, DataTable dtSecond, DataColumn[] dcFirst, DataColumn[] dcSecond, bool isOuter)
        {
            DataTable dtResult = null;
            DataSet ds = null;
            DataRelation dr = null;

            try
            {
                ds = new DataSet();

                ds.Tables.AddRange(new DataTable[] { dtFirst.Copy(), dtSecond.Copy() });

                DataColumn[] parentColumn = new DataColumn[dcFirst.Length];
                for (int i = 0; i < parentColumn.Length; i++)
                {
                    parentColumn[i] = ds.Tables[0].Columns[dcFirst[i].ColumnName];
                }

                DataColumn[] childColumn = new DataColumn[dcSecond.Length];
                for (int i = 0; i < childColumn.Length; i++)
                {
                    childColumn[i] = ds.Tables[1].Columns[dcSecond[i].ColumnName];
                }

                try
                {
                    dr = new DataRelation(string.Empty, parentColumn, childColumn, false);
                    ds.Relations.Add(dr);
                }
                catch
                {
                    return null;
                }

                dtResult = new DataTable(dtFirst.TableName + "_" + dtSecond.TableName);

                for (int i = 0; i < dtFirst.Columns.Count; i++)
                {
                    dtResult.Columns.Add(dtFirst.TableName + "_" + dtFirst.Columns[i].ColumnName, dtFirst.Columns[i].DataType);
                }

                for (int i = 0; i < dtSecond.Columns.Count; i++)
                {
                    dtResult.Columns.Add(dtSecond.TableName + "_" + dtSecond.Columns[i].ColumnName, dtSecond.Columns[i].DataType);
                }

                dtResult.BeginLoadData();

                foreach (DataRow firstrow in ds.Tables[0].Rows)
                {
                    DataRow[] childrow = firstrow.GetChildRows(dr);
                    object[] parentarray = firstrow.ItemArray;
                    if (childrow != null && childrow.Length > 0)
                    {
                        foreach (DataRow secondrow in childrow)
                        {
                            object[] childarray = secondrow.ItemArray;
                            object[] joinarray = new object[parentarray.Length + childarray.Length];
                            Array.Copy(parentarray, 0, joinarray, 0, parentarray.Length);
                            Array.Copy(childarray, 0, joinarray, parentarray.Length, childarray.Length);
                            dtResult.LoadDataRow(joinarray, true);
                        }
                    }
                    else
                    {
                        if (isOuter)
                        {
                            object[] joinarray = new object[parentarray.Length];
                            Array.Copy(parentarray, 0, joinarray, 0, joinarray.Length);
                            dtResult.LoadDataRow(joinarray, true);
                        }
                    }
                }

                dtResult.EndLoadData();

                foreach (DataColumn col in dcSecond)
                {
                    if (dtResult.Columns.Contains(dtSecond.TableName + "_" + col.ColumnName))
                        dtResult.Columns.Remove(dtSecond.TableName + "_" + col.ColumnName);
                }

                dtResult.AcceptChanges();

                return dtResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dtResult != null) { dtResult.Dispose(); dtResult = null; }
                if (ds != null) { ds.Dispose(); ds = null; }
                if (dr != null) { dr = null; }
            }
        }

        /// <summary>
        /// ����Ÿ���̺��� �ּҰ�/�ִ밪�� �ҷ��´�.
        /// </summary>
        /// <param name="dt">���� ����Ÿ���̺�</param>
        /// <param name="colname">Į����</param>
        /// <param name="min">�ּҰ�</param>
        /// <param name="max">�ִ밪</param>
        public static void SelectMinMax(DataTable dt, string colname, out object min, out object max)
        {
            try
            {
                DataRow[] dr = dt.Select("", colname);

                min = dr[0][colname];
                max = dr[dr.Length - 1][colname];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        /// <summary>
        /// string�� List�� �����Ѵ�.
        /// </summary>
        /// <param name="str">string</param>
        /// <returns></returns>
        public static List<string> GetArrayList(string str)
        {
            List<string> alResult = null;
            string[] strArray = null;
            try
            {
                alResult = new List<string>();
                strArray = str.Split(',');

                for (int i = 0; i < strArray.Length; i++)
                {
                    alResult.Add(strArray[i]);
                }

                return alResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                strArray = null;
            }
        }

        /// <summary>
        /// List�� string���� �����Ѵ�.
        /// </summary>
        /// <param name="lst">����Ʈ</param>
        /// <returns></returns>
        public static string GetString(List<string> lst)
        {
            StringBuilder sb = null;
            try
            {
                sb = new StringBuilder();
                for (int i = 0; i < lst.Count; i++)
                {
                    sb.AppendFormat("{0},", lst[i].ToString());
                }
                if (sb.Length > 0)
                    sb.Remove(sb.Length - 1, 1);

                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sb != null) sb = null;
            }
        }
    }
}
