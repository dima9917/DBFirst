﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst
{

    public enum Level : byte
    {
        Beginner = 1,
        Intermediate = 2,
        Advanced = 3

    }
    class Program
    {

        static void Main(string[] args)
        {
            var dbContext = new PlutoDBContext();

            var course = new Course();
            course.Level = Level.Beginner;  

            dbContext.GetAuthorCourses(1);

            var courses = dbContext.GetCourses();

            foreach(var c in courses)
            {
                Console.WriteLine(c.Title);
            }


            Console.ReadKey();
        }
    }
}
