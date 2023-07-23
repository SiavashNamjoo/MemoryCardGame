using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Game : MonoBehaviour
{
   
    private void Start()
    {
        Deck deck = new Deck(new List<Card>(){new Card(0), new Card(1),new Card(2),new Card(3),new Card(4),new Card(5),new Card(6),new Card(7)});
        deck.GenerateRandomCard();
        foreach (var card in deck.card)
        {
            Debug.Log(card.Value);
        }
    }

    private static void  StartGame()
    {
        //TODO: Make 10 cards, 5 of each
        
    }

    private void EndGame()
    {
        
    }

    public void CountScore()
    {
        
    }

    public int GetScore()
    {
        return 2;
    }
}
