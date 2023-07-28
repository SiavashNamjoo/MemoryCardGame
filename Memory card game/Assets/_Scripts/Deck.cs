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
    private List<Card> cards;
    public List<bool> isCardsHidden;
    
    public Deck(List<Card> cards)
    {
        this.cards = cards;
        this.isCardsHidden = new List<bool>();
        for (int i = 0; i < cards.Count; i++)
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

    public int GetCardNumber(int index)
    {
        if (index >= 0 && index < cards.Count)
        {
            return cards[index].Value;
        }

        return -1;
    }

    public void RemoveEqualNumbers(int number)
    {
        for (int i = 0; i < cards.Count; i++)
        {
            if (cards[i].Value != number)
            {
                cards.Add(cards[i]);
                isCardsHidden.Add(true);
            }
        }
    }

    public void TurnOffCard(int index)
    {
        isCardsHidden[index] = true;
    }

    public void TurnOffAllCards()
    {
        for (int i = 0; i < isCardsHidden.Count; i++)
        {
            isCardsHidden[i] = true;
        }
    }

    public void TurnOnCard(int index)
    {
        isCardsHidden[index] = false;

    }

    public void TrunOnAllCard()
    {
        for (int i = 0; i < isCardsHidden.Count; i++)
        {
            isCardsHidden[i] = false;
        }
    }
    public void DisplayDeck()
    {
        for (var i = 0; i < cards.Count; i++)
        {
            var card = cards[i];
            if (isCardsHidden[i])
                Debug.Log("Card " + i + " Hidden");
            else
                Debug.Log("Card Value: " + cards[i].Value);
        }
    }
    public void AddCard(int value)
    {
        cards.Add(new Card(value));
        isCardsHidden.Add(true);
    }
    
}
