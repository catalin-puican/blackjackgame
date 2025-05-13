using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMoreGame
{
    public class Card
    {
        private string suit; // Culoarea 
        private string rank; // Rank (2,3,4,..,Juvete,Dama,Rege,As)
        private int value;   // Asta e pentru scor cand il calculam

        

        public Card(string suit, string rank, int value )
        {
            this.suit = suit;
            this.rank = rank;
            this.value = value;
           
        }

        public int GetValue() => value;
       
        public string GetSuit() => suit;
        public string GetRank() => rank;

        public  string ToString()
        {
            return $"{rank} of {suit}"; // asta este pentru afisare
        }

    }

}
