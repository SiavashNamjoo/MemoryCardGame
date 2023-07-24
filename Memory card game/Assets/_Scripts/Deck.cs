using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Random = UnityEngine.Random;

public class Deck
{
    public List<Card> card;
    private List<int> cardIndex;

    public int GetCardCount()
    {
        return card.Count;
    }

    public bool IsEqual()
    {
        card = new List<Card>();
        if (card.Count == 2)
        {
            Card i = card[cardIndex[0]];
            Card j = card[cardIndex[1]];
            if (i == j)
            {
                RemoveCard();
                return true;
            }
            else
            {
                Debug.Log("Try Again!!");
            }
        }

        return false;
    }

    void RemoveCard()
    {
        foreach (int index in cardIndex)
        {
            card.RemoveAt(index);
        }
    }
    public Deck(List<Card> card)
    {
        this.card = card;
    }
    
    public void GenerateRandomCard()
    {
       System.Random random = new System.Random();
        var index = card.Count;

        while (index > 1)
        {
            index--;
            int k = random.Next(index + 1);
            (card[k], card[index]) = (card[index], card[k]);
        }
    }

    private void AddCard(int value)
    {
        card.Add(new Card(value));
        card.Add(new Card(value));
    }
}
