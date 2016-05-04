using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializer
{
    class FileHandler
    {
        public static FileInfo EarliestFile(string path, string ext)
        {
            string[] personEntries = Directory.GetFiles(path, ext);
            foreach (var entry in personEntries)
            {
                FileInfo file = new FileInfo(entry);
            }
            return null;
        }

    }
}
