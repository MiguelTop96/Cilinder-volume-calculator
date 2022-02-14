using System;

class Program{

    static void Main(string[] args){
            
        Console.Title = "Volume de cilindro";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WindowWidth = 60;
        Console.WindowHeight = 20;

        double diameter;
        double height;

        Console.WriteLine("What is the diameter of the cilinder?");
        diameter = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What is the height of the cilinder?");
        height = Convert.ToDouble(Console.ReadLine());

        double radius = diameter / 2;
        double m3 = Math.Pow(radius, 2) * 3.14 * height;
        double answer = m3 / 1000;


        Console.WriteLine("So, the volume of cilinder is: " + answer + " liters");


        Console.ReadKey();

    }
}


