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
    public partial class client : UserControl
    {
        public client()
        {
            InitializeComponent();
        }
        DataTable dt1 = new DataTable();
        private void client_Load(object sender, EventArgs e)
        {
            bunifuThinButton25.Visible = false;

            Class1.adapter = new MySqlDataAdapter("select * from client ", Class1.cn);
            Class1.adapter.Fill(dt1);
            bunifuCustomDataGrid1.DataSource = dt1;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
                bunifuCustomDataGrid1.Visible = true;
            if(RadioButton2.Checked == true)
                bunifuCustomDataGrid1.Visible = false;
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox1.Text!="" && bunifuMetroTextbox2.Text != "" && bunifuMetroTextbox3.Text != "" && bunifuMetroTextbox4.Text != "" && bunifuMetroTextbox5.Text != "") { 
            try
            {
                Class1.cmd = new MySqlCommand("INSERT INTO client values (@CNI, @NOM, @PRENOM, @TELEPHONE, @ADRESSE, @NOTE )", Class1.cn);
                Class1.cmd.Parameters.Add(new MySqlParameter("@CNI", MySqlDbType.VarChar, 30)).Value = bunifuMetroTextbox1.Text;
                Class1.cmd.Parameters.Add(new MySqlParameter("@NOM", MySqlDbType.VarChar, 30)).Value = bunifuMetroTextbox2.Text;
                Class1.cmd.Parameters.Add(new MySqlParameter("@PRENOM", MySqlDbType.VarChar, 30)).Value = bunifuMetroTextbox3.Text;
                Class1.cmd.Parameters.Add(new MySqlParameter("@TELEPHONE", MySqlDbType.VarChar, 30)).Value = bunifuMetroTextbox4.Text;
                Class1.cmd.Parameters.Add(new MySqlParameter("@ADRESSE", MySqlDbType.VarChar, 30)).Value = bunifuMetroTextbox5.Text;
                Class1.cmd.Parameters.Add(new MySqlParameter("@NOTE", MySqlDbType.VarChar, 100)).Value = bunifuMetroTextbox6.Text;
                Class1.cn.Open();
                Class1.cmd.ExecuteNonQuery();              
                DataTable dt1 = new DataTable();
                Class1.adapter = new MySqlDataAdapter("select * from client ", Class1.cn);
                Class1.adapter.Fill(dt1);
                bunifuCustomDataGrid1.DataSource = dt1;
                bunifuCustomDataGrid1.Visible = true;
                notyf n = new notyf();
                n.Show();
                    notificationicon not = new notificationicon("Ajouter" , "client   :"+ bunifuMetroTextbox2.Text );
                    Class1.index++;
                    not.Location = new Point(Class1.index, n.Height * Class1.index);
                    login.p.top_bare1.panel1.Controls.Add(not);
                    bunifuMetroTextbox1.Text = "";
                    bunifuMetroTextbox2.Text = "";
                    bunifuMetroTextbox5.Text = "";
                    bunifuMetroTextbox3.Text = "";
                    bunifuMetroTextbox4.Text = "";
                    bunifuMetroTextbox6.Text = "";
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
             
            }
            Class1.cn.Close();
        }
       
        else {

                MessageBox.Show("Remplir tous les champs svp !!");
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
                    Class1.cmd = new MySqlCommand("delete from client WHERE CNI ='" + bunifuCustomDataGrid1.CurrentRow.Cells[0].Value + "'", Class1.cn);
                    Class1.cn.Open();
                    Class1.cmd.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    Class1.adapter = new MySqlDataAdapter("select * from client ", Class1.cn);
                    Class1.adapter.Fill(dt1);
                    bunifuCustomDataGrid1.DataSource = dt1;
                    notyf n = new notyf();
                    n.Show();
                    notificationicon not = new notificationicon("Supprimer" , "le client   :" + bunifuCustomDataGrid1.CurrentRow.Cells[1].Value);
                    not.Location = new Point(Class1.index, n.Height * Class1.index);
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

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
                bunifuCustomDataGrid1.Visible = false;
                BunifuThinButton21.Visible = false;
                bunifuMetroTextbox1.Text = (string)bunifuCustomDataGrid1.CurrentRow.Cells[0].Value;
                bunifuMetroTextbox2.Text = (string)bunifuCustomDataGrid1.CurrentRow.Cells[1].Value;
                bunifuMetroTextbox3.Text = (string)bunifuCustomDataGrid1.CurrentRow.Cells[2].Value;
                bunifuMetroTextbox4.Text = (string)bunifuCustomDataGrid1.CurrentRow.Cells[3].Value;
                bunifuMetroTextbox5.Text = (string)bunifuCustomDataGrid1.CurrentRow.Cells[4].Value;
                bunifuMetroTextbox6.Text = (string)bunifuCustomDataGrid1.CurrentRow.Cells[5].Value;
            bunifuThinButton25.Visible = true;
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Class1.cmd = new MySqlCommand("update client set CNI=@CNI, NOM=@NOM, PRENOM=@PRENOM, TELEPHONE=@TELEPHONE, ADRESSE=@ADRESSE, NOTE=@NOTE where CNI='"+ bunifuMetroTextbox1.Text+"'", Class1.cn);
            Class1.cmd.Parameters.Add(new MySqlParameter("@CNI", MySqlDbType.VarChar, 30)).Value = bunifuMetroTextbox1.Text;
            Class1.cmd.Parameters.Add(new MySqlParameter("@NOM", MySqlDbType.VarChar, 30)).Value = bunifuMetroTextbox2.Text;
            Class1.cmd.Parameters.Add(new MySqlParameter("@PRENOM", MySqlDbType.VarChar, 30)).Value = bunifuMetroTextbox3.Text;
            Class1.cmd.Parameters.Add(new MySqlParameter("@TELEPHONE", MySqlDbType.VarChar, 30)).Value = bunifuMetroTextbox4.Text;
            Class1.cmd.Parameters.Add(new MySqlParameter("@ADRESSE", MySqlDbType.VarChar, 30)).Value = bunifuMetroTextbox5.Text;
            Class1.cmd.Parameters.Add(new MySqlParameter("@NOTE", MySqlDbType.VarChar, 100)).Value = bunifuMetroTextbox6.Text;
            Class1.cn.Open();
            Class1.cmd.ExecuteNonQuery();
            bunifuCustomDataGrid1.Visible = true;
            bunifuThinButton25.Visible = false;
            DataTable dt1 = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from client ", Class1.cn);
            Class1.adapter.Fill(dt1);
            bunifuCustomDataGrid1.DataSource = dt1;
            Class1.cn.Close();
            notyf n = new notyf();
            n.Show();
            notificationicon not = new notificationicon("Modifier", "le client   :" + bunifuMetroTextbox2.Text);
            not.Location = new Point(Class1.index, n.Height * Class1.index);
            Class1.index++;
            login.p.top_bare1.panel1.Controls.Add(not);
            bunifuMetroTextbox1.Text = "";
            bunifuMetroTextbox2.Text = "";
            bunifuMetroTextbox5.Text = "";
            bunifuMetroTextbox3.Text = "";
            bunifuMetroTextbox4.Text = "";
            bunifuMetroTextbox6.Text = "";
        }
        

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            dt1.Clear();
            Class1.adapter = new MySqlDataAdapter("select * from client ", Class1.cn);
            Class1.adapter.Fill(dt1);
            DataTable dtc = dt1;
            DataView dv = dtc.DefaultView;
            dv.RowFilter = "CNI+NOM+PRENOM+TELEPHONE+NOTE like '%" + TextBox1.Text + "%'";
            bunifuCustomDataGrid1.DataSource = dv;

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
                
                if (!string.IsNullOrEmpty(DateTime.Now.Day.ToString() + ".xlsx"))
                {
                    try
                    {
                        workSheet.SaveAs(DateTime.Now.Day.ToString() + ".xlsx");
                        excelApp.Quit();
                        MessageBox.Show("Excel file saved!");

                        System.Diagnostics.Process.Start("C:/Users/othmane/Documents/"+ DateTime.Now.Day.ToString()+".xlsx");



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
            bunifuCustomDataGrid1.Visible = true;
            DataTable dt1 = new DataTable();
            Class1.adapter = new MySqlDataAdapter("select * from client ", Class1.cn);
            Class1.adapter.Fill(dt1);
            bunifuCustomDataGrid1.DataSource = dt1;

        }
    }
    }

