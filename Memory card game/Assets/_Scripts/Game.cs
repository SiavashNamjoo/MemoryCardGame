using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class Game : MonoBehaviour
{
    private Deck deck = new Deck(new List<Card>(1));
    private void Start()
    {
       StartGame();
       
    }

    private void Update()
    {
        
    }

    private void StartGame()
    {
        //TODO: Make 10 cards, 5 of each
        for (var i = 1; i <= 5; i++)
        {
            deck.AddCard(Random.Range(1, 101));
        }
        
        deck.GenerateRandomCard();
        
        foreach (var card in deck.card)
        {
            deck.HideNumbers();
            
        }  // nafahmidam chi shod :/
          
        Debug.Log(deck.GetCardCount());
    }

    private void EndGame()
    {
    }

    public void CountScore()
    {
        
    }

   
}
