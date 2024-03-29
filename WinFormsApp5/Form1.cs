﻿using System;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            canta1txt.Text = "Cant." + a1;
            canta2txt.Text = "Cant." + a2;
            canta3txt.Text = "Cant." + a3;
            cantb1txt.Text = "Cant." + b1;
            cantb2txt.Text = "Cant." + b2;
            cantb3txt.Text = "Cant." + b3;
            creditostxt.Text = "$0";
        }

        int creditos;
        string articulo;
        int a1 = 10;
        int b1 = 10;
        int a2 = 10;
        int b2 = 10;
        int a3 = 6;
        int b3 = 6;
        int cambio;
        int a1Costo = 18, a2Costo = 22, a3Costo = 38, b1Costo = 18, b2Costo = 22, b3Costo = 38;



        //Pagar
        private void button9_Click(object sender, EventArgs e)
        {
            if (articulo =="a1")
            {
                a1--;
                    creditos -= a1Costo;
                    creditostxt.Text = "";

                canta1txt.Text = "Cant." + a1;
                cambio = creditos;
                cambiotxt.Text = "$" + cambio.ToString();
                btnproduc.BackColor = System.Drawing.Color.White;
                btnproduc.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\johan\source\repos\WinFormsApp5\WinFormsApp5\Resources\corona-355.png");
                btnproduc.Text = "";
            }
            else if (articulo=="b1")
            {
                b1--;
                creditos -= b1Costo;
                creditostxt.Text = "";

                canta1txt.Text = "Cant." + b1;
                cambio = creditos;
                cambiotxt.Text = "$" + cambio.ToString();
                btnproduc.BackColor = System.Drawing.Color.White;
                btnproduc.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\johan\source\repos\WinFormsApp5\WinFormsApp5\Resources\victoria-355.png");
                btnproduc.Text = "";
            }
            else if (articulo == "a2")
            {
                a2--;
                creditos -= a2Costo;
                creditostxt.Text = "";

                canta1txt.Text = "Cant." + a2;
                cambio = creditos;
                cambiotxt.Text = "$" + cambio.ToString();
                btnproduc.BackColor = System.Drawing.Color.White;
                btnproduc.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\johan\source\repos\WinFormsApp5\WinFormsApp5\Resources\corona-laton.png");
                btnproduc.Text = "";
            }
            else if (articulo == "b2")
            {
                b2--;
                creditos -= b2Costo;
                creditostxt.Text = "";

                canta1txt.Text = "Cant." + b2;
                cambio = creditos;
                cambiotxt.Text = "$" + cambio.ToString();
                btnproduc.BackColor = System.Drawing.Color.White;
                btnproduc.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\johan\source\repos\WinFormsApp5\WinFormsApp5\Resources\victoria-laton.png");
                btnproduc.Text = "";
            }
            else if (articulo == "a3")
            {
                a3--;
                creditos -= a3Costo;
                creditostxt.Text = "";

                canta1txt.Text = "Cant." + a3;
                cambio = creditos;
                cambiotxt.Text = "$" + cambio.ToString();
                btnproduc.BackColor = System.Drawing.Color.White;
                btnproduc.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\johan\source\repos\WinFormsApp5\WinFormsApp5\Resources\corona-familiar.png");
                btnproduc.Text = "";
            }
            else if (articulo == "b3")
            {
                b3--;
                creditos -= b3Costo;
                creditostxt.Text = "";

                canta1txt.Text = "Cant." + b3;
                cambio = creditos;
                cambiotxt.Text = "$" + cambio.ToString();
                btnproduc.BackColor = System.Drawing.Color.White;
                btnproduc.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\johan\source\repos\WinFormsApp5\WinFormsApp5\Resources\victoria-familiar.png");
                btnproduc.Text = "";
            }
        }


        //Botones articulos
        private void button11_Click(object sender, EventArgs e)
        {
            if (a1 == 0)
            {
                MessageBox.Show("Ya no hay de este producto en existencia.");
            }
            else
            {
                if (creditos >= a1Costo)
                {
                    articulo = "a1";
                }
                else
                {
                    MessageBox.Show("No tienes créditos suficientes.");
                }
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (b1 == 0)
            {
                MessageBox.Show("Ya no hay de este producto en existencia.");
            }
            else
            {
                if (creditos >= b1Costo)
                {                   
                    articulo = "b1";
                }
                else
                {
                    MessageBox.Show("No tienes créditos suficientes.");
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (a2 == 0)
            {
                MessageBox.Show("Ya no hay de este producto en existencia.");
            }
            else
            {
                if (creditos >= a2Costo)
                {              
                    articulo = "a2";
                }
                else
                {
                    MessageBox.Show("No tienes créditos suficientes.");
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (b2 == 0)
            {
                MessageBox.Show("Ya no hay de este producto en existencia.");
            }
            else
            {
                if (creditos >= b2Costo)
                {                 
                    articulo = "b2";
                }
                else
                {
                    MessageBox.Show("No tienes créditos suficientes.");
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (a3 == 0)
            {
                MessageBox.Show("Ya no hay de este producto en existencia.");
            }
            else
            {
                if (creditos >= a3Costo)
                {
                    articulo = "a3";
                }
                else
                {
                    MessageBox.Show("No tienes créditos suficientes.");
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (b3 == 0)
            {
                MessageBox.Show("Ya no hay de este producto en existencia.");
            }
            else
            {
                if (creditos >= b3Costo)
                {
                    articulo = "b3";
                }
                else
                {
                    MessageBox.Show("No tienes créditos suficientes.");
                }
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            creditos++;
            creditostxt.Text = creditos.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            creditos += 2;
            creditostxt.Text = creditos.ToString();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        public void tmrCar1_Tick(object sender, EventArgs e)
        {
            bool retro = true;
            int cintax2 = cintatxt.Location.X + 1077, cintax1 = cintatxt.Location.X;
            timer1.Interval = 20;
            cintatxt.Location = new System.Drawing.Point(cintax1 - 5, 22);

            int hitboxcintax2 = cintatxt.Location.X + 1077;

            if (cintax2 <= 460)
            {
                retro = false;
            }

            if (retro == false)
            {
                cintatxt.Location = new System.Drawing.Point(900, 22);
            }
        }

        private void cintatxt_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            cambiotxt.Text = "$";
            creditostxt.Text = "$";
            cambio = 0;
            creditos = 0;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnproduc.BackColor = System.Drawing.Color.Black;
            btnproduc.BackgroundImage = null;
        }

        private void victorialaton_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            creditos += 5;
            creditostxt.Text = "$" + creditos.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            creditos += 10;
            creditostxt.Text = "$" + creditos.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            creditos += 20;
            creditostxt.Text = "$" + creditos.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            creditos += 50;
            creditostxt.Text = "$" + creditos.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            creditos += 100;
            creditostxt.Text = "$"+creditos.ToString();
        }
    }
}
