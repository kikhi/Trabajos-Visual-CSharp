using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_22_Trujillo_Garay_Cesar_Andres
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
            string Nombre;
            int Edad;
            Nombre = textBox1.Text;
            Edad = int.Parse(textBox2.Text);
            if ((Edad == 1)|(Edad == 2)|(Edad == 3))
            {
                pictureBox1.Visible = true;
                label4.Text = Nombre + " debe estar en Guarderia";
            }
            if ((Edad == 4)|(Edad == 5))
            {
                pictureBox2.Visible = true;
                label4.Text = Nombre + " debe estar en Kinder";
            }
            if ((Edad == 6)|(Edad == 7)|(Edad == 8)|(Edad == 9)|(Edad == 10)|(Edad == 11))
            {
                pictureBox3.Visible = true;
                label4.Text = Nombre + " debe estar en Primaria";
            }
            if ((Edad == 12)|(Edad == 13)|(Edad == 14))
            {
                pictureBox4.Visible = true;
                label4.Text = Nombre + " debe estar en Secundaria";
            }
             if ((Edad == 15)|(Edad == 16)|(Edad == 17))
            {
                pictureBox5.Visible = true;
                label4.Text = Nombre + " debe estar en Preparatoria";
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
        }
    }
}

