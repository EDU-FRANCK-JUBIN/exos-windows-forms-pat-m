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
    public partial class Jeu : Form
    {
        List<Image> pictures = new List<Image>();
        Random rand = new Random();
        public Jeu()
        {
            InitializeComponent();
            pictures.Add(Properties.Resources._1);
            pictures.Add(Properties.Resources._2);
            pictures.Add(Properties.Resources._3);
            pictures.Add(Properties.Resources._4);
            pictures.Add(Properties.Resources._5);
            pictures.Add(Properties.Resources._6);
            pictures.Add(Properties.Resources._7);
            pictures.Add(Properties.Resources._8);
            pictures.Add(Properties.Resources._9);
            pictures.Add(Properties.Resources._null);

            refreshPictures();

            

        }

        
        



        private void button1_Click(object sender, EventArgs e)
        {
            int n = pictures.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                Image value = pictures[k];
                pictures[k] = pictures[n];
                pictures[n] = value;
            }
            refreshPictures();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void refreshPictures()
        {
            pictureBox2.Image = pictures[0];
            pictureBox3.Image = pictures[1];
            pictureBox4.Image = pictures[2];
            pictureBox5.Image = pictures[3];
            pictureBox6.Image = pictures[4];
            pictureBox7.Image = pictures[5];
            pictureBox8.Image = pictures[6];
            pictureBox11.Image = pictures[7];
            pictureBox9.Image = pictures[8];
            pictureBox10.Image = pictures[9];
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
    }
}
