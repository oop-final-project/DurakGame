using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakGame_ClassLib
{
    /// <summary>
    /// Handles the AI's medium difficulty setting, inherits from Player and IComputerPlayer
    /// </summary>
    public class MediumPlayer : Player, IComputerPlayer
    {
        /// <summary>
        /// Default constructor for the MediumPlayer class
        /// </summary>
        /// <param name="cardDraws"></param>
        public MediumPlayer(Deck cardDraws)
            : base(cardDraws)
        {

        }

        /// <summary>
        /// selectCard method lets the AI determine which cards are playable and which one to select. On medium mode, this is dictated by the rank of the card
        /// </summary>
        /// <param name="playedCards"></param>
        /// <returns>The AI's selected card to put into play</returns>
        public Card selectCard(Cards playedCards)
        {
            // Instantiate the playableCards class with the current playable cards
            Cards playableCards = this.GetPlayableCards(playedCards);

            // Number of playable cards
            int numberOfCards = playableCards.Count;

            // If there are no playable cards
            if (numberOfCards == 0)
            {
                throw new OperationCanceledException("No cards are playable...");
            }

            // Card object holds the card that will be selected by the AI
            Card returnCard = playableCards[getLowestCard(playableCards)];

            // Remove this card from the AI's hand before adding it to the river
            playerHand.Remove(returnCard);

            return returnCard;
        }

        /// <summary>
        /// A method to get the lowest-ranking card in the AI's hand. This is exclusive to medium difficulty and will make the AI more challenging
        /// </summary>
        /// <param name="index"></param>
        /// <returns>The index of the lowest ranking card in the AI's hand</returns>
        public int getLowestCard(Cards index)
        {
            // The index of the current card
            int cardIndex = 0;

            // Loop through each card in the hand
            for (int i = 1; i < index.Count; i++)
            {
                // If the rank of the current card is lower than the previously lowest card
                if (index[i] < (index[cardIndex]))
                {
                    // Set the current card as the lowest card in the hand
                    cardIndex = i;
                }
            }
            return cardIndex;
        }
    }
}
