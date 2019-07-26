using System.Runtime.InteropServices;

namespace SimpleChess
{
     public class Rook : Piece
    {
       public string type = "Rook";


        public Rook()
        {
            Symbol = "TRN";
        }

        public override bool Move(string fromPosition, string toPosition)
        {
            if (type == "Rook") return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
            return true;
        }
    }
}
