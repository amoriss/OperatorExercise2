using System;

namespace OperatorExercise2
{
    class Program

    {
        public static void areaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle ?");
            var radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);

        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            areaOfCircle();

        }
    } 
}


     
