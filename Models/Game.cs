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
               System.Console.WriteLine($"{course.Key.Location}. {course.Value[0].Par} {course.Key.Holes}");
            }
            System.Console.WriteLine("Which course would you like to play today?");
            // SelectCourse();
        } 
        

        // public void SelectCourse()
        // {
        //     Course targetCourse;
        //     while(!Enum.TryParse(Console.ReadLine(), out targetCourse))
        //     {
        //         System.Console.WriteLine("Not a valid course");
        //     }
        // }
            

        
        public Game(string name)
        {
            Name = name;
            // NumPlayers = numplayers;
            // CourseChoice = courseChoice;
        }
    }

}