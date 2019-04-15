/*
 * Author: Adam Peltenburg 
 * Author: Purab Barot
 * Author: Tyler Querido
 * 
 * Description: The code for the Winner form
 */

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

        /// <summary>
        /// Code for handling the quit button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
