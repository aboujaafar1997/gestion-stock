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
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class fournisseur : UserControl
    {
        DataTable dt1 = new DataTable();
        public fournisseur()
        {
            InitializeComponent();
        }

        private void fournisseur_Load(object sender, EventArgs e)
        {
            Class1.adapter = new MySqlDataAdapter("select * from fournisseur ", Class1.cn);
            Class1.adapter.Fill(dt1);
            bunifuCustomDataGrid1.DataSource = dt1;
            bunifuThinButton26.Visible = false;
        }

    private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
                bunifuCustomDataGrid1.Visible = true;
            if (RadioButton2.Checked == true)
                bunifuCustomDataGrid1.Visible = false;
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (BunifuMetroTextbox1.Text != "" && BunifuMetroTextbox2.Text != "" && BunifuMetroTextbox3.Text != "" && BunifuMetroTextbox4.Text != "" && BunifuMetroTextbox5.Text != "")
            {

                try
                {
                    Class1.cmd = new MySqlCommand("INSERT INTO fournisseur values (@N, @NOM, @ADRESSE, @TELEPHONE, @CATEGORIE,@E_mail, @LOGO )", Class1.cn);
                    Class1.cmd.Parameters.Add(new MySqlParameter("@N", MySqlDbType.VarChar, 30)).Value = BunifuMetroTextbox1.Text;
                    Class1.cmd.Parameters.Add(new MySqlParameter("@NOM", MySqlDbType.VarChar, 30)).Value = BunifuMetroTextbox2.Text;
                    Class1.cmd.Parameters.Add(new MySqlParameter("@ADRESSE", MySqlDbType.VarChar, 30)).Value = BunifuMetroTextbox3.Text;
                    Class1.cmd.Parameters.Add(new MySqlParameter("@TELEPHONE", MySqlDbType.VarChar, 30)).Value = BunifuMetroTextbox4.Text;
                    Class1.cmd.Parameters.Add(new MySqlParameter("@E_mail", MySqlDbType.VarChar, 30)).Value = bunifuMetroTextbox6.Text;
                    Class1.cmd.Parameters.Add(new MySqlParameter("@CATEGORIE", MySqlDbType.VarChar, 30)).Value = BunifuMetroTextbox5.Text;
                    if (PictureBox1.Image != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat);
                        var pictuure = ms.ToArray();
                        Class1.cmd.Parameters.Add(new MySqlParameter("@LOGO", MySqlDbType.LongBlob, 30)).Value = pictuure;

                    }
                    else
                    {
                        Class1.cmd.Parameters.Add(new MySqlParameter("@LOGO", MySqlDbType.LongBlob, 30)).Value = null;
                    }



                    Class1.cn.Open();
                    Class1.cmd.ExecuteNonQuery();
                    notyf na = new notyf();
                    na.Show();
                    notificationicon not = new notificationicon("Ajouter", "le fournisseur   :" + BunifuMetroTextbox1.Text);
                    not.Location = new Point(Class1.index, na.Height * Class1.index);
                    Class1.index++;
                    login.p.top_bare1.panel1.Controls.Add(not);
                    BunifuMetroTextbox1.Text = "";
                    BunifuMetroTextbox2.Text = "";
                    BunifuMetroTextbox5.Text = "";
                    BunifuMetroTextbox3.Text = "";
                    BunifuMetroTextbox4.Text = "";
                    bunifuMetroTextbox6.Text = "";
                    DataTable dt1 = new DataTable();
                    Class1.adapter = new MySqlDataAdapter("select * from fournisseur ", Class1.cn);
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
           if( openFileDialog1.ShowDialog() == DialogResult.OK) {
                openFileDialog1.Filter = "All Image | *.JPG; *.PNG";
                PictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
       }
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.Visible = true;
            DataTable dt1 = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from fournisseur ", Class1.cn);
            Class1.adapter.Fill(dt1);
            bunifuCustomDataGrid1.DataSource = dt1;
        }
       

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult a;
                a = MessageBox.Show("suprimer", "suprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    Class1.cmd = new MySqlCommand("delete from fournisseur WHERE N ='" + bunifuCustomDataGrid1.CurrentRow.Cells[0].Value + "'", Class1.cn);
                    Class1.cn.Open();
                    Class1.cmd.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    Class1.adapter = new MySqlDataAdapter("select * from fournisseur ", Class1.cn);
                    Class1.adapter.Fill(dt1);
                    bunifuCustomDataGrid1.DataSource = dt1;
                    notyf na = new notyf();
                    na.Show();
                    notificationicon not = new notificationicon("Supprimer", "la fournisseur   :" +BunifuMetroTextbox1.Text);
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

                if (!string.IsNullOrEmpty(DateTime.Now.Day.ToString() + "fournisseur.xlsx"))
                {
                    try
                    {
                        workSheet.SaveAs(DateTime.Now.Day.ToString() + "fournisseur.xlsx");
                        excelApp.Quit();
                        MessageBox.Show("Excel file saved!");

                        System.Diagnostics.Process.Start("C:/Users/othmane/Documents/" + DateTime.Now.Day.ToString() + "fournisseur.xlsx");



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

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            try
            {
                Class1.cmd = new MySqlCommand("update fournisseur set N=@N, NOM=@NOM, ADRESSE=@ADRESSE, TELEPHONE=@TELEPHONE, CATEGORIE=@CATEGORIE, E_mail=@E_mail, LOGO=@LOGO where N='" + bunifuCustomDataGrid1.CurrentRow.Cells [0].Value.ToString()+"'", Class1.cn);
                Class1.cmd.Parameters.Add(new MySqlParameter("@N", MySqlDbType.VarChar, 30)).Value = BunifuMetroTextbox1.Text;
                Class1.cmd.Parameters.Add(new MySqlParameter("@NOM", MySqlDbType.VarChar, 30)).Value = BunifuMetroTextbox2.Text;
                Class1.cmd.Parameters.Add(new MySqlParameter("@ADRESSE", MySqlDbType.VarChar, 30)).Value = BunifuMetroTextbox3.Text;
                Class1.cmd.Parameters.Add(new MySqlParameter("@TELEPHONE", MySqlDbType.VarChar, 30)).Value = BunifuMetroTextbox4.Text;
                Class1.cmd.Parameters.Add(new MySqlParameter("@E_mail", MySqlDbType.VarChar, 30)).Value = bunifuMetroTextbox6.Text;
                Class1.cmd.Parameters.Add(new MySqlParameter("@CATEGORIE", MySqlDbType.VarChar, 30)).Value = BunifuMetroTextbox5.Text;
                if (PictureBox1.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat);
                    var pictuure = ms.ToArray();
                    Class1.cmd.Parameters.Add(new MySqlParameter("@LOGO", MySqlDbType.LongBlob, 30)).Value = pictuure;

                }
                else
                {
                    Class1.cmd.Parameters.Add(new MySqlParameter("@LOGO", MySqlDbType.LongBlob, 30)).Value = null;
                }

                notyf na = new notyf();
                na.Show();
                notificationicon not = new notificationicon("Modifier", "le fournisseur   :" + BunifuMetroTextbox1.Text);
                not.Location = new Point(Class1.index, na.Height * Class1.index);
                Class1.index++;
                login.p.top_bare1.panel1.Controls.Add(not);
                Class1.cn.Open();
                Class1.cmd.ExecuteNonQuery();
                BunifuMetroTextbox1.Text = "";
                BunifuMetroTextbox2.Text = "";
                BunifuMetroTextbox5.Text = "";
                BunifuMetroTextbox3.Text = "";
                BunifuMetroTextbox4.Text = "";
                bunifuMetroTextbox6.Text = "";

                bunifuCustomDataGrid1.Visible = true;
                BunifuThinButton21.Visible = true;
                bunifuThinButton26.Visible = false;
                DataTable dt1 = new DataTable();
                Class1.adapter = new MySqlDataAdapter("select * from fournisseur ", Class1.cn);
                Class1.adapter.Fill(dt1);
                bunifuCustomDataGrid1.DataSource = dt1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          

           
            Class1.cn.Close();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.CurrentRow.Cells[6].Value.ToString()!="")
            {
                Byte[] img = (byte[])bunifuCustomDataGrid1.CurrentRow.Cells[6].Value;
             
            MemoryStream ms = new MemoryStream(img);
            BunifuMetroTextbox5.Text = (string)bunifuCustomDataGrid1.CurrentRow.Cells[4].Value;
            PictureBox1.Image = Image.FromStream(ms); }

            bunifuCustomDataGrid1.Visible = false;
            BunifuThinButton21.Visible = false;
            BunifuMetroTextbox1.Text = (string)bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
            BunifuMetroTextbox2.Text = (string)bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
            BunifuMetroTextbox3.Text = (string)bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
             BunifuMetroTextbox4.Text = (string)bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString();
            bunifuMetroTextbox6.Text = (string)bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString();
            BunifuMetroTextbox5.Text = (string)bunifuCustomDataGrid1.CurrentRow.Cells[5].Value.ToString();


            BunifuThinButton21.Visible = false;
            bunifuThinButton26.Visible = true;
           

        }

        private void bunifuCustomDataGrid1_DoubleClick(object sender, EventArgs e)
        {
            fiche_fournisseur fch = new fiche_fournisseur();
            fch.Label10.Text = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
            fch.Label9.Text= bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
            fch.Label8.Text= bunifuCustomDataGrid1.CurrentRow.Cells[2].Value .ToString();
            fch.Label6.Text = bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString();
            fch.Label1.Text= bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString();
            if (bunifuCustomDataGrid1.CurrentRow.Cells[6].Value.ToString() != "")
            {
                Byte[] img = (byte[])bunifuCustomDataGrid1.CurrentRow.Cells[6].Value;

                MemoryStream ms = new MemoryStream(img);
               
                fch.PictureBox1.Image = Image.FromStream(ms);
            }
            fch.Show();
        }
    }
}
