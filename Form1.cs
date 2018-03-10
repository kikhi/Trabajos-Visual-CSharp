using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_15_Trujillo_Garay_Cesar_Andres
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label5.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int C1, C2, C3, P;
            C1 = int.Parse(textBox1.Text);
            C2 = int.Parse(textBox2.Text);
            C3 = int.Parse(textBox3.Text);
            P = (C1 + C2 + C3) / 3;
            label7.Text = Convert.ToString(P);
            if (P >= 6)
                label6.Text = "APROBADO";
            else
                label6.Text = "REPROBADO";
        }
    }
}
