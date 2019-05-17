using System;
using System.Collections.Generic;
namespace golfcard.Models
{
    public class Game
    {
        public string Name { get; set; }
        // public List<Players> NumPlayers { get; set; } = new List<Players>();
        public List<Course> CourseChoice { get; set; } = new List<Course>();
        public List<Hole> ScorePerHole { get; set; } = new List<Hole>();

        public void ShowGreeting()
        {   
            int i = 1;
            System.Console.WriteLine("Welcome to the golf game! Which course would you like to play today?");
            foreach(var course in CourseChoice){
                System.Console.WriteLine(i + ": " + course.Name);
                i++;
            }
        }

        
        public Game(string name)
        {
            Name = name;
            // NumPlayers = numplayers;
            // CourseChoice = courseChoice;
        }
    }

}