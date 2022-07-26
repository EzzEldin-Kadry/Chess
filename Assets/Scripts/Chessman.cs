using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Chessman : MonoBehaviour
{
    public int currentX{ set; get; }
    public int currentY{ set; get; }
    public bool isWhite;

    public void SetPosition(int x, int y)
    {
        currentX = x;
        currentY = y;
    }
    public virtual bool [,] possibleMoves()
    {
        print("Return boolean");
        return new bool[8,8];
    }

}
