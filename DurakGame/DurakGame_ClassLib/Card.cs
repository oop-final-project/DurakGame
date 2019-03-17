using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakGame_ClassLib
{
    public class Card : ICloneable
    {
        //added just to get started

      
        public readonly Rank rank;
        public readonly Suit suit;

        /// <summary>
        /// Trump suit to use if useTrumps is true.
        /// </summary>
        public static Suit trump = Suit.Club;

        private Card()
        {
        }

        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }

        public static bool operator ==(Card card1, Card card2)
        {
            return (card1.suit == card2.suit) && (card1.rank == card2.rank);
        }

        public static bool operator !=(Card card1, Card card2)
        {
            return !(card1 == card2);
        }

        public override bool Equals(object card)
        {
            return this == (Card)card;
        }

        public override int GetHashCode()
        {
            return 13 * (int)suit + (int)rank;
        }

        public static bool operator >(Card card1, Card card2)
        {
            if (card1.suit != card2.suit)
            {
                if (card1.suit == Card.trump)
                {
                    return true;
                }
                else if (card2.suit == Card.trump)
                {
                    return false;
                }
                else
                {
                    return (card1.rank > card2.rank);
                }
            }
            else
            {
                return (card1.rank > card2.rank);
            }
        }

        public static bool operator <(Card card1, Card card2)
        {
            return !(card1 >= card2);
        }

        public static bool operator >=(Card card1, Card card2)
        {
            if (card1.suit != card2.suit)
            {
                if (card1.suit == Card.trump)
                {
                    return true;
                }
                else if (card2.suit == Card.trump)
                {
                    return false;
                }
                else
                {
                    return (card1.rank >= card2.rank);
                }
            }
            else
            {
                return (card1.rank >= card2.rank);
            }
        }

        public static bool operator <=(Card card1, Card card2)
        {
            return !(card1 > card2);
        }

        /// <summary>
        /// Determines if the card is playable
        /// </summary>
        /// <param name="playedCards"> The cards to check against </param>
        /// <returns> True is the card is playable; false otherwise </returns>
        public bool isPlayable(Cards playedCards)
        {
            bool returnValue = false;

            if (playedCards.Count == 0)
            {
                returnValue = true;
            }
            else
            {
                if (playedCards.Count % 2 == 0)
                {
                    foreach(Card card in playedCards)
                    {
                        if(this.rank == card.rank)
                        {
                            returnValue = true;
                        }
                    }
                }
                else
                {
                    if (this.suit == playedCards[playedCards.Count - 1].suit)
                    {
                        returnValue = (this > playedCards[playedCards.Count - 1]);
                    }
                    else if (this.suit == Card.trump)
                    {
                        returnValue = true;
                    }
                }
            }

            return returnValue;
        }
    }
}
