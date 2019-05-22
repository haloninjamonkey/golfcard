using System.Collections.Generic;

namespace golfcard.Models
{
    public class Hole
    {
        //make a list of the par for each hole
        public int Par { get; private set; }

        public Hole(int par)
        {
            Par = par;
        }

    }
}