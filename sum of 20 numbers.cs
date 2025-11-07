using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloWold;

public static class Program
{
    public static void Main()
    {

        int x, y;
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("enter number 1");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number2");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}", x, y, (x + y));
        }
        Console.ReadKey();
    }
}
