/*
 * Author: Adam Peltenburg 
 * Author: Purab Barot
 * Author: Tyler Querido
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
    public class Hand : Cards
    {
        //The default size of a hand
        const int HAND_SIZE = 6;

        /// <summary>
        /// The constructor for a hand
        /// </summary>
        /// <param name="drawDeck"> The deck to draw cards from </param>
        public Hand(Deck drawDeck)
        {
            for(int cards = 0; cards < HAND_SIZE; cards++)
            {
                List.Add(drawDeck.DrawCard());
            }
        }
    }
}
