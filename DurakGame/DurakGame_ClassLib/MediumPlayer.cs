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
            Card returnCard = playableCards[getLowestCard(playableCards)];

            playerHand.Remove(returnCard);

            return returnCard;
        }
        public int getLowestCard(Cards index)
        {
            int cardIndex = 0;
            for (int i = 1; i < index.Count; i++)
            {
                if (index[i] < (index[cardIndex]))
                {
                    cardIndex = i;
                }
            }
            return cardIndex;
        }
    }
}
