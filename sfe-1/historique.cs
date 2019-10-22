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
    public partial class historique : UserControl
    {
        public historique()
        {
            InitializeComponent();
        }

        private void historique_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from historique_acces ", Class1.cn);
            Class1.adapter.Fill(dt);
            BunifuCustomDataGrid1.DataSource = dt;

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from historique_acces ", Class1.cn);
            Class1.adapter.Fill(dt);
            BunifuCustomDataGrid1.DataSource = dt;
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = MessageBox.Show("vider", "vider", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Class1.cmd = new MySqlCommand("delete from historique_acces ", Class1.cn);
                Class1.cn.Open();
                Class1.cmd.ExecuteNonQuery();
                Class1.cn.Close();

                DataTable dt1 = new DataTable();
                Class1.adapter = new MySqlDataAdapter("select * from historique_acces ", Class1.cn);
                Class1.adapter.Fill(dt1);
                BunifuCustomDataGrid1.DataSource = dt1;
                notyf n = new notyf();
                n.Show();
            }
        }
    }
}
