using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : Chessman
{
    public override bool[,] possibleMoves()
    {
        bool[,] r = new bool[8, 8];

        //moves :(
        //up left
        KnightMove(currentX - 1, currentY + 2, ref r);

        //up right
        KnightMove(currentX + 1, currentY + 2, ref r);

        //right up
        KnightMove(currentX + 2, currentY + 1, ref r);

        //right down
        KnightMove(currentX + 2, currentY - 1, ref r);

        //down left
        KnightMove(currentX - 1, currentY - 2, ref r);

        //down right
        KnightMove(currentX + 1, currentY - 2, ref r);

        //left up
        KnightMove(currentX - 2, currentY + 1, ref r);

        //left down
        KnightMove(currentX - 2, currentY - 1, ref r);
        return r;
    }

    public void KnightMove(int x, int y, ref bool[,] r)
    {
        Chessman c;
        if(x >= 0 && x < 8 && y>=0 && y<8)
        {
            c = Board_Manager.Instance.Chessmans[x, y];
            if (c == null)
                r[x, y] = true;
            else if (isWhite != c.isWhite)
                r[x, y] = true;
        }
    }
}
