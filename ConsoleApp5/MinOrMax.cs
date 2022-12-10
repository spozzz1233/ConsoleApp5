using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class MinOrMax
    {
        public static void Number()
        {
            while (true)
            {
                int vod = int.Parse(Console.ReadLine());
                if (vod == 0)
                {
                    break;
                }
                int result = 0;
                int[] masiv = new int[10000000];
                
                for (int j = 1; j < 10000000; j++)
                {
                    masiv[j] = j;
                    for (int i = 1; i < j; i++)
                    {
                        if (masiv[j] <= 100)
                        {
                            int x1 = masiv[j] % 10;
                            int x2 = masiv[j] / 10;
                            result = x1 + x2;
                        }
                        if (masiv[j] >= 100)
                        {
                            int x1 = masiv[j] % 10;
                            int x2 = masiv[j] / 100;
                            int x3 = (masiv[j] / 10) % 10;
                            result = x1 + x2 + x3;

                        }
                    }
                    if (result == vod)
                    {
                        Console.WriteLine(masiv[j]);
                        break;
                    }


                }
            }

        }
    }
}
