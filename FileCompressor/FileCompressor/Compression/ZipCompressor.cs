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
        public ZipCompressor(string outputDirectoryPath) : base(outputDirectoryPath, ".zip")
        {
        }

        public override void Compress(List<string> targetFilePaths)
        {
            throw new NotImplementedException();
        }
    }
}
