using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCompressor.Compression
{
    /// <summary>
    /// Zipコンプレッサー
    /// </summary>
    public class ZipCompressor : CompressorBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="outputDirectoryPath">圧縮ファイル出力先ディレクトリパス</param>
        public ZipCompressor(string outputDirectoryPath) : base(outputDirectoryPath, ".zip")
        {
        }

        /// <summary>
        /// 圧縮する。
        /// </summary>
        /// <param name="targetFilePaths">対象ファイルパス群</param>
        public override void Compress(List<string> targetFilePaths)
        {
            throw new NotImplementedException();
        }
    }
}
