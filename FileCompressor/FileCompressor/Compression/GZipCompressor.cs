using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCompressor.Compression
{
    public class GZipCompressor : CompressorBase
    {
        public GZipCompressor(string outputDirectoryPath, string compressionExtension) : base(outputDirectoryPath, compressionExtension)
        {
        }

        public override void Compress(List<string> targetFilePaths)
        {
            throw new NotImplementedException();
        }
    }
}
