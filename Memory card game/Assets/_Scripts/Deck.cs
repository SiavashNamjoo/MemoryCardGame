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
    private List<int> cardIndex;

    public int GetCardCount()
    {
        return card.Count;
    }

    public void IsEqual()
    {
        for (int i = 0; i < card.Count; i++)
        {
            for (int j = 0; j < card.Count; j++)
            {
                if (!card[i].isMatched && !card[j].isMatched && card[i].value == card[j].value)
                {
                    card[i].isMatched = true;
                    card[j].isMatched = true;
                    break;
                }
            }
        }
    }

    void RemoveCard()
    {
        IsEqual();
        card.RemoveAll(_card => _card.isMatched);
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
}
