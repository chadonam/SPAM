using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;

namespace SPAM.Common
{
    /// <summary>
    ///Layer 간 다량 데이터 전달에 사용할 클래스

    /// </summary>
    /// <remarks>
    /// ArrayList 를 기반으로 하여 쿼리에 넣을 순서대로 데이터를 객체에 추가하도록 한다.
    /// </remarks>
    [Serializable]
    public class ParamPack : ISerializable
    {
        /// <summary>
        /// 기본 용량
        /// </summary>
        private const int DEFAULT_CAPACITY = 10;

        /// <summary>
        /// 파라미터값을 저장할 ArrayList 객체
        /// </summary>
        private ArrayList _params;
        private Dictionary<string, int> _Idxparams;
        private Dictionary<int, string> _itemparams;

        /// <summary>
        /// 기본 생성자, 10개로 초기화

        /// </summary>
        public ParamPack()
            : this(DEFAULT_CAPACITY)
        {

        }

        /// <summary>
        /// ParamPack에 추가할 데이터 개수를 지정하여 ParamPack 생성
        /// </summary>
        /// <param name="capacity"></param>
        public ParamPack(int capacity)
        {
            this._params = new ArrayList(capacity);
            this._Idxparams = new Dictionary<string, int>();
            this._itemparams = new Dictionary<int, string>();
        }

        /// <summary>
        /// Serialization 생성자

        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public ParamPack(SerializationInfo info, StreamingContext context)
        {
            _params = (ArrayList)info.GetValue("ParamPack_Value", typeof(ArrayList));
        }


        /// <summary>
        /// 데이터를 ParamPack에 추가합니다.
        /// </summary>
        /// <param name="data">추가할 데이터값</param>
        /// <returns>값이 추가된 인덱스</returns>
        public int Add(object data)
        {
            return this._params.Add(data);
        }

        public void Add(string sIdxString, object data)
        {
            int nIdx = this._params.Add(data);
            _Idxparams.Add(sIdxString, nIdx);
            _itemparams.Add(nIdx, sIdxString);
        }

        /// <summary>
        /// 데이터를 삭제합니다.
        /// </summary>
        public void Clear()
        {
            this._params.Clear(); //초기화

            this._Idxparams.Clear(); //초기화

            this._itemparams.Clear(); //초기화

        }

        /// <summary>
        /// 데이터를 ParamPack에 추가합니다.
        /// </summary>
        /// <param name="data">추가할 데이터값</param>
        /// <returns>값이 추가된 인덱스</returns>
        public int Add(string data)
        {
            return this._params.Add(data.Trim());
        }

        /// <summary>
        /// 특정한 인덱스에 데이터를 추가합니다.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="data"></param>
        public void Insert(int index, object data)
        {
            this._params.Insert(index, data);
        }


        /// <summary>
        /// 데이터 배열을 ParamPack에 추가시킵니다.
        /// </summary>
        /// <param name="data">ParamPack 에 추가할 데이터 배열</param>
        public void AddRange(object[] data)
        {
            this._params.AddRange(data);
        }

        /// <summary>
        /// 특정 인덱스의 요소를 삭제
        /// </summary>
        /// <param name="index">ParamPack 에서 제거할 요소의 인덱스</param>
        public void RemoveAt(int index)
        {
            string item = this._itemparams[index].ToString();
            this._Idxparams.Remove(item);
            this._itemparams.Remove(index);
            this._params.RemoveAt(index);
        }

        public void RemoveAt(string item)
        {
            int index = int.Parse(_Idxparams[item].ToString());
            this._Idxparams.Remove(item);
            this._itemparams.Remove(index);
            this._params.RemoveAt(index);

        }

        /// <summary>
        /// ArrayList에서 요소의 범위를 제거합니다.
        /// </summary>
        /// <param name="index">제거할 요소의 범위에 대한 인덱스(0부터 시작)</param>
        /// <param name="count">제거할 요소의 수</param>
        public void RemoveRange(int index, int count)
        {
            this._params.RemoveRange(index, count);
        }

        /// <summary>
        /// 특정한 인덱스에 있는 Value 값 반환
        /// </summary>
        public object this[int index]
        {
            get
            {
                if ((index >= 0) && (index < this._params.Count))
                {
                    return this._params[index];
                }
                else
                {
                    throw new IndexOutOfRangeException(String.Format("index 는 0에서 {0} 사이의 정수여야 합니다.", _params.Count));
                }
            }
            set
            {
                if ((index >= 0) && (index < this._params.Count))
                {
                    this._params[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException(String.Format("index 는 0에서 {0} 사이의 정수여야 합니다.", _params.Count));
                }
            }
        }

        public object this[string IndexString]
        {

