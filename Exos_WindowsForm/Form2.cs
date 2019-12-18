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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox_cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listBox_cities.GetItemText(listBox_cities.SelectedItem);
            MessageBox.Show(text);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
