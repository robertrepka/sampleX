using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;

namespace sampleX
{
    public partial class MenuA : Form
    {
        private readonly RRcode RRcode = new RRcode();
        private readonly RRfun RRfun = new RRfun();
        private readonly RRdata RRdata = new RRdata();

        string sSql;
        public MenuA()
        {
            InitializeComponent();
        }

        private void MenuA_Load(object sender, EventArgs e)
        {
            this.Text = RRvar.sHeader;
            lStatus.Text = "sampleX - " + RRvar.sFullName;
            RRcode.Front();
        }

        private void ChildFormClosedFull(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            this.Visible = true;
            RRcode.Front();
        }

        private void ChildFormClosedFullNoFade(object sender, EventArgs e)
        {
            this.Enabled = true;
            RRcode.Front();
        }

        private void MenuA_Shown(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            RRcode.Front();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            RRfun.ShowMyInfoToolTip(pictureBox1.Location.X + 50, pictureBox1.Location.Y + 50, this);
        }

        private void bPassCh_Click(object sender, EventArgs e)
        {
            Form PassChange = new PassChange();
            this.Enabled = false;
            PassChange.Closed += new EventHandler(ChildFormClosedFullNoFade);
            PassChange.Show();
        }

        private void bUsers_Click(object sender, EventArgs e)
        {
            RRcode.Log("Číselník užívateľov");
            RRcode.FadeOut(this);
            this.Visible = false;
            Form RefeN = new RefeN();
            RefeN.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "Číselník užívateľov";
            RefeN.Show();
        }

        private void bPartner_Click(object sender, EventArgs e)
        {
            RRvar.sTemp = "";
            RRcode.Log("Číselník zákazníkov");
            RRcode.FadeOut(this);
            this.Visible = false;
            Form Partners = new Partners();
            Partners.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "Číselník zákazníkov";
            Partners.Show();
        }

        private void bJournal_Click(object sender, EventArgs e)
        {
            RRcode.Log("Prezeranie denníka činností");
            RRcode.FadeOut(this);
            this.Visible = false;
            Form Journal = new Journal();
            Journal.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "Denník činností";
            Journal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Určite sa chceš hrať s automaticky pridelenými číslami???!!!", "Znefunkčnenie aplikácie", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (MessageBox.Show("Určite vieš, čo robíš?", "Varovanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Uvedomuješ si, že táto aplikácia po tvojom zásahu \r\nuž asi nikdy viac nebude normálne fungovať???", "Posledné varovanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
                    {
                        MessageBox.Show("Všetko čo od tejto chvíle urobíš,\r\nmože byť a aj bude použité proti Tebe!!!", "Informácia", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        try
                        {
                            RRcode.Log("Naposledy pridelené čísla");
                            RRcode.FadeOut(this);
                            this.Visible = false;
                            Form Last = new Last();
                            Last.Closed += new EventHandler(ChildFormClosedFull);
                            RRvar.sHeader = "Naposledy pridelené čísla";
                            Last.Show();
                        }
                        catch { }
                    }
                    else
                    {
                        MessageBox.Show("Keď si to uvedomuješ, tak prečo to robíš???", "Údiv", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Určite chceš meniť systémovú systémovú konfiguráciu???!!!", "Znefunkčnenie aplikácie", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (MessageBox.Show("Určite vieš, čo robíš?", "Varovanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Uvedomuješ si, že táto aplikácia po tvojom zásahu \r\nuž asi nikdy viac nebude normálne fungovať???", "Posledné varovanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
                    {
                        MessageBox.Show("Všetko čo od tejto chvíle urobíš,\r\nmože byť a aj bude použité proti Tebe!!!", "Informácia", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        try
                        {
                            RRcode.Log("Systémové parametre");
                            RRcode.FadeOut(this);
                            this.Visible = false;
                            Form Config = new Config();
                            Config.Closed += new EventHandler(ChildFormClosedFull);
                            RRvar.sHeader = "Systémové parametre";
                            Config.Show(); 
                        }
                        catch { }
                    }
                    else
                    {
                        MessageBox.Show("Keď si to uvedomuješ, tak prečo to robíš???", "Údiv", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }
    }
}



