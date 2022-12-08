using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Legioners
    {

        public static void legioners()
        {
            int[] val = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                val[i] = int.Parse(Console.ReadLine());
                static int f(int s)
                {
                    if (s <= 0) return 0;
                    int n = (int)Math.Pow(s, 0.5 / 1);
                    return (n + 4) * n + f(s - n * n);
                }
                Console.WriteLine(f(val[i]));
                if (val[i] == 0)
                {
                    break;
                }
            }

        }
    }
}

