using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Speech.Synthesis;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class catalogue : UserControl
    {
        MySqlConnection cn = new MySqlConnection("server=127.0.0.1; port=3308; database= sfe; uid=root; password=");
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable dt1 = new DataTable();
        ImageList ima = new ImageList();
       public static SpeechSynthesizer sp = new SpeechSynthesizer();
        int i = 0;
        public catalogue()
        {
            InitializeComponent();
        }

        private void catalogue_Load(object sender, EventArgs e)
        {
            bunifuImageButton4.Visible=false;
            /*axWindowsMediaPlayer1.settings.volume = 10;
            axWindowsMediaPlayer1.URL = "a.wav";
            axWindowsMediaPlayer1.settings.setMode("loop", true);*/
            adapter = new MySqlDataAdapter("select image,NOM from produit", cn);
            adapter.Fill(dt1);
            Byte[] img = (byte[])dt1.Rows[i][0];
            bunifuCustomLabel1.Text = dt1.Rows[i][1].ToString();
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
           DataTable dt = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select NOM_FAMILLE from produit ", Class1.cn);
            Class1.adapter.Fill(dt);
            comboBox1.DataSource = dt;

            comboBox1.DisplayMember = "NOM_FAMILLE";







            ima.ImageSize = new Size(256, 256);
            string[] pth = { };
            pth = Directory.GetFiles("C:/Users/othmane/Desktop/LifeFrame");
            foreach (string pat in pth)
            {
                ima.Images.Add(Image.FromFile(pat));
            }
            listView1.View = View.Details;
            listView1.Columns.Add(" ", 300);

            listView1.SmallImageList = ima;
            for (int i = 0; i < ima.Images.Count; i++)
            {
                listView1.Items.Add("", i);

            }











        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            bunifuImageButton4.Visible = false;
            timer1.Enabled = false;
            if (dt1.Rows.Count > i + 1)
            {
                i = i + 1;
            }

            if (dt1.Rows[i][0].ToString() != "")
            {
                Byte[] img = (byte[])dt1.Rows[i][0];
                bunifuCustomLabel1.Text = dt1.Rows[i][1].ToString();
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                sp.Speak(bunifuCustomLabel1.Text.ToString());
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            timer1.Enabled = false;
            bunifuImageButton4.Visible = false;
            if (i > 0)
            {
                i = i - 1;
            }
            if (dt1.Rows[i][0].ToString() != "")
            {

                Byte[] img = (byte[])dt1.Rows[i][0];
                bunifuCustomLabel1.Text = dt1.Rows[i][1].ToString();
                
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                sp.Speak(bunifuCustomLabel1.Text.ToString());
            }
        }

        private void catalogue_KeyPress(object sender, KeyPressEventArgs e)
        {
        

        }

        private void catalogue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {
                bunifuImageButton4.Visible = false;
                timer1.Enabled = false;
                if (dt1.Rows.Count > i + 1)
                {
                    i = i + 1;
                }

                if (dt1.Rows[i][0].ToString() != "")
                {
                    Byte[] img = (byte[])dt1.Rows[i][0];
                    bunifuCustomLabel1.Text = dt1.Rows[i][1].ToString();
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);
                    sp.Speak(bunifuCustomLabel1.Text.ToString());
                }





            }


        }



        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            login.a = true;
            timer1.Enabled = true;
            bunifuImageButton4.Visible = true;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

            timer1.Enabled = false;
            bunifuImageButton4.Visible = false;
            i = 0;




        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (login.a == true)
            {
                if (dt1.Rows.Count > i + 1)
                {
                    i = i + 1;


                    if (dt1.Rows[i][0].ToString() != "")
                    {

                        Byte[] img = (byte[])dt1.Rows[i][0];
                        bunifuCustomLabel1.Text = dt1.Rows[i][1].ToString();

                        MemoryStream ms = new MemoryStream(img);
                        pictureBox1.Image = Image.FromStream(ms);
                        sp.Speak(bunifuCustomLabel1.Text.ToString());

                    }

                }
                else { i = 0; }
            }
        }


        int var2;
        private void listView2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                var2 = listView1.SelectedItems[0].Index;
                pictureBox1.Image = ima.Images[var2];
            }
        }

        private void catalogue_MouseEnter(object sender, EventArgs e)
        {
           
            //SoundPlayer play = new SoundPlayer();
            //play.SoundLocation = "a.wav";
            //play.Play();
            //sp.Speak("Caractéristiques Techniques Perçage suspension invis Caisson four avec étagère Caisson évier renforcé Support étagère en polycarbonate Panneaux de fond avec emplacement pour pieds réglable");
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = bunifuSlider1.Value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSlider2_ValueChanged(object sender, EventArgs e)
        {
            sp.Volume = bunifuSlider2.Value;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            bunifuImageButton4.Visible = false;
            i = 0;
        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
