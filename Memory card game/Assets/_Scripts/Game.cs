using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class Game : MonoBehaviour
{
    private Deck deck = new Deck(new List<Card>());
    private Card card = new Card(4);
    private List<Card> cards = new List<Card>();
    private int firstInput = -1;
    private int secondInput = -1;
    private bool allCardsOn = false;
    
    private void Start()
    {
       StartGame();
    }
    private void StartGame()
    {
        for (var i = 0; i < 5; i++)
        {
            int cardNumber = Random.Range(1, 101);
            deck.AddCard(cardNumber);
            deck.AddCard(cardNumber);
        }
        deck.GenerateRandomCard();
        deck.DisplayDeck();        
    }

    public void OnButtonClick(int index)
    {
        deck.OnButtonClick(index);
    }
   
    
    private void Update()
    {
      
    }
}
