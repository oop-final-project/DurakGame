using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakGame_ClassLib
{
    public class Deck : Cards
    {

        const int MAX_SIZE = 52;
        const int MIN_SIZE = 0;

        /// <summary>
        /// Initializes a standard deck of 52 cards
        /// </summary>
        public Deck()
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    List.Add(new Card(suit, rank));
                }
            }
        }

        /// <summary>
        /// Creates a deck of cards based on the given size starting with aces, then kings, queens, etc.
        /// </summary>
        /// <param name="size"> Size of the deck to be created; must be divisible by 4 and between 0 and 52 </param>
        public Deck(int size)
        {
            if (size <= MAX_SIZE && size >= MIN_SIZE)
            {
                if (size % 4 == 0)
                {
                    int rank = 14;

                    for (int index = 0; index < size / 4; index++)
                    {
                        List.Add(new Card(Suit.Club, (Rank)rank));
                        List.Add(new Card(Suit.Diamond, (Rank)rank));
                        List.Add(new Card(Suit.Heart, (Rank)rank));
                        List.Add(new Card(Suit.Spade, (Rank)rank));

                        rank--;
                    }
                }
                else
                {
                    throw new ArgumentException("The number of cards must be divisble by 4");
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("The number of cards must be between " +
                    MIN_SIZE + " and " + MAX_SIZE + ".");
            }
        }

        /// <summary>
        /// Returns a card in a given position; top card by default
        /// </summary>
        /// <param name="position"> position of the card to be drawn </param>
        /// <returns> the card drawn </returns>
        public Card DrawCard(int position = 0)
        {
            Card returnCard = this[position];

            this.Remove(returnCard);

            return returnCard;
        }

        /// <summary>
        /// Shuffles the deck then returns it
        /// </summary>
        /// <returns> Returns the shuffled deck </returns>
        public Deck Shuffle()
        {
            Deck shuffledDeck = new Deck(0);

            int numberOfCards = List.Count;
            Random randomNumber = new Random();

            for (int draws = 0; draws < numberOfCards; draws++)
            {
                shuffledDeck.Add(this.DrawCard(randomNumber.Next(0, List.Count)));
            }

            return shuffledDeck;
        }

        /// <summary>
        /// Get the trump suit for the game
        /// </summary>
        /// <returns> The trump suit </returns>
        public Suit getTrumpSuit()
        {
            int index = List.Count - 1;
            
            return this[index].suit;
        }

        public Card getTrumpCard()
        {
            return this[this.Count - 1];
        }
    }
}
