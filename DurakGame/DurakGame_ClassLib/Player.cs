using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakGame_ClassLib
{
    public class Player
    {
        protected Hand playerHand;
        public Player(Deck cardDraws)
        {
            playerHand = new Hand(cardDraws);
        }

        public Hand GetHand()
        {
            return playerHand;
        }

        public void FillHand(Deck cardDraws)
        {
            for(int cardCount = playerHand.Count; cardCount < 6; cardCount++)
            {
                playerHand.Add(cardDraws.DrawCard(0));
            }
        }

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
    }
}
