using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakGame_ClassLib
{
    public class EasyPlayer : Player, IComputerPlayer
    {

        public EasyPlayer(Deck cardDraws)
            : base(cardDraws)
        {

        }

        public Card selectCard(Cards playedCards)
        {
            Cards playableCards = this.GetPlayableCards(playedCards);

            int numberOfCards = playableCards.Count;
            Random randomNumber = new Random();

            if(playableCards.Count == 0)
            {
                throw new OperationCanceledException("No cards are playable...");
            }

            Card returnCard = playableCards[randomNumber.Next(0, numberOfCards)];

            playerHand.Remove(returnCard);

            return returnCard;
        }
    }
}
