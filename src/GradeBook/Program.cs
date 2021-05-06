using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book= new Book();
            book.AddGrade(89.5);
            var grades=new List<double>() {12.5,13.5,7.8};

            grades.Add(46.7);
            var result=0.0;
            foreach(var number in grades)
            {
                result+=number;
            }
            Console.WriteLine($"The average is {result}");
            result/=grades.Count;  
            Console.WriteLine($"The average is {result}");
            if(args.Length>0)
            {

                 Console.WriteLine($"Hello, {args[0]}!");
            
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
