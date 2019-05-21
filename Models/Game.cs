using System;
using System.Collections.Generic;
namespace golfcard.Models
{
    public class Game
    {
        public string Name { get; set; }
        // public List<Players> NumPlayers { get; set; } = new List<Players>();
        // public List<Course> CourseChoice { get; set; } = new List<Course>();
        public Dictionary<Course,List<Hole>> Courses = new Dictionary<Course, List<Hole>>();
        public List<Hole> ScorePerHole { get; set; } = new List<Hole>();

        
        public void ShowGreeting()
        {   
            System.Console.WriteLine("Welcome to the golf game!");
            System.Console.WriteLine("Which course would you like to play?");
        }

        public void DisplayCourses()
        {
            System.Console.WriteLine("Here are the course choices: ");
            foreach(KeyValuePair<Course, List<Hole>> course in Courses){
               System.Console.WriteLine(value: $"{(int)course.Key.Location}. {course.Key.Location}: {course.Value.Count} holes");
            }
            System.Console.WriteLine("Which course would you like to play today?");
            SelectCourse();
            PlayerScore(PlayerCount());
        } 
        
        public void SelectCourse()
        {   
            Location targetCourse;
            try
            {
                while(!Enum.TryParse(Console.ReadLine(), true, out targetCourse))
                {
                    System.Console.WriteLine("Not a valid Course, please choose a different course.");
                }
                System.Console.WriteLine("You have chosen " + targetCourse);
            } 
            catch(KeyNotFoundException)
            {
                System.Console.WriteLine("Not a valid choice");
                System.Console.WriteLine("Please enter another choice");
                SelectCourse();
            }
            
        }

        public int PlayerCount()
        {
            int playerInt;
            System.Console.WriteLine("How many players are in this game? ");
            string playerStr = Console.ReadLine();
            bool goodNum = Int32.TryParse(playerStr, out playerInt);
            if(!goodNum || playerInt <= 0)
            {
                System.Console.WriteLine("Please use numbers greater than 0 to select player count");
            }
            return playerInt;
        }

        public void PlayerScore(int players)
        {
            int totalScore;
            for(int i = players; i > 0; i--){
                int holeScoreInt = 0;
                System.Console.WriteLine("Please enter your score ");
                string holeScoreStr = Console.ReadLine();
                bool goodScore = Int32.TryParse(holeScoreStr, out holeScoreInt);
                totalScore = holeScoreInt;
                System.Console.WriteLine(totalScore);
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