using System;
using System.Collections.Generic;
using golfcard.Models;

namespace golfcard
{
    class Program
    {
        static void Main(string[] args)
        {
            // var hole1 = 1;
            // var aNatHoles = new List<Hole>();
            var augusta = new Course(72, 18, Name.Augusta);
            var pebble = new Course(72, 18, Name.Pebble);
            var plantation = new Course(72, 18, Name.Plantation);
            var qHollow = new Course(36, 9, Name.QuailHollow);
            var myFirstTry = new Game("First try");
            myFirstTry.CourseChoice.Add(augusta);
            myFirstTry.CourseChoice.Add(pebble);
            myFirstTry.CourseChoice.Add(plantation);
            myFirstTry.CourseChoice.Add(qHollow);


            Console.Clear();
            // System.Console.WriteLine("{0} has {1} holes and a par of {2}", augusta.Name, augusta.Holes, augusta.Par);
            myFirstTry.ShowGreeting();
            Console.ReadLine();
        }
    }
}
