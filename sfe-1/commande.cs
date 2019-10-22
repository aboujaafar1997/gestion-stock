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
    public partial class commande : UserControl
    {
        bool t = false;
        public commande()
        {
            InitializeComponent();
        }

        private void commande_Load(object sender, EventArgs e)
        {
            bunifuCustomDataGrid3.Visible = true;
                bunifuCustomDataGrid1.Visible = false;

            // commande_ef
            DataTable dtcommande_ef = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from commande_effectue_client ", Class1.cn);
            Class1.adapter.Fill(dtcommande_ef);
            bunifuCustomDataGrid1.DataSource = dtcommande_ef;

            // commande
            DataTable dtcommande = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from commande_c ", Class1.cn);
            Class1.adapter.Fill(dtcommande);
            bunifuCustomDataGrid3.DataSource = dtcommande;










            //ajouter
            DataTable dtn = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select max(N_C_C) from commande_c  ", Class1.cn);
            Class1.adapter.Fill(dtn);
            int   a= Convert.ToInt32(dtn.Rows[0][0]);
            a = a + 1;
            bunifuCustomLabel11.Text = a.ToString();
            DataTable dtclient = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from client ", Class1.cn);
            Class1.adapter.Fill(dtclient);
            ComboBox1.DataSource = dtclient;
            ComboBox1.ValueMember = "CNI";
            ComboBox1.DisplayMember = "NOM";
            DataTable dtproduit = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from produit ", Class1.cn);
            Class1.adapter.Fill(dtproduit);
            ComboBox2.DataSource = dtproduit;
            ComboBox2.ValueMember = "N_P";
            ComboBox2.DisplayMember = "NOM";
            t = true;
            


        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (t == true)
                ComboBox1.Enabled = false;




        }

        private void ComboBox1_Click(object sender, EventArgs e)
        {


           

        }
        bool a = false;
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        { if (a == true) { 
            DataTable prix = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select PRIX_TOTALE from produit where NOM='"+ComboBox2.Text+"'", Class1.cn);
            Class1.adapter.Fill(prix);
                if( prix.Rows.Count > 0)
            bunifuCustomLabel8.Text = prix.Rows[0][0].ToString();
            }
        }

        private void commande_MouseEnter(object sender, EventArgs e)
        {
            a = true;
        }
        int i = -1;
        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            if (ComboBox2.SelectedValue.ToString() != "" && ComboBox1.SelectedValue.ToString() != "" && bunifuMetroTextbox3.Text != "" && bunifuMetroTextbox1.Text != "" && bunifuCustomLabel8.Text != "Prix")
            {

                try
                {
                    double prix = (Convert.ToInt32(bunifuCustomLabel8.Text) * Convert.ToInt32(bunifuMetroTextbox1.Text));
                    double remise = (Convert.ToInt32(bunifuMetroTextbox3.Text) * prix) / 100;
                    i++;
                    bunifuCustomDataGrid2.Rows.Add();
                 
                    bunifuCustomDataGrid2.Rows[i].Cells[0].Value = ComboBox2.SelectedValue.ToString();
                    if (bunifuMetroTextbox3.Text == "")
                    {
                        bunifuCustomDataGrid2.Rows[i].Cells[1].Value = bunifuCustomLabel8.Text;

                    }
                    else
                    {
                        bunifuCustomDataGrid2.Rows[i].Cells[1].Value = (prix - remise).ToString();
                    }
                    bunifuCustomDataGrid2.Rows[i].Cells[2].Value = bunifuMetroTextbox3.Text.ToString();
                    bunifuCustomDataGrid2.Rows[i].Cells[3].Value = bunifuMetroTextbox1.Text.ToString();
                    bunifuMetroTextbox3.Text = "";
                    bunifuMetroTextbox1.Text = "";
                    bunifuCustomLabel8.Text = "Prix";
                    ComboBox2.Text = "";


                }
                catch (Exception d)
                {

                    MessageBox.Show(d.Message);
                }
            }
            else {
                MessageBox.Show("remplir les champs !!");

            }
            
            
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            
            double prixtotal=0;
            

            //prixtatoal
            for (int i=0; i < bunifuCustomDataGrid2.Rows.Count-1; i++)
            {
              
                prixtotal = prixtotal + Convert.ToInt32(bunifuCustomDataGrid2.Rows[i].Cells[1].Value);
            }
        
            //commande

            try
            {
                Class1.cmd = new MySqlCommand("INSERT INTO commande_c values (@N_C_C, @ID_user, @CNI, @N_FACTURE, @DATE, @PRIX_TOTALE,@N_bonne,@avance)", Class1.cn);
                Class1.cmd.Parameters.Add(new MySqlParameter("@N_C_C", MySqlDbType.VarChar, 30)).Value = bunifuCustomLabel11.Text;
                Class1.cmd.Parameters.Add(new MySqlParameter("@ID_user", MySqlDbType.VarChar, 30)).Value = login.p.Label3.Text;
                Class1.cmd.Parameters.Add(new MySqlParameter("@CNI", MySqlDbType.VarChar, 30)).Value = ComboBox1.SelectedValue;
                Class1.cmd.Parameters.Add(new MySqlParameter("@N_FACTURE", MySqlDbType.VarChar, 30)).Value = bunifuCustomLabel11.Text;
                Class1.cmd.Parameters.Add(new MySqlParameter("@DATE", MySqlDbType.Date)).Value = bunifuDatepicker1.Value;
                Class1.cmd.Parameters.Add(new MySqlParameter("@PRIX_TOTALE", MySqlDbType.VarChar, 30)).Value = prixtotal.ToString();
                Class1.cmd.Parameters.Add(new MySqlParameter("@N_bonne", MySqlDbType.VarChar, 30)).Value = bunifuMetroTextbox4.Text;
                Class1.cmd.Parameters.Add(new MySqlParameter("@avance", MySqlDbType.VarChar, 30)).Value = bunifuMetroTextbox2.Text;

                Class1.cn.Open();
                Class1.cmd.ExecuteNonQuery();
              
            
         
            
            //contient


            for (int i = 0; i < bunifuCustomDataGrid2.Rows.Count; i++)
            {
                    MessageBox.Show(i.ToString());
                Class1.cmd = new MySqlCommand("INSERT INTO contient_c_client values (@N_P,@N_C_C,@QTE)", Class1.cn);
                Class1.cmd.Parameters.Add(new MySqlParameter("@N_P", MySqlDbType.VarChar, 30)).Value = bunifuCustomDataGrid2.Rows[i].Cells[0].Value;
                Class1.cmd.Parameters.Add(new MySqlParameter("@N_C_C", MySqlDbType.VarChar, 30)).Value = bunifuCustomLabel11.Text;
                Class1.cmd.Parameters.Add(new MySqlParameter("@QTE", MySqlDbType.VarChar, 30)).Value = bunifuCustomDataGrid2.Rows[i].Cells[3].Value;
               
                Class1.cmd.ExecuteNonQuery();
                
             
            }
            Class1.cn.Close();

            ////facture
            Class1.cmd = new MySqlCommand("INSERT INTO facture values (@N_FACTURE, @CNI)", Class1.cn);
            Class1.cmd.Parameters.Add(new MySqlParameter("@N_FACTURE", MySqlDbType.VarChar, 30)).Value = bunifuCustomLabel11.Text;
            Class1.cmd.Parameters.Add(new MySqlParameter("@CNI", MySqlDbType.VarChar, 30)).Value = ComboBox1.SelectedValue;
            Class1.cn.Open();
            Class1.cmd.ExecuteNonQuery();
            Class1.cn.Close();
            bunifuCustomDataGrid2.Rows.Clear();
            i = -1;
            Class1.cn.Close();
            DataTable dtn = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select max(N_C_C) from commande_c  ", Class1.cn);
            Class1.adapter.Fill(dtn);
            int a = Convert.ToInt32(dtn.Rows[0][0]);
            a = a + 1;
            bunifuCustomLabel11.Text = a.ToString();
            ComboBox1.Enabled = true;
            bunifuMetroTextbox3.Text = "";
            bunifuMetroTextbox1.Text = "";
            bunifuCustomLabel8.Text = "Prix";
            ComboBox2.Text = "";
            bunifuMetroTextbox4.Text = "";
            bunifuMetroTextbox2.Text = "";
            notyf na = new notyf();
            na.Show();
            notificationicon not = new notificationicon("Ajouter", "la commande   :" + bunifuCustomLabel8.Text);
            not.Location = new Point(Class1.index, na.Height * Class1.index);
            Class1.index++;
            login.p.top_bare1.panel1.Controls.Add(not);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            ComboBox1.Enabled = true;
            bunifuMetroTextbox3.Text = "";
            bunifuMetroTextbox1.Text = "";
            bunifuCustomLabel8.Text = "Prix";
            ComboBox2.Text = "";
            bunifuMetroTextbox4.Text = "";
            bunifuMetroTextbox2.Text = "";
            bunifuCustomDataGrid1.Rows.Clear();
            i = -1;
        }

            private void RadioButton1_CheckedChanged(object sender, EventArgs e)
            {
                if (RadioButton1.Checked == true) {
                    bunifuCustomDataGrid3.Visible = true;
                    bunifuThinButton26.Visible = true;

                }
           
            }

            private void RadioButton2_CheckedChanged(object sender, EventArgs e)
            {
                if (RadioButton2.Checked == true)
                {
                    bunifuCustomDataGrid1.Visible = true;
                    bunifuCustomDataGrid3.Visible = false;
                    bunifuThinButton26.Visible = false;

                }

        
            }

            private void radioButton3_CheckedChanged(object sender, EventArgs e)
            {
                if (radioButton3.Checked == true)
                {
                    bunifuCustomDataGrid1.Visible = false;
                    bunifuCustomDataGrid3.Visible = false;
                    bunifuThinButton26.Visible = false;

                }
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            // commande_ef
            DataTable dtcommande_ef = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from commande_effectue_client ", Class1.cn);
            Class1.adapter.Fill(dtcommande_ef);
            bunifuCustomDataGrid1.DataSource = dtcommande_ef;

            // commande
            DataTable dtcommande = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from commande_c ", Class1.cn);
            Class1.adapter.Fill(dtcommande);
            bunifuCustomDataGrid3.DataSource = dtcommande;
            notyf n = new notyf();
            n.Show();










            //ajouter
            DataTable dtn = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select max(N_C_C) from commande_c  ", Class1.cn);
            Class1.adapter.Fill(dtn);
            int a = Convert.ToInt32(dtn.Rows[0][0]);
            a = a + 1;
            bunifuCustomLabel11.Text = a.ToString();
            DataTable dtclient = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from client ", Class1.cn);
            Class1.adapter.Fill(dtclient);
            ComboBox1.DataSource = dtclient;
            ComboBox1.ValueMember = "CNI";
            ComboBox1.DisplayMember = "NOM";
            DataTable dtproduit = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from produit ", Class1.cn);
            Class1.adapter.Fill(dtproduit);
            ComboBox2.DataSource = dtproduit;
            ComboBox2.ValueMember = "N_P";
            ComboBox2.DisplayMember = "NOM";
            t = true;
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            DataTable verifier = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select N_C_C from commande_effectue_client where N_C_C='"+bunifuCustomDataGrid3.CurrentRow.Cells[0].Value+"'", Class1.cn);
            Class1.adapter.Fill(verifier);
            ComboBox2.DataSource = verifier;
            if (verifier.Rows.Count == 0)
            {
                Class1.cmd = new MySqlCommand("INSERT INTO commande_effectue_client values (@N_C_C, @ID, @DATE1)", Class1.cn);
                Class1.cmd.Parameters.Add(new MySqlParameter("@N_C_C", MySqlDbType.VarChar, 30)).Value = bunifuCustomDataGrid3.CurrentRow.Cells[0].Value;
                Class1.cmd.Parameters.Add(new MySqlParameter("@ID", MySqlDbType.VarChar, 30)).Value = login.p.Label3.Text.ToString();
                Class1.cmd.Parameters.Add(new MySqlParameter("@DATE1", MySqlDbType.VarChar, 30)).Value = DateTime.Now.ToString();
                Class1.cn.Open();
                Class1.cmd.ExecuteNonQuery();
                notyf n = new notyf();
                n.Show();
                Class1.cn.Close();
                DataTable dtcommande_ef = new DataTable();
                Class1.adapter = new MySqlDataAdapter("select * from commande_effectue_client ", Class1.cn);
                Class1.adapter.Fill(dtcommande_ef);
                bunifuCustomDataGrid1.DataSource = dtcommande_ef;
                //message
                if (login.p.parametre1.bunifuSwitch1.Value == true)
                {
                    DataTable tel = new DataTable();
                    Class1.adapter = new MySqlDataAdapter("select TELEPHONE from client where CNI='" + bunifuCustomDataGrid3.CurrentRow.Cells[2].Value + "'", Class1.cn);
                    Class1.adapter.Fill(tel);
                    MessageBox.Show(tel.Rows[0][0].ToString());
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Close();
                    }

                    serialPort1.PortName = login.p.parametre1.ComboBox1.Text.ToString();
                    serialPort1.BaudRate = 9600;
                    serialPort1.Parity = System.IO.Ports.Parity.None;
                    serialPort1.DataBits = 8;
                    serialPort1.Handshake = System.IO.Ports.Handshake.RequestToSend;
                    serialPort1.DtrEnable = true;
                    serialPort1.RtsEnable = true;
                    try
                    {
                        serialPort1.Open();
                        if (serialPort1.IsOpen)
                        {

                            serialPort1.Write("at\r");
                            serialPort1.Write("at+cmgf=1\r");
                            System.Threading.Thread.Sleep(1000);
                            serialPort1.Write("at+cmgs=\"" + tel.Rows[0][0].ToString() + "\"\r\n");
                            serialPort1.Write(login.p.parametre1.BunifuMetroTextbox1.Text + "\x1A");
                            System.Threading.Thread.Sleep(1000);
                            MessageBox.Show("efuctue");
                            notyf na = new notyf();
                            na.Show();
                            notificationicon not = new notificationicon("Passer a effectué", "la commande   :" + bunifuCustomDataGrid3.CurrentRow.Cells[0].Value);
                            not.Location = new Point(Class1.index, na.Height * Class1.index);
                            Class1.index++;
                            login.p.top_bare1.panel1.Controls.Add(not);
                            serialPort1.Close();
                            MessageBox.Show("message envoyer");
                        }
                        else
                        {
                            MessageBox.Show("Port '" + serialPort1.PortName + "' is not available!");
                        }
                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);


                    }


                }
            }
            else
            {
                MessageBox.Show("deja effectué");

            }



        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult a;
                a = MessageBox.Show("suprimer", "suprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    Class1.cmd = new MySqlCommand("delete from commande_c WHERE N_C_C='" + bunifuCustomDataGrid3.CurrentRow.Cells[0].Value + "'", Class1.cn);
                    Class1.cn.Open();
                    Class1.cmd.ExecuteNonQuery();
                    Class1.cn.Close();
                    Class1.cmd = new MySqlCommand("delete from facture WHERE N_FACTURE='" + bunifuCustomDataGrid3.CurrentRow.Cells[3].Value + "'", Class1.cn);
                    Class1.cn.Open();
                    Class1.cmd.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    Class1.adapter = new MySqlDataAdapter("select * from commande_c ", Class1.cn);
                    Class1.adapter.Fill(dt1);
                    bunifuCustomDataGrid3.DataSource = dt1;
                    notyf na = new notyf();
                    na.Show();
                    notificationicon not = new notificationicon("Supprimer", "la commande   :" + bunifuCustomDataGrid3.CurrentRow.Cells[0].Value);
                    not.Location = new Point(Class1.index, na.Height * Class1.index);
                    Class1.index++;
                    login.p.top_bare1.panel1.Controls.Add(not);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            Class1.cn.Close();
            notyf n = new notyf();
            n.Show();





        }


        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid3.Visible == true)
            {
                DataTable dt1 = new DataTable();
                Class1.adapter = new MySqlDataAdapter("select * from commande_c ", Class1.cn);
                Class1.adapter.Fill(dt1);
                try
                {
                    if (dt1 == null || dt1.Columns.Count == 0)
                        throw new Exception("ExportToExcel: Null or empty input table!\n");

                    // load excel, and create a new workbook
                    var excelApp = new Microsoft.Office.Interop.Excel.Application();
                    excelApp.Workbooks.Add();

                    // single worksheet
                    Microsoft.Office.Interop.Excel._Worksheet workSheet = excelApp.ActiveSheet;

                    // column headings
                    for (var i = 0; i < dt1.Columns.Count; i++)
                    {
                        workSheet.Cells[1, i + 1] = dt1.Columns[i].ColumnName;
                    }

                    // rows
                    for (var i = 0; i < dt1.Rows.Count; i++)
                    {
                        // to do: format datetime values before printing
                        for (var j = 0; j < dt1.Columns.Count; j++)
                        {
                            workSheet.Cells[i + 2, j + 1] = dt1.Rows[i][j];
                        }
                    }

                    // check file path

                    if (!string.IsNullOrEmpty(DateTime.Now.Day.ToString() + "commande_c.xlsx"))
                    {
                        try
                        {
                            workSheet.SaveAs(DateTime.Now.Day.ToString() + "commande_c.xlsx");
                            excelApp.Quit();
                            MessageBox.Show("Excel file saved!");

                            System.Diagnostics.Process.Start("C:/Users/othmane/Documents/" + DateTime.Now.Day.ToString() + "commande_c.xlsx");



                        }
                        catch (Exception ex)
                        {
                            throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                                                + ex.Message);
                        }
                    }
                    else
                    { // no file path is given
                        excelApp.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }

            
                if (bunifuCustomDataGrid1.Visible == true)
            {
                DataTable dt1 = new DataTable();
                Class1.adapter = new MySqlDataAdapter("select * from commande_effectue_client ", Class1.cn);
                Class1.adapter.Fill(dt1);
                try
                {
                    if (dt1 == null || dt1.Columns.Count == 0)
                        throw new Exception("ExportToExcel: Null or empty input table!\n");

                    // load excel, and create a new workbook
                    var excelApp = new Microsoft.Office.Interop.Excel.Application();
                    excelApp.Workbooks.Add();

                    // single worksheet
                    Microsoft.Office.Interop.Excel._Worksheet workSheet = excelApp.ActiveSheet;

                    // column headings
                    for (var i = 0; i < dt1.Columns.Count; i++)
                    {
                        workSheet.Cells[1, i + 1] = dt1.Columns[i].ColumnName;
                    }

                    // rows
                    for (var i = 0; i < dt1.Rows.Count; i++)
                    {
                        // to do: format datetime values before printing
                        for (var j = 0; j < dt1.Columns.Count; j++)
                        {
                            workSheet.Cells[i + 2, j + 1] = dt1.Rows[i][j];
                        }
                    }

                    // check file path

                    if (!string.IsNullOrEmpty(DateTime.Now.Day.ToString() + "commande_effectue_client.xlsx"))
                    {
                        try
                        {
                            workSheet.SaveAs(DateTime.Now.Day.ToString() + "commande_effectue_client.xlsx");
                            excelApp.Quit();
                            MessageBox.Show("Excel file saved!");

                            System.Diagnostics.Process.Start("C:/Users/othmane/Documents/" + DateTime.Now.Day.ToString() + "commande_effectue_client.xlsx");



                        }
                        catch (Exception ex)
                        {
                            throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                                                + ex.Message);
                        }
                    }
                    else
                    { // no file path is given
                        excelApp.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }



        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid3.Visible == true) {
                DataTable dt1 = new DataTable();
                Class1.adapter = new MySqlDataAdapter("select * from commande_c ", Class1.cn);
            Class1.adapter.Fill(dt1);
            DataTable dtc = dt1;
            DataView dv = dtc.DefaultView;
            dv.RowFilter = "N_C_C+ID_user+CNI+N_FACTURE+N_bonne like '%" + TextBox1.Text + "%'";
            bunifuCustomDataGrid3.DataSource = dv;
            }
            if (bunifuCustomDataGrid1.Visible == true)
            {
                DataTable dt1 = new DataTable();
                Class1.adapter = new MySqlDataAdapter("select * from commande_effectue_client ", Class1.cn);
                Class1.adapter.Fill(dt1);
                DataTable dtc = dt1;
                DataView dv = dtc.DefaultView;
                dv.RowFilter = "N_C_C+ID+DATE1 like '%" + TextBox1.Text + "%'";
                bunifuCustomDataGrid1.DataSource = dv;
            }
        }

        private void bunifuCustomDataGrid3_DoubleClick(object sender, EventArgs e)
        {
            DataTable dt12 = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from contient_c_client where N_C_C='"+ bunifuCustomDataGrid3.CurrentRow.Cells[0].Value + "'", Class1.cn);
            Class1.adapter.Fill(dt12);
            detail dtail = new detail();

            dtail.bunifuCustomDataGrid1.DataSource = dt12;
            dtail.Show();
        }
    }
}
