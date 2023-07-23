using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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

    public void GenerateRandomCard()
    {
        
        int index = card.Count;
        
        while (index > 1)
        {
            index--;
            int k = Random.Range(0, index + 1);
            Card temp = card[k];
            card[k] = card[index];
            card[index] = temp;
        }
    }
}
