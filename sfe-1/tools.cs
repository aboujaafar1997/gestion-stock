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

namespace WindowsFormsApplication1
{
    public partial class tools : UserControl
    {
        int a = -1;
        public tools()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
        


                
              


              
                
            
        }
        private void tools_Load(object sender, EventArgs e)
        {
           
        }

        private void tools_Load_1(object sender, EventArgs e)
        {
            // nembre de client
            DataTable nclient = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select count(NOM) from client ", Class1.cn);
            Class1.adapter.Fill(nclient);
            label10.Text = label10.Text + " " + nclient.Rows[0][0].ToString();
            // nembre de commande
            DataTable ncommande = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select count(CNI) from commande_c ", Class1.cn);
            Class1.adapter.Fill(ncommande);
            label11.Text = label11.Text + " " + ncommande.Rows[0][0].ToString();
            //nembre de fournisseur
            DataTable nfournisseur = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select count(NOM) from fournisseur", Class1.cn);
            Class1.adapter.Fill(nfournisseur);
            label2.Text = label2.Text + " " + nfournisseur.Rows[0][0].ToString();
            // nembre de produite
            DataTable nproduit = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select count(NOM) from fournisseur", Class1.cn);
            Class1.adapter.Fill(nproduit);
            label1.Text = label1.Text + " " + nproduit.Rows[0][0].ToString();


        }

        private void tools_Click(object sender, EventArgs e)
        {
 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label10.Left += 1;
            label11.Left += 1;
            label1.Left += 1;
            label2.Left += 1;
            label3.Left += 1;

            if (label10.Left > 1100)
                label10.Left = -3;
            if (label11.Left > 1100)
                label11.Left = -3;
            if (label1.Left > 1100)
                label1.Left = -3;
            if (label2.Left > 1100)
                label2.Left = -3;
            if (label3.Left > 1100)
                label3.Left = -3;
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {

            this.Size = new System.Drawing.Size(10, 39);
            login.p.panel1.Location = new Point(176, 45);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            String t = DateTime.Now.ToString("HH:mm:ss");
            label3.Text =  "Horloge :  " + t;
        }
    }
}
