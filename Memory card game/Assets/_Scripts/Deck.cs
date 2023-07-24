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
    public List<Card> card;
    

    public int GetCardCount()
    {
        return card.Count;
    }

    public void IsEqual()
    {
        foreach (var t in card)
        {
            foreach (var t1 in card)
            {
                if (!t.isMatched && !t1.isMatched && t.value == t1.value)
                {
                    t.isMatched = true;
                    t1.isMatched = true;
                    break;
                }
            }
        }
    }

    public void RemoveCard()
    {
        IsEqual();
        for (int i = card.Count - 1; i >= 0; i--)
        {
            if (card[i].isMatched)
            {
                card.RemoveAt(i);
            }
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

    public void AddCard(int value)
    {
        card.Add(new Card(value));
        card.Add(new Card(value));
    }

    public void HideNumbers()
    {
        for (int i = 0; i < card.Count; i++)
        
            Debug.Log("Card number: " + i + card[i].value);
        
    }
}
