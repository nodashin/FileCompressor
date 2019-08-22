using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCompressor
{
    /// <summary>
    /// ファイルローダー
    /// </summary>
    public class FileLoader
    {
        /// <summary>
        /// ロードするファイルを格納してあるディレクトリのパス
        /// </summary>
        public string DirectoryPath { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="directoryPath">ロードするファイルを格納してあるディレクトリのパス</param>
        public FileLoader(string directoryPath)
        {
            DirectoryPath = directoryPath;
        }

        /// <summary>
        /// ファイルをロードする。
        /// </summary>
        /// <returns>ロードしたファイル群</returns>
        public IEnumerable<FileInfo> LoadFiles()
        {
            foreach (var p in Directory.GetFiles(this.DirectoryPath))
                yield return new FileInfo(p);
        }
    }
}
