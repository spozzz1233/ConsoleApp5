using System;

namespace ConsoleApp5
{
    internal class Lychrel
    {
        private static Int64 reverse(Int64 number)
        {
            Int64 reverse = 0;

            while (number > 0)
            {
                Int64 remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            return reverse;
        }
        public static void lychrel()
        {
            int q = int.Parse(Console.ReadLine());
            string[] Massiv = new string[q];
            string[] kol = new string[q];
            int c = 0, j = 0;
            for (int i = 0; i < q; i++)
            {

                bool stop = true;
                Int64 chislo = Convert.ToInt64(Console.ReadLine());
                Int64 b = reverse(chislo);
                do
                {
                    Int64 res = chislo + b;
                    Int64 sum = res;
                    c = 1;
                repeat:
                    if (sum > 1000000000)
                    {
                        Massiv[i] = "Lychrel?";
                        kol[i] = "";
                        stop = false;
                    }
                    else if (sum == reverse(sum))
                    {
                        Massiv[i] = Convert.ToString(sum);
                        stop = false;

                    }
                    else
                    {
                        sum = sum + reverse(sum);
                        kol[i] = Convert.ToString(++c);
                        goto repeat;
                    }
                } while (stop);

            }
            for (int i = 0; i < q; i++)
            {
                if (kol[i] == "")
                {
                    Console.WriteLine(Massiv[i]);
                }
                else
                {
                    Console.WriteLine(kol[i] + " " + Massiv[i]);
                }
            }
        }
    }
}