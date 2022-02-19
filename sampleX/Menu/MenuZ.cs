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
    public partial class MenuZ : Form
    {
        private readonly RRcode RRcode = new RRcode();
        private readonly RRfun RRfun = new RRfun();
        private readonly RRdata RRdata = new RRdata();

        string sSql;
        public MenuZ()
        {
            InitializeComponent();
        }

        private void MenuZ_Load(object sender, EventArgs e)
        {
            this.Text = RRvar.sHeader;
            lStatus.Text = "sampleX - " + RRvar.sFullName;

            bPartner.Select();
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

        private void MenuZ_Shown(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            RRcode.Front();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            RRfun.ShowMyInfoToolTip(pictureBox1.Location.X + 50, pictureBox1.Location.Y + 50, this);
        }

        private void bPartner_Click(object sender, EventArgs e)
        {
            RRvar.sTemp = "";
            RRcode.Log("Číselník objednávateľov");
            RRcode.FadeOut(this);
            this.Visible = false;
            Form Partners = new Partners();
            Partners.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "Číselník objednávateľov";
            Partners.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RRvar.sTemp = "";
            RRcode.Log("Objednávky / Zmluvy");
            RRcode.FadeOut(this);
            this.Visible = false;
            Form Obj_partner = new Obj_partner();
            Obj_partner.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "Objednávky / Zmluvy";
            Obj_partner.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RRvar.sTemp = "";
            RRcode.Log("Zákazky");
            RRcode.FadeOut(this);
            this.Visible = false;
            Form Zakazka_obj_partner = new Zakazka_obj_partner();
            Zakazka_obj_partner.Closed += new EventHandler(ChildFormClosedFull);
            RRvar.sHeader = "Zákazky";
            Zakazka_obj_partner.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sLabc = "";

            if (ShowInputDialog(ref sLabc) == DialogResult.OK)
            {
                RRvar.sTemp = sLabc;
                if (Convert.ToInt16(RRdata.sSqlResult("SELECT count(*) as total FROM `samplex`.`labc_zakazka` " + RRvar.sTemp, 1, 1)) == 0)
                {
                    MessageBox.Show("Nenašiel som...", "Hľadanie", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    RRcode.Log("Laboratórne čísla");
                    RRcode.FadeOut(this);
                    this.Visible = false;
                    Form Labc_zakazka = new Labc_zakazka();
                    Labc_zakazka.Closed += new EventHandler(ChildFormClosedFull);
                    RRvar.sHeader = "Laboratórne čísla";
                    Labc_zakazka.Show();
                }
            }
        }

        private static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(165, 70);
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
            nud1.Font = new Font("Segoe UI", 11);
            inputBox.Controls.Add(nud1);

            System.Windows.Forms.NumericUpDown nud2 = new NumericUpDown();
            nud2.Minimum = 2020;
            nud2.Maximum = 2100;
            nud2.Size = new System.Drawing.Size(75, 25);
            nud2.Location = new System.Drawing.Point(85, 5);
            nud2.Font = new Font("Segoe UI", 11);
            nud2.Value = Convert.ToDecimal(RRvar.iRok);
            inputBox.Controls.Add(nud2);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 30);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(5, 35);
            okButton.Font = new Font("Segoe UI", 10);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 30);
            cancelButton.Text = "&Zruš";
            cancelButton.Location = new System.Drawing.Point(85, 35);
            cancelButton.Font = new Font("Segoe UI", 10);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            string s = " where labc='" + nud1.Value.ToString() + "' and rok='" + nud2.Value.ToString() + "';";
            input = s;
            return result;
        }
    }
}



