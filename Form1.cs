using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_29_Trujillo_Garay_Cesar_Andres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label4.Text = "Datos enviados";
            label5.Text = "Nombre: " + textBox1.Text;
            label6.Text = "Grupo: " + textBox2.Text;


            if (radioButton1.Checked == true)
            {
                label7.Text = "Futbol Soccer";
                pictureBox1.Visible = true;
            } 
            if (radioButton2.Checked == true)
            {
                label7.Text = "Futbol Americano";
                pictureBox2.Visible = true;
            }
            if (radioButton3.Checked == true)
            {
                label7.Text = "Voleybol";
                pictureBox3.Visible = true;
            }
            if (radioButton4.Checked == true)
            {
                label7.Text = "Danza";
                pictureBox4.Visible = true;
            }
            if (radioButton5.Checked == true)
            {
                label7.Text = "Guitarra";
                pictureBox5.Visible = true;
            }
            if (radioButton6.Checked == true)
            {
                label7.Text = "Canto";
                pictureBox6.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
