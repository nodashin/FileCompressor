using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCompressor.Compression
{
    /// <summary>
    /// GZipコンプレッサー
    /// </summary>
    public class GZipCompressor : CompressorBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="outputDirectoryPath">圧縮ファイル出力先ディレクトリパス</param>
        public GZipCompressor(string outputDirectoryPath) : base(outputDirectoryPath, ".gz")
        {
        }

        /// <summary>
        /// 圧縮する。
        /// </summary>
        /// <param name="targetFilePaths">対象ファイルパス群</param>
        public override void Compress(List<string> targetFilePaths)
        {
            foreach (var f in targetFilePaths)
            {
                //圧縮ファイルのパスを取得する。
                var archiveFilePath = this.GetArchiveFilePath(f);

                using (var inStream = new FileStream(f, FileMode.Open, FileAccess.Read))
                using (var outStream = new FileStream(archiveFilePath, FileMode.Create))
                using (var gzipStream = new GZipStream(outStream, CompressionMode.Compress))
                {
                    var num = 0;
                    var bytes = new byte[1024];
                    while ((num = inStream.Read(bytes, 0, bytes.Length)) > 0)
                        gzipStream.Write(bytes, 0, num);
                }
            }
        }
    }
}
