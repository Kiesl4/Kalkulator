using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string LiczbaPierwsza, LiczbaDruga;
        char dzialanie = ' ';
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            Dzialanie(1);    
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Dzialanie(2);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Dzialanie(3);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Dzialanie(4);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            Dzialanie(5);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            Dzialanie(6);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            Dzialanie(7);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            Dzialanie(8);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            Dzialanie(9);
        }

        private void bPrzecinek_Click(object sender, EventArgs e)
        {
            tbWynik.Text = tbWynik.Text + ",";
            tbWynik.Text = Convert.ToString(tbWynik.Text);
        }

        private void b0_Click(object sender, EventArgs e)
        {
            Dzialanie(0);
        }

        private void bDodawanie_Click(object sender, EventArgs e)
        {
            dzialanie = '+';
            tbWynik.Text = "";
        }

        private void bOdejmowanie_Click(object sender, EventArgs e)
        {
            dzialanie = '-';
            tbWynik.Text = "";
        }

        private void bWynik_Click(object sender, EventArgs e)
        {
            switch(dzialanie)
            {
                case ('+'):
                    tbWynik.Text = (int.Parse(LiczbaPierwsza) + int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('-'):
                    tbWynik.Text = (int.Parse(LiczbaPierwsza) - int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('*'):
                    tbWynik.Text = (int.Parse(LiczbaPierwsza) * int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('/'):
                    tbWynik.Text = (int.Parse(LiczbaPierwsza) / int.Parse(LiczbaDruga)).ToString();
                    break;
            }
            LiczbaPierwsza = "";
            LiczbaDruga = "";
            dzialanie = ' ';
        }

        private void bCzyszczenie_Click(object sender, EventArgs e)
        {
            tbWynik.Text = "0";
        }

        private void bMnożenie_Click(object sender, EventArgs e)
        {
            dzialanie = '*';
            tbWynik.Text = "";
        }

        private void bDzielenie_Click(object sender, EventArgs e)
        {
            dzialanie = '/';
            tbWynik.Text = "";
        }

        /*
        private void tbWynik(object sender, EventArgs e)
        {

        }
        */
        private void Dzialanie(int liczba)
        {
            if(dzialanie == ' ')
            {
                LiczbaPierwsza += liczba;
                tbWynik.Text = LiczbaPierwsza;
            }
            else
            {
                LiczbaDruga += liczba;
                tbWynik.Text = LiczbaDruga;
            }
        }

    }
}
