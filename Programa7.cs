using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_12_Trujillo_Garay_Cesar_Andres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N;
            N = int.Parse(textBox1.Text);
            if (N==1)
                {label4.Text = "Domingo";
                    pictureBox1.Visible = true;
        }
            if (N==2)
            {label4.Text = "Lunes";
                    pictureBox2.Visible = true;
            }
            if (N==3)
            {label4.Text = "Martes";
                    pictureBox3.Visible = true;
        }
            if (N==4)
            {label4.Text = "Miercoles";
                    pictureBox4.Visible = true;
    }
            if (N==5)
            {label4.Text = "Jueves";
                    pictureBox6.Visible = true;
}
            if (N==6)
            {label4.Text = "Viernes";
                    pictureBox7.Visible = true;
}
            if (N==7)
            {label4.Text = "Sabado";
                    pictureBox8.Visible = true;
                }
        }
    }
}
