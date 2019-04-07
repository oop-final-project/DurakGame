using System;
using System.Windows.Forms;
using DurakGame_ClassLib;

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
            int cardNum;

            char difficulty;

            if(rdo20.Checked)
            {
                cardNum = 20;
            }
            else if(rdo36.Checked)
            {
                cardNum = 36;
            }
            else
            {
                cardNum = 52;
            }

            if(rdoEasy.Checked)
            {
                difficulty = 'e';
            }
            else if(rdoModerate.Checked)
            {
                difficulty = 'm';
            }
            else
            {
                difficulty = 'h';
            }

            this.Hide();
            frmDurakGame game = new frmDurakGame(cardNum, difficulty);
            game.ShowDialog();
            this.Show();
        }
    }
}
