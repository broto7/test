using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulacka15
{
    public partial class Form1 : Form
    {
        Pocet operation = new Pocet();
        public Form1()
        {
            InitializeComponent();
            operation.Op = true;
            operation.JeC = true;
        }

        private void buttonCis_Click(object sender, EventArgs e)
        {
            if (Vysledek.Text == "0" || (operation.Op))
                Vysledek.ResetText();
            operation.Op = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (operation.JeC)
                {
                    Vysledek.Text = Vysledek.Text + button.Text;
                    operation.JeC = false;
                }
            }
            else
                Vysledek.Text = Vysledek.Text + button.Text;
        }

        private void Vypocet_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation.Vypocet = button.Text;
            operation.Hodnota = double.Parse(Vysledek.Text);
            operation.Op = true;
            operation.JeC = true;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonVysl_Click(object sender, EventArgs e)
        {

            switch (operation.Vypocet)
            {
                case "+":
                    Vysledek.Text = Pocet.Scitani(operation.Hodnota, double.Parse(Vysledek.Text)).ToString();
                    break;
                case "-":
                    Vysledek.Text = Pocet.Odecitani(operation.Hodnota, double.Parse(Vysledek.Text)).ToString();
                    break;
                case "*":
                    Vysledek.Text = Pocet.Nasobeni(operation.Hodnota, double.Parse(Vysledek.Text)).ToString();
                    break;
                case "/":
                    Vysledek.Text = Pocet.Deleni(operation.Hodnota, double.Parse(Vysledek.Text)).ToString();
                    break;
                default:
                    break;
            }
            operation.Op = true;
            operation.JeC = true;

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            Vysledek.ResetText();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            Vysledek.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
