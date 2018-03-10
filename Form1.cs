using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_11_Trujillo_garay_Cesar_Andres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N;
            N = int.Parse(textBox1.Text);
            if (N == 1)
                label3.Text = "Uno";
            if (N == 2)
                label3.Text = "Dos";
            if (N == 3)
                label3.Text = "Tres";
            if (N == 4)
                label3.Text = "Cuatro";
            if (N == 5)
                label3.Text = "Cinco";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
