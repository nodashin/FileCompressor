using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileCompressor.Extensions;

namespace FileCompressor.Compression
{
    /// <summary>
    /// コンプレッサーBase
    /// </summary>
    public abstract class CompressorBase
    {
        /// <summary>
        /// 出力先ディレクトリパス
        /// </summary>
        public string OutputDirectoryPath { get; }

        /// <summary>
        /// 圧縮拡張子
        /// </summary>
        public string CompressionExtension { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="outputDirectoryPath">出力先ディレクトリパス</param>
        /// <param name="compressionExtension">圧縮拡張子</param>
        protected CompressorBase(string outputDirectoryPath, string compressionExtension)
        {
            OutputDirectoryPath = outputDirectoryPath;
            CompressionExtension = compressionExtension;
        }

        /// <summary>
        /// 圧縮する。
        /// </summary>
        /// <param name="targetFilePaths">対象ファイルパス群</param>
        public abstract void Compress(List<string> targetFilePaths);

        /// <summary>
        /// 圧縮ファイルパスを取得する。
        /// </summary>
        /// <param name="targetPath">圧縮対象パス</param>
        /// <returns>圧縮ファイルパス</returns>
        protected string GetArchiveFilePath(string targetPath)
            => targetPath.RemoveLastPathDelimiter() + this.CompressionExtension;
    }
}
