using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileCompressor.Extensions;

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
            foreach (var f in targetFilePaths)
            {
                //ファイル名と同じフォルダを作成する。
                var zipDirectoryPath = this.CreateDirectory(f);
                //作成したフォルダにファイルをコピーする。
                this.CopyFile(f, zipDirectoryPath);
                //圧縮する。
                this.CompressFile(zipDirectoryPath);
            }
        }

        /// <summary>
        /// 圧縮対象ファイル名と同じ名前のフォルダを作成する。
        /// </summary>
        /// <param name="targetFilePath">圧縮対象ファイルパス</param>
        /// <remarks>作成したディレクトリパス</remarks>
        string CreateDirectory(string targetFilePath)
        {
            var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(targetFilePath);
            var createDirectoryPath = this.OutputDirectoryPath.AppendPathDelimiter();
            Directory.CreateDirectory(createDirectoryPath);

            return createDirectoryPath;
        }

        /// <summary>
        /// 指定したZip用ディレクトリ配下に圧縮対象ファイルをコピーする。
        /// </summary>
        /// <param name="targetFilePath">圧縮対象ファイルパス</param>
        /// <param name="zipDirectoryPath">Zip用ディレクトリパス</param>
        /// <returns></returns>
        string CopyFile(string targetFilePath, string zipDirectoryPath)
        {
            var destFilePath = zipDirectoryPath.AppendPathDelimiter() + Path.GetFileName(targetFilePath);
            File.Copy(targetFilePath, destFilePath);

            return destFilePath;
        }

        /// <summary>
        /// ファイルを圧縮する。
        /// </summary>
        /// <param name="targetDirectoryPath">圧縮対象のディレクトリパス</param>
        /// <returns>圧縮後のファイルパス</returns>
        string CompressFile(string targetDirectoryPath)
        {
            var archiveFilePath = this.GetArchiveFilePath(targetDirectoryPath);
            System.IO.Compression.ZipFile.CreateFromDirectory(targetDirectoryPath.RemoveLastPathDelimiter(), archiveFilePath);
            return archiveFilePath;
        }
    }
}
