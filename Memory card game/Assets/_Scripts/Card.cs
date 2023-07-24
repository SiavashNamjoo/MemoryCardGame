using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Card
{
    public int value;
    public bool isMatched;
    
    
    public Card(int value)
    {
        this.value = value;
        isMatched = false;
    }
}
