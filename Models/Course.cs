using System.Collections.Generic;

namespace golfcard.Models
{
    public enum Location 
    { 
        Augusta = 1,
        Pebble,
        Plantation,
        QuailHollow

    } 
    public class Course
    {
        // public int NumHoles { get; set; }
        public int Par { get; private set; }
        public int Holes { get; set; }
        public Location Location { get; set; }

        
        
        public Course(int par, int holes, Location location)
        {
            Par = par;
            Holes = holes;
            Location = location;       
        }           
        
    }
    
}