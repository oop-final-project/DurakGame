using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DurakForms
{
    public partial class frmWinner : Form
    {
        public frmWinner()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            this.Hide();                                    // hides the about form
            DurakMain Main = new DurakMain();               // creates the form to display
            Main.ShowDialog();                              // displays the main form

        }
    }
}
