using System;
using System.Windows.Forms;

namespace DurakForms
{
    public partial class frmDurakGame : Form
    {
        public frmDurakGame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles Main menu button click
        /// </summary
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();                                    // hides the about form
            DurakMain Main = new DurakMain();               // creates the form to display
            Main.ShowDialog();                              // displays the main form

        }
    }
}