            get
            {
                if (true == _Idxparams.ContainsKey(IndexString))
                {
                    int nIdx = this._Idxparams[IndexString];
                    return this._params[nIdx];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (true == _Idxparams.ContainsKey(IndexString))
                {
                    int nIdx = this._Idxparams[IndexString];
                    this._params[nIdx] = value;
                }
                else
                {
                    throw new Exception("Index key가 존재하지 않습니다.");
                }
            }
        }

        /// <summary>
        /// 데이터를 담고 있는 ArrayList형의 _params를 리턴하는 속성
        /// </summary>
        public ArrayList Params
        {
            get
            {
                return this._params;
            }
        }

        /// <summary>
        /// 데이터를 담고 있는 Dictionary<string, int>형의 _items를 리턴하는 속성
        /// </summary>
        public Dictionary<int, string> Items
        {
            get
            {
                return this._itemparams;
            }
        }

        /// <summary>
        /// 객체가 담고 있는 데이타의 개수를 가져오는 속성
        /// </summary>
        public int Count
        {
            get
            {
                return this._params.Count;
            }
        }

        /// <summary>
        /// 매개변수로 주어진 데이터행을 가지고 있는 데이터값으로 채운다.
        /// </summary>
        /// <param name="dr"></param>
        public void ToDataRow(DataRow dr)
        {
            if (dr == null)
            {
                throw new ArgumentNullException();
            }
            if (dr.ItemArray.Length == _params.Count)
            {
                for (int i = 0; i < _params.Count; i++)
                {
                    dr[i] = _params[i];
                }
            }
            else
            {
                throw new ApplicationException("DataRow의 길이와 ParamPack의 길이가 일치하지 않습니다.");
            }
        }

        /// <summary>
        /// 가지고 있는 데이터 값을 바탕으로 데이터행을 초기화한 후 반환한다.
        /// </summary>
        /// <returns></returns>
        public DataRow ToDataRow()
        {
            string columnFormat = "Column{0}";
            string columnName = "";
            DataTable table = new DataTable();
            DataRow dr = table.NewRow();


            for (int i = 0; i < _params.Count; i++)
            {
                columnName = String.Format(columnFormat, i + 1);

                object oValue = this._params[i];
                if (oValue is DBNull)
                {
                    table.Columns.Add(columnName); // Column1, Column2 형태로 컬럼 이름을 넣음
                }
                else
                {
                    table.Columns.Add(columnName, oValue.GetType());
                }
                dr[columnName] = oValue;
            }

            return dr;
        }

        /// <summary>
        /// DataRow 로부터 ParamPack 객체를 생성해서 반환합니다.
        /// </summary>
        /// <param name="dr">ParamPack 으로 변환활 DataRow</param>
        /// <returns></returns>
        public static ParamPack FromDataRow(DataRow dr)
        {
            if (dr == null)
            {
                throw new ArgumentNullException();
            }

            ParamPack paramPack = new ParamPack(dr.ItemArray.Length);
            paramPack.AddRange(dr.ItemArray);
            return paramPack;
        }

        /// <summary>
        /// DataSet 로부터 ParamPack 객체를 생성해서 반환합니다.
        /// </summary>
        /// <remarks>
        /// DataSet 의 첫번째 테이블의 첫 DataRow 로부터 변환을 수행합니다.
        /// </remarks>
        /// <param name="ds">ParamPack 으로 변환활 DataSet</param>
        /// <returns></returns>
        public static ParamPack FromDataSet(DataSet ds)
        {
            if (ds == null)
            {
                throw new ArgumentNullException();
            }
            if (ds.Tables.Count < 1
                || ds.Tables[0].Rows.Count < 1)
            {
                return null;
            }
            return FromDataRow(ds.Tables[0].Rows[0]);
        }

        /// <summary>
        /// DataTable 로부터 ParamPack 객체를 생성해서 반환합니다.
        /// </summary>
        /// <remarks>
        /// DataTable 첫 DataRow 로부터 변환을 수행합니다.
        /// </remarks>
        /// <param name="table">ParamPack 으로 변환활 DataSet</param>
        /// <returns></returns>
        public static ParamPack FromDataTable(DataTable table)
        {
            if (table == null)
            {
                throw new ArgumentNullException();
            }
            if (table.Rows.Count < 1)
            {
                return null;
            }

            return FromDataRow(table.Rows[0]);
        }


        /// <summary>
        /// Null 처리 유틸
        /// </summary>
        /// <param name="data">Null 검사할 데이터</param>
        /// <returns>Null 일 경우 DBNull.Value 로 변환하여 넘김</returns>
        private static object ProcessDBNull(object data)
        {
            if (data == null || data.ToString() == String.Empty)
            {
                return DBNull.Value;
            }
            else
            {
                return data;
            }
        }

        #region Implementation of ISerializable
        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            info.AddValue("ParamPack_Value", _params);
        }
        #endregion

    }
}
