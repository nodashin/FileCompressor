using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCompressor.Compression
{
    /// <summary>
    /// コンプレッサーFactory
    /// </summary>
    public static class CompressorFactory
    {
        /// <summary>
        /// コンプレッサーを作成する。
        /// </summary>
        /// <param name="compressionTypeIndex">圧縮タイプIndex</param>
        /// <param name="outputDirectoryPath">圧縮ファイル出力先ディレクトリパス</param>
        /// <returns>コンプレッサー</returns>
        public static CompressorBase Create(int compressionTypeIndex, string outputDirectoryPath)
        {
            switch(compressionTypeIndex)
            {
                case 0:
                    return new ZipCompressor(outputDirectoryPath);
                case 1:
                    return new GZipCompressor(outputDirectoryPath);
                default:
                    throw new ArgumentException($"圧縮タイプIndexが不正：{compressionTypeIndex}");
            }
        }
    }
}
