using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Serializer
{
    [Serializable]
    public class Person : IDeserializationCallback
    {
        public string name { get; set; }
        public string address { get; set; }
        public long phoneNumber { get; set; }
        public DateTime dataRecorded { get; set; }
        [NonSerialized]
        private int _serial;

        public int Serial
        {
            get { return _serial; }
            set { _serial = value; }
        }

        public Person(string name, string address, long phoneNumber) 
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            dataRecorded = DateTime.Now;
        }

        public void OnDeserialization(object sender)
        {
            Match m = Regex.Match(Serializer.CurrFilePath, @"(?<=person).*?(?=.dat)");
            _serial = Int32.Parse(m.Value);
        }
    }
}
