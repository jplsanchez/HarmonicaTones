using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicaTones.res
{
    class ByteFileCreator
    {
        string Filename = "Minor";
        public ByteFileCreator(string filename)
        {
            this.Filename = filename;
        }
        public void GenerateScaleByteFile(bool enable)
        {
            if (enable)
            {
                byte[] Scale = new byte[]
                {
                    1,
                    3,
                    4,
                    6,
                    8,
                    9,
                    11
                };
                File.WriteAllBytes(@"C:\Users\jpaul\source\repos\jplsanchez\HarmonicaTones\HarmonicaTones\res\scales\" + Filename, Scale);
            }

        }

    }
}
