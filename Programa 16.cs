﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progr26_Trujillo_Garay_Cesar_Andres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dinero;
            dinero = int.Parse(textBox1.Text);
            //Acumulador
            dinero = dinero + 10;
            textBox1.Text = Convert.ToString(dinero);
            label8.Text = Convert.ToString(dinero);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dinero;
            dinero = int.Parse(textBox1.Text);
            dinero = dinero + 50;
            textBox1.Text = Convert.ToString(dinero);
            label8.Text = Convert.ToString(dinero);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int dinero;
            dinero = int.Parse(textBox1.Text);
            dinero = dinero + 100;
            textBox1.Text = Convert.ToString(dinero);
            label8.Text = Convert.ToString(dinero);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Pesos;
            Pesos = int.Parse(textBox1.Text);
            switch(Pesos)
                {
                case 0:
            {
                    label5.ForeColor=ColorTranslator.FromHtml("#FF0000");
                    label5.Text="Debes Aportar Una Cantidad";
                    break;
                    }
            default:
            {
                //Numeros Aleatorios
                Random numeros = new Random();
                double n1 = numeros.Next(0,10);
                double n2 = numeros.Next(0,10);
                double n3 = numeros.Next(0,10);
                //Desplegar Valores
                label2.Text= n1.ToString();
                label3.Text= n2.ToString();
                label4.Text= n3.ToString();
                //Checar si salen 3 Sietes
                if((label2.Text=="7")&&(label3.Text=="7")&&(label4.Text=="7"))
                    {
                    label5.Text="Felicidades ganaste 5000.00 pesos";
                    int dinero;
                    dinero = int.Parse(textBox1.Text);
                    //Acumulador
                    dinero = dinero + 5000;
                    textBox1.Text=Convert.ToString(dinero);
                    label8.Text=Convert.ToString(dinero);
                    }
                //Checar NO salen 3 sietes
                if ((label2.Text != "7") && (label3.Text != "7") && (label4.Text != "7"))
                {
                    label5.Text = "Perdiste 10.00 pesos";
                    int dinero;
                    dinero = int.Parse(textBox1.Text);
                    //Acumulador
                    dinero = dinero -10;
                    textBox1.Text = Convert.ToString(dinero);
                    label8.Text = Convert.ToString(dinero);
                }
                //Checar si salen 2 Sietes
                if ((label2.Text == "7") && (label3.Text == "7") && (label4.Text != "7") || (label2.Text == "7") && (label3.Text != "7") && (label4.Text == "7") || (label2.Text != "7") && (label3.Text == "7") && (label4.Text == "7"))
                {
                    label5.Text = "Felicidades ganaste 100.00 pesos";
                    int dinero;
                    dinero = int.Parse(textBox1.Text);
                    //Acumulador
                    dinero = dinero + 100;
                    textBox1.Text = Convert.ToString(dinero);
                    label8.Text = Convert.ToString(dinero);
                }

                
                break;
                    }

                }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}

