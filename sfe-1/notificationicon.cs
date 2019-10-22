using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class notificationicon : UserControl
    {
        public notificationicon(string type,string name)
        {
            InitializeComponent();
            label2.Text = type;
            label3.Text = name;
            label1.Text = DateTime.Now.ToString("HH:mm");
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void notificationicon_Load(object sender, EventArgs e)
        {

        }
    }
}
