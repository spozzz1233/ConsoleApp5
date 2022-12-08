using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Triangle
    {
        public static void triangle()
        {
            int stop = int.Parse(Console.ReadLine());
            for (int j = 0; j < stop; j++)
            {
                int[] arr = new int[3];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                
                //int a = int.Parse(Console.ReadLine()); a 0 b 1  c 2
                //int b = int.Parse(Console.ReadLine());
                //int c = int.Parse(Console.ReadLine());

                foreach (int ma in arr)
                {
                    Console.Write(ma + " ");
                } 
                if (Math.Pow(arr[2], 2) > Math.Pow(arr[0], 2) + Math.Pow(arr[1], 2))
                {
                    Console.WriteLine("Этот треугольник тупоугольный");
                }
                else if (Math.Pow(arr[2], 2) == Math.Pow(arr[0], 2) + Math.Pow(arr[1], 2))
                {
                    Console.WriteLine("Этот треугольник прямоугольный.");
                }
                else if (Math.Pow(arr[2], 2) < Math.Pow(arr[0], 2) + Math.Pow(arr[1], 2))
                {
                    Console.WriteLine("Этот треугольник остроугольный.");
                }
                else if (arr[0] + arr[1] <= arr[2] || arr[0] + arr[2] <= arr[1] || arr[1] + arr[2] <= arr[0])
                {
                    Console.WriteLine("Этот не треугольник");
                }
            }

        }
    }
}
//если с2 < a2 + b2, то треугольник остроугольный.
//если с2 = a2 + b2, то треугольник прямоугольный.
//если с2 > a2 + b2, то треугольник тупоугольный.