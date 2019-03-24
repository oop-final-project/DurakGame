using System;
using System.Windows.Forms;

namespace DurakForms
{
    public partial class frmAbout : Form
    {
        /// <summary>
        /// Inititalizes the form
        /// </summary>
        public frmAbout()
        {
            InitializeComponent();
        }

        /// <summary>
        /// To handle the main menu button click from the about page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMainMenu_Click(object sender, EventArgs e)
        {   
            this.Hide();                                    // hides the about form
            DurakMain Main = new DurakMain();               // creates the form to display
            Main.ShowDialog();                              // displays the main form
        }
    }
}
