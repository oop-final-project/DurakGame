/*
 * Author: Adam Peltenburg 
 * Author: Purab Barot
 * Author: Tyler Querido
 * 
 * Description: A class representing a computer player set to easy
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakGame_ClassLib
{
    /// <summary>
    /// EasyPlayer class handles an AI player with easy difficulty set. Inherits from Player and IComputerPlayer
    /// </summary>
    public class EasyPlayer : Player, IComputerPlayer
    {

        /// <summary>
        /// Default EasyPlayer constructor
        /// </summary>
        /// <param name="cardDraws"> The deck to draw cards from </param>
        public EasyPlayer(Deck cardDraws)
            : base(cardDraws)
        {

        }

        /// <summary>
        /// selectCard method lets the AI determine which cards are playable and which one to select. On easy mode, this is entirely random
        /// </summary>
        /// <param name="playedCards"> The cards that have been played </param>
        /// <returns> The card that was played </returns>
        public Card selectCard(Cards playedCards)
        {
            Cards playableCards = this.GetPlayableCards(playedCards);

            // Number of playable cards
            int numberOfCards = playableCards.Count;

            // Random number allows the AI to select a card at a random index
            Random randomNumber = new Random();

            // If there are no playable cards
            if(numberOfCards == 0)
            {
                throw new OperationCanceledException("No cards are playable...");
            }
            // Select a random playable card from the hand
            Card returnCard = playableCards[randomNumber.Next(0, numberOfCards)];

            // Remove any matching card at this index in the hand before adding the same card in the river
            playerHand.Remove(returnCard);

            // Return card object
            return returnCard;
        }
    }
}
