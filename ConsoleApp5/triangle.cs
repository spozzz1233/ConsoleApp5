using System;
class Triangle
{
    static void Main()
    {
        int stop = int.Parse(Console.ReadLine());
        for (int j = 0; j < stop; j++)
        {

            int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray<int>();


            if (Math.Pow(arr.Max(), 2) < Math.Floor(Math.Pow(arr.Average(), 2)) + Math.Pow(arr.Min(), 2))
            {
                Console.WriteLine("ACUTANGLE");
            }
            else if (Math.Pow(arr.Max(), 2) > Math.Floor(Math.Pow(arr.Average(), 2)) + Math.Pow(arr.Min(), 2))
            {
                if (arr.Min() + Math.Floor(arr.Average()) <= arr.Max())
                {
                    Console.WriteLine("IMPOSIBLE");
                }
                else
                {
                    Console.WriteLine("OBTUSANGLE");
                }
            }
            else if (Math.Pow(arr.Max(), 2) == Math.Floor(Math.Pow(arr.Average(), 2)) + Math.Pow(arr.Min(), 2))
            {
                Console.WriteLine("RECTANGLE");
            }
        }
    }
}