using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space : MonoBehaviour
{
    public int column;
    public bool filled;
    public int suit;
    public int number;
    public int honor = 0;

    void Assign(int suitA, int numberA, int honorA)
    {
        if (honorA == 0)
        {
            suit = suitA; number = numberA;

        }
        else
        {
            honor = honorA;
        }
        filled = true;

    }
}
