using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : Chessman
{
    public override bool[,] possibleMoves()
    {
        bool[,] r = new bool[8, 8];

        Chessman c;
        int i;
        //right
        i = currentX; // allowed moves
        while (true)
        {
            i++;
            if (i >= 8)
                break;

            c = Board_Manager.Instance.Chessmans[i, currentY];
            if (c == null)
                r[i, currentY] = true;
            else
            {
                if (c.isWhite != isWhite)
                    r[i, currentY] = true;
                break;
            }
        }

        //left
        i = currentX; // allowed moves
        while (true)
        {
            i--;
            if (i < 0)
                break;

            c = Board_Manager.Instance.Chessmans[i, currentY];
            if (c == null)
                r[i, currentY] = true;
            else
            {
                if (c.isWhite != isWhite)
                    r[i, currentY] = true;
                break;
            }
        }

        //up
        i = currentY; // allowed moves
        while (true)
        {
            i++;
            if (i >= 8)
                break;

            c = Board_Manager.Instance.Chessmans[currentX, i];
            if (c == null)
                r[currentX, i] = true;
            else
            {
                if (c.isWhite != isWhite)
                    r[currentX, i] = true;

                break;
            }
        }

        //down
        i = currentY; // allowed moves
        while (true)
        {
            i--;
            if (i < 0)
                break;

            c = Board_Manager.Instance.Chessmans[currentX, i];
            if (c == null)
                r[currentX, i] = true;
            else
            {
                if (c.isWhite != isWhite)
                    r[currentX, i] = true;

                break;
            }
        }
        return r;
    }

}
