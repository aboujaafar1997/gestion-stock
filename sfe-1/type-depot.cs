using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class type_depot : Form
    {
        public type_depot()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            Class1.cmd = new MySql.Data.MySqlClient.MySqlCommand("INSERT INTO depot values (@NOM_DEPOT)", Class1.cn);
            Class1.cmd.Parameters.Add(new MySqlParameter("@NOM_DEPOT", MySqlDbType.VarChar, 30)).Value = BunifuMetroTextbox7.Text;
            Class1.cn.Open();
            Class1.cmd.ExecuteNonQuery();
            Class1.adapter = new MySqlDataAdapter("select * from depot ", Class1.cn);
            Class1.adapter.Fill(dt1);
            bunifuCustomDataGrid1.DataSource = dt1;
            notyf n = new notyf();
            n.Show();
            BunifuMetroTextbox7.Text="";
            Class1.cn.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            Class1.cmd = new MySql.Data.MySqlClient.MySqlCommand("INSERT INTO famille values (@NOM_FAMILLE)", Class1.cn);
            Class1.cmd.Parameters.Add(new MySqlParameter("@NOM_FAMILLE", MySqlDbType.VarChar, 30)).Value = bunifuMetroTextbox1.Text;
            Class1.cn.Open();
            Class1.cmd.ExecuteNonQuery();
            Class1.adapter = new MySqlDataAdapter("select * from famille ", Class1.cn);
            Class1.adapter.Fill(dt2);
            bunifuCustomDataGrid2.DataSource = dt2;
            notyf n = new notyf();
            n.Show();
            bunifuMetroTextbox1.Text = "";
            Class1.cn.Close();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult a;
                a = MessageBox.Show("suprimer", "suprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    Class1.cmd = new MySqlCommand("delete from depot WHERE NOM_DEPOT ='" + bunifuCustomDataGrid1.CurrentRow.Cells[0].Value + "'", Class1.cn);
                    Class1.cn.Open();
                    Class1.cmd.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    Class1.adapter = new MySqlDataAdapter("select * from depot ", Class1.cn);
                    Class1.adapter.Fill(dt1);
                    bunifuCustomDataGrid2.DataSource = dt1;
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

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try { 

            DialogResult a;
            a = MessageBox.Show("suprimer", "suprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Class1.cmd = new MySqlCommand("delete from famille WHERE NOM_FAMILLE ='" + bunifuCustomDataGrid2.CurrentRow.Cells[0].Value + "'", Class1.cn);
                Class1.cn.Open();
                Class1.cmd.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                Class1.adapter = new MySqlDataAdapter("select * from famille ", Class1.cn);
                Class1.adapter.Fill(dt2);
                bunifuCustomDataGrid2.DataSource = dt2;
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

        private void type_depot_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from famille ", Class1.cn);
            Class1.adapter.Fill(dt1);
            bunifuCustomDataGrid2.DataSource = dt1;

            DataTable dt2 = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from depot ", Class1.cn);
            Class1.adapter.Fill(dt2);
            bunifuCustomDataGrid1.DataSource = dt2;
        }
    }
}
