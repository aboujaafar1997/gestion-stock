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
    public partial class bonne : UserControl
    {
       
        public bonne()
        {
            InitializeComponent();
        }
        DataTable bon= new DataTable();
        private void bonne_Load(object sender, EventArgs e)
        {
           
            Class1.adapter = new MySqlDataAdapter("select N_bonne,N_C_C,CNI,DATE,avance from commande_c ", Class1.cn);
            Class1.adapter.Fill(bon);
            BunifuCustomDataGrid1.DataSource = bon;

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            bon.Clear();
         
            DataTable dtc = bon;
            DataView dv = dtc.DefaultView;
            dv.RowFilter = " N_bonne,N_C_C,CNI,DATE,avance like '%" + TextBox1.Text + "%'";
            BunifuCustomDataGrid1.DataSource = dv;
        }
    }
}
