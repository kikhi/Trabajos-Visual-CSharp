using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_18_Trujillo_Garay_Cesar_Andres
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

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            label17.Text = "";
            label17.Visible = false;
            checkBox1.Checked = false;
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label7.Text = "Datos Enviados";
            label8.Text = "Nombre" + textBox1.Text;
            label9.Text = "Domicilio" + textBox2.Text;
            label10.Text = "Telefono Celular" + textBox3.Text;
            label11.Text = "Telefono Casa" + textBox4.Text;
            label12.Text = "Email" + textBox5.Text;
            if (checkBox1.Checked == true)
                label13.Text = "entrego Acta de nacimiento";
            else
                label13.Text = "Pendiente Acta de Nacimiento";
            if (checkBox2.Checked == true)
                label14.Text = "Entrego certificado";
            else
                label14.Text = "pendiente certificado";
            if (checkBox3.Checked == true)
                label15.Text = "Entrego Fotografias";
            else
                label15.Text = "Pendiente Fotografias";
            if (checkBox4.Checked == true)
                label16.Text = "Entrego comprobante de Domicilio";
            else
                label16.Text = "Pendiente Comprobante";
            if (checkBox5.Checked == true)
                label17.Text = "Entrego Solicitud Completa";
            else
                label17.Text = "Solicitud Completa Pendiente";


        }
    }
}
