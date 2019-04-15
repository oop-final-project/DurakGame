/*
 * Author: Adam Peltenburg 
 * Author: Purab Barot
 * Author: Tyler Querido
 * 
 * Description: Class representing a player in durak
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakGame_ClassLib
{
    /// <summary>
    /// Player class handles the human player's actions
    /// </summary>
    public class Player
    {
        // Hand object
        protected Hand playerHand;

        const int DEFAULT_HAND_SIZE = 6;
        /// <summary>
        /// Default Player constructor
        /// </summary>
        /// <param name="cardDraws"> The deck to draw the hand from </param>
        public Player(Deck cardDraws)
        {
            playerHand = new Hand(cardDraws);
        }

        /// <summary>
        /// Getter for the human player's hand
        /// </summary>
        /// <returns>the player's hand</returns>
        public Hand GetHand()
        {
            return playerHand;
        }

        /// <summary>
        /// If there is less than six cards in hand, the hand is replenished with more cards from the deck
        /// </summary>
        /// <param name="cardDraws"> The deck to draw cards from </param>
        public void FillHand(Deck cardDraws)
        {
            for(int cardCount = playerHand.Count; cardCount < DEFAULT_HAND_SIZE && cardDraws.Count != 0; cardCount++)
            {
                playerHand.Add(cardDraws.DrawCard(0));
            }
        }

        /// <summary>
        /// Get all cards that are playable based on cards that are already in the river
        /// </summary>
        /// <param name="playedCards"> The cards that have been played </param>
        /// <returns> A collection of playable cards </returns>
        public Cards GetPlayableCards(Cards playedCards)
        {
            Cards playableCards = new Cards();

            foreach (Card card in playerHand)
            {
                if (card.isPlayable(playedCards))
                {
                    playableCards.Add(card);
                }
            }

            return playableCards;
        }

        /// <summary>
        /// Takes an array of cards from the river and adds them to the hand of the defender if the attacker wins
        /// </summary>
        /// <param name="addCards"> The collection of cards to be added </param>
        public void AddCardsToHand(Cards addCards)
        {
            foreach(Card card in addCards)
            {
                playerHand.Add(card);
            }
        }

        /// <summary>
        /// Draws a card from the deck
        /// </summary>
        /// <param name="drawDeck"> The deck to draw the card from </param>
        public void DrawCard(Deck drawDeck)
        {
            playerHand.Add(drawDeck.DrawCard());
        }
    }
}
