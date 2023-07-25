using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Random = UnityEngine.Random;
// lambda  ??? chat-gpt ;) RemoveCard method
public class Deck
{
    public List<Card> cards;
    public List<bool> isCardsHidden; 
    public int GetCardCount()
    {
        return cards.Count;
    }
    public void RemoveEqualNumbers(List<Card> card, int num1, int num2)
        {
            if (num1 == num2)
            {
                card.RemoveAll(num => num1 == num2);
            }
            else
            {
                Debug.Log("Numbers you choose in not equal try again!");
            }
        }
    public Deck(List<Card> cards)
    {
        this.cards = cards;
        this.isCardsHidden = new List<bool>();
        for (int i = 0; i < isCardsHidden.Count; i++)
        {
            isCardsHidden.Add(true);
        }
    }
    public void GenerateRandomCard()
    {
       System.Random random = new System.Random();
        var index = cards.Count;
        while (index > 1)
        {
            index--;
            int k = random.Next(index + 1);
            (cards[k], cards[index]) = (cards[index], cards[k]);
        }
    }
    public void AddCard(int value)
    {
        cards.Add(new Card(value));
        cards.Add(new Card(value));
    }
    
    
    public void HideCard(int index)
    {
        var card = cards[index];
        Debug.Log(cards[index].Value);
    }

    public void HideAllCards()
    {
        for (int i = 0; i < isCardsHidden.Count; i++)
        {
            isCardsHidden.Add(false);
        }
    }

    public void TurnOnCard(int index)
    {
        var card = cards[index];
        Debug.Log(card.Value);
    }

    public void TrunOnAllCard()
    {
        for (int i = 0; i < isCardsHidden.Count; i++)
        {
            isCardsHidden.Add(true);
        }
    }

    public void DisplayDeck()
    {
        for (var i = 0; i < cards.Count; i++)
        {
            var card = cards[i];
            if (isCardsHidden[i])
                Debug.Log(i);
            else
                Debug.Log(cards[i].Value);
        }
    }
}
