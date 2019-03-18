using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakGame_ClassLib
{
    public class EasyPlayer : IPlayer
    {
        private Hand playerHand;

        public EasyPlayer(Deck cardDraws)
        {
            playerHand = new Hand(cardDraws);
        }

        public Card selectCard(Cards playedCards)
        {
            Cards playableCards = new Cards();

            foreach(Card card in playerHand)
            {
                if(card.isPlayable(playedCards))
                {
                    playableCards.Add(card);
                }
            }

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

        public Hand getHand()
        {
            return playerHand;
        }
    }
}
