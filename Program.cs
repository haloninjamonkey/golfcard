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
            var augusta = new Course(72, 18, Location.Augusta);
            var pebble = new Course(72, 18, Location.Pebble);
            var plantation = new Course(72, 18, Location.Plantation);
            var qHollow = new Course(36, 9, Location.QuailHollow);
            var myFirstTry = new Game("First try");
            var augustaHoles  = new List<Hole>();
            var pebbleHoles = new List<Hole>();
            var plantationHoles = new List<Hole>();
            var qHollowHoles = new List<Hole>();
            var hole1 = new Hole(3);
            augustaHoles.Add(hole1);
            pebbleHoles.Add(hole1);
            plantationHoles.Add(hole1);
            qHollowHoles.Add(hole1);
            myFirstTry.Courses.Add(augusta, augustaHoles);
            myFirstTry.Courses.Add(pebble, pebbleHoles);
            myFirstTry.Courses.Add(plantation, plantationHoles);
            myFirstTry.Courses.Add(qHollow, qHollowHoles);


            // Console.Clear();
            // System.Console.WriteLine("{0} has {1} holes and a par of {2}", augusta.Name, augusta.Holes, augusta.Par);
            myFirstTry.ShowGreeting();
            System.Console.WriteLine();
            myFirstTry.DisplayCourses();
            Console.ReadLine();
        }
    }
}
