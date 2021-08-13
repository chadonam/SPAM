using System.Drawing;

namespace SPAM.Common
{
    /// <summary>
    /// 클 래 스  명 : ResourceImage
    /// 작 성  목 적 : 리소스 이미지를 반환한다.
    /// </summary>
    public static class ResourceImage
    {
        /// <summary>
        /// 리소스 이미지를 반환한다.
        /// </summary>
        /// <param name="name">파일명</param>
        /// <returns></returns>
        public static Image GetImage(string name)
        {
            return (Image)Resource.ResourceManager.GetObject(name);
        }
    }
}
