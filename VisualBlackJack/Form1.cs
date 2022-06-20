using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VisualBlackJack
{
    public partial class BlackJack : Form
    {
        private int PlayerCounter = 0;
        public double Total { get; set; } = 0;
        public double DealerCounter { get; set; } = 0;
        int DealerSum = 0;
        int PlayerSum = 0;

        public List<Card> DeckofCards = new List<Card>
        {
            new Card {Name =Properties.Resources.Ace_of_Clubs, Value = 1},
            new Card {Name =Properties.Resources._2_of_Clubs, Value = 2},
            new Card {Name =Properties.Resources._3_of_Clubs, Value = 3},
            new Card {Name =Properties.Resources._4_of_Clubs, Value = 4},
            new Card {Name =Properties.Resources._5_of_Clubs, Value = 5},
            new Card {Name =Properties.Resources._6_of_Clubs, Value = 6},
            new Card {Name =Properties.Resources._7_of_Clubs, Value = 7},
            new Card {Name =Properties.Resources._8_of_Clubs, Value = 8},
            new Card {Name =Properties.Resources._9_of_Clubs, Value = 9},
            new Card {Name =Properties.Resources._10_of_Clubs, Value = 10},
            new Card {Name =Properties.Resources.Jack_of_Clubs, Value = 10},
            new Card {Name =Properties.Resources.Queen_of_Clubs, Value = 10},
            new Card {Name =Properties.Resources.King_of_Clubs, Value = 10},
            new Card {Name =Properties.Resources.Ace_of_Diamonds, Value = 1},
            new Card {Name =Properties.Resources._2_of_Diamonds, Value = 2},
            new Card {Name =Properties.Resources._3_of_Diamonds, Value = 3},
            new Card {Name =Properties.Resources._4_of_Diamonds, Value = 4},
            new Card {Name =Properties.Resources._5_of_Diamonds, Value = 5},
            new Card {Name =Properties.Resources._6_of_Diamonds, Value = 6},
            new Card {Name =Properties.Resources._7_of_Diamonds, Value = 7},
            new Card {Name =Properties.Resources._8_of_Diamonds, Value = 8},
            new Card {Name =Properties.Resources._9_of_Diamonds, Value = 9},
            new Card {Name =Properties.Resources._10_of_Diamonds, Value = 10},
            new Card {Name =Properties.Resources.Jack_of_Diamonds, Value = 10},
            new Card {Name =Properties.Resources.Queen_of_Diamonds, Value = 10},
            new Card {Name =Properties.Resources.King_of_Diamonds, Value = 10},
            new Card {Name =Properties.Resources.Ace_of_Hearts, Value = 1},
            new Card {Name =Properties.Resources._2_of_Hearts, Value = 2},
            new Card {Name =Properties.Resources._3_of_Hearts, Value = 3},
            new Card {Name =Properties.Resources._4_of_Hearts, Value = 4},
            new Card {Name =Properties.Resources._5_of_Hearts, Value = 5},
            new Card {Name =Properties.Resources._6_of_Hearts, Value = 6},
            new Card {Name =Properties.Resources._7_of_Hearts, Value = 7},
            new Card {Name =Properties.Resources._8_of_Hearts, Value = 8},
            new Card {Name =Properties.Resources._9_of_Hearts, Value = 9},
            new Card {Name =Properties.Resources._10_of_Hearts, Value = 10},
            new Card {Name =Properties.Resources.Jack_of_Hearts, Value = 10},
            new Card {Name =Properties.Resources.Queen_of_Hearts, Value = 10},
            new Card {Name =Properties.Resources.King_of_Hearts, Value = 10},
            new Card {Name =Properties.Resources.Ace_of_Spades, Value = 1},
            new Card {Name =Properties.Resources._2_of_Spades, Value = 2},
            new Card {Name =Properties.Resources._3_of_Spades, Value = 3},
            new Card {Name =Properties.Resources._4_of_Spades, Value = 4},
            new Card {Name =Properties.Resources._5_of_Spades, Value = 5},
            new Card {Name =Properties.Resources._6_of_Spades, Value = 6},
            new Card {Name =Properties.Resources._7_of_Spades, Value = 7},
            new Card {Name =Properties.Resources._8_of_Spades, Value = 8},
            new Card {Name =Properties.Resources._9_of_Spades, Value = 9},
            new Card {Name =Properties.Resources._10_of_Spades, Value = 10},
            new Card {Name =Properties.Resources.Jack_of_Spades, Value = 10},
            new Card {Name =Properties.Resources.Queen_of_Spades, Value = 10},
            new Card {Name =Properties.Resources.King_of_Spades, Value = 10}
        };
        List<Card> PlayerHand = new List<Card>();

        List<Card> DealerHand = new List<Card>();

        public BlackJack()
        {
            InitializeComponent();

            PlayerHand = new List<Card>();

            DealerHand = new List<Card>();

        }
        public Card GetRandomCard(List<Card> DeckofCards)
        {
            int playerRandomCard = RandomCards(DeckofCards.Count);

            return DeckofCards[playerRandomCard];
        }
        public void Draw_Click(object sender, EventArgs e)
        {
            var playerCard = GetRandomCard(DeckofCards);
            PlayerHand.Add(playerCard);
            DeckofCards.Remove(playerCard);

            if (DrawCard.Enabled = true && PlayerCounter == 0)
            {
                PlayerCard1.Visible = true;
                PlayerCard1.Image = PlayerHand[0].Name;
                PlayerCounter++;
                PlayerSum = PlayerHand[0].Value;
            }
            else if (DrawCard.Enabled = true && PlayerCounter == 1)
            {
                PlayerCard2.Visible = true;
                PlayerCard2.Image = PlayerHand[1].Name;
                PlayerCounter++;
                PlayerSum = PlayerHand[0].Value + PlayerHand[1].Value;
            }
            else if (DrawCard.Enabled = true && PlayerCounter == 2)
            {
                PlayerCard3.Visible = true;
                PlayerCard3.Image = PlayerHand[2].Name;
                PlayerCounter++;
                PlayerSum = PlayerHand[0].Value + PlayerHand[1].Value + PlayerHand[2].Value;
            }
            else if (DrawCard.Enabled = true && PlayerCounter == 3)
            {
                PlayerCard4.Visible = true;
                PlayerCard4.Image = PlayerHand[3].Name;
                PlayerCounter++;
                PlayerSum = PlayerHand[0].Value + PlayerHand[1].Value + PlayerHand[2].Value + PlayerHand[3].Value;
            }
            else if (DrawCard.Enabled = true && PlayerCounter == 4)
            {
                PlayerCard5.Visible = true;
                PlayerCard5.Image = PlayerHand[4].Name;
                PlayerCounter++;
                PlayerSum = PlayerHand[0].Value + PlayerHand[1].Value + PlayerHand[2].Value + PlayerHand[3].Value + PlayerHand[4].Value;
                
            }
            if (PlayerSum > 15)
            {
                DrawCard.Text = "Careful";
                if (PlayerSum > 21)
                {
                    DrawCard.Enabled = false;
                    DrawCard.Text = "You're over 21";
                }
            }
        }

        public void EndTurn_Click(object sender, EventArgs e)
        {

            var DealerCard = GetRandomCard(DeckofCards);
            DealerHand.Add(DealerCard);
            DeckofCards.Remove(DealerCard);

            if (DealerDraw.Enabled = true && DealerCounter == 0)
            {
                DealerCard1.Image = DealerHand[0].Name;
                DealerCounter++;
                DealerSum = DealerHand[0].Value;
            }
            else if (DealerDraw.Enabled = true && DealerCounter == 1)
            {
                DealerCard2.Image = DealerHand[1].Name;
                DealerCounter++;
                DealerSum = DealerHand[0].Value + DealerHand[1].Value;
            }
            else if (DealerDraw.Enabled = true && DealerCounter == 2)
            {
                DealerCard3.Image = DealerHand[2].Name;
                DealerCounter++;
                DealerSum = DealerHand[0].Value + DealerHand[1].Value + DealerHand[2].Value;
            }
            else if (DealerDraw.Enabled = true && DealerCounter == 3)
            {
                DealerCard4.Image = DealerHand[3].Name;
                DealerCounter++;
                DealerSum = DealerHand[0].Value + DealerHand[1].Value + DealerHand[2].Value + DealerHand[3].Value;
            }
            else if (DealerDraw.Enabled = true && DealerCounter == 4)
            {
                DealerCard5.Image = DealerHand[4].Name;
                DealerCounter++;
                DealerSum = DealerHand[0].Value + DealerHand[1].Value + DealerHand[2].Value + DealerHand[3].Value + DealerHand[4].Value;
            }
            if (DealerSum >= 15)
            {
                DealerDraw.Enabled = false;
                EndGame.Visible = true;
                if (DealerSum > 21)
                {
                    DealerDraw.Text = "You're over 21";
                }
            }
        }

        private void BlackJack_Load(object sender, EventArgs e)
        {

        }

        private void PlayerCard1_Click(object sender, EventArgs e)
        {

        }

        private static Random r = new Random();
        public static int RandomCards(int num1)
        {
            return r.Next(num1);
        }

        private void DealerCard1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            gameScore.AutoSize = true;
        }

        public void EndGame_Click(object sender, EventArgs e)
        {
            if (DealerSum > PlayerSum && DealerSum <= 21)
            {
                gameScore.Visible = true;
                gameScore.Text = $"The Dealer wins with:{DealerSum} to your:{PlayerSum}";
            }
            if (DealerSum < PlayerSum && PlayerSum <= 21)
            {
                gameScore.Visible = true;
                gameScore.Text = $"The Player wins with:{PlayerSum} to the Dealers:{DealerSum}";
            }
            if (DealerSum > 21 && PlayerSum > 21)
            {
                gameScore.Visible = true;
                gameScore.Text = "Both players Bust and no one wins!";
            }
            if (PlayerSum > 21 && DealerSum < 21)
            {
                gameScore.Visible = true;
                gameScore.Text = "The player bust so the Dealer wins!";
            }
            if (DealerSum > 21 && PlayerSum < 21)
            {
                gameScore.Visible = true;
                gameScore.Text = "The Dealer bust so the Player wins!";
            }
            if (DealerSum == PlayerSum)
            {
                gameScore.Visible = true;
                gameScore.Text = "The dealer and the player draw!";
            }
        }
    }
}
