using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    private bool isFacedUp = false;
    public int Value;
    
    private int GetValue()
    {
        return Value;
    }
    public Card(int value)
    {
        Value = value;
    }
}
