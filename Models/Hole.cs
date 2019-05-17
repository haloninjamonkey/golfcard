using System.Collections.Generic;

namespace golfcard.Models
{
    public class Hole
    {
        //make a list of the par for each hole
        public int Par { get; set; }
        //make a list of the actual player score for each hole
        //public int Score { get; set; }

        public Hole(int par)
        {
            Par = par;
        }

    }
}