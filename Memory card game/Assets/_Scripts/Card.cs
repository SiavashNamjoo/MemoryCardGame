using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Card
{
    private int value;
    public bool isMatched;

    public int Value => value;

    public Card(int value)
    {
        this.value = value;
        isMatched = false;
    }
}
