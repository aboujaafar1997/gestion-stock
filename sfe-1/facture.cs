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
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApplication1
{
    public partial class facture : UserControl
    {
        public facture()
        {
            InitializeComponent();
        }

        private void BunifuCustomDataGrid1_DoubleClick(object sender, EventArgs e)
        {
            factureimprimer f = new factureimprimer();
            //CNI
            DataTable cni = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select CNI from commande_c where N_FACTURE='" + BunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString() + "'", Class1.cn);
            Class1.adapter.Fill(cni);
            //total
            DataTable total = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select PRIX_TOTALE from commande_c where N_FACTURE='" + BunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString() + "'", Class1.cn);
            Class1.adapter.Fill(total);


            Class1.adapter = new MySqlDataAdapter("select * from contient_c_client where N_C_C in (select N_C_C from commande_c where N_FACTURE='"+BunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString()+"')", Class1.cn);
            Class1.adapter.Fill(f.sfeDataSet.contient_c_client);
            Microsoft.Reporting.WinForms.ReportParameter p1 = new ReportParameter("date", DateTime.Now.ToString("dddd/MMMM/yyyy"));
            f.reportViewer1.LocalReport.SetParameters(p1);
            Microsoft.Reporting.WinForms.ReportParameter p2 = new ReportParameter("CIN", cni.Rows[0][0].ToString());
            f.reportViewer1.LocalReport.SetParameters(p2);
            Microsoft.Reporting.WinForms.ReportParameter p3 = new ReportParameter("TOTAL", total.Rows[0][0].ToString());
            f.reportViewer1.LocalReport.SetParameters(p3);
 


            f.reportViewer1.RefreshReport();
            f.Show();



        }

        private void facture_Load(object sender, EventArgs e)
        {
            DataTable F= new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from facture ", Class1.cn);
            Class1.adapter.Fill(F);
            BunifuCustomDataGrid1.DataSource = F;


        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            DataTable F = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from facture ", Class1.cn);
            Class1.adapter.Fill(F);
            BunifuCustomDataGrid1.DataSource = F;
        }
    }
}
