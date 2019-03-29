using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakGame_ClassLib
{
    public interface IComputerPlayer
    {
        Card selectCard(Cards playedCards);
    }
}
