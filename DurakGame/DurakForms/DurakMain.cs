﻿using System;
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
            Close();         // closes the form(application)
        }

        /// <summary>
        /// Handles About butoon click
        /// </summary>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            Hide();                            // hides the current form
            frmAbout abou = new frmAbout();               // creates new abou form to show
            abou.ShowDialog();                      // displays the abou form
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();                            // hides the current form
            frmDurakGame game = new frmDurakGame();               // creates new abou form to show
            game.ShowDialog();

        }
    }
}
