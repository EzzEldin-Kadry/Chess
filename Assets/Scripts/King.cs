using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : Chessman
{
    public override bool[,] possibleMoves()
    {
        bool[,] r = new bool[8, 8];
        Chessman c;
        int i, j;
        //Top Sides
        i = currentX - 1;
        j = currentY + 1;
        if(currentY != 7)
        {
            for(int k=0;k<3 ;k++)
            {
                if(i>=0 || i<8)
                {
                    c = Board_Manager.Instance.Chessmans[i, j];
                    if (c == null)
                        r[i, j] = true;
                    else if (isWhite != c.isWhite)
                        r[i, j] = true;
                }
                i++;
            }
        }
        //down Sides
        i = currentX - 1;
        j = currentY - 1;
        if (currentY != 0)
        {
            for (int k = 0; k < 3; k++)
            {
                if (i >= 0 || i < 8)
                {
                    c = Board_Manager.Instance.Chessmans[i, j];
                    if (c == null)
                        r[i, j] = true;
                    else if (isWhite != c.isWhite)
                        r[i, j] = true;
                }
                i++;
            }

        }

        //left
        if(currentX!=0)
        {
            c = Board_Manager.Instance.Chessmans[currentX - 1, currentY];
            if (c == null)
                r[currentX - 1, currentY] = true;
            else if (isWhite != c.isWhite)
                r[currentX - 1, currentY] = true;

        }
        //right
        if (currentX != 7)
        {
            c = Board_Manager.Instance.Chessmans[currentX + 1, currentY];
            if (c == null)
                r[currentX + 1, currentY] = true;
            else if (isWhite != c.isWhite)
                r[currentX + 1, currentY] = true;

        }
        return r;
    }
}
