﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DurakGame_ClassLib;

namespace DurakGame_Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deck testDeck = new Deck();

            //foreach (Card card in testDeck)
            //{
            //    Console.WriteLine(card.ToString());
            //}

            Deck testDeck = new Deck(36);

            foreach (Card card in testDeck)
            {
                Console.WriteLine(card.ToString());
            }

            testDeck = testDeck.Shuffle();

            Card.trump = testDeck[testDeck.Count-1].suit;

            Console.WriteLine("");

            foreach (Card card in testDeck)
            {
                Console.WriteLine(card.ToString());
            }

            EasyPlayer compPlayer = new EasyPlayer(testDeck);

            IComputerPlayer cpuPlayer = compPlayer;

            Player testPlayer = compPlayer;

            Cards playedCards = new Cards();

            //playedCards.Add(new Card(Suit.Spade, Rank.Eight));
            //playedCards.Add(new Card(Suit.Spade, Rank.Jack));

            Console.WriteLine("");

            foreach (Card card in playedCards)
            {
                Console.WriteLine(card.ToString());
            }

            Console.WriteLine("");

            foreach (Card card in testPlayer.GetHand())
            {
                if (card.isPlayable(playedCards))
                {
                    Console.WriteLine(card.ToString() + " is playable");
                }
                else
                {
                    Console.WriteLine(card.ToString() + " is not playable");
                }
            }

            Console.WriteLine("");

            try
            {
                Console.WriteLine(cpuPlayer.selectCard(playedCards).ToString() + " was played!");
            }
            catch(OperationCanceledException e)
            {
                Console.WriteLine(e.Message);
            }

            //Console.WriteLine("");

            //foreach (Card card in testHand)
            //{
            //    Console.WriteLine(card.ToString());
            //}

            //Console.WriteLine("");

            //foreach (Card card in testDeck)
            //{
            //    Console.WriteLine(card.ToString());
            //}

            //if (testDeck[0] > testDeck[1])
            //{
            //    Console.WriteLine("Greater");
            //}
            //else
            //{
            //    Console.WriteLine("Less or equal");
            //}

            //if (testDeck[0] >= testDeck[1])
            //{
            //    Console.WriteLine("Greater or equal");
            //}
            //else
            //{
            //    Console.WriteLine("Less");
            //}

            Console.ReadKey();
        }
    }
}
