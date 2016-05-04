using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Serializer
{
    public partial class Serializer : Form
    {
        private int serial = 1;
        private List<Person> deserializedPersons = new List<Person>();
        private string[] personEntries = Directory.GetFiles(@"C:\Users\viczmandni\Documents\visual studio 2015\Projects\Week15B_Projects\Serializer\bin\Debug", "*.dat");
        public static string CurrFilePath { get; set; }

        public Serializer()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (serial<=99)
            {
                Person person = new Person(textBoxName.Text, textBoxAddress.Text, Convert.ToInt64(textBoxPhone.Text));
                string fileName = "person" + serial.ToString("D2") + ".dat";
                Serialize.Serializing(person, fileName);
                serial++;
                textBoxName.Text = string.Empty;
                textBoxAddress.Text = string.Empty;
                textBoxPhone.Text = string.Empty;
            }
        }

        private void Serializer_Load(object sender, EventArgs e)
        {
            foreach (var entry in personEntries)
            {
                CurrFilePath = Path.GetFileName(entry);
                deserializedPersons.Add(Serialize.Deserializing(entry));
            }
            Person p = deserializedPersons[0];
            textBoxName.Text = p.name;
            textBoxAddress.Text = p.address;
            textBoxPhone.Text = p.phoneNumber.ToString();
        }
    }
}
