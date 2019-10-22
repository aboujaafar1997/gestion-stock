using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class produit : UserControl
    {
        DataTable dt1 = new DataTable();
        public produit()
        {
            InitializeComponent();
        }

        private void bunifuMetroTextbox10_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (BunifuMetroTextbox1.Text != "" && BunifuMetroTextbox2.Text != "" && BunifuMetroTextbox3.Text != "" && bunifuMetroTextbox4.Text != "" && BunifuMetroTextbox5.Text != "" && BunifuMetroTextbox8.Text != "" && bunifuMetroTextbox11.Text != "" && bunifuMetroTextbox10.Text != "" && BunifuMetroTextbox7.Text != "" && bunifuMetroTextbox9.Text != "") 
                {

                    try
                    {
                        Class1.cmd = new MySqlCommand("INSERT INTO produit values (@N_P, @N_fournisseur, @NOM_DEPOT, @NOM_FAMILLE, @NOM, @TAILLE,@POSITION, @PRIX_TOTALE, @seuil_bas, @image  )", Class1.cn);
                        Class1.cmd.Parameters.Add(new MySqlParameter("@N_P", MySqlDbType.VarChar, 30)).Value = BunifuMetroTextbox1.Text;
                        Class1.cmd.Parameters.Add(new MySqlParameter("@N_fournisseur", MySqlDbType.VarChar, 30)).Value = BunifuMetroTextbox5.Text;
                        Class1.cmd.Parameters.Add(new MySqlParameter("@NOM_DEPOT", MySqlDbType.VarChar, 30)).Value = bunifuMetroTextbox11.Text;
                        Class1.cmd.Parameters.Add(new MySqlParameter("@NOM_FAMILLE", MySqlDbType.VarChar, 30)).Value = BunifuMetroTextbox3.Text;
                        Class1.cmd.Parameters.Add(new MySqlParameter("@NOM", MySqlDbType.VarChar, 30)).Value = BunifuMetroTextbox2.Text;
                        Class1.cmd.Parameters.Add(new MySqlParameter("@TAILLE", MySqlDbType.VarChar, 30)).Value = BunifuMetroTextbox8.Text + "*" + bunifuMetroTextbox9.Text + "*" + bunifuMetroTextbox10.Text;
                        Class1.cmd.Parameters.Add(new MySqlParameter("@POSITION", MySqlDbType.VarChar, 30)).Value = bunifuMetroTextbox6.Text;
                        Class1.cmd.Parameters.Add(new MySqlParameter("@PRIX_TOTALE", MySqlDbType.VarChar, 30)).Value = BunifuMetroTextbox7.Text;
                        Class1.cmd.Parameters.Add(new MySqlParameter("@seuil_bas", MySqlDbType.VarChar, 30)).Value = BunifuMetroTextbox7.Text;


                        if (PictureBox1.Image != null)
                        {
                            MemoryStream ms = new MemoryStream();
                            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat);
                            var pictuure = ms.ToArray();
                            Class1.cmd.Parameters.Add(new MySqlParameter("@image", MySqlDbType.LongBlob, 30)).Value = pictuure;

                        }
                        else
                        {
                            Class1.cmd.Parameters.Add(new MySqlParameter("@image", MySqlDbType.LongBlob, 30)).Value = null;
                        }
                    notyf n = new notyf();
                    n.Show();
                    notificationicon not = new notificationicon("Ajouter", "le produit   :" + bunifuMetroTextbox11.Text);
                    not.Location = new Point(Class1.index, n.Height * Class1.index);
                    Class1.index++;
                    Class1.cn.Open();
                        Class1.cmd.ExecuteNonQuery();
                        bunifuMetroTextbox11.Text = "";
                        BunifuMetroTextbox1.Text = "";
                        BunifuMetroTextbox2.Text = "";
                        BunifuMetroTextbox5.Text = "";
                        BunifuMetroTextbox3.Text = "";
                        bunifuMetroTextbox4.Text = "";
                        BunifuMetroTextbox5.Text = "";
                        bunifuMetroTextbox6.Text = "";
                        BunifuMetroTextbox7.Text = "";
                        BunifuMetroTextbox8.Text = "";
                        bunifuMetroTextbox9.Text = "";
                        bunifuMetroTextbox10.Text = "";

                        Class1.adapter = new MySqlDataAdapter("select * from produit ", Class1.cn);
                        Class1.adapter.Fill(dt1);
                        bunifuCustomDataGrid1.DataSource = dt1;
                        bunifuCustomDataGrid1.Visible = true;
                   



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    Class1.cn.Close();
                }
            else
            {
                MessageBox.Show("remplir tous les champs !!");


            }

        }

        private void produit_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from produit ", Class1.cn);
            Class1.adapter.Fill(dt1);
            bunifuCustomDataGrid1.DataSource = dt1;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Filter = "All Image | *.JPG; *.PNG";
                PictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult a;
                a = MessageBox.Show("suprimer", "suprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    Class1.cmd = new MySqlCommand("delete from produit WHERE N_P ='" + bunifuCustomDataGrid1.CurrentRow.Cells[0].Value + "'", Class1.cn);
                    Class1.cn.Open();
                    Class1.cmd.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    Class1.adapter = new MySqlDataAdapter("select * from produit ", Class1.cn);
                    Class1.adapter.Fill(dt1);
                    bunifuCustomDataGrid1.DataSource = dt1;
                    notyf n = new notyf();
                    n.Show();
                    notificationicon not = new notificationicon("Supprimer", "le produit   :" + bunifuCustomDataGrid1.CurrentRow.Cells[0].Value);
                    not.Location = new Point(Class1.index, n.Height * Class1.index);
                    Class1.index++;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            Class1.cn.Close();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
                bunifuCustomDataGrid1.Visible = true;
            if (RadioButton2.Checked == true)
                bunifuCustomDataGrid1.Visible = false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            dt1.Clear();
            Class1.adapter = new MySqlDataAdapter("select * from produit ", Class1.cn);
            Class1.adapter.Fill(dt1);
            DataTable dtc = dt1;
            DataView dv = dtc.DefaultView;
            dv.RowFilter = "N_P+NOM+N_fournisseur+NOM_DEPOT+NOM_FAMILLE+PRIX_TOTALE+seuil_bas like '%" + TextBox1.Text + "%'";
            
            bunifuCustomDataGrid1.DataSource = dv;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            dt1.Clear();
            Class1.adapter = new MySqlDataAdapter("select N_P, N_fournisseur,NOM_DEPOT, NOM_FAMILLE,NOM,TAILLE,POSITION,PRIX_TOTALE,seuil_bas from produit ", Class1.cn);
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

                if (!string.IsNullOrEmpty(DateTime.Now.Day.ToString() + "pro.xlsx"))
                {
                    try
                    {
                        workSheet.SaveAs(DateTime.Now.Day.ToString() + "pro.xlsx");
                        excelApp.Quit();
                        MessageBox.Show("Excel file saved!");

                        System.Diagnostics.Process.Start("C:/Users/othmane/Documents/" + DateTime.Now.Day.ToString() + "pro.xlsx");



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
}
