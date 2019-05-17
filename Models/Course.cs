using System.Collections.Generic;

namespace golfcard.Models
{
    public enum Name 
    { 
        Augusta = 1,
        Pebble,
        Plantation,
        QuailHollow

    } 
    public class Course
    {
        // public int NumHoles { get; set; }
        public int Par { get; set; }
        public int Holes { get; set; }
        public Name Name { get; set; }

        
        
        public Course(int par, int holes, Name name)
        {
            Par = par;
            Holes = holes;
            Name = name;
        }

        
    }
    
}