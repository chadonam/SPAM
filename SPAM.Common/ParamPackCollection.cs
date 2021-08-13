using System;
using System.Collections;

namespace SPAM.Common
{
    /// <summary>
    /// ParamPack 클래스의 Strong Type Collection 클래스입니다.
    /// </summary>
    [Serializable]
    public class ParamPackCollection : CollectionBase
    {
        /// <summary>
        /// ParamPack 개체를 Collection 의 끝 부분에 추가합니다.
        /// </summary>
        /// <param name="paramPack"></param>
        public void Add(ParamPack paramPack)
        {
            List.Add(paramPack);
        }

        /// <summary>
        /// Collection 에서 주어진 ParamPack 개체를 제거합니다.
        /// </summary>
        /// <param name="paramPack"></param>
        public void Remove(ParamPack paramPack)
        {
            List.Remove(paramPack);
        }

        /// <summary>
        /// 주어진 ParamPack 객체의 Collection에서 Index 반환
        /// </summary>
        /// <param name="paramPack"></param>
        /// <returns></returns>
        public int IndexOf(ParamPack paramPack)
        {
            return List.IndexOf(paramPack);
        }

        /// <summary>
        /// 주어진 ParamPack 객체를 포함하고 있는지 여부 반환
        /// </summary>
        /// <param name="paramPack"></param>
        /// <returns></returns>
        public bool Contains(ParamPack paramPack)
        {
            return List.Contains(paramPack);
        }

        /// <summary>
        /// 특정한 인덱스에 있는 ParamPack 객체 반환
        /// </summary>
        public ParamPack this[int index]
        {
            get
            {
                if ((index >= 0) && (index < base.List.Count))
                {
                    return (ParamPack)List[index];
                }
                else
                {
                    throw new IndexOutOfRangeException(String.Format("index 는 0에서 {0} 사이의 정수여야 합니다.", List.Count));
                }
            }
            set
            {
                List[index] = value;
            }
        }
    }
}
