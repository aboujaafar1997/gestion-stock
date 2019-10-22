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
    public partial class notyf : Form
    {
        public notyf()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            this.Top = 60;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0) {
                this.Opacity -= 0.03;  }
            else {
                this.Close();
                }
        }

        private void notyf_MouseEnter(object sender, EventArgs e)
        {
            this.Opacity = 100;
        }

        private void bunifuGradientPanel1_MouseEnter(object sender, EventArgs e)
        {
            this.Opacity = 100;
        }
    }
}
