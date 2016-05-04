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
        private string _name;
        private string _address;
        private long _phoneNumber;
        private DateTime _dataRecorded;
        [NonSerialized]
        private int _serial;

        public int Serial
        {
            get { return _serial; }
            set { _serial = value; }
        }

        public Person(string name, string address, long phoneNumber) 
        {
            _name = name;
            _address = address;
            _phoneNumber = phoneNumber;
            _dataRecorded = DateTime.Now;
        }

        public void OnDeserialization(object sender)
        {
            var numb = Regex.Matches(fileName, "\\d{1,2}");
            foreach (var n in numb)
            {
                _serial = (int)n;
            }
        }
    }
}
