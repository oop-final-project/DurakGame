using System;
using System.Windows.Forms;
using System.Drawing;
using DurakGame_ClassLib;
using CardBox;

namespace DurakForms
{
    public partial class frmDurakGame : Form
    {
        //Form Level Variables
        Player attacker;
        Player defender;
        Player cardAdder;

        IComputerPlayer cpuPlayer;
        Player humanPlayer;

        Deck talon;
        Cards river = new Cards();

        CardBox.CardBox deckBox;

        CardBox.CardBox trumpBox;

        /// <summary>
        /// The regular size of a CardBox control
        /// </summary>
        static private Size regularSize = new Size(38, 54);

        public frmDurakGame(int numOfCards, char difficulty)
        {
            InitializeComponent();

            talon = new Deck(numOfCards);

            talon = talon.Shuffle();

            humanPlayer = new Player(talon);

            attacker = humanPlayer;

            if(difficulty == 'e')
            {
                EasyPlayer easy = new EasyPlayer(talon);

                defender = easy;
                cpuPlayer = easy;
            }
            else if(difficulty == 'm')
            {
                //TODO: Code for moderate
            }
            else
            {
                //TODO: Code for hard
            }

            Card.trump = talon.getTrumpSuit();

            SetDeck();

            river.Add(talon.DrawCard());
            river.Add(talon.DrawCard());
            river.Add(talon.DrawCard());

            Redraw();
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

        private void Redraw()
        {
            EmptyPanel(pnlHuman);
            EmptyPanel(pnlCPU);

            lblTalonCount.Text = talon.Count.ToString();

            if(talon.Count == 0)
            {
                this.Controls.Remove(trumpBox);
            }
            if(talon.Count < 2)
            {
                this.Controls.Remove(deckBox);
            }

            AddCardsToPanel(humanPlayer.GetHand(), pnlHuman);
            AddCardsToPanel(defender.GetHand(), pnlCPU);
            AddCardsToPanel(river, pnlRiver);

            RealignPlayerCards(pnlHuman);
            RealignPlayerCards(pnlCPU);
            RealignRiver();
        }

        private void SetDeck()
        {
            deckBox = new CardBox.CardBox();

            trumpBox = new CardBox.CardBox(talon.getTrumpCard());

            trumpBox.CardOrientation = Orientation.Horizontal;
            trumpBox.FaceUp = true;

            deckBox.Location = new Point(4, 200);
            trumpBox.Location = new Point(4, 215);

            this.Controls.Add(deckBox);
            this.Controls.Add(trumpBox);
        }

        /// <summary>
        /// Repositions the cards in a panel so that they are evenly distributed in the area available.
        /// </summary>
        /// <param name="panelHand"></param>
        private void RealignPlayerCards(Panel panelHand)
        {
            // Determine the number of cards/controls in the panel.
            int myCount = panelHand.Controls.Count;

            // If there are any cards in the panel
            if (myCount > 0)
            {
                // Determine how wide one card/control is.
                int cardWidth = panelHand.Controls[0].Width;
                // Determine where the left-hand edge of a card/control placed 
                // in the middle of the panel should be  
                int startPoint = (panelHand.Width - cardWidth) / 2;
                // An offset for the remaining cards
                int offset = 0;
                // If there are more than one cards/controls in the panel
                if (myCount > 1)
                {
                    // Determine what the offset should be for each card based on the 
                    // space available and the number of card/controls
                    offset = (panelHand.Width - cardWidth - 2) / (myCount - 1);
                    // If the offset is bigger than the card/control width, i.e. there is lots of room, 
                    // set the offset to the card width. The cards/controls will not overlap at all.
                    if (offset > cardWidth)
                    {
                        offset = cardWidth;
                    }
                }
                // Determine width of all the cards/controls 
                int allCardsWidth = (myCount - 1) * offset + cardWidth;
                // Set the start point to where the left-hand edge of the "first" card should be.
                startPoint = (panelHand.Width - allCardsWidth) / 2;

                // Aligning the cards: Note that I align them in reserve order from how they
                // are stored in the controls collection. This is so that cards on the left 
                // appear underneath cards to the right. This allows the user to see the rank
                // and suit more easily.

                // Align the "first" card (which is the last control in the collection)
                panelHand.Controls[myCount - 1].Top = 0;
                panelHand.Controls[myCount - 1].Left = startPoint;

                // for each of the remaining controls, in reverse order.
                for (int index = myCount - 2; index >= 0; index--)
                {
                    // Align the current card
                    panelHand.Controls[index].Top = 0;
                    panelHand.Controls[index].Left = panelHand.Controls[index + 1].Left + offset;
                }
            }
        }

        /// <summary>
        /// Repositions the cards in a panel so that they are evenly distributed in the area available.
        /// </summary>
        /// <param name="panelHand"></param>
        private void RealignRiver()
        {
            // Determine the number of cards/controls in the panel.
            int myCount = pnlRiver.Controls.Count;

            // If there are any cards in the panel
            if (myCount > 0)
            {
                bool atkCard = false;
                // Determine how wide one card/control is.
                int cardWidth = pnlRiver.Controls[0].Width;
                // Determine where the left-hand edge of a card/control placed 
                // in the middle of the panel should be  
                int startPoint = (pnlRiver.Width - cardWidth) / 2;
                // An offset for the remaining cards
                int offset = 0;
                // If there are more than one cards/controls in the panel
                if (myCount > 1)
                {
                    // Determine what the offset should be for each card based on the 
                    // space available and the number of card/controls
                    offset = (pnlRiver.Width - cardWidth - 2) / (myCount - 1);
                    // If the offset is bigger than the card/control width, i.e. there is lots of room, 
                    // set the offset to the card width. The cards/controls will not overlap at all.
                    if (offset > cardWidth)
                    {
                        offset = cardWidth;
                    }
                }
                // Determine width of all the cards/controls 
                int allCardsWidth = (myCount - 1) * offset + cardWidth;
                // Set the start point to where the left-hand edge of the "first" card should be.
                startPoint = (pnlRiver.Width - allCardsWidth) / 2;

                // Aligning the cards: Note that I align them in reserve order from how they
                // are stored in the controls collection. This is so that cards on the left 
                // appear underneath cards to the right. This allows the user to see the rank
                // and suit more easily.

                // Align the "first" card (which is the last control in the collection)
                pnlRiver.Controls[myCount - 1].Top = 0;
                pnlRiver.Controls[myCount - 1].Left = startPoint;

                // for each of the remaining controls, in reverse order.
                for (int index = myCount - 2; index >= 0; index--)
                {
                    if(atkCard)
                    {
                        // Align the current card
                        pnlRiver.Controls[index].Top = 0;
                        pnlRiver.Controls[index].Left = pnlRiver.Controls[index + 1].Left + offset;

                        atkCard = !atkCard;
                    }
                    else
                    {
                        pnlRiver.Controls[index].Top = 25;
                        pnlRiver.Controls[index].Left = pnlRiver.Controls[index + 1].Left;

                        atkCard = !atkCard;
                    }
                }
            }
        }

        private void InsertCardIntoPanel(Card card, Panel addPanel)
        {
            // Create a new CardBox control based on the card drawn
            CardBox.CardBox aCardBox = new CardBox.CardBox(card);

            aCardBox.Size = regularSize;

            if(addPanel != pnlCPU)
            {
                aCardBox.FaceUp = true;
            }
            aCardBox.UpdateCardImage();

            // Add the new control to the appropriate panel
            addPanel.Controls.Add(aCardBox);
        }

        public void EmptyPanel(Panel panel)
        {
            for(int index = 0; index < panel.Controls.Count; index++)
            {
                panel.Controls.Remove(panel.Controls[index]);
            }
        }

        private void AddCardsToPanel(Cards cards, Panel panel)
        {
            foreach(Card card in cards)
            {
                InsertCardIntoPanel(card, panel);
            }
        }
    }
}
