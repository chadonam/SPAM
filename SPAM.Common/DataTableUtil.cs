using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SPAM.Common
{
    /// <summary>
    /// Config에 대한 요약 설명입니다.
    /// </summary>
    public class DataTableUtil
    {
        /// <summary>
        /// 두개의 칼럼 배열이 동일한지 여부를 확인한다.
        /// </summary>
        /// <param name="A">첫번째 칼럼배열</param>
        /// <param name="B">두번재 칼럼배열</param>
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
        /// 해당칼럼에 Distinct 데이타를 불러온다.
        /// </summary>
        /// <param name="TableName">테이블명</param>
        /// <param name="SourceTable">원보데이타테이블</param>
        /// <param name="FieldNames">칼럼명</param>
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
        /// 해당칼럼에 Distinct 데이타를 순서를 두고 불러온다.
        /// </summary>
        /// <param name="TableName">테이블명</param>
        /// <param name="SourceTable">원본데이타테이블</param>
        /// <param name="FieldNames">칼럼명</param>
        /// <param name="Order">순서</param>
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
        /// 데이타테이블을 Filter한다.
        /// </summary>
        /// <param name="dt">원본데이타테이블</param>
        /// <param name="filter">필터</param>
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
        /// 데이타테이블을 Sort한다.
        /// </summary>
        /// <param name="dt">원본데이타테이블</param>
        /// <param name="order">순서</param>
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
        /// 데이타테이블을 Filter 및 Sort한다.
        /// </summary>
        /// <param name="dt">원본데이타테이블</param>
        /// <param name="filter">필터</param>
        /// <param name="order">순서</param>
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
        /// 두개의 데이타테이블을 조인한다.
        /// </summary>
        /// <param name="dtFirst">첫번째 데이타테이블</param>
        /// <param name="dtSecond">두번째 데이타테이블</param>
        /// <param name="dcFirst">첫번째 데이타칼럼배열</param>
        /// <param name="dcSecond">두번째 데이타칼럼배열</param>
        /// <param name="isOuter">Outer Join 여부</param>
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
        /// 데이타테이블의 최소값/최대값을 불러온다.
        /// </summary>
        /// <param name="dt">원본 데이타테이블</param>
        /// <param name="colname">칼럼명</param>
        /// <param name="min">최소값</param>
        /// <param name="max">최대값</param>
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
        /// string을 List로 변경한다.
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
        /// List을 string으로 변경한다.
        /// </summary>
        /// <param name="lst">리스트</param>
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
