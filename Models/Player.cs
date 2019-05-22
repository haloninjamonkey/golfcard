namespace golfcard.Models
{
    public class Player
    {
        public readonly string Name;
        public Course Course { get; set; }
        public int Score { get; set; }

        public Player(string name, Course course, int score)
        {
            Name = name;
            Course = course;
            Score = score;
        }
    
    }

    

}