using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kreditberechnung;

namespace Kreditberechnung
{
    public partial class KreditAuswahl : Form
    {
        public KreditAuswahl()
        {
            InitializeComponent();
        }

        private void btn_EinmalKredit_Click(object sender, EventArgs e)
        {
            var newForm = new EinmalKreditForm1();
            newForm.Show();
        }
    }
}
