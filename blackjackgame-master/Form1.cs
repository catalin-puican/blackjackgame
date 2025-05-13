using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using OneMoreGame;
using Blackjack;






namespace Blackjack
{
    public partial class Form1 : Form
    {
        
        private GameLogic gameLogic;
        private Deck deck;

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // instantiam logica si incepem jocul 
            gameLogic = new GameLogic();
            gameLogic.StartGame();
            
            

            // afisam cartile pentru inceput
            UpdateCardsLabels(dealerLabel, gameLogic.GetDealer().GetHand(), gameLogic.GetDealer().CalculateHandValue());
            UpdateCardsLabels(playerLabel, gameLogic.GetPlayer().GetHand(), gameLogic.GetPlayer().CalculateHandValue());

            // activam in caz ca nu inchidem jocul 
            hitButon.Enabled = true;
            standButon.Enabled = true;

            // trecem de la tabul de welcome la cel de joc 
            tabControl1.SelectedTab = gameTab;
        }

        
        

        

        private void DetermineWinner()
        {
            //vedem cine a castigat si afisam
            int playerScore = gameLogic.GetPlayer().CalculateHandValue();
            int dealerScore = gameLogic.GetDealer().CalculateHandValue();

            string message;

            if (dealerScore > 21 || playerScore > dealerScore)
            {
                message = "Bravo, bine! Ai castigat!";
            }
            else if (playerScore == dealerScore)
            {
                message = "Remiza, nu e nici rau nici bine.";
            }
            else
            {
                message = "Ghinion, ai pierdut!";
            }

            MessageBox.Show(message);
        }

        private void UpdateCardsLabels(Label cardsLabel, List<Card> hand, int score)
        {
            // aici concatenam pentru a afisa la label 
            var handDescription = string.Join(", ", hand.Select(card => card.ToString()));
            cardsLabel.Text = $"Cards: {handDescription} | Score: {score}";
        }

        private void ShowHandDetails(string playerType, List<Card> hand, int score)
        {
            // si aici concatenam dar pentru cand o sa apasam butonul
            string handDescription = string.Join(", ", hand.Select(card => card.ToString()));
            MessageBox.Show($"{playerType} Cards: {handDescription}\nScore: {score}");
        }

        private void EndGame()
        {
            // aici o sa dezactivam butoanele dupa ce terminam jocul 
            hitButon.Enabled = false;
            standButon.Enabled = false;
        }

        private void playerButton_Click(object sender, EventArgs e)
        {
            // se afiseaza cand apasam cartile playerului si scorul 
            ShowHandDetails("Player", gameLogic.GetPlayer().GetHand(), gameLogic.GetPlayer().CalculateHandValue());
        }

        private void hitButon_Click(object sender, EventArgs e)
        {
            // tragem o carte (hit)
            gameLogic.GetPlayer().AddCard(gameLogic.GetDeck().DrawCard());

            // aici pentru cazul in care dam hit
            UpdateCardsLabels(playerLabel, gameLogic.GetPlayer().GetHand(), gameLogic.GetPlayer().CalculateHandValue());

            // sa vedem daca am pierdut 
            if (gameLogic.GetPlayer().CalculateHandValue() > 21)
            {
                MessageBox.Show("Ghinion, ai pierdut!");
                EndGame();
            }
        }

        private void standButon_Click(object sender, EventArgs e)
        {
            // aici dupa ce apasam stand dealer isi continua treaba
            while (gameLogic.GetDealer().CalculateHandValue() < 17)
            {
                gameLogic.GetDealer().AddCard(gameLogic.GetDeck().DrawCard());
            }

            // la fel ca mai sus afisam update la label 
            UpdateCardsLabels(dealerLabel, gameLogic.GetDealer().GetHand(), gameLogic.GetDealer().CalculateHandValue());

            // vedem cine a castigat si oprim jocul 
            DetermineWinner();
            EndGame();
        }

        private void dealerButton_Click(object sender, EventArgs e)
        {
            // pentru butonul de dealer sa vedem ce carti are 
            ShowHandDetails("Dealer", gameLogic.GetDealer().GetHand(), gameLogic.GetDealer().CalculateHandValue());
        }
    }
}



