using System.Collections.Generic;

namespace golfcard.Models
{
    public class Player
    {
        public string Name { get; set; }
        // public Course Course { get; set; }
        public List<int> Scores { get; set; } = new List<int>();

        public Player(string name)
        {
            Name = name;
            // Course = course;
            // Scores = score;
        }
    

    }

    

}