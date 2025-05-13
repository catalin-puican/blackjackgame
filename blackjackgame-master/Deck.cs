using System;
using System.Collections.Generic;
using System.Linq;

namespace OneMoreGame
{
    public class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
            InitializeDeck();
            Shuffle();
        }

        private void InitializeDeck()
        {
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            int[] values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };

            cards.Clear(); // curatam lista ca sa creeam alt pachet 

            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < ranks.Length; j++)
                {
                    cards.Add(new Card(suits[i], ranks[j], values[j]));
                }
            }
        }

        public void Shuffle()
        {
            Random rng = new Random();
            cards = cards.OrderBy(x => rng.Next()).ToList(); // pentru amestecat pachet
        }

        public Card DrawCard()
        {
            if (cards.Count == 0)
            {
                throw new InvalidOperationException("No more cards in the deck!");
            }

            Card drawnCard = cards[0];
            cards.RemoveAt(0);
            return drawnCard;
        }

        public void ResetDeck()
        {
            InitializeDeck();// sa apelez la inceput cand apas start sa creez alt deck si sa il amestec
            Shuffle();
        }
    }
    }

