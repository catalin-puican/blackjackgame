using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMoreGame
{
    public class Player
    {
        private List<Card> hand;
        private bool isDealer;

        public Player(bool isDealer)
        {
            this.isDealer = isDealer;
            hand = new List<Card>();
        }

        public void AddCard(Card card)
        {
            hand.Add(card);
        }

        public List<Card> GetHand() => hand;

        public int CalculateHandValue()
        {
            int value = hand.Sum(card => card.GetValue());
            int aceCount = hand.Count(card => card.GetValue() == 11);

            while (value > 21 && aceCount > 0)
            {
                value -= 10; // scade 10 de la asul care initial e 11 in caz ca am da bust 
                aceCount--; // 
            }

            return value;
        }
    }

}
