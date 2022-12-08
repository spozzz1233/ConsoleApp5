using ConsoleApp5;
using System;

public class Program
{
    public static void Main()
    {
        bool stop = true;
        while(stop){
            Console.WriteLine("\n" + "Выберите задачу");
            Console.WriteLine("1.Числа лихрела");
            Console.WriteLine("2.Наименьшее число с той же суммой цифр");
            Console.WriteLine("3.Щиты римской армии");
            Console.WriteLine("4.Треугольник");
            Console.WriteLine("5.Если вы передумали введите '0' ");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Вы выбрали задачу 'Числа лихрела'");
                    Lychrel.lychrel();
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали задачу 'Наименьшее число с той же суммой цифр'");
                    MinOrMax.Number();
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали задачу 'Щиты римской армии'");
                    Legioners.legioners();
                    break;
                case 4:
                    Console.WriteLine("Вы выбрали задачу 'Треугольник'");
                    Triangle.triangle();
                    break;
                default:
                    stop = false;
                    break;
            }
        }

    }
}