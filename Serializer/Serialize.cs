using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serializer
{
    class Serialize
    {
        public static void Serializing(Person person, string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, person);
            fs.Close();
        }

        public static void Deserializing(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            formatter.Deserialize(fs);
            fs.Close();
        }
    }
}
