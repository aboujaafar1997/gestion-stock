using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class top_bare : UserControl
    {
        public top_bare()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            login.p.catalogue1.axWindowsMediaPlayer1.settings.volume = 0;
            login.p.catalogue1.bunifuSlider1.Value = 0;
            bunifuImageButton5.Visible = false;
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            login.p.catalogue1.bunifuSlider2.Value = 0;
            bunifuImageButton7.Visible = false;
            catalogue.sp.Volume = 0;
            login.p.catalogue1.timer1.Enabled = false;
        }
        
        private void top_bare_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dddd dd MMMM yyyy");
          
           
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
         
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
         
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            login.p.parametre1.BringToFront();
            this.Visible = false;

        }

        private void bunifuImageButton6_Click_1(object sender, EventArgs e)
        {
            login.p.catalogue1.bunifuSlider2.Value = 35;
            bunifuImageButton7.Visible = true;
            catalogue.sp.Volume = 35;
            login.p.catalogue1.timer1.Enabled = true;
        }

        private void bunifuImageButton4_Click_1(object sender, EventArgs e)
        {
            login.p.catalogue1.bunifuSlider1.Value = 20;
            bunifuImageButton5.Visible = true;
            login.p.catalogue1.axWindowsMediaPlayer1.settings.volume = 20;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm");
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Class1.index = 0;
        }
    }
}
