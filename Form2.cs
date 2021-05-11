using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kreditberechnung
{
    public partial class Form2 : Form
    {
        public Form2(string String_Wert)
        {
            InitializeComponent();
            EingabeBox1.Text = String_Wert;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
