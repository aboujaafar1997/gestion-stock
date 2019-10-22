using Bunifu.Framework.UI;
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
    public partial class fiche_fournisseur : Form
    {
        public fiche_fournisseur()
        {
            InitializeComponent();
        }

    
           

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            Bitmap a = new Bitmap(this.Width, Panel2.Height);
            String b = "C:/Users/othmane/Desktop/" + Label9.Text + ".png";
            this.DrawToBitmap(a, new Rectangle(0, 0, this.Width, Panel2.Height));
            a.Save(b);
            MessageBox.Show("save in desktop sous le nom: " + Label9.Text);
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            BunifuDragControl contol = new BunifuDragControl();
            contol.TargetControl = Panel1;

        }
    }
}
