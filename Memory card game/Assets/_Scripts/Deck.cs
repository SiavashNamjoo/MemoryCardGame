using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Deck
{
    public List<Card> card = new List<Card>();

    public void EqualCard(int card1, int card2)
    {
        if (card1 == card2)
        {
            
        }
        else
        {
            Debug.Log("Try again!");
        }
    }

    private void GenerateRandomCard()
    {
        int n = card.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            Card temp = card[k];
            card[k] = card[n];
            card[n] = temp;
        }
    }
}
