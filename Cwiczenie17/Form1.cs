using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cwiczenie17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Game game;
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textName.Text))
            {
                MessageBox.Show("Wpisz swoje imię", "Nie mozna jescze rozpocząć gry.");
                return;
            }
            game = new Game(textName.Text, new List<string> { "Janek", "Bartek" }, textProgress);
            buttonStart.Enabled = false;
            textName.Enabled = false;
            buttonAsk.Enabled = true;
            UpdateForm();
        }
        private void UpdateForm() {
            listHand.Items.Clear();
            foreach (String cardName in game.GetPlayerCardNames())
                listHand.Items.Add(cardName);
            textBooks.Text = game.DescribeBooks();
            textProgress.Text += game.DescribePlayerHands();
            textProgress.SelectionStart = textProgress.Text.Length;
            textProgress.ScrollToCaret();
        }

        private void buttonAsk_Click(object sender, EventArgs e)
        {
            textProgress.Text = " ";
            if(listHand.SelectedIndex < 0)
            {
                MessageBox.Show("Wybierz kartę.");
                return;
            }
            if (game.PlayOneRound(listHand.SelectedIndex))
            {
                textProgress.Text += "Zwycięzcą jest... " + game.GetWinnerName();
                textBooks.Text = game.DescribeBooks();
                buttonAsk.Enabled = false;
            }
            else
                UpdateForm();
        }
        public Card Peek(int cardNumber)
        {
            return cards[cardNumber];
        }
       
        public Card Deal()
        {
            return Deal(0);
        }
        public bool ContainsValue(Values value)
        {
            foreach (Card card in cards)
                if (card.Value == value)
                    return true;
            return false;
        }
        public Deck PullOutValues(Values value)
        {
            Deck deckToReturn = new Deck(new Card[] { });
            for (int i = cards.Count - 1; i >= 0; i--)
                if (cards[i].Value == value)
                    deckToReturn.Add(Deal(i));
            return deckToReturn;
        }
        public bool HasBook(Values value)
        {
            int NumberOfCards = 0;
            foreach (Card card in cards)
                if (card.Value == value)
                    NumberOfCards++;
            if (NumberOfCards == 4)
                return true;
            else
                return false;
        }
        public void SortByValue()
        {
            cards.Sort(new CardComparer_byValue());
        }
    }
}
