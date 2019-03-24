using System;
using System.Windows.Forms;

namespace DurakForms
{
    public partial class DurakMain : Form
    {
        public DurakMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles Quit button quit
        /// </summary>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();                   // closes the form(application)
        }

        /// <summary>
        /// Handles About butoon click
        /// </summary>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.Hide();                            // hides the current form
            About abou = new About();               // creates new abou form to show
            abou.ShowDialog();                      // displays the abou form
            
        }
    }
}
