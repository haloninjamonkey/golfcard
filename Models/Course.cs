using System.Collections.Generic;

namespace golfcard.Models
{
    // public enum Location 
    // { 
    //     Augusta = 1,
    //     Pebble,
    //     Plantation,
    //     QuailHollow

    // } 
    public class Course
    {
        // public int NumHoles { get; set; }
        public int Par { get; private set; }
        public int Holes { get; set; }
        public string Location { get; set; }

        
        
        public Course(int holes, string location)
        {
            Holes = holes;
            Location = location;       
        }           
        
    }
    
}