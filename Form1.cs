using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_20_Trujillo_Garay_Cesar_Andres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            listBox2.Visible = false;
            listBox3.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label4.Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = listBox1.Text;
            if ()
        }
    }
}
