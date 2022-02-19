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
    public partial class Menu : Form
    {
        private readonly RRcode RRcode = new RRcode();
        private readonly RRfun RRfun = new RRfun();
        private readonly RRdata RRdata = new RRdata();

        string sSql;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Auth();
            RRvar.iRok = Convert.ToInt16(DateTime.Now.ToString("yyyy"));
            RRvar.sFooter = "sampleX verzia: " + Application.ProductVersion + " - " + RRvar.sFullName;
            lStatus.Text = RRvar.sFooter;
            //RRvar.sFooter = "sampleX - " + RRvar.sFullName;
            rokUD.Value = Convert.ToDecimal(RRvar.iRok);
            RRcode.Log("ŠTART verzia: " + Application.ProductVersion);
            RRcode.Front();
        }

        private void Auth()
        {
            //ciselniky
            if (RRdata.bAuth("c"))
            {
                bC.Enabled = true;
            }
            else
            {
                bC.Enabled = false;
            }
            //nastavenia
            if (RRdata.bAuth("a"))
            {
                bN.Enabled = true;
            }
            else
            {
                bN.Enabled = false;
            }
            //zakazky
            if (RRdata.bAuth("z-r") || RRdata.bAuth("z-rw"))
            {
                bZ.Enabled = true;
            }
            else
            {
                bZ.Enabled = false;
            }

            //vysledky
            if (RRdata.bAuth("v-r") || RRdata.bAuth("v-rw"))
            {
                bV.Enabled = true;
            }
            else
            {
                bV.Enabled = false;
            }
        }

        private void ChildFormClosedFull(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            Auth();
            this.Visible = true;
            RRcode.Front();
        }

        private void ChildFormClosedFullNoFade(object sender, EventArgs e)
        {
            this.Enabled = true;
            RRcode.Front();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            RRcode.Log("KONIEC");
            Application.Exit();
        }

        private void Menu_Shown(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            RRcode.Front();
            bZ.Select();
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

        private void button8_Click_1(object sender, EventArgs e)
        {
            RRcode.FadeOut(this);
            this.Visible = false;
            Form MenuC = new MenuC();
            MenuC.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "sampleX - správa číselníkov";
            MenuC.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RRcode.FadeOut(this);
            this.Visible = false;
            Form MenuV = new MenuV();
            MenuV.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "sampleX - meranie a výsledky";
            MenuV.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RRcode.FadeOut(this);
            this.Visible = false;
            Form MenuZ = new MenuZ();
            MenuZ.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "sampleX - zákazky a laboratórne čísla";
            MenuZ.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RRcode.FadeOut(this);
            this.Visible = false;
            Form MenuA = new MenuA();
            MenuA.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "sampleX - administrácia";
            MenuA.Show();
        }

        private void rokUD_ValueChanged(object sender, EventArgs e)
        {
            RRvar.iRok = Convert.ToInt16(rokUD.Value);
        }

        private void bSelect_Click(object sender, EventArgs e)
        {
            RRvar.sTemp = " where zakazka_id=196;";
            Form Labc_zakazka2 = new Labc_zakazka2();
            RRvar.sHeader = "Laboratórne čísla: TEST1";
            Labc_zakazka2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RRvar.sTemp = " where zakazka_id=204;";
            Form Labc_zakazka2 = new Labc_zakazka2();
            RRvar.sHeader = "Laboratórne čísla: TEST2";
            Labc_zakazka2.Show();
        }
    }
}



