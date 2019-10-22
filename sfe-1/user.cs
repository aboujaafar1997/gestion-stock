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
    public partial class user : UserControl
    {
        public user()
        {
            InitializeComponent();
        }

        private void user_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from utilisateur ", Class1.cn);
            Class1.adapter.Fill(dt1);
            BunifuCustomDataGrid1.DataSource = dt1;
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                Class1.cmd = new MySqlCommand("INSERT INTO utilisateur values (@ID, @PWD)", Class1.cn);
                Class1.cmd.Parameters.Add(new MySqlParameter("@ID", MySqlDbType.VarChar, 30)).Value = BunifuMetroTextbox4.Text;
                Class1.cmd.Parameters.Add(new MySqlParameter("@PWD", MySqlDbType.VarChar, 30)).Value = Class1.sha256(BunifuMetroTextbox5.Text);

                Class1.cn.Open();
                Class1.cmd.ExecuteNonQuery();
                BunifuMetroTextbox4.Text = "";
                BunifuMetroTextbox5.Text = "";
                DataTable dt1 = new DataTable();
                
                Class1.adapter = new MySqlDataAdapter("select * from utilisateur ", Class1.cn);
                Class1.adapter.Fill(dt1);
                BunifuCustomDataGrid1.DataSource = dt1;
                notyf n = new notyf();
                n.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            Class1.cn.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult a;
                a = MessageBox.Show("suprimer", "suprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    Class1.cmd = new MySqlCommand("delete from utilisateur WHERE ID ='" + BunifuCustomDataGrid1.CurrentRow.Cells[0].Value + "'", Class1.cn);
                    Class1.cn.Open();
                    Class1.cmd.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                  

                    Class1.adapter = new MySqlDataAdapter("select * from utilisateur ", Class1.cn);
                    Class1.adapter.Fill(dt1);
                    BunifuCustomDataGrid1.DataSource = dt1;
                    notyf n = new notyf();
                    n.Show();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            Class1.cn.Close();
        }
    }
}
