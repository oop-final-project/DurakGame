using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakGame_ClassLib
{
    public class MediumPlayer : Player, IComputerPlayer
    {
        public MediumPlayer(Deck cardDraws)
            : base(cardDraws)
        {

        }
        public Card selectCard(Cards playedCards)
        {
            Cards playableCards = this.GetPlayableCards(playedCards);

            int numberOfCards = playableCards.Count;
            Random randomNumber = new Random();

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
