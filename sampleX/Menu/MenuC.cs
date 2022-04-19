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
    public partial class MenuC : Form
    {
        private readonly RRcode RRcode = new RRcode();
        private readonly RRfun RRfun = new RRfun();
        private readonly RRdata RRdata = new RRdata();

        string sSql;
        public MenuC()
        {
            InitializeComponent();
        }

        private void MenuC_Load(object sender, EventArgs e)
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

        private void MenuC_Shown(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            RRcode.Front();
            bMatrica.Select();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            RRfun.ShowMyInfoToolTip(pictureBox1.Location.X + 50, pictureBox1.Location.Y + 50, this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
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

        private static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(165, 60);
            Form inputBox = new Form();
            inputBox.TopMost = true;
            inputBox.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            inputBox.ControlBox = false;
            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            inputBox.MinimizeBox = false;
            inputBox.ShowIcon = false;
            inputBox.ShowInTaskbar = false;
            inputBox.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            inputBox.StartPosition = FormStartPosition.CenterParent;
            inputBox.ShowInTaskbar = false;
            inputBox.AutoSize = false;
            inputBox.ClientSize = size;
            inputBox.Text = "Laboratórne číslo";

            System.Windows.Forms.NumericUpDown nud1 = new NumericUpDown();
            nud1.Minimum = 1;
            nud1.Maximum = 10000;
            nud1.Size = new System.Drawing.Size(75, 25);
            nud1.Location = new System.Drawing.Point(5, 5);
            inputBox.Controls.Add(nud1);

            System.Windows.Forms.NumericUpDown nud2 = new NumericUpDown();
            nud2.Minimum = 2020;
            nud2.Maximum = 2100;
            nud2.Size = new System.Drawing.Size(75, 25);
            nud2.Location = new System.Drawing.Point(85, 5);
            inputBox.Controls.Add(nud2);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 25);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(5, 30);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 25);
            cancelButton.Text = "&Zruš";
            cancelButton.Location = new System.Drawing.Point(85, 30);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            string s = " where labc='" + nud1.Value.ToString() + "' and rok='" + nud2.Value.ToString() + "';";
            input = s;
            return result;
        }

        private void bPrincip_Click(object sender, EventArgs e)
        {
            RRcode.Log("Prezeranie číselníka princípov");
            RRcode.FadeOut(this);
            this.Visible = false;
            Form Princip = new Princip();
            Princip.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "Princípy merania";
            Princip.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RRcode.Log("Prezeranie číselníka matríc");
            RRcode.FadeOut(this);
            this.Visible = false;
            Form Matrica = new Matrica();
            Matrica.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "Matrice";
            Matrica.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RRcode.Log("Prezeranie číselníka kategórií");
            RRcode.FadeOut(this);
            this.Visible = false;
            Form Cat = new Cat();
            Cat.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "Kategórie";
            Cat.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RRcode.Log("Prezeranie číselníka parametrov");
            RRcode.FadeOut(this);
            this.Visible = false;
            Form Parameter = new Parameter();
            Parameter.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "Parametre";
            Parameter.Show();
        }

        private void bOzn_Click(object sender, EventArgs e)
        {
            RRcode.Log("Prezeranie číselníka označení");
            RRcode.FadeOut(this);
            this.Visible = false;
            Form Ozn = new Ozn();
            Ozn.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "Označenie";
            Ozn.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            RRcode.Log("Prezeranie číselníka oddelení");
            RRcode.FadeOut(this);
            this.Visible = false;
            Form Odd = new Odd();
            Odd.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "Oddelenia";
            Odd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RRcode.Log("Skupinová väzba: Kategória --> Parameter");
            RRcode.FadeOut(this);
            this.Visible = false;
            Form Filter1 = new Filter1();
            Filter1.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "Skupinová väzba: Vlastná kategória --> Vlastnosti merania";
            Filter1.Show();
        }

        private void bFilter_Click(object sender, EventArgs e)
        {
            RRcode.Log("Rozsah akreditácie s neistotami");
            RRcode.FadeOut(this);
            this.Visible = false;
            Form FilterA = new FilterA();
            FilterA.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "Rozsah akreditácie s neistotami ";
            FilterA.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            RRcode.Log("Prezeranie číselníka jednotiek");
            RRcode.FadeOut(this);
            this.Visible = false;
            Form Jednotka = new Jednotka();
            Jednotka.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "Číselník jednotiek";
            Jednotka.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            RRcode.Log("Prezeranie číselníka jednotiek");
            RRcode.FadeOut(this);
            this.Visible = false;
            Form Jednotka = new Jednotka();
            Jednotka.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "Jednotky";
            Jednotka.Show();
        }

        private void bSuper_Click(object sender, EventArgs e)
        {
            Form Super = new Super();
            RRvar.sHeader = "Znaky použiteľné v hornom a dolnom indexe";
            Super.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RRcode.Log("Číselník neakreditovaných skúšok");
            RRcode.FadeOut(this);
            this.Visible = false;
            Form FilterAN = new FilterAN();
            FilterAN.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "Číselník neakreditovaných skúšok ";
            FilterAN.Show();
        }
    }
}



