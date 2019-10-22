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
    public partial class chate : Form
    {
        WebClient w = new WebClient();
        WebClient r = new WebClient();
        public chate()
        {
            InitializeComponent();
        }

        private void chate_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            w.DownloadString("http://127.0.0.1:8081/sfe/chate.php?a=write&cmd=" + bunifuMaterialTextbox1.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            bunifuMetroTextbox1.Text = r.DownloadString("http://127.0.0.1:8081/sfe/chate.php?a=read");
            if (bunifuMetroTextbox1.Text != "") { 
                login.p.label1.Text = "1";
            notyf na = new notyf();
        
            notificationicon not = new notificationicon("Message", "le contenu   :" + bunifuMetroTextbox1.Text);
            not.Location = new Point(Class1.index, na.Height * Class1.index);
            Class1.index++;
            login.p.top_bare1.panel1.Controls.Add(not);
                timer1.Enabled = false;
            }
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            w.DownloadString("http://127.0.0.1:8081/sfe/chate.php?a=write&cmd=" + "");
            login.p.label1.Text = " ";
            timer1.Enabled = true;
        }
    }
}
