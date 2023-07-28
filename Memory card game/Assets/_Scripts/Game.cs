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
    private int InputCount = 0;
    private int firstInput = -1;
    private int secondInput = -1;

    private void Start()
    {
       StartGame();
    }

    private void Update()
    {
      
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
        if (InputCount < 2)
        {
            if (InputCount == 0)
            {
                firstInput = index;
                deck.TurnOnCard(firstInput);
            }
            else if (InputCount == 1)
            {
                secondInput = index;
                deck.TurnOnCard(secondInput);
            }
            InputCount++;
            if (InputCount == 2)
            {
                CompareNumber();
            }
        }
    }

    private void CompareNumber()
    {
        var firstChoise = deck.GetCardNumber(firstInput);
        var secondChoise = deck.GetCardNumber(secondInput);
        if (firstChoise == secondChoise)
        {
            Debug.Log("Great Guess! Number you choose is equal!");
            deck.RemoveEqualNumbers(firstChoise);
        }
        else
        {
            Debug.Log("That was not right. Try Again!");
        }
        firstInput = -1;
        secondInput = -2;
        InputCount = 0;
        deck.DisplayDeck();
    }
}
