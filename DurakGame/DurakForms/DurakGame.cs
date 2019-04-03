using System;
using System.Windows.Forms;
using MyCardBox;

using DemoCardsLibrary;
using System.Drawing;
using DurakGame_ClassLib;

namespace DurakForms
{
    public partial class frmDurakGame : Form

    {

        private const int POP = 25;
        /// <summary>
        /// Sets the size of Cardbox control
        /// </summary>
        static private Size regularSize = new Size(75, 107);


        private CardDealer myDealer = new CardDealer(new DemoCardsLibrary.Deck(false));
        

        public frmDurakGame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles Main menu button click
        /// </summary
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            DurakMain Main = new DurakMain();               // creates the form to display
            Main.ShowDialog();                              // displays the main form
            this.Close();                            // hides the current form
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDurakGame_Load(object sender, EventArgs e)
        {
            pbDeck.Image= (new Card()).GetCardImage();      // back card image for  the deck
            pbDiscard.Image = (new Card()).GetCardImage();   //Back card image for the discarded cards
           // myDealer.OutOfCards += myDealer_OutOfCards();
            lblCardCount.Text = myDealer.CardsRemaining.ToString();
            
        }

     
       

        /// <summary>
        /// Deals a card when deck is clicked
        /// </summary>
        private void pbDeck_Click(object sender, EventArgs e)
        {
            if (pbDeck.Image == null)
            {
                ResetGame();
            }
            else
            {
                PlayingCard card = new PlayingCard();

                if (myDealer.DrawCard(ref card, true))
                {
                    CardBox aCardBox = new CardBox(card);
                }


             //   pnlAttacker.Controls.Add(aCardBox);
              //  RealignCards(pnlAttacker);
            }
        }

        /// <summary>
        /// Removes the image if the deck is empty
        /// </summary>
        private void myDealer_OutOfCards(object sender, EventArgs e)
        {
            pbDeck.Image = null;
        }
        

        void CardBox_Click(object sender, EventArgs e)
        {
            CardBox aCardBox = sender as CardBox;

            if (aCardBox != null)
            {
                if (aCardBox.Parent == pnlAttacker)
                {
                    pnlAttacker.Controls.Remove(aCardBox);
                    pnlPlay.Controls.Add(aCardBox);
                }
                else
                {
                    pnlDefender.Controls.Remove(aCardBox);
                    pnlPlay.Controls.Add(aCardBox);
                }
                RealignCards(pnlDefender);
                RealignCards(pnlPlay);
                RealignCards(pnlAttacker);
            }
        }

        private void RealignCards(Panel panelHand)
        {
            int mycount = panelHand.Controls.Count;

            if (mycount > 0)
            {
                int cardWidth = panelHand.Controls[0].Width;

                int startPoint = (panelHand.Width - cardWidth) / 2;

                int offset = 0;

                if (mycount > 1)
                {
                    offset = (panelHand.Width - cardWidth - 2 * POP) / mycount - 1;

                    if (offset > cardWidth)
                        offset = cardWidth;

                    int allCardsWidth = (mycount - 1) * offset + cardWidth;

                    startPoint = (panelHand.Width - allCardsWidth) / 2;
                }

                panelHand.Controls[mycount - 1].Top = POP;
                System.Diagnostics.Debug.Write(panelHand.Controls[mycount - 1].Top.ToString() + "\n");
                panelHand.Controls[mycount - 1].Left = startPoint;

                for (int index = mycount - 2; index >= 0; index--)
                {

                    // Align the current card
                    panelHand.Controls[index].Top = POP;
                    panelHand.Controls[index].Left = panelHand.Controls[index + 1].Left + offset;
                }

            }
        }



        /// <summary>
        /// resets the game
        /// </summary>
        void ResetGame()
        {
            // Clear the panels
            pnlAttacker.Controls.Clear();
            pnlPlay.Controls.Clear();
            pnlDefender.Controls.Clear();

            // Load the card dealer 
            myDealer.LoadCardDealer();

            // Set the image to a card back
            pbDeck.Image = (new PlayingCard()).GetCardImage();

            // Display the number of cards remaining in the deck. 
            lblCardCount.Text = myDealer.CardsRemaining.ToString();
        }
    }
}
