using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCompressor.Extensions
{
    /// <summary>
    /// String拡張メソッド
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// パスの最後にパス区切り文字を加える。
        /// </summary>
        /// <param name="path">パス</param>
        /// <returns>パス区切り文字を加えたパス</returns>
        public static string AppendPathDelimiter(this string path)
        {
            if (path.EndsWith(@"\"))
                return path;
            return path + @"\";
        }

        /// <summary>
        /// パスの最後のパス区切り文字を取り除く。
        /// </summary>
        /// <param name="path">パス</param>
        /// <returns>パス区切り文字を取り除いたパス</returns>
        public static string RemoveLastPathDelimiter(this string path)
        {
            if (path.EndsWith(@"\"))
                return path.Remove(path.Length - 1, 1);
            return path;
        }
    }
}
