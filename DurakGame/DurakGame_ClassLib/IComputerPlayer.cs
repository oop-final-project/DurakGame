/*
 * Author: Adam Peltenburg 
 * Author: Purab Barot
 * Author: Tyler Querido
 * 
 * Description: An interface for computer players
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakGame_ClassLib
{
    public interface IComputerPlayer
    {
        /// <summary>
        /// Selects a card to be played
        /// </summary>
        /// <param name="playedCards"> The cards that have been played </param>
        /// <returns> The card that was played </returns>
        Card selectCard(Cards playedCards);
    }
}
