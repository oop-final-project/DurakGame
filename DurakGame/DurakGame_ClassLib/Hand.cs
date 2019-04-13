/*
 * @author: Adam Peltenburg
 * @author: Tyler Querido
 * @author: Purab Barot
 * 
 * Description: A class representing a player's hand
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakGame_ClassLib
{
    /// <summary>
    /// Class for the player's hand. Inherits from Cards
    /// </summary>
    public class Hand : Cards
    {
        // Hand size
        const int HAND_SIZE = 6;

        /// <summary>
        /// Draws six cards into the player's hand
        /// </summary>
        /// <param name="drawDeck"></param>
        public Hand(Deck drawDeck)
        {
            // Loop through the hand and draw a new card
            for (int cards = 0; cards < HAND_SIZE; cards++)
            {
                List.Add(drawDeck.DrawCard());
            }
        }
    }
}
