/*
 * Author: Adam Peltenburg 
 * Author: Purab Barot
 * Author: Tyler Querido
 * 
 * Description: A class for handling the desicions a medium
 * difficulty player will make
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakGame_ClassLib
{
    public class MediumPlayer : Player, IComputerPlayer
    {
        /// <summary>
        /// The constructor for a medium player
        /// </summary>
        /// <param name="cardDraws"> The deck to draw the cards from </param>
        public MediumPlayer(Deck cardDraws)
            : base(cardDraws)
        {

        }

        /// <summary>
        /// Selects the lowest card in the player's hand
        /// </summary>
        /// <param name="playedCards"> The cards that have been played </param>
        /// <returns> The card that has been played </returns>
        public Card selectCard(Cards playedCards)
        {
            //Get the playable cards
            Cards playableCards = this.GetPlayableCards(playedCards);

            //The number of cards that are playable
            int numberOfCards = playableCards.Count;

            //If no cards are playable
            if (numberOfCards == 0)
            {
                //Cancel the operation
                throw new OperationCanceledException("No cards are playable...");
            }
            //Get the lowest card
            Card returnCard = playableCards[getLowestCard(playableCards)];

            //Remove the card that has been played
            playerHand.Remove(returnCard);

            //return the played card
            return returnCard;
        }

        /// <summary>
        /// Gets the lowest card in the given collection
        /// </summary>
        /// <param name="cards"> The collection to find the lowest card in </param>
        /// <returns> The indexof the lowest card </returns>
        public int getLowestCard(Cards cards)
        {
            int cardIndex = 0;
            for (int index = 1; index < cards.Count; index++)
            {
                if (cards[index] < (cards[cardIndex]))
                {
                    cardIndex = index;
                }
            }
            return cardIndex;
        }
    }
}
