using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sampleX
{
    public partial class Super : Form
    {
        RRcode RRcode = new RRcode();
        RRdata RRdata = new RRdata();
        RRfun RRfun = new RRfun();
        RRsql RRsql = new RRsql();
        RRstring RRstring = new RRstring();
        
        public Super()
        {
            InitializeComponent();
        }

        private void Super_Load(object sender, EventArgs e)
        {
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width - 80, Screen.PrimaryScreen.Bounds.Height - 80);
            this.Location = new Point(40, 10);
            this.Text = RRvar.sHeader;
            lStatus.Text = "sampleX - " + RRvar.sFullName;
            dg.Text += "Horný index\r\n";
            dg.Text += "Xᐨᐩ\r\n";
            dg.Text += "Xᵃᵇᶜᵈᵉᶠᵍʰⁱʲᵏˡᵐⁿᵒᵖʳˢᵗᵘᵛʷˣʸᶻ\r\n";
            dg.Text += "X¹²³⁴⁵⁶⁷⁸⁹⁰*ᐨᐩᐟᐠᕽᘁᑊ⁽⁾\r\n";
            dg.Text += "Xʰʱʲʳʴʵʶʷʸˀˁˠˡˢˣˤ\r\n";
            dg.Text += "Xᐜᐝᐞᐟᐠᐡᐢᐣᐤᐥᐦ\r\n";
            dg.Text += "Xᐪᑉᑊᑋᒃᒄᒢᒻᒼᒽᒾᓐᓑᓒᓪᓫᔆᔇᔈᔉᔊᔋᔥᔾᕐᕑᕝᕪᕻᕽᖅᖕᖖᣕᣖᣗᣘᣙᣚᣛᣜᣝᣞᣟᣳᣴᣵ\r\n";
            dg.Text += "Xᴬᴮᴰᴱᴳᴴᴵᴶᴷᴸᴹᴺᴼᴾᴿᵀᵁⱽᵂ\r\n";
            dg.Text += "Xᴬᴭᴮᴯᴰᴱᴲᴳᴴᴵᴶᴷᴸᴹᴺᴻᴼᴽᴾᴿᵀᵁᵂᵃᵅᵆᵇᵈᵉᵊᵋᵌᵍᵏᵐᵑᵒᵓᵖᵗᵘᵚᵛ\r\n";
            dg.Text += "Xᕽᘁᑊᐜᐝᐞᐟᐠᐡᐢᐣᐤᐥᐦᐨᐩᐪᑉᑊᑋᒃᒄᒡᒢᒻᒼᒽᒾᓐᓑᓒᓪᓫᔅᔆᔇᔈᔉᔊᔋᔥᔾᔿᕐᕑᕝᕪᕻᕽᖅᖕᖖᖟᖦᖮᗮᘁᙆᙇᙚᙾᙿ\r\n";
            dg.Text += "Xᶦᶫᶰᶸ\r\n";
            dg.Text += "Xɶᴴᵉᴸᴸᵒ ᵂᵒᴿᴸᵈ\r\n";
            dg.Text += "Xᵝᵞᵟᵠᵡ\r\n";
            dg.Text += "X◌ͣ ◌ͤ ◌ͥ ◌ͦ ◌ͧ ◌ͨ ◌ͩ ◌ͪ ◌ͫ ◌ͬ ◌ͭ ◌ͮ ◌ͯ\r\n";
            dg.Text += "\r\n";
            dg.Text += "Dolný index\r\n";
            dg.Text += "X₋₊\r\n";
            dg.Text += "X₀₁₂₃₄₅₆₇₈₉₊₋₌₍₎\r\n";
            dg.Text += "Xₐₑₒₒₓₔₕₖₗₘₙₚₛₜ\r\n";
            dg.Text += "Xₐₑₕᵢⱼₖₗₘₙₒₚᵣₛₜᵤᵥₓ\r\n";
            dg.Text += "Xᵢᵣᵤᵥ\r\n";
            dg.Text += "Xᵦᵧᵨᵩᵪ\r\n";
            dg.Text += "X%‰‱✓\r\n";
            dg.Select(0, 0);
            //this.WindowState = FormWindowState.Maximized;
            RRcode.Front();
            RRcode.FadeIn(this);
            bSelect.Visible = true;
            pictureBox1.Visible = true;
            myResize();
           
        }

        private void Super_Shown(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            RRfun.ShowMyInfoToolTip(pictureBox1.Location.X + 50, pictureBox1.Location.Y + 50, this);
        }
        
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
        }
      
        private void myResize()
        {
            bSelect.Location = new Point(55, 10);
            //bPass.Location = new Point(5 + bExcel.Height + 3, dr.Height + bn.Height + 10);
            pictureBox1.Location = new Point(5, this.Size.Height - 115);
            bSelect.Location = new Point(this.Size.Width - 70, this.Size.Height - 115);
            dg.Location = new Point(10, 10);
            dg.Size = new Size(this.Size.Width - 35, this.Size.Height - 130);
            //dg.Size = new Size(35, 25);
            
            Application.DoEvents();
        }

        private void dg_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void ChildFormClosedFull(object sender, EventArgs e)
        {
            this.Enabled = true;
            RRcode.Front();
        }

        private void Super_Resize(object sender, EventArgs e)
        {
            myResize();
        }

        private void Super_FormClosing(object sender, FormClosingEventArgs e)
        {
            RRcode.FadeOut(this);
        }
        
        private void bSelect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dg_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
