/*
 * Author: Adam Peltenburg 
 * Author: Purab Barot
 * Author: Tyler Querido
 * 
 * Ref: Tutorial 9
 * 
 * Description: Code for the game form; handles game logic for durak
 */

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
        //The roles a player can have
        Player attacker;
        Player defender;
        Player cardAdder;

        //The players
        IComputerPlayer cpuPlayer;
        Player humanPlayer;

        //The collections of cards for use in the game
        Deck talon;
        Cards river = new Cards();
        Cards adder = new Cards();

        //Holds the rank of the cards that won the attack
        Rank? adderRank = null;

        //Cardbox for storing the deck
        CardBox.CardBox deckBox;

        //Cardbox for storing the trump card
        CardBox.CardBox trumpBox;

        /// <summary>
        /// The regular size of a CardBox control
        /// </summary>
        static private Size regularSize = new Size(38, 54);

        /// <summary>
        /// The constructor for the game; instantializes all required variables
        /// </summary>
        /// <param name="numOfCards"> The deck size for the game </param>
        /// <param name="difficulty"> The difficulty of the ai player </param>
        public frmDurakGame(int numOfCards, char difficulty)
        {
            InitializeComponent();

            //Create a deck with the specified number of cards
            talon = new Deck(numOfCards);

            //Shuffle the deck
            talon = talon.Shuffle();

            //Create the human player
            humanPlayer = new Player(talon);

            //Set the attacker to be the human player
            attacker = humanPlayer;

            //Create an ai player based on the difficulty
            if(difficulty == 'e')
            {
                EasyPlayer easy = new EasyPlayer(talon);

                //Set the defender and cpuPlayer
                defender = easy;
                cpuPlayer = easy;
            }
            else if(difficulty == 'h')
            {
                MediumPlayer med = new MediumPlayer(talon);

                //Set the defender and cpuPlayer
                defender = med;
                cpuPlayer = med;
            }

            //Set the trump suit
            Card.trump = talon.getTrumpSuit();

            //Adds the deck images to the form
            SetDeck();

            //Draw everything to the form
            Redraw();
        }

        /// <summary>
        /// Handles Main menu button click
        /// </summary
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            // closes the current form
            this.Close();
        }

        /// <summary>
        /// Updates form to display the underlying information
        /// </summary>
        private void Redraw()
        {
            //Empty the three main panels
            EmptyPanel(pnlHuman);
            EmptyPanel(pnlCPU);
            EmptyPanel(pnlRiver);

            //Update the counter for the number of cards in the talon
            lblTalonCount.Text = talon.Count.ToString();

            //Removes the cardboxes in the deck if few enough cards remain
            if(talon.Count == 0)
            {
                this.Controls.Remove(trumpBox);
            }
            if(talon.Count < 2)
            {
                this.Controls.Remove(deckBox);
            }

            //Adds player's cards to the player panel
            AddCardsToPanel(humanPlayer.GetHand(), pnlHuman);

            //Add computer player's cards to the cpu panel
            if (cpuPlayer == defender)
            {
                AddCardsToPanel(defender.GetHand(), pnlCPU);
            }
            else
            {
                AddCardsToPanel(attacker.GetHand(), pnlCPU);
            }

            //Add cards in the river to the panel
            AddCardsToPanel(river, pnlRiver);

            //If the adder has cards in it; display the adder panel with the cards in it
            if(adder.Count > 0)
            {
                //Empty adder panel
                EmptyPanel(pnlAdder);

                //Display the adder panel
                gbxAdder.Visible = true;

                //Add the adder cards to the adder panel
                AddCardsToPanel(adder, pnlAdder);

                //Align the cards in the adder
                RealignPlayerCards(pnlAdder);
            }
            else
            {
                //Hide the adder panel
                gbxAdder.Visible = false;
            }

            //Realign the cards in the three main panels
            RealignPlayerCards(pnlHuman);
            RealignPlayerCards(pnlCPU);
            RealignRiver();

            //Set the click events on the cards
            SetPlayableCards();
        }

        /// <summary>
        /// Display the Cardboxes for the deck
        /// </summary>
        private void SetDeck()
        {
            //Instantialize the deck and trump cardboxs
            deckBox = new CardBox.CardBox();
            trumpBox = new CardBox.CardBox(talon.getTrumpCard());

            //Set the orientation of the trump card and make it face up
            trumpBox.CardOrientation = Orientation.Horizontal;
            trumpBox.FaceUp = true;

            //Set the locations of the cards
            deckBox.Location = new Point(4, 200);
            trumpBox.Location = new Point(4, 215);

            //Add the controls to the form
            this.Controls.Add(deckBox);
            this.Controls.Add(trumpBox);
        }

        /// <summary>
        /// Repositions the cards in a panel so that they are evenly distributed in the area available
        /// </summary>
        /// <param name="panelHand"> The panel to realign </param>
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
        /// Repositions the cards in the river so they display properly
        /// </summary>
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
                        // Algn the current card
                        pnlRiver.Controls[index].Top = VERTICAL_DISPLACEMENT;
                        pnlRiver.Controls[index].Left = pnlRiver.Controls[index - 1].Left - offset;
                    }
                    atkCard = !atkCard;
                }
            }
        }

        /// <summary>
        /// Insert a given card into a given panel
        /// </summary>
        /// <param name="card"> The card to add </param>
        /// <param name="addPanel"> The panel to add the card to </param>
        private void InsertCardIntoPanel(Card card, Panel addPanel)
        {
            // Create a new CardBox control based on the card to be inserted
            CardBox.CardBox aCardBox = new CardBox.CardBox(card);

            //Set the new cardbox's size
            aCardBox.Size = regularSize;

            //Determine if the inserted card should be face up
            if(addPanel != pnlCPU)
            {
                aCardBox.FaceUp = true;
            }
            else
            {
                aCardBox.FaceUp = false;
            }

            //Update the card's image
            aCardBox.UpdateCardImage();

            // Add the new control to the appropriate panel
            addPanel.Controls.Add(aCardBox);
        }

        /// <summary>
        /// Empty's the provided panel
        /// </summary>
        /// <param name="panel"> The panel to be emptied </param>
        public void EmptyPanel(Panel panel)
        {
            //Empty the panel of it's controls
            panel.Controls.Clear();
        }

        /// <summary>
        /// Add a collection of cards to a given panel as cardboxes
        /// </summary>
        /// <param name="cards"> The collection of cards to add </param>
        /// <param name="panel"> The panel to add the cards to </param>
        private void AddCardsToPanel(Cards cards, Panel panel)
        {
            //Loop through the collection of cards
            for (int index = cards.Count - 1; index >= 0; index--)
            {
                //Add the card to the panel
                InsertCardIntoPanel(cards[index], panel);
            }
        }

        /// <summary>
        /// Configure the human player's panel with click events
        /// </summary>
        private void SetPlayableCards()
        {
            //Loop through all the Cardbox controls
            foreach(CardBox.CardBox box in pnlHuman.Controls)
            {
                //Determine if the card is playable
                if (adderRank == null)
                {
                    if (box.Card.isPlayable(river))
                    {
                        //Add a click event
                        box.Click += Cardbox_Click;
                    }
                    else
                    {
                        //Move the Cardbox down
                        box.Top = VERTICAL_DISPLACEMENT;
                    }
                }
                else
                {
                    if(box.Card.rank == adderRank || (river.Count != 0 && box.Card.isPlayable(river)))
                    {
                        //Add a click event
                        box.Click += Cardbox_Click;
                    }
                    else
                    {
                        //Move the Cardbox down
                        box.Top = VERTICAL_DISPLACEMENT;
                    }
                }
            }
        }

        /// <summary>
        /// The event that will be wired to playable Cardboxes
        /// </summary>
        /// <param name="sender"> The object that the event is fired from </param>
        /// <param name="e"> The EventArgs object </param>
        private void Cardbox_Click(object sender, EventArgs e)
        {
            //Initialize the sender as a Cardbox
            CardBox.CardBox box = sender as CardBox.CardBox;

            //If the human player is the attacker
            if(attacker == humanPlayer)
            {
                //Add the card to the river
                river.Add(box.Card);

                //Remove the card from the player's hand
                humanPlayer.GetHand().Remove(box.Card);

                //If the player's hand is empty and the deck is empty then the human player wins
                if (humanPlayer.GetHand().Count == 0 && talon.Count == 0)
                {
                    //Show the Winner form
                    this.Hide();
                    frmWinner win = new frmWinner();
                    win.ShowDialog();
                    this.Close();
                }
                else
                {
                    try
                    {
                        //Draw a card from the computer's hand
                        Card cpuCard = cpuPlayer.selectCard(river);
                        
                        //If the computer's hand is empty and the deck is empty then the human player loses
                        if(defender.GetHand().Count == 0 && talon.Count == 0)
                        {
                            //Show the Loser form
                            this.Hide();
                            frmLoser lose = new frmLoser();
                            lose.ShowDialog();
                            this.Close();
                        }

                        //Add the computer's card to the river
                        river.Add(cpuCard);

                        //If the number of cards in the river equals 12
                        if (river.Count == 12)
                        {
                            //The defender was successful
                            DefenceSuccess();
                        }
                    }
                    catch (OperationCanceledException)
                    {
                        //Set the human player as the cardAdder
                        cardAdder = humanPlayer;
                        attacker = null;

                        //Move the played card to the adder
                        adder.Add(box.Card);

                        //Set the rank of the adder
                        adderRank = box.Card.rank;

                        //Remove the card from the river
                        river.Remove(box.Card);
                    }
                }
            }
            //If the human player is the defender
            else if(defender == humanPlayer)
            {
                //Add the card to the river
                river.Add(box.Card);

                //Remove the card from the player hand
                humanPlayer.GetHand().Remove(box.Card);

                //If the human player's hand is empty and the deck is empty then the human player wins
                if (humanPlayer.GetHand().Count == 0 && talon.Count == 0)
                {
                    //Show the Winner form
                    this.Hide();
                    frmWinner win = new frmWinner();
                    win.ShowDialog();
                    this.Close();
                }

                //if the river count equals 12
                if (river.Count == 12)
                {
                    //The defender was successful
                    DefenceSuccess();
                }
                else
                {
                    try
                    {
                        //Draw a card from the computer's hand
                        Card cpuCard = cpuPlayer.selectCard(river);

                        //If the computer's hand is empty and the deck is empty then the human player loses
                        if (attacker.GetHand().Count == 0 && talon.Count == 0)
                        {
                            //Show the Loser form
                            this.Hide();
                            frmLoser lose = new frmLoser();
                            lose.ShowDialog();
                            this.Close();
                        }

                        //Add the computer's card to the river
                        river.Add(cpuCard);
                    }
                    catch (OperationCanceledException)
                    {
                        //The defender was successful
                        DefenceSuccess();
                    }
                }
            }
            //If the human player is the cardAdder
            else if(cardAdder == humanPlayer)
            {
                //Add the card to the adder
                adder.Add(box.Card);

                //Remove the card from the player hand
                humanPlayer.GetHand().Remove(box.Card);

                //If the human player's hand is empty and the deck is empty then the human player wins
                if (humanPlayer.GetHand().Count == 0 && talon.Count == 0)
                {
                    //Show the Winner form
                    this.Hide();
                    frmWinner win = new frmWinner();
                    win.ShowDialog();
                    this.Close();
                }

                //If the human player has played 6 cards
                if(river.Count / 2 + adder.Count == 6)
                {
                    //The attacker was successful
                    AttackSuccess();
                }
            }

            //Redraw the form
            Redraw();
        }

        /// <summary>
        /// Event for handling the clicking of the end defence button
        /// </summary>
        /// <param name="sender"> The button that sent the event </param>
        /// <param name="e"> The EventArgs </param>
        private void btnEndDefence_Click(object sender, EventArgs e)
        {
            //Set the attacker as the card adder
            cardAdder = attacker;
            attacker = null;

            //The card that was played most recently
            Card addCard = river[river.Count - 1];

            //Add the card to the adder
            adder.Add(addCard);

            //Set the adder rank
            adderRank = addCard.rank;

            //Remove the card from the river
            river.Remove(addCard);

            //A collection of playable cards
            Cards playable = new Cards();

            //Loop through allthe cards in the cardAdder's hand
            foreach (Card card in cardAdder.GetHand())
            {
                //If the card is playable
                if (card.rank == adderRank || (river.Count != 0 && card.isPlayable(river)))
                {
                    //Add the card to list of playable cards
                    playable.Add(card);
                }
            }

            //Loop until the river is full or there are no more playable cards
            while ((river.Count / 2) + adder.Count < 6 && playable.Count > 0)
            {
                //Add the card to the adder
                adder.Add(playable[0]);

                //Remove the card from the computer's hand
                cardAdder.GetHand().Remove(playable[0]);

                //Remove the card from the playable cards
                playable.Remove(playable[0]);

                //If the cardAdder's hand is empty and the deck is empty then the human player loses
                if (cardAdder.GetHand().Count == 0 && talon.Count == 0)
                {
                    //Show the Loser form
                    this.Hide();
                    frmLoser lose = new frmLoser();
                    lose.ShowDialog();
                    this.Close();
                }
            }
            
            //The attacker was successful
            AttackSuccess();

            //If the attacker's hand is not empty
            if (attacker.GetHand().Count != 0)
            {
                //Draw a card from the computer's hand
                Card cpuCard = cpuPlayer.selectCard(river);

                //If the computer's hand is empty and the deck is empty then the human player loses
                if (attacker.GetHand().Count == 0 && talon.Count == 0)
                {
                    //Show the Loser form
                    this.Hide();
                    frmLoser lose = new frmLoser();
                    lose.ShowDialog();
                    this.Close();
                }

                //Add the drawn card to the river
                river.Add(cpuCard);
            }

            //Redraw the form
            Redraw();
        }

        /// <summary>
        /// Event for handling the clicking of the end attack button
        /// </summary>
        /// <param name="sender"> The button that sent the event </param>
        /// <param name="e"> The EventArgs </param>
        private void btnEndAttack_Click(object sender, EventArgs e)
        {
            //If the human player is the attacker
            if (humanPlayer == attacker)
            {
                //The defence was successful
                DefenceSuccess();

                //Draw a card from the computer's hand
                Card cpuCard = cpuPlayer.selectCard(river);

                //If the computer's hand is empty and the deck is empty then the human player loses
                if (attacker.GetHand().Count == 0 && talon.Count == 0)
                {
                    //Show the loser form
                    this.Hide();
                    frmLoser lose = new frmLoser();
                    lose.ShowDialog();
                    this.Close();
                }

                //Add the drawn card to the river
                river.Add(cpuCard);

                //Redraw the form
                Redraw();
            }
            else
            {
                //The attack was successful
                AttackSuccess();
            }
        }

        /// <summary>
        /// Handles logic for a successful defence
        /// </summary>
        private void DefenceSuccess()
        {
            //Switch button visibility
            btnEndAttack.Visible = !btnEndAttack.Visible;
            btnEndDefence.Visible = !btnEndDefence.Visible;

            //Fill both players' hands
            attacker.FillHand(talon);
            defender.FillHand(talon);

            //Switch the attacker and defender
            Player dummy = attacker;
            attacker = defender;
            defender = dummy;

            //Switch the attacker and defender labels
            if (gbxHuman.Text == "Attacker")
            {
                gbxHuman.Text = "Defender";
                gbxComputer.Text = "Attacker";
            }
            else
            {
                gbxHuman.Text = "Attacker";
                gbxComputer.Text = "Defender";
            }

            //Reset the river
            river = new Cards();
        }

        /// <summary>
        /// Handles the logic for a successful attack
        /// </summary>
        private void AttackSuccess()
        {
            //Set the attacker as the card adder
            attacker = cardAdder;
            cardAdder = null;
            adderRank = null;

            //Add the river and the adder to the defender's hand
            defender.AddCardsToHand(river);
            defender.AddCardsToHand(adder);

            //Fill the attacker's and the defender's hand
            attacker.FillHand(talon);
            defender.FillHand(talon);

            //Reset the river and the adder
            river = new Cards();
            adder = new Cards();

            //Redraw the form
            Redraw();
        }
    }
}