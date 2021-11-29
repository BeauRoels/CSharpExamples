using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame_Roels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngooi_Click(object sender, EventArgs e)
        {
            int dice, totaal, subtotaal, teller, onder, boven, dice1, dice2, dice3,dice4,dice5,dice6,punt50,punt100,punt1000,teller1;
            teller1 = 0;
            teller = 1;
            onder = 1;
            boven = 7;
            totaal = 0;
            Random random = new Random();
           
            dice1 = random.Next(1, 7);
            dice2 = random.Next(1, 7);
            dice3 = random.Next(1, 7);
            dice4 = random.Next(1, 7);
            dice5 = random.Next(1, 7);
            dice6 = random.Next(1, 7);

            txtDice1.Text = dice1.ToString();
            txtDice2.Text = dice2.ToString();
            txtDice3.Text = dice3.ToString();
            txtDice4.Text = dice4.ToString();
            txtDice5.Text = dice5.ToString();
            txtDice6.Text = dice6.ToString();

            if (dice1==1)
            {
                totaal += 100;
                teller1++;
            }
            else if (dice1 == 5)
            {
                totaal += 50;

            }
            if (dice2 == 1)
            {
                totaal += 100;
                teller1++;
            }
            else if (dice2 == 5)
            {
                totaal += 50;

            }
            if (dice3 == 1)
            {
                totaal += 100;
                teller1++;
            }
            else if (dice3 == 5)
            {
                totaal += 50;

            }
            if (dice4 == 1)
            {
                totaal += 100;
                teller1++;
            }
            else if (dice4 == 5)
            {
                totaal +=  50;

            }
            if (dice5 == 1)
            {
                totaal += 100;
                teller1++;
            }
            else if (dice5 == 5)
            {
                totaal += 50;

            }
            if (dice6 == 1)
            {
                totaal += 100;
                teller1++;
            }
            else if (dice6 == 5)
            {
                totaal += 50;

            }
            if (dice1 == 1)
            {
                totaal += 100;
                teller1++;
            }
            else if (teller1 == 3)
            {
                totaal = totaal - 300 + 1000;

            }
            else if (dice1!=dice2&&dice2!=dice3&&dice3!=dice4&&dice4!=dice5&&dice5!=dice6)
            {
                totaal = 1500;

            }

            txtTotaal.Text = totaal.ToString();




        }

       
    }
}
