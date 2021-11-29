using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vakantie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbereken_Click(object sender, EventArgs e)
        {
            int aantvolwassenen, aantalkinderen, aantalnachten, aantalkindondertwee, aantalkindbovenzestien, prijspervolwassenepernacht, prijsperkindpernacht, totaal = 0, prijspernacht;

            aantvolwassenen = Convert.ToInt32(txtvolwassenen.Text);
            aantalkinderen = Convert.ToInt32(txtkinderen.Text);
            aantalnachten = Convert.ToInt32(txtnacht.Text);
            aantalkindondertwee = Convert.ToInt32(txtonder2.Text);
            aantalkindbovenzestien = Convert.ToInt32(txttot16.Text);

            if (lloretDeMarspanjeToolStripMenuItem.Checked==true)
            {
                lblbestemming.Text = "bestemming spanje met" + aantvolwassenen + "en" + aantalkinderen + "in";
            }
            if (almeriaspanjeToolStripMenuItem.Checked == true)
            {
                lblbestemming.Text = "bestemming almeria met" + aantvolwassenen + "en" + aantalkinderen + "in";
            }
            if (turkijeToolStripMenuItem.Checked == true)
            {
                lblbestemming.Text = "bestemming turkije met" + aantvolwassenen + "en" + aantalkinderen + "in";
            }



            if (standaard50nachtToolStripMenuItem.Checked == true)
            {
                txtprijspervolwassene.Text = "50";
                txtprijsperkind.Text = "25";

                prijsperkindpernacht = 50 / 2;
                prijspervolwassenepernacht = 50;
                totaal += prijspervolwassenepernacht * aantvolwassenen * aantalnachten;
                totaal += prijsperkindpernacht * aantalkinderen * aantalnachten;
                txtaantalnacht.Text = Convert.ToString(aantalnachten);
            }

            else if (comfort60nachtToolStripMenuItem.Checked == true)
            {
                txtprijspervolwassene.Text = "60";
                txtprijsperkind.Text = "30";
                prijspernacht = 60;
                prijsperkindpernacht = 60 / 2;
                prijspervolwassenepernacht = 60;
                totaal += prijspervolwassenepernacht * aantvolwassenen * aantalnachten;
                totaal += prijsperkindpernacht * aantalkinderen * aantalnachten;
                txtaantalnacht.Text = Convert.ToString(aantalnachten);
            }
            else
            {
                txtprijspervolwassene.Text = "100";
                txtprijsperkind.Text = "50";
                prijspernacht = 100;
                prijsperkindpernacht = 100 / 2;
                prijspervolwassenepernacht = 100;
                totaal += prijspervolwassenepernacht * aantvolwassenen * aantalnachten;
                totaal += prijsperkindpernacht * aantalkinderen * aantalnachten;
                txtaantalnacht.Text = Convert.ToString(aantalnachten);

            }


                    if (kamerEnOntbijt0ToolStripMenuItem.Checked == true)
                    {
                        
                        lblbestemming.Text += " kamer en ontbijt";
                        txtverblijfsformule.Text += "kamer en ontbijt";

                    }
                     if (halfPension7nachtpersToolStripMenuItem.Checked == true)
                    {
                        totaal += 7 * aantvolwassenen * aantalnachten;
                        totaal += 7/2 * aantalkinderen * aantalnachten;
                       
                        
                        lblbestemming.Text += "halfpension";
                        txtverblijfsformule.Text += "halfpension";

                    }
                    if(volPension10nachtpersoonToolStripMenuItem.Checked ==true)
                    {
                        totaal += 10 * aantvolwassenen * aantalnachten;
                        totaal += 10 / 2 * aantalkinderen * aantalnachten;


                        lblbestemming.Text += "vol pension";
                        txtverblijfsformule.Text += "vol pension";
                    }

               

                txttotaal.Text = Convert.ToString(totaal);


            
        }

        private void lloretDeMarspanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lloretDeMarspanjeToolStripMenuItem.Checked = true;
            almeriaspanjeToolStripMenuItem.Checked = false;
            turkijeToolStripMenuItem.Checked = false;
        }

        private void almeriaspanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lloretDeMarspanjeToolStripMenuItem.Checked = false;
            almeriaspanjeToolStripMenuItem.Checked = true;
            turkijeToolStripMenuItem.Checked = false;
        }

        private void turkijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lloretDeMarspanjeToolStripMenuItem.Checked =false;
            almeriaspanjeToolStripMenuItem.Checked = false;
            turkijeToolStripMenuItem.Checked = true;
        }

        private void standaard50nachtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            standaard50nachtToolStripMenuItem.Checked = true;
            comfort60nachtToolStripMenuItem.Checked = false;
            luxesuite100nachtToolStripMenuItem.Checked = false;
        }

        private void comfort60nachtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            standaard50nachtToolStripMenuItem.Checked = false;
            comfort60nachtToolStripMenuItem.Checked = true;
            luxesuite100nachtToolStripMenuItem.Checked = false;
        }

        private void luxesuite100nachtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            standaard50nachtToolStripMenuItem.Checked = false;
            comfort60nachtToolStripMenuItem.Checked = false;
            luxesuite100nachtToolStripMenuItem.Checked = true;
        }

        private void kamerEnOntbijt0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kamerEnOntbijt0ToolStripMenuItem.Checked = true;
            halfPension7nachtpersToolStripMenuItem.Checked = false;
            volPension10nachtpersoonToolStripMenuItem.Checked = false;
            allinn20nachtpersoonToolStripMenuItem.Checked = false;


        }

        private void halfPension7nachtpersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kamerEnOntbijt0ToolStripMenuItem.Checked = false;
            halfPension7nachtpersToolStripMenuItem.Checked = true;
            volPension10nachtpersoonToolStripMenuItem.Checked = false;
            allinn20nachtpersoonToolStripMenuItem.Checked = false;
        }

        private void volPension10nachtpersoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kamerEnOntbijt0ToolStripMenuItem.Checked = false;
            halfPension7nachtpersToolStripMenuItem.Checked = false;
            volPension10nachtpersoonToolStripMenuItem.Checked = true;
            allinn20nachtpersoonToolStripMenuItem.Checked = false;
        }

        private void allinn20nachtpersoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kamerEnOntbijt0ToolStripMenuItem.Checked = false;
            halfPension7nachtpersToolStripMenuItem.Checked = false;
            volPension10nachtpersoonToolStripMenuItem.Checked = false;
            allinn20nachtpersoonToolStripMenuItem.Checked = true;
        }

        private void btnsimulatie_Click(object sender, EventArgs e)
        {
            txtaantalnacht.Text = " ";
            txttotaal.Text = " ";
            txtverblijfsformule.Text = " ";
            lblbestemming.Text = " ";
            txtvolwassenen.Text = " ";
            txtkinderen.Text = " ";
            txtnacht.Text = " ";
            txtonder2.Text = " ";
            txttot16.Text = " ";
            txtprijspervolwassene.Text = " ";
         


        }

        private void txtkinderen_TextChanged(object sender, EventArgs e)
        {
            int aantalkinderen;
            int.TryParse(txtkinderen.Text, out aantalkinderen);
            if (aantalkinderen==0)
            {
                lblkleinerdan2.Visible = false;
                lbltot16.Visible = false;
            }
            else if(aantalkinderen<0)
            {
                txtkinderen.Text = "0";
            }
            else
            {
                lblkleinerdan2.Visible = true;
                lbltot16.Visible = true;
            }
        }

        private void btnsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
