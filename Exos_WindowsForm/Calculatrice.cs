using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exos_WindowsForm
{
    public partial class Calculatrice : Form
    {
        public Calculatrice()
        {
            InitializeComponent();
        }
        string bufferChiffre1;
        string bufferChiffre2;
        double reponse;
        double bufferChiffreString;
        string operateur;
        double convertChiffre1;
        double convertChiffre2;
        double memoireMPlus = 0;

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            bufferChiffre1 = textBox1.Text;
            textBox2.Text = bufferChiffre1;
            operateur = "-";
            textBox1.Text += " - ";
            textBox2.Text += " - ";
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bufferChiffre1 = textBox1.Text;
            textBox2.Text = bufferChiffre1;
            operateur = "+";
            textBox1.Text += " + ";
            textBox2.Text += " + ";
            textBox1.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bufferChiffre1 = textBox1.Text;
            textBox2.Text = bufferChiffre1;
            operateur = "/";
            textBox1.Text += " / ";
            textBox2.Text += " / ";
            textBox1.Clear();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            bufferChiffre1 = textBox1.Text;
            textBox2.Text = bufferChiffre1;
            operateur = "*";
            textBox1.Text += " * ";
            textBox2.Text += " * ";
            textBox1.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (operateur == "+")
            {
                bufferChiffre2 = textBox1.Text;
                textBox2.Text += bufferChiffre2 + " = ";
                convertChiffre1 = Convert.ToDouble(bufferChiffre1);
                convertChiffre2 = Convert.ToDouble(bufferChiffre2);
                reponse = convertChiffre1 + convertChiffre2;
                textBox2.Text += reponse;
                textBox1.Text = Convert.ToString(reponse);
                convertChiffre1 = reponse;

            }
            else if (operateur == "*")
            {
                bufferChiffre2 = textBox1.Text;
                textBox2.Text += bufferChiffre2 + " = ";
                convertChiffre1 = Convert.ToDouble(bufferChiffre1);
                convertChiffre2 = Convert.ToDouble(bufferChiffre2);
                reponse = convertChiffre1 * convertChiffre2;
                textBox2.Text += reponse;
                textBox1.Text = Convert.ToString(reponse);
                convertChiffre1 = reponse;

            }
            else if (operateur == "/")
            {
                bufferChiffre2 = textBox1.Text;
                textBox2.Text += bufferChiffre2 + " = ";
                convertChiffre1 = Convert.ToDouble(bufferChiffre1);
                convertChiffre2 = Convert.ToDouble(bufferChiffre2);
                textBox2.Text += reponse;
                textBox1.Text = Convert.ToString(reponse);
                convertChiffre1 = reponse;


            }
            else if (operateur == "-")
            {
                bufferChiffre2 = textBox1.Text;
                textBox2.Text += bufferChiffre2 + " = ";
                convertChiffre1 = Convert.ToDouble(bufferChiffre1);
                convertChiffre2 = Convert.ToDouble(bufferChiffre2);
                reponse = convertChiffre1 - convertChiffre2;
                textBox2.Text += reponse;
                textBox1.Text = Convert.ToString(reponse);
                convertChiffre1 = reponse;

            }
        }
    }
}
