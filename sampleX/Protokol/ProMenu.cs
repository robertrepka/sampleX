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
    public partial class ProMenu : Form
    {
        private readonly RRcode RRcode = new RRcode();
        private readonly RRfun RRfun = new RRfun();
        private readonly RRdata RRdata = new RRdata();

        string sSql;
        public ProMenu()
        {
            InitializeComponent();
        }

        private void ProMenu_Load(object sender, EventArgs e)
        {
            this.Text = "Typ protokolu";
            lStatus.Text = "sampleX - " + RRvar.sFullName;
            RRcode.Front();
        }

        private void ChildFormClosedFull(object sender, EventArgs e)
        {
            //    RRcode.FadeIn(this);
            //this.Visible = true;
            //RRcode.Front();
            this.Close();
        }

        private void ProMenu_Shown(object sender, EventArgs e)
        {
            RRcode.FadeIn(this);
            RRcode.Front();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            RRfun.ShowMyInfoToolTip(pictureBox1.Location.X + 50, pictureBox1.Location.Y + 50, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RRcode.FadeOut(this);
            this.Visible = false;
            Form Pro1 = new Pro1();
            Pro1.Closed += new EventHandler(ChildFormClosedFull);
            Pro1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RRcode.FadeOut(this);
            this.Visible = false;
            Form Pro2 = new Pro2();
            Pro2.Closed += new EventHandler(ChildFormClosedFull);
            Pro2.Show();
        }
    }
}



