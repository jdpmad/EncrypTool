using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncrypTool
{
    class FileRW
    {
        public static string ReadInputFile()
        {
            return File.ReadAllText(Variables.inputFileLoc);
        }

        public static void SaveOutputFile(string path, string processedText)
        {
            File.WriteAllText(path, processedText);
        }
    }
}
