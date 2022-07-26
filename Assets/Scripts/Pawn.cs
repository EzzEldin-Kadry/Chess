using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : Chessman
{
    public override bool[,] possibleMoves()
    {
        bool[,] r = new bool[8, 8];
        Chessman c, c2;
        //White team move pawn
        if(isWhite)
        {
            //Diagonal left
            if(currentX!=0 && currentY!=7)
            {
                c = Board_Manager.Instance.Chessmans[currentX-1 , currentY+1] ;
                if(c!= null&& !c.isWhite)
                {
                    r[currentX - 1, currentY + 1] = true;
                }
            }
            //Diagonal Right
            if (currentX != 7 && currentY != 7)
            {
                c = Board_Manager.Instance.Chessmans[currentX + 1, currentY + 1];
                if (c != null && !c.isWhite)
                {
                    r[currentX + 1, currentY + 1] = true;
                }
            }
            //Middle 
            if(currentY!=7)
            {
                c = Board_Manager.Instance.Chessmans[currentX, currentY + 1];
                if (c == null)
                    r[currentX, currentY + 1] = true;
            }
            //Middl on first move
            if(currentY==1)
            {
                c = Board_Manager.Instance.Chessmans[currentX, currentY + 1];
                c2 = Board_Manager.Instance.Chessmans[currentX, currentY + 2];
                if (c == null && c2 == null)
                    r[currentX, currentY + 2] = true;
            }
        }
        else
        {
            //Diagonal left
            if (currentX != 0 && currentY != 0)
            {
                c = Board_Manager.Instance.Chessmans[currentX - 1, currentY - 1];
                if (c != null && c.isWhite)
                {
                    r[currentX - 1, currentY - 1] = true;
                }
            }
            //Diagonal Right
            if (currentX != 7 && currentY != 0)
            {
                c = Board_Manager.Instance.Chessmans[currentX + 1, currentY - 1];
                if (c != null && c.isWhite)
                {
                    r[currentX + 1, currentY - 1] = true;
                }
            }
            //Middle 
            if (currentY != 0)
            {
                c = Board_Manager.Instance.Chessmans[currentX, currentY - 1];
                if (c == null)
                    r[currentX, currentY - 1] = true;
            }
            //Middl on first move
            if (currentY == 6)
            {
                c = Board_Manager.Instance.Chessmans[currentX, currentY - 1];
                c2 = Board_Manager.Instance.Chessmans[currentX, currentY - 2];
                if (c == null && c2 == null)
                    r[currentX, currentY - 2] = true;
            }
        }
        return r;
    }
}
