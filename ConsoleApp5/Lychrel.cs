using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Lychrel
    {
        private static bool isLychrel(long number)
        {
            bool a = true;
            for (int i = 0; i < 20; i++)
            {
                number = number + reverse(number);
                if (isPalindrome(number))
                    a = false;
                return a;

            }
            return a;
        }
        private static bool isPalindrome(long number)
        {
            return number == reverse(number);
        }
        private static long reverse(long number)
        {
            long reverse = 0;

            while (number > 0)
            {
                long remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            return reverse;
        }

        public static void lychrel()
        {
            long number = long.Parse(Console.ReadLine());
            Console.Write(number + "Это число лихрела?" + isLychrel(number));
        }
    }
}
