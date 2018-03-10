using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_27_Trujillo_Garay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Prog_27_Trujillo_Garay.Properties.Resources.Tijuana_1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Prog_27_Trujillo_Garay.Properties.Resources.Tijuana_2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Prog_27_Trujillo_Garay.Properties.Resources.Tijuana_3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Prog_27_Trujillo_Garay.Properties.Resources.Tijuana_4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Prog_27_Trujillo_Garay.Properties.Resources.Tijuana_5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
