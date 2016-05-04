using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search
{
    public partial class Matcher : Form
    {
        public Matcher()
        {
            InitializeComponent();
        }

        private void Matcher_Load(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBoxMatched.Items.Clear();
            var inputTxt = textBoxText.Text;
            string regexp = textBoxPattern.Text;

            var match = Regex.Matches(inputTxt, regexp);

            foreach (var m in match)
            {
                listBoxMatched.Items.Add(m);
            }
        }
    }
}
