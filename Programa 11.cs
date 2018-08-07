using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_17_Trujillo_Garay_Cesar_Andres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int OP;
            OP=int.Parse(textBox1.Text);
            
            if (OP==1)
            {
                Form DOS = new VOLTAJE ();
                DOS.Show();
                this.Hide();
            }

            if (OP==2)
            {
                Form TRES = new RESISTENCIA ();
                TRES.Show();
                this.Hide();
            }
            if (OP==3)
            {
                Form CUATRO = new CORRIENTE();
                CUATRO.Show();
                this.Hide();
            }
            if (OP==4)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
