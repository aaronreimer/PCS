using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCS
{
    public partial class SetupForm : Form
    {
        public SetupForm()
        {
            InitializeComponent();
        }

        public static int size, seed;

        private void TxtSize_TextChanged(object sender, EventArgs e)
        {
            lblSize.Text = "x " + txtSize.Text;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                size = int.Parse(txtSize.Text);
            }
            catch (Exception)
            {
                size = 5;
            }
            
            try
            {
                seed = int.Parse(txtSeed.Text);
            }
            catch (Exception)
            {
                Random r = new Random();
                seed = r.Next();
            }
            Game ng = new Game();
            ng.Show();
            
            
            
        }
    }
}
