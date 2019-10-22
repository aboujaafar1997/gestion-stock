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
using System.Net.Mail;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class commandefournisseur : UserControl
    {
        bool ab = false;
        public commandefournisseur()
        {
            InitializeComponent();
        }
        int i = -1;
        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid2.Rows.Add();
            i++;
            bunifuCustomDataGrid2.Rows[i].Cells[0].Value = ComboBox2.SelectedValue.ToString();
            bunifuCustomDataGrid2.Rows[i].Cells[1].Value = BunifuMetroTextbox5.Text.ToString();
            bunifuCustomDataGrid2.Rows[i].Cells[2].Value = bunifuCustomLabel9.Text.ToString();
            BunifuMetroTextbox5.Text = "";
            ComboBox2.Text = "";
            bunifuCustomLabel9.Text = "";
        }

        private void commandefournisseur_Load(object sender, EventArgs e)
        {
            //data1
            DataTable dtfournisseur = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from commande_fournisseur  ", Class1.cn);
            Class1.adapter.Fill(dtfournisseur);
            bunifuCustomDataGrid3.DataSource = dtfournisseur;
            //data2
            DataTable dtfef = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from commande_efectuer_fournisseur  ", Class1.cn);
            Class1.adapter.Fill(dtfef);
            bunifuCustomDataGrid1.DataSource = dtfef;


            //remplir
            DataTable dtn = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select max(N_COMMANDE) from commande_fournisseur  ", Class1.cn);
            Class1.adapter.Fill(dtn);
            int a = Convert.ToInt32(dtn.Rows[0][0]);
            a = a + 1;
            bunifuCustomLabel7.Text = a.ToString();
            DataTable dtfour = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from fournisseur ", Class1.cn);
            Class1.adapter.Fill(dtfour);
            ComboBox1.DataSource = dtfour;
            ComboBox1.ValueMember = "N";
            ComboBox1.DisplayMember = "NOM";
            DataTable dtproduit = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from produit ", Class1.cn);
            Class1.adapter.Fill(dtproduit);
            ComboBox2.DataSource = dtproduit;
            ComboBox2.ValueMember = "N_P";
            ComboBox2.DisplayMember = "NOM";
            ab = true;
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            ComboBox1.Enabled = true;
            BunifuMetroTextbox5.Text = "";
            ComboBox2.Text = "";
            bunifuCustomLabel9.Text = "Prix";
            bunifuCustomDataGrid2.Rows.Clear();
            notyf n = new notyf();
            n.Show();

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            ComboBox1.Enabled = true;
            //total prix
            int prixtotal = 0;
            for (int i = 0; i < bunifuCustomDataGrid2.Rows.Count-1; i++)
            {

                prixtotal = prixtotal + Convert.ToInt32(bunifuCustomDataGrid2.Rows[i].Cells[2].Value);
            }
            Class1.cmd = new MySqlCommand("INSERT INTO commande_fournisseur values (@N_COMMANDE, @USER_DEMANDER, @PRIX_TOTAL, @date)", Class1.cn);
            Class1.cmd.Parameters.Add(new MySqlParameter("@N_COMMANDE", MySqlDbType.VarChar, 30)).Value = bunifuCustomLabel7.Text;
            Class1.cmd.Parameters.Add(new MySqlParameter("@USER_DEMANDER", MySqlDbType.VarChar, 30)).Value = login.p.Label3.Text;
            Class1.cmd.Parameters.Add(new MySqlParameter("@PRIX_TOTAL", MySqlDbType.VarChar, 30)).Value = prixtotal;
            Class1.cmd.Parameters.Add(new MySqlParameter("@date", MySqlDbType.Date)).Value = bunifuDatepicker1.Value;
            Class1.cn.Open();
            Class1.cmd.ExecuteNonQuery();
            Class1.cn.Close();
            //contient
            Class1.cn.Open();
            for (int i = 0; i < bunifuCustomDataGrid2.Rows.Count; i++)
            {
                Class1.cmd = new MySqlCommand("INSERT INTO contient_c_fournisseur values (@N_COMMANDE, @N_P, @QTE)", Class1.cn);
                Class1.cmd.Parameters.Add(new MySqlParameter("@N_COMMANDE", MySqlDbType.VarChar, 30)).Value = bunifuCustomLabel7.Text.ToString();
                Class1.cmd.Parameters.Add(new MySqlParameter("@N_P", MySqlDbType.VarChar, 30)).Value = bunifuCustomDataGrid2.Rows[i].Cells[0].Value.ToString();
                Class1.cmd.Parameters.Add(new MySqlParameter("@QTE", MySqlDbType.VarChar, 30)).Value = bunifuCustomDataGrid2.Rows[i].Cells[2].Value.ToString();
                Class1.cmd.ExecuteNonQuery();


            }
            Class1.cn.Close();
            notyf ntf = new notyf();
            DataTable dt2 = new DataTable();
            ntf.Show();
            Class1.adapter = new MySqlDataAdapter("select E_mail from fournisseur where N='"+ComboBox1.SelectedValue.ToString()+"'", Class1.cn);
            Class1.adapter.Fill(dt2);
          

            try
            {

                MailMessage mail = new MailMessage();
                mail.From = new System.Net.Mail.MailAddress(login.p.parametre1.bunifuMetroTextbox2.Text.ToString());
                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(mail.From.Address, login.p.parametre1.bunifuMetroTextbox3.Text.ToString());
                smtp.Host = "smtp.gmail.com";

                //recipient
                mail.To.Add(new MailAddress(dt2.Rows[0][0].ToString()));

                mail.IsBodyHtml = true;
                string st = login.p.parametre1.bunifuMetroTextbox4.Text.ToString();

                mail.Body = st;
                smtp.Send(mail);
                MessageBox.Show("envoyer");
                notyf na = new notyf();
                na.Show();
                notificationicon not = new notificationicon("Ajouter", "la commande   :" + bunifuCustomLabel7.Text);
                not.Location = new Point(Class1.index, na.Height * Class1.index);
                Class1.index++;
                login.p.top_bare1.panel1.Controls.Add(not);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }








        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ab == true)
            {
                DataTable prix = new DataTable();
                Class1.adapter = new MySqlDataAdapter("select PRIX_TOTALE from produit where NOM='" + ComboBox2.Text + "'", Class1.cn);
                Class1.adapter.Fill(prix);
                if (prix.Rows.Count > 0)
                    bunifuCustomLabel9.Text = prix.Rows[0][0].ToString();

            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ab == true)
            {
                ComboBox1.Enabled = false;
            }

        }
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
            {
                bunifuCustomDataGrid3.Visible = true;
                bunifuThinButton26.Visible = true;
                bunifuThinButton27.Visible = true;

            }
        }

        private void RadioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RadioButton2.Checked == true)
            {
                bunifuCustomDataGrid1.Visible = true;
                bunifuCustomDataGrid3.Visible = false;
                bunifuThinButton27.Visible = false;


            }
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                bunifuCustomDataGrid1.Visible = false;
                bunifuCustomDataGrid3.Visible = false;
                bunifuThinButton27.Visible = false;

            }
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            DataTable verifier = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select N_C from commande_efectuer_fournisseur where N_C='" + bunifuCustomDataGrid3.CurrentRow.Cells[0].Value + "'", Class1.cn);
            Class1.adapter.Fill(verifier);
            ComboBox2.DataSource = verifier;
            if (verifier.Rows.Count == 0)
            {
                Class1.cmd = new MySqlCommand("INSERT INTO commande_efectuer_fournisseur values (@N_C, @USER_CONFERME, @DATE)", Class1.cn);
                Class1.cmd.Parameters.Add(new MySqlParameter("@N_C", MySqlDbType.VarChar, 30)).Value = bunifuCustomDataGrid3.CurrentRow.Cells[0].Value;
                Class1.cmd.Parameters.Add(new MySqlParameter("@USER_CONFERME", MySqlDbType.VarChar, 30)).Value = login.p.Label3.Text.ToString();
                Class1.cmd.Parameters.Add(new MySqlParameter("@DATE", MySqlDbType.VarChar, 30)).Value = DateTime.Now.ToString();
                Class1.cn.Open();
                Class1.cmd.ExecuteNonQuery();
                notyf n = new notyf();
                n.Show();
                Class1.cn.Close();
                DataTable dtcommande_ef = new DataTable();
                Class1.adapter = new MySqlDataAdapter("select * from commande_efectuer_fournisseur ", Class1.cn);
                Class1.adapter.Fill(dtcommande_ef);
                bunifuCustomDataGrid1.DataSource = dtcommande_ef;
            }
            else
            {
                MessageBox.Show("deja efectué");


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
                    Class1.cmd = new MySqlCommand("delete from commande_fournisseur WHERE N_COMMANDE='" + bunifuCustomDataGrid3.CurrentRow.Cells[0].Value + "'", Class1.cn);
                    Class1.cn.Open();
                    Class1.cmd.ExecuteNonQuery();
                    Class1.cn.Close();

                    DataTable dt1 = new DataTable();
                    Class1.adapter = new MySqlDataAdapter("select * from commande_fournisseur ", Class1.cn);
                    Class1.adapter.Fill(dt1);
                    bunifuCustomDataGrid3.DataSource = dt1;
                   
                    notyf na = new notyf();
                    na.Show();
                    notificationicon not = new notificationicon("Supprimer", "la commande fournisseur   :" + bunifuCustomDataGrid3.CurrentRow.Cells[0].Value);
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
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            if (bunifuCustomDataGrid3.Visible == true)
            {
                
                Class1.adapter = new MySqlDataAdapter("select * from commande_fournisseur ", Class1.cn);
                Class1.adapter.Fill(dt1);
            }
            else if (bunifuCustomDataGrid1.Visible == true)
            {
                
                    
                Class1.adapter = new MySqlDataAdapter("select * from commande_efectuer_fournisseur ", Class1.cn);
                Class1.adapter.Fill(dt1);
            }
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

                    if (!string.IsNullOrEmpty(DateTime.Now.Day.ToString() + "commande_f.xlsx"))
                    {
                        try
                        {
                            workSheet.SaveAs(DateTime.Now.Day.ToString() + "commande_f.xlsx");
                            excelApp.Quit();
                            MessageBox.Show("Excel file saved!");

                            System.Diagnostics.Process.Start("C:/Users/othmane/Documents/" + DateTime.Now.Day.ToString() + "commande_f.xlsx");



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
        

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid3.Visible == true)
            {
                DataTable dt1 = new DataTable();
                Class1.adapter = new MySqlDataAdapter("select * from commande_fournisseur ", Class1.cn);
                Class1.adapter.Fill(dt1);
                DataTable dtc = dt1;
                DataView dv = dtc.DefaultView;
                dv.RowFilter = "N_COMMANDE+	USER_DEMANDER+date like '%" + TextBox1.Text + "%'";
                bunifuCustomDataGrid3.DataSource = dv;
            }
            if (bunifuCustomDataGrid1.Visible == true)
            {
                DataTable dt1 = new DataTable();
                Class1.adapter = new MySqlDataAdapter("select * from commande_efectuer_fournisseur ", Class1.cn);
                Class1.adapter.Fill(dt1);
                DataTable dtc = dt1;
                DataView dv = dtc.DefaultView;
                dv.RowFilter = "N_C+USER_CONFERME+DATE like '%" + TextBox1.Text + "%'";
                bunifuCustomDataGrid1.DataSource = dv;
            }
        }
    }
}

