using System;
using System.Collections.Generic;
namespace golfcard.Models
{
    public class Game
    {
        public string Name { get; set; }
        // public List<Players> NumPlayers { get; set; } = new List<Players>();
        // public List<Course> CourseChoice { get; set; } = new List<Course>();
        public List<Course> Courses = new List<Course>();
        public List<Hole> ScorePerHole { get; set; } = new List<Hole>();
        public Player ActivePlayer { get; set; }
        public Course ActiveCourse { get; set; }

        public void GameSetup()
        {
            #region course and hole data
            var augustaHoles = new List<Hole>();
            var pebbleHoles = new List<Hole>();
            var plantationHoles = new List<Hole>();
            var qHollowHoles = new List<Hole>();

            var hole1 = new Hole(4);
            var hole2 = new Hole(5);
            var hole3 = new Hole(4);
            var hole4 = new Hole(3);
            var hole5 = new Hole(4);
            var hole6 = new Hole(3);
            var hole7 = new Hole(4);
            var hole8 = new Hole(5);
            var hole9 = new Hole(4);
            var hole10 = new Hole(4);
            var hole11 = new Hole(4);
            var hole12 = new Hole(3);
            var hole13 = new Hole(5);
            var hole14 = new Hole(4);
            var hole15 = new Hole(5);
            var hole16 = new Hole(3);
            var hole17 = new Hole(4);
            var hole18 = new Hole(4);

            augustaHoles.Add(hole1);
            augustaHoles.Add(hole2);
            augustaHoles.Add(hole3);
            augustaHoles.Add(hole4);
            augustaHoles.Add(hole5);
            augustaHoles.Add(hole6);
            augustaHoles.Add(hole7);
            augustaHoles.Add(hole8);
            augustaHoles.Add(hole9);
            augustaHoles.Add(hole10);
            augustaHoles.Add(hole11);
            augustaHoles.Add(hole12);
            augustaHoles.Add(hole13);
            augustaHoles.Add(hole14);
            augustaHoles.Add(hole15);
            augustaHoles.Add(hole16);
            augustaHoles.Add(hole17);
            augustaHoles.Add(hole18);
            pebbleHoles.Add(hole1);
            pebbleHoles.Add(hole2);
            pebbleHoles.Add(hole3);
            pebbleHoles.Add(hole4);
            pebbleHoles.Add(hole5);
            pebbleHoles.Add(hole6);
            pebbleHoles.Add(hole7);
            pebbleHoles.Add(hole8);
            pebbleHoles.Add(hole9);
            plantationHoles.Add(hole1);
            plantationHoles.Add(hole2);
            plantationHoles.Add(hole3);
            plantationHoles.Add(hole4);
            plantationHoles.Add(hole5);
            plantationHoles.Add(hole6);
            plantationHoles.Add(hole7);
            plantationHoles.Add(hole8);
            plantationHoles.Add(hole9);
            plantationHoles.Add(hole10);
            plantationHoles.Add(hole11);
            plantationHoles.Add(hole12);
            plantationHoles.Add(hole13);
            plantationHoles.Add(hole14);
            plantationHoles.Add(hole15);
            plantationHoles.Add(hole16);
            plantationHoles.Add(hole17);
            plantationHoles.Add(hole18);
            qHollowHoles.Add(hole1);
            qHollowHoles.Add(hole2);
            qHollowHoles.Add(hole3);
            qHollowHoles.Add(hole4);
            qHollowHoles.Add(hole5);
            qHollowHoles.Add(hole6);
            qHollowHoles.Add(hole7);
            qHollowHoles.Add(hole8);
            qHollowHoles.Add(hole9);
            var augusta = new Course(augustaHoles.Count, "Augusta");
            var pebble = new Course(pebbleHoles.Count, "Pebble");
            var plantation = new Course(plantationHoles.Count, "Plantation");
            var qHollow = new Course(qHollowHoles.Count, "Quail Hollow");
            Courses.Add(augusta);
            Courses.Add(pebble);
            Courses.Add(plantation);
            Courses.Add(qHollow);
            #endregion
            System.Console.WriteLine("What's your name? ");
            string userInput = Console.ReadLine();
            ActivePlayer = new Player(userInput,ActiveCourse, 0);
            ShowGreeting();
        }
        public void ShowGreeting()
        {
            System.Console.WriteLine("Welcome to the golf game!");
            DisplayCourses();
        }

        public void DisplayCourses()
        {
            int i = 1;
            System.Console.WriteLine("Here are the course choices: ");
            foreach (Course course in Courses)
            {
                System.Console.WriteLine($"{course.Location}: {course.Holes} holes");
                i++;
            }

            SelectCourse();
        }


        public void StartGame(Player player, Course course)
        {
            
        }


        public void SelectCourse()
        {
            string chosenCourse;
            System.Console.WriteLine($"{ActivePlayer.Name}, which course would you like to play today?");
            chosenCourse = Console.ReadLine().ToLower();
            switch (chosenCourse)
            {
                case "augusta":
                    break;
                case "pebble":
                    System.Console.WriteLine("You have chosen Pebble");
                    break;
                case "plantation":
                    System.Console.WriteLine("You have chosen Plantation");
                    break;
                case "quail hollow":
                    System.Console.WriteLine("You have chosen Quail Hollow");
                    break;
                default:
                    System.Console.WriteLine("That is not a valid choice, please try again.");
                    SelectCourse();
                    break;
            }
        }
    }

}