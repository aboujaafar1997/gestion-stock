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
    public partial class Statistique : UserControl
    {
        public Statistique()
        {
            InitializeComponent();
        }

        private void Statistique_Load(object sender, EventArgs e)
        {
           
            // bar

            DataTable ab = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select count(N_C_C) from commande_c", Class1.cn);
            Class1.adapter.Fill(ab);
            int tous = Convert.ToInt32(ab.Rows[0][0]);
            DataTable abc = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select count(N_C_C) from commande_effectue_client", Class1.cn);
            Class1.adapter.Fill(abc);
            int ef= Convert.ToInt32(abc.Rows[0][0]);
          

            bunifuCircleProgressbar1.Value = (ef * 100) / tous;


            //chart 2

            Class1.cmd = new MySqlCommand("select DATE_FORMAT(a.date, '%m') as mois,sum(PRIX_TOTAL) as nbr from  commande_fournisseur a group by DATE_FORMAT(a.date, '%m') ", Class1.cn);
            Class1.cn.Open();
            MySqlDataReader num3 = Class1.cmd.ExecuteReader();
            while (num3.Read())
            {
                chart2.Series["cout"].Points.AddXY(num3.GetString("mois"), num3.GetUInt64("nbr"));
            }
            Class1.cn.Close();

            //chart1



            Class1.cmd = new MySqlCommand("select DATE_FORMAT(a.date, '%m') as mois,sum(PRIX_TOTALE) as nbr from  commande_c a group by DATE_FORMAT(a.date, '%m') ", Class1.cn);
        Class1.cn.Open();
        MySqlDataReader num = Class1.cmd.ExecuteReader();
        while(num.Read()) {
                Chart1.Series["financement"].Points.AddXY(num.GetString("mois"), num.GetUInt64("nbr"));


                    }

            Class1.cn.Close();


            //chart3
            DataTable a = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select P.NOM ,COUNT(C.N_P) as nbr from contient_c_client C , produit P where C.N_P=P.N_P group by C.N_P", Class1.cn);
            Class1.adapter.Fill(a);
           
            for (int i=0;i<a.Rows.Count;i++)
          
            {

                string x = a.Rows[i][0].ToString();
                string y = a.Rows[i][1].ToString();

                chart3.Series["produit"].Points.AddXY(x, y);


            }

            Class1.cn.Close();
            // mieur client 
            DataTable client = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select NOM from client where CNI IN(SELECT p.CNI from(select CNI, count(CNI) as nbr from commande_c a  group by CNI HAVING nbr >= max(nbr)) p); ", Class1.cn);
            Class1.adapter.Fill(client);
            label1.Text = client.Rows[0][0].ToString();
            // dernier client 
            DataTable dclient = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select NOM from client where CNI IN (select CNI from commande_c)   ", Class1.cn);
            Class1.adapter.Fill(dclient);
            label3.Text = dclient.Rows[0][0].ToString();
            // nembre de client
            DataTable nclient = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select count(NOM) from client ", Class1.cn);
            Class1.adapter.Fill(nclient);
            label10.Text = label10.Text+" "+nclient.Rows[0][0].ToString();
            // nembre de commande
            DataTable ncommande = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select count(CNI) from commande_c ", Class1.cn);
            Class1.adapter.Fill(ncommande);
            label11.Text = label11.Text +" "+ ncommande.Rows[0][0].ToString();

        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Left += 1;
       
            if (label10.Left > 1000)
                label10.Left = 85;
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Bitmap a = new Bitmap(this.Width, this.Height);
            String b = "C:/Users/othmane/Desktop/statistique.png";
            this.DrawToBitmap(a, new Rectangle(0, 0, this.Width, this.Height));
            a.Save(b);
            MessageBox.Show("save in desktop sous le nom: statistique");
        }
    }
}
