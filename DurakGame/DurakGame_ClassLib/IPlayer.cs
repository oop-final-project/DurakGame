using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakGame_ClassLib
{
    public interface IPlayer
    {
        Card selectCard(Cards playedCards);

        Hand getHand();
    }
}
