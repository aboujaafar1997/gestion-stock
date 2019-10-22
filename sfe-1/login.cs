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

    public partial class login : Form
    {
        static public bool a = false;
        static public principale p = new principale();
        public login()
        {
           

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuDragControl e1 = new Bunifu.Framework.UI.BunifuDragControl();
            e1.TargetControl = this;



        }
        public static void vs()
        {


        }
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        private void BunifuThinButton21_Click_1(object sender, EventArgs e)
        {


            try
            {
                DataTable dt1 = new DataTable();
                Class1.adapter = new MySqlDataAdapter("select * from utilisateur where ID = @ID and PWD = @PWD", Class1.cn);
                Class1.adapter.SelectCommand.Parameters.Add(new MySqlParameter("@ID", MySqlDbType.VarChar, 50)).Value = bunifuMetroTextbox1.Text;
                Class1.adapter.SelectCommand.Parameters.Add(new MySqlParameter("@PWD", MySqlDbType.VarChar, 50)).Value = Class1.sha256(bunifuMetroTextbox2.Text);
                Class1.adapter.Fill(dt1);
                if (dt1.Rows.Count > 0) { 

                 
                






                Class1.cmd = new MySqlCommand("INSERT INTO historique_acces values (@date, @ID)", Class1.cn);
                Class1.cmd.Parameters.Add(new MySqlParameter("@ID", MySqlDbType.VarChar, 30)).Value = bunifuMetroTextbox1.Text;
                Class1.cmd.Parameters.Add(new MySqlParameter("@date", MySqlDbType.VarChar, 30)).Value = DateTime.Now.ToString();


                Class1.cn.Open();
                Class1.cmd.ExecuteNonQuery();
                Class1.cn.Close();
                    p.Show();
                    notifyIcon1.ShowBalloonTip(20, "Beinvenu", bunifuMetroTextbox1.Text, ToolTipIcon.Info);
                    p.Label3.Text = bunifuMetroTextbox1.Text;
                   
                 
                    this.Visible = false;
                   
                }
                 else{
                    MessageBox.Show("le utilisateur ou le mote de passe incorecte !", "Ereur !!");

                }
            }


            catch (Exception ex) {
                MessageBox.Show(ex.Message); }
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {
                bunifuMetroTextbox2.isPassword = false;
            }
            if (bunifuCheckbox1.Checked == false)
            {
                bunifuMetroTextbox2.isPassword = true;



            }
        }

        private void exiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("contacter : 0615885422");
        }

        private void contacteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("contacter : 0615885422 \n email : aboujaafar.othmane@gmail.com \n ville : agadir \n Nom : aboujaafar \n     Facebook : aboujaafar othmane");
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                DataTable dt1 = new DataTable();
                Class1.adapter = new MySqlDataAdapter("select * from utilisateur where ID = @ID and PWD = @PWD", Class1.cn);
                Class1.adapter.SelectCommand.Parameters.Add(new MySqlParameter("@ID", MySqlDbType.VarChar, 50)).Value = bunifuMetroTextbox1.Text;
                Class1.adapter.SelectCommand.Parameters.Add(new MySqlParameter("@PWD", MySqlDbType.VarChar, 50)).Value = Class1.sha256(bunifuMetroTextbox2.Text);
                Class1.adapter.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {









                    Class1.cmd = new MySqlCommand("INSERT INTO historique_acces values (@date, @ID)", Class1.cn);
                    Class1.cmd.Parameters.Add(new MySqlParameter("@ID", MySqlDbType.VarChar, 30)).Value = bunifuMetroTextbox1.Text;
                    Class1.cmd.Parameters.Add(new MySqlParameter("@date", MySqlDbType.VarChar, 30)).Value = DateTime.Now.ToString();


                    Class1.cn.Open();
                    Class1.cmd.ExecuteNonQuery();
                    Class1.cn.Close();
                    p.Show();
                    notifyIcon1.ShowBalloonTip(20, "Beinvenu", bunifuMetroTextbox1.Text, ToolTipIcon.Info);
                    p.Label3.Text = bunifuMetroTextbox1.Text;


                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("le utilisateur ou le mote de passe incorecte !", "Ereur !!");

                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
