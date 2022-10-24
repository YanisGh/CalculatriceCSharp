using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculette
{
    public partial class Form1 : Form
    {
        float nb1, nb2;
        String Signe = "";
        float total;
        String Historique ="";

        public Form1()
        {
            InitializeComponent();
        }

        private void Bouton1_Click(object sender, EventArgs e)
        {
            textRes.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textRes.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textRes.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textRes.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textRes.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textRes.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textRes.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textRes.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textRes.Text += 9;
        }

        private void BoutonAdd_Click(object sender, EventArgs e)
        {
            nb1 = float.Parse(textRes.Text);
            Historique = textRes.Text += nb1;
            Signe = "+";
            textRes.Text = "";
           
        }

        private void BoutonSous_Click(object sender, EventArgs e)
        {
            if (textRes.Text == "")
            {
                textRes.Text = "-";
            }
            else
            {
                nb1 = float.Parse(textRes.Text);
                Signe = "-";
                textRes.Text = "";
            }
        }

        private void BoutonMul_Click(object sender, EventArgs e)
        {
            nb1 = float.Parse(textRes.Text);
            Signe = "x";
            textRes.Text = "";
        }

        private void BoutonDiv_Click(object sender, EventArgs e)
        {
            nb1 = float.Parse(textRes.Text);
            Signe = "/";
            textRes.Text = "";
        }

        private void ResetBout_Click(object sender, EventArgs e)
        {
            nb1 = 0;
            nb2 = 0; 
            textRes.Text = "";
        }

        private void BoutonVirg_Click(object sender, EventArgs e)
        {
            textRes.Text += ",";
        }

        private void Bouton0_Click(object sender, EventArgs e)
        {
            textRes.Text += 0;
        }

        private void BoutonMP_Click(object sender, EventArgs e)
        {
            int nb = textRes.Text.Length;
            if (nb > 0)
            {
                if (textRes.Text.Substring(0, 1) == "-")
                {
                    textRes.Text = "" + textRes.Text.Remove(0, 1);
                }
                else if (textRes.Text == "" + textRes.Text)
                {
                    textRes.Text = "-" + textRes.Text;
                }
            }
            else if(nb == 0)
            {
                textRes.Text = "E";
            }
        }

        private void BoutonCube_Click(object sender, EventArgs e)
        {
            float totalC = float.Parse(textRes.Text) * float.Parse(textRes.Text) * float.Parse(textRes.Text);
            textRes.Text = Convert.ToString(totalC);
        }

        private void BoutonEgal_Click(object sender, EventArgs e)
        {
            nb2 = float.Parse(textRes.Text);
            switch(Signe)
            {
                case "+":
                    total = nb1 + nb2;
                    textRes.Text = total.ToString();
                    Historique = textRes.Text;
                    break;
                case "-":
                    total = nb1 - nb2;
                    textRes.Text = total.ToString();
                    break;
                case "x":
                    total = nb1 * nb2;
                    textRes.Text = total.ToString();
                    break;
                case "/":
                    if (nb1 == 0 | nb2 == 0)
                    {
                        total = 0;
                        textRes.Text = "Erreur";
                    } 
                    else total = nb1 / nb2;

                    break;

            }
        }
    }
}
