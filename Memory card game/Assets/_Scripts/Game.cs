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
        
    }

    private void Update()
    {
        // If one of the inputs is -1
            // return;
        // Else
            // Show card[firstInput] and card[SecondInput] : TurnOn
            // Check card[firstInput] and card[SecondInput]
                // If they're equal
                    // Check if all the cards are on
                        // If they're all on
                            // Log YOU WIN
                            // return
                // Else
                    // TurnOff
        if (firstInput == -1 || secondInput == -1)
        {
            return;
        }
        else
        {
            deck.TurnOnCard(firstInput); 
            deck.TurnOnCard(secondInput);
            if (!allCardsOn)
            {
                Debug.Log("You win!!");
                return;
            }
            else
            {
                deck.TurnOffAllCards();
                return;
            }
        }
    }
}
