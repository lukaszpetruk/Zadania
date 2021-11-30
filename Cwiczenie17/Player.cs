using System;
using System.Collections.Generic;
using System.Text;

namespace Cwiczenie17
{
    class Player
    {
        public Player(string name, Random random, TextBox textBoxOnForm)
        {
            this.name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;
            this.cards = new Deck(new Card[] { });
            textBoxOnForm.Text += name + " przyłączył się do gry " + Environment.NewLine;
        }
        public Values GetRandomValue()
        {
            Card randomCard = cards.PullOutValues(value);
            textBoxOnForm.Text += Name + " ma " + cardsIHave.Count + " " + Card.Plural(value, cardsIHave.Count) + Environment.NewLine;
            return cardsIHave;
        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            if (stock.Count > 0)
            {
                if (cards.Count == 0)
                    cards.Add(stock.Deal());
                Values randomValue = GetRandomValue();
                AskForACard(players, myIndex, stock, randomValue);
            }
        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            textBoxOnForm.Text += Name + " pyta , czy ktoś ma " + Card.Plural(value, 1) + Environment.NewLine;
            int totalCardsGiven = 0;
            for (int i = 0; i < players.Count; i++)
            {
                if (i != myIndex)
                {
                    Player player = players[i];
                    Deck CardsGiven = player.DoYouHaveAny(value);
                    totalCardsGiven += CardsGiven.Count;
                    while (CardsGiven.Count > 0)
                        cards.Add(CardsGiven.Deal());
                }
            }
            if (totalCardsGiven == 0)
            {
                textBoxOnForm.Text = Name + " pobrał kartkę z kupki." + Environment.NewLine;
                cards.Add(stock.Deal());
            }
        }
    }
}
