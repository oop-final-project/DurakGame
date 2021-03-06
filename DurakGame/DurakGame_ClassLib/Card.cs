﻿/*
 * Author: Adam Peltenburg 
 * Author: Purab Barot
 * Author: Tyler Querido
 * 
 * Ref: Tutorial 8
 * 
 * Description: A class representing a card
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DurakGame_ClassLib
{
    public class Card : ICloneable
    {

        // The rank of the card
        public readonly Rank rank;

        // The suit of the card
        public readonly Suit suit;

        // Whether or not the card is face up
        private bool faceUp = false;

        /// <summary>
        /// Gets or Sets the faceUp property
        /// </summary>
        public bool FaceUp
        {
            set
            {
                faceUp = value;
            }
            get
            {
                return faceUp;
            }
        }

        /// <summary>
        /// The trump suit.
        /// </summary>
        public static Suit trump = Suit.Club;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Card()
        {
        }

        /// <summary>
        /// Constructor that creates a card with the given rank and suit
        /// </summary>
        /// <param name="newSuit"> The suit of the new card </param>
        /// <param name="newRank"> The rank of the new card </param>
        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        /// <summary>
        /// Clones the card
        /// </summary>
        /// <returns> The clone of the card as an object </returns>
        public object Clone()
        {
            return MemberwiseClone();
        }

        /// <summary>
        /// Returns the card as a string
        /// </summary>
        /// <returns> A string that represents the card </returns>
        public override string ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }

        /// <summary>
        /// Tests if two cards have an equal value
        /// </summary>
        /// <param name="card1"> The first card </param>
        /// <param name="card2"> The second card </param>
        /// <returns> Whether or not the cards are equal </returns>
        public static bool operator ==(Card card1, Card card2)
        {
            return (card1.suit == card2.suit) && (card1.rank == card2.rank);
        }

        /// <summary>
        /// Tests if two cards have a different value
        /// </summary>
        /// <param name="card1"> The first card </param>
        /// <param name="card2"> The second card </param>
        /// <returns> Whether or not the cards are different </returns>
        public static bool operator !=(Card card1, Card card2)
        {
            return !(card1 == card2);
        }

        /// <summary>
        /// Tests if two cards have an equal value
        /// </summary>
        /// <param name="card1"> The first card </param>
        /// <param name="card2"> The second card </param>
        /// <returns> Whether or not the cards are equal </returns>
        public override bool Equals(object card)
        {
            return this == (Card)card;
        }

        /// <summary>
        /// Gets the hashcode of a card
        /// </summary>
        /// <returns> The hashcode of a card </returns>
        public override int GetHashCode()
        {
            return 13 * (int)suit + (int)rank;
        }

        /// <summary>
        /// Tests if one card is greater than another
        /// </summary>
        /// <param name="card1"> The first card </param>
        /// <param name="card2"> The second card </param>
        /// <returns> Whether or one card is greater than the other </returns>
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

        /// <summary>
        /// Tests if one card is less than another
        /// </summary>
        /// <param name="card1"> The first card </param>
        /// <param name="card2"> The second card </param>
        /// <returns> Whether or one card is less than the other </returns>
        public static bool operator <(Card card1, Card card2)
        {
            return !(card1 >= card2);
        }

        /// <summary>
        /// Tests if one card is greater than or equal to another
        /// </summary>
        /// <param name="card1"> The first card </param>
        /// <param name="card2"> The second card </param>
        /// <returns> Whether or one card is greater than or equal to the other </returns>
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

        /// <summary>
        /// Tests if one card is less than or equal to another
        /// </summary>
        /// <param name="card1"> The first card </param>
        /// <param name="card2"> The second card </param>
        /// <returns> Whether or one card is less than or equal to the other </returns>
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

        /// <summary>
        /// Gets the image of the card
        /// </summary>
        /// <returns> The image of the card </returns>
        public Image GetCardImage()
        {
            string imageName;    //the name of the image in the resources file
            Image cardImage;    //holds the image

            //if the card is not face up
            if (!faceUp)
            {
                //set the image name to "Back"
                imageName = "Back"; //sets it to the image name foe the back of a card
            }
            else // else the card is fce up and ot joker
            {
                //set the image name to{Suit} _{Rank}
                imageName = suit.ToString() + "_" + rank.ToString(); // enums are handy!

            }

            //set the image to the appropriate objcet we get from the resources file
            cardImage = Properties.Resources.ResourceManager.GetObject(imageName) as Image;
            // return the image
            return cardImage;
        }
    }
}