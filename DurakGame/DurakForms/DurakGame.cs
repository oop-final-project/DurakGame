using System;
using System.Windows.Forms;
using System.Drawing;
using DurakGame_ClassLib;
using CardBox;

namespace DurakForms
{
    public partial class frmDurakGame : Form
    {
        //Constants
        const int VERTICAL_DISPLACEMENT = 25;

        //Form Level Variables
        Player attacker;
        Player defender;
        Player cardAdder;

        IComputerPlayer cpuPlayer;
        Player humanPlayer;

        Deck talon;
        Cards river = new Cards();
        Cards adder = new Cards();

        Rank? adderRank = null;

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

            Redraw();
        }

        /// <summary>
        /// Handles Main menu button click
        /// </summary
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();                            // closes the current form
        }

        private void Redraw()
        {
            EmptyPanel(pnlHuman);
            EmptyPanel(pnlCPU);
            EmptyPanel(pnlRiver);

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

            if (cpuPlayer == defender)
            {
                AddCardsToPanel(defender.GetHand(), pnlCPU);
            }
            else
            {
                AddCardsToPanel(attacker.GetHand(), pnlCPU);
            }
            AddCardsToPanel(river, pnlRiver);

            if(adder.Count > 0)
            {
                EmptyPanel(pnlAdder);
                gbxAdder.Visible = true;
                AddCardsToPanel(adder, pnlAdder);
                RealignPlayerCards(pnlAdder);
            }
            else
            {
                gbxAdder.Visible = false;
            }

            RealignPlayerCards(pnlHuman);
            RealignPlayerCards(pnlCPU);
            RealignRiver();

            SetPlayableCards();
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
                bool atkCard = (myCount % 2 == 0);
                // Determine how wide one card/control is.
                int cardWidth = pnlRiver.Controls[0].Width;
                // Determine where the left-hand edge of a card/control placed 
                // in the middle of the panel should be  
                int startPoint = (pnlRiver.Width - cardWidth * 2);
                // An offset for the remaining cards
                int offset = 0;
                // If there are more than one cards/controls in the panel
                if (myCount > 1)
                {
                    offset = cardWidth;
                }

                // Aligning the cards: Note that I align them in reserve order from how they
                // are stored in the controls collection. This is so that cards on the left 
                // appear underneath cards to the right. This allows the user to see the rank
                // and suit more easily.

                // Align the "first" card (which is the last control in the collection)
                if (atkCard)
                {
                    pnlRiver.Controls[0].Top = VERTICAL_DISPLACEMENT;
                }
                else
                {
                    pnlRiver.Controls[0].Top = 0;
                }


                pnlRiver.Controls[0].Left = startPoint;

                // for each of the remaining controls, in reverse order.
                for (int index = 1; index < myCount; index++)
                {
                    if(atkCard)
                    {
                        // Align the current card
                        pnlRiver.Controls[index].Top = 0;
                        pnlRiver.Controls[index].Left = pnlRiver.Controls[index - 1].Left;
                    }
                    else
                    {
                        pnlRiver.Controls[index].Top = VERTICAL_DISPLACEMENT;
                        pnlRiver.Controls[index].Left = pnlRiver.Controls[index - 1].Left - offset;
                    }
                    atkCard = !atkCard;
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
            else
            {
                aCardBox.FaceUp = false;
            }
            aCardBox.UpdateCardImage();

            // Add the new control to the appropriate panel
            addPanel.Controls.Add(aCardBox);
        }

        public void EmptyPanel(Panel panel)
        {
            panel.Controls.Clear();
        }

        private void AddCardsToPanel(Cards cards, Panel panel)
        {
            for (int index = cards.Count - 1; index >= 0; index--)
            {
                InsertCardIntoPanel(cards[index], panel);
            }
        }

        private void SetPlayableCards()
        {
            foreach(CardBox.CardBox box in pnlHuman.Controls)
            {
                if (adderRank == null)
                {
                    if (box.Card.isPlayable(river))
                    {
                        box.Click += Cardbox_Click;
                    }
                    else
                    {
                        box.Top = VERTICAL_DISPLACEMENT;
                    }
                }
                else
                {
                    if(box.Card.rank == adderRank || (river.Count != 0 && box.Card.isPlayable(river)))
                    {
                        box.Click += Cardbox_Click;
                    }
                    else
                    {
                        box.Top = VERTICAL_DISPLACEMENT;
                    }
                }
            }
        }

        private void Cardbox_Click(object sender, EventArgs e)
        {
            CardBox.CardBox box = sender as CardBox.CardBox;

            if(attacker == humanPlayer)
            {
                river.Add(box.Card);

                humanPlayer.GetHand().Remove(box.Card);

                if(humanPlayer.GetHand().Count == 0 && talon.Count == 0)
                {
                    this.Hide();
                    frmWinner win = new frmWinner();
                    win.ShowDialog();
                    this.Close();
                }

                try
                {
                    Card cpuCard = cpuPlayer.selectCard(river);

                    if(defender.GetHand().Count == 0 && talon.Count == 0)
                    {
                        this.Hide();
                        frmLoser lose = new frmLoser();
                        lose.ShowDialog();
                        this.Close();
                    }

                    river.Add(cpuCard);

                    if(river.Count == 12)
                    {
                        DefenceSuccess();
                    }
                }
                catch(OperationCanceledException)
                {
                    cardAdder = humanPlayer;
                    attacker = null;

                    adder.Add(box.Card);

                    adderRank = box.Card.rank;

                    river.Remove(box.Card);
                }
            }
            else if(defender == humanPlayer)
            {
                river.Add(box.Card);

                humanPlayer.GetHand().Remove(box.Card);

                if (humanPlayer.GetHand().Count == 0 && talon.Count == 0)
                {
                    this.Hide();
                    frmWinner win = new frmWinner();
                    win.ShowDialog();
                    this.Close();
                }

                if (river.Count == 12)
                {
                    DefenceSuccess();
                }
                else
                {
                    try
                    {
                        Card cpuCard = cpuPlayer.selectCard(river);

                        if (defender.GetHand().Count == 0 && talon.Count == 0)
                        {
                            this.Hide();
                            frmLoser lose = new frmLoser();
                            lose.ShowDialog();
                            this.Close();
                        }

                        river.Add(cpuCard);
                    }
                    catch (OperationCanceledException)
                    {
                        DefenceSuccess();
                    }
                }
            }
            else if(cardAdder == humanPlayer)
            {
                adder.Add(box.Card);

                humanPlayer.GetHand().Remove(box.Card);

                if (humanPlayer.GetHand().Count == 0 && talon.Count == 0)
                {
                    this.Hide();
                    frmWinner win = new frmWinner();
                    win.ShowDialog();
                    this.Close();
                }

                if(river.Count / 2 + adder.Count == 6)
                {
                    AttackSuccess();
                }
            }

            Redraw();
        }

        private void btnEndDefence_Click(object sender, EventArgs e)
        {
            btnEndDefence.Visible = false;
            btnEndAttack.Visible = true;
        }

        private void btnEndAttack_Click(object sender, EventArgs e)
        {
            if (humanPlayer == attacker)
            {
                DefenceSuccess();
            }
            else
            {
                AttackSuccess();
            }
        }

        private void DefenceSuccess()
        {
            btnEndAttack.Visible = false;
            btnEndDefence.Visible = true;

            attacker.FillHand(talon);
            defender.FillHand(talon);

            attacker = defender;
            defender = humanPlayer;

            gbxHuman.Text = "Defender";
            gbxComputer.Text = "Attacker";

            river = new Cards();

            Card cpuCard = cpuPlayer.selectCard(river);

            river.Add(cpuCard);

            Redraw();
        }

        private void AttackSuccess()
        {
            btnEndAttack.Visible = true;
            btnEndDefence.Visible = false;

            attacker = cardAdder;
            cardAdder = null;
            adderRank = null;

            defender.AddCardsToHand(river);
            defender.AddCardsToHand(adder);

            attacker.FillHand(talon);
            defender.FillHand(talon);

            river = new Cards();
            adder = new Cards();

            Redraw();
        }
    }
}
