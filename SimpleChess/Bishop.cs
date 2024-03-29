﻿using System;

namespace SimpleChess
{
    public class Bishop : Piece
    {

        public string type = "Bishop";


        public Bishop()
        {
            Symbol = "LPR";
        }

        public override bool Move(string fromPosition, string toPosition)
        {
            if (type == "Bishop")
            {
                var diffCol = fromPosition[0] - toPosition[0];
                var diffRow = fromPosition[1] - toPosition[1];
                return Math.Abs(diffRow) == Math.Abs(diffCol);
            }
            return true;
        }

    }
}
