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
    public partial class left_brare : UserControl
    {
        int a = -1;
        public left_brare()
        {
            InitializeComponent();
        }

        private void BunifuFlatButton7_Click(object sender, EventArgs e)
        {
            Panel3.Top = BunifuFlatButton7.Top;
            Panel3.Height = BunifuFlatButton7.Height;
            login.p.statistique1.BringToFront();
            login.p.statistique1.Visible = false;
            bunifuTransition1.ShowSync(login.p.statistique1);
            login.p.statistique1.BringToFront();
            login.p.catalogue1.timer1.Enabled = false;

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Panel3.Top = bunifuFlatButton1.Top;
            Panel3.Height = bunifuFlatButton1.Height;
            login.p.client1.BringToFront();
            login.p.client1.Visible = false;
            bunifuTransition1.ShowSync(login.p.client1);
            login.p.client1.BringToFront();
            login.p.catalogue1.timer1.Enabled = false;
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            Panel3.Top = bunifuFlatButton9.Top;
            Panel3.Height = bunifuFlatButton9.Height;
            login.p.catalogue1.BringToFront();
            login.p.catalogue1.Visible = false;
            bunifuTransition1.ShowSync(login.p.catalogue1);
            login.p.catalogue1.BringToFront();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            if (a == -1)
            {

               
                this.Size = new System.Drawing.Size(78, 850);
                login.p.panel1.Location = new Point(0, -5);
                login.p.catalogue1.pa1.Visible = false;
               

                 a = a * (-1);
            }
            else
            {
             
                this.Visible = false;
                bunifuTransition2.ShowSync(this);

                this.Size = new System.Drawing.Size(191, 850);
                login.p.panel1.Location = new Point(129, 62);
                this.BringToFront();
                a = a * (-1);
                login.p.catalogue1.pa1.Visible = true;
                


            }

        }

        private void left_brare_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            Panel3.Top = BunifuFlatButton5.Top;
            Panel3.Height = BunifuFlatButton5.Height;
            login.p.historique1.BringToFront();
            login.p.historique1.Visible = false;
            bunifuTransition1.ShowSync(login.p.historique1);
            login.p.historique1.BringToFront();
            login.p.catalogue1.timer1.Enabled = false;
        }

        private void BunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Panel3.Top = BunifuFlatButton6.Top;
            Panel3.Height = BunifuFlatButton6.Height;
            login.p.parametre1.BringToFront();
            login.p.parametre1.Visible = false;
            bunifuTransition1.ShowSync(login.p.parametre1);
            login.p.parametre1.BringToFront();
            login.p.catalogue1.timer1.Enabled = false;
        }

        private void BunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Panel3.Top = BunifuFlatButton5.Top;
            Panel3.Height = BunifuFlatButton5.Height;
            login.p.user1.BringToFront();
            login.p.user1.Visible = false;
            bunifuTransition1.ShowSync(login.p.user1);
            login.p.user1.BringToFront();
            login.p.catalogue1.timer1.Enabled = false;
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            Panel3.Top = bunifuFlatButton11.Top;
            Panel3.Height = bunifuFlatButton11.Height;
            login.p.facture1.BringToFront();
            login.p.facture1.Visible = false;
            bunifuTransition1.ShowSync(login.p.facture1);
            login.p.facture1.BringToFront();
            login.p.catalogue1.timer1.Enabled = false;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Panel3.Top = bunifuFlatButton2.Top;
            Panel3.Height = bunifuFlatButton2.Height;
            login.p.commandefournisseur1.BringToFront();
            login.p.commandefournisseur1.Visible = false;
            bunifuTransition1.ShowSync(login.p.commandefournisseur1);
            login.p.commandefournisseur1.BringToFront();
            login.p.catalogue1.timer1.Enabled = false;
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            Panel3.Top = bunifuFlatButton12.Top;
            Panel3.Height = bunifuFlatButton12.Height;
            login.p.bonne1.BringToFront();
            login.p.bonne1.Visible = false;
            bunifuTransition1.ShowSync(login.p.bonne1);
            login.p.bonne1.BringToFront();
            login.p.catalogue1.timer1.Enabled = false;
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Panel3.Top = BunifuFlatButton4.Top;
            Panel3.Height = BunifuFlatButton4.Height;
            login.p.fournisseur1.BringToFront();
            login.p.fournisseur1.Visible = false;
            bunifuTransition1.ShowSync(login.p.fournisseur1);
            login.p.fournisseur1.BringToFront();
            login.p.catalogue1.timer1.Enabled = false;

        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Panel3.Top = BunifuFlatButton3.Top;
            Panel3.Height = BunifuFlatButton3.Height;
            login.p.produit1.BringToFront();
            login.p.produit1.Visible = false;
            bunifuTransition1.ShowSync(login.p.produit1);
            login.p.produit1.BringToFront();
            login.p.catalogue1.timer1.Enabled = false;

        }

        private void BunifuFlatButton8_Click(object sender, EventArgs e)
        {
            Panel3.Top = BunifuFlatButton8.Top;
            Panel3.Height = BunifuFlatButton8.Height;
            login.p.commande1.BringToFront();
            login.p.commande1.Visible = false;
            bunifuTransition1.ShowSync(login.p.commande1);
            login.p.commande1.BringToFront();
            login.p.catalogue1.timer1.Enabled = false;
        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }
    }
}
