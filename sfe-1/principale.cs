using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class principale : Form     {
        int lodin;
        
        public principale()
        {
            InitializeComponent();
            
    }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            

           
            

        }
        
        private void principale_Load(object sender, EventArgs e)
        {
            Class1.ch = new chate();
            Class1.ch.Show();
            Class1.ch.Visible = false;
            BunifuDragControl e1 = new BunifuDragControl();
            e1.TargetControl = this;
            bunifuProgressBar1.BringToFront();
            login.p.top_bare1.Visible = false;

            


        }

        private void left_brare1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            if (lodin == 16) { 
                catalogue1.BringToFront();
            login.p.timer1.Enabled = false;
            login.p.chargemant1.Visible = false;
                login.p.bunifuProgressBar1.Visible = false;
               
            }

            else
            {
                lodin = lodin + 1;
                login.p.bunifuProgressBar1.Value += 6;

            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)

        {
           
            label1.Text = " ";
            Class1.ch.Visible = true;
           
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sfe othmane aboujaafar :06158885422");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Dari-am%C3%A9nagement-1732358693655950/");
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://127.0.0.1:8081/othmane/index.PHP");
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            login.p.top_bare1.BringToFront();
            login.p.top_bare1.Visible = false;
            bunifuTransition1.ShowSync(login.p.top_bare1);
            
        }

        private void top_bare1_Load(object sender, EventArgs e)
        {

        }
    }
}
