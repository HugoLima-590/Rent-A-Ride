using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P2
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += progressBar1.Step;
            }
            if (progressBar1.Value == 100) 
            {
                MenuPrincipal menu = new MenuPrincipal();
                menu.Show();
                this.Hide();
                timer2.Stop();
            }
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
