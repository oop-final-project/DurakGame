using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakGame_ClassLib
{
    public class Hand : Cards
    {
        const int HAND_SIZE = 6;

        public Hand(Deck drawDeck)
        {
            for(int cards = 0; cards < HAND_SIZE; cards++)
            {
                List.Add(drawDeck.drawCard());
            }
        }
    }
}
