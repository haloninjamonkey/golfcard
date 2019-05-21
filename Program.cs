using System;
using System.Collections.Generic;
using golfcard.Models;

namespace golfcard
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Data region
                
            
            var augustaHoles  = new List<Hole>();
            var pebbleHoles = new List<Hole>();
            var plantationHoles = new List<Hole>();
            var qHollowHoles = new List<Hole>();
            
            var myFirstTry = new Game("First try");
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
            plantationHoles.Add(hole1);
            qHollowHoles.Add(hole1);
            var augusta = new Course(augustaHoles.Count, augustaHoles.Count, Location.Augusta);
            var pebble = new Course(72, pebbleHoles.Count, Location.Pebble);
            var plantation = new Course(72, plantationHoles.Count, Location.Plantation);
            var qHollow = new Course(36, qHollowHoles.Count, Location.QuailHollow);
            myFirstTry.Courses.Add(augusta, augustaHoles);
            myFirstTry.Courses.Add(pebble, pebbleHoles);
            myFirstTry.Courses.Add(plantation, plantationHoles);
            myFirstTry.Courses.Add(qHollow, qHollowHoles);
            #endregion

            // Console.Clear();
            // System.Console.WriteLine("{0} has {1} holes and a par of {2}", augusta.Name, augusta.Holes, augusta.Par);
            myFirstTry.ShowGreeting();
            System.Console.WriteLine();
            myFirstTry.DisplayCourses();
            Console.ReadLine();
        }
    }
}
