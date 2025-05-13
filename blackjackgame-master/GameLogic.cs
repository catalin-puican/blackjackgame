using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMoreGame
{
    public class GameLogic
    {
        private Deck deck;
        private Player dealer;
        private Player player;

        public GameLogic()
        {
            deck = new Deck();
            dealer = new Player(isDealer: true);// in caz ca functia din player isdealer face obiectul dealer de tip player 
            player = new Player(isDealer: false);
        }

        public void StartGame()
        {
            // imparte cartile
            for (int i = 0; i < 2; i++)
            {
                player.AddCard(deck.DrawCard());
                dealer.AddCard(deck.DrawCard());
            }
        }

        public Player GetDealer() => dealer;
        public Player GetPlayer() => player;
        public Deck GetDeck() => deck;
    }

}
