/*
 * Author: Adam Peltenburg 
 * Author: Purab Barot
 * Author: Tyler Querido
 * 
 * Description: The code for the about page
 */

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
            this.Close();
        }
    }
}
