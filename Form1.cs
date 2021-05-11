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
    public partial class Form1 : Form
    {
        int StepCounter = 0;
        decimal Kreditwert;
        decimal Prozentsatz;
        private void EingabeBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && //erlaubt nur zahlen, punkt und minuszeichen
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // erlaubt nur einen Punkt/Minus 
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        public Form1()

        {

            InitializeComponent();
            this.EingabeBox1.KeyPress += new
            System.Windows.Forms.KeyPressEventHandler(EingabeBox1_KeyPress); //registriert Event
        }
        private void button3_Click(object sender, EventArgs e)
        //das ist der Weiter Button
        {
            if (StepCounter == 0)
            {
                try
                {
                    Kreditwert = decimal.Parse(EingabeBox1.Text);

                }
                catch (FormatException)
                {
                    MessageBox.Show("Bitte nur Zahlen eingeben", "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                EingabeBox1.Text = "";
                label2.Text = "Geben Sie nun den Prozentsatz ein";
                StepCounter++;

            }
            else if (StepCounter == 1)
            {
                try
                {
                    Prozentsatz = decimal.Parse(EingabeBox1.Text);

                }
                catch (FormatException)
                {
                    MessageBox.Show("Bitte nur Zahlen eingeben", "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                EingabeBox1.Text = "";

                decimal Ergebnis = (Kreditwert / 100 * Prozentsatz) + Kreditwert;
                MessageBox.Show("Kreditbetrag: " + Ergebnis, "Ergebnis", MessageBoxButtons.OK, MessageBoxIcon.Information);

                StepCounter = 0;
                Kreditwert = 0;
                Prozentsatz = 0;
                label2.Text = "Geben Sie hier den Kreditbetrag ein";

                //StepCounter++;

            }
            else if (StepCounter == 2)
            {


            }
        }

        private void Zahl_Click(object sender, EventArgs e)
        {
            Button Button1 = (Button)sender;
            EingabeBox1.Text = EingabeBox1.Text + Button1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        //Delete Button bzw Clear Button
        {
            EingabeBox1.Text = "";
        }

    }
}
