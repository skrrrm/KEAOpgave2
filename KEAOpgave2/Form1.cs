using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEAOpgave2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Variabler
        double a, b, res;
        private void buttonSum_Click(object sender, EventArgs e) // Crasher hvis der ikke indskrives tal
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text); // Konvertere textbox1 til en double, så der kan regnes på det, da det jo er en string
                b = Convert.ToDouble(textBox2.Text); // --------- || ---------
            }
            catch
            {
                labelResult.Text = "Indtast kun tal";
            }

            res = a + b; // Lægger a og b sammen og konvertere til tekst
            labelResult.Text = Convert.ToString(res); // Konvertere 'res' til en string så den kan smækkes ind i 'labelResult'

        }
    }
}
