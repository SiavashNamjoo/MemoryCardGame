using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private void Update()
    {
        StartGame();
    }

    private void StartGame()
    {
       Card card = new Card(5);
       Debug.Log(card.Value);
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
