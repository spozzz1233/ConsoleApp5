using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Lychrel
    {
        public static void lychrel()
        {
            int q = int.Parse(Console.ReadLine());
            int[] val = new int[q];
            for (int i = 0; i < q; i++)
            {
                string num = Console.ReadLine();
                int res = 0, c = 0, res2 = 0;

                for (int j = 0; j < 100000; j++)
                {
                    char[] Massiv = num.ToCharArray();
                    char[] Mass = Massiv;
                    Array.Reverse(Mass);
                    string massa = new string(Mass);
                    int massa1 = Convert.ToInt32(massa);
                    res = massa1 + int.Parse(num);
                    string res1 = Convert.ToString(res);
                    if (massa1 == int.Parse(num))

                    {
                        Console.WriteLine("Lychrel?");
                        break;
                    }
                    else
                    {
                        do
                        {
                            char[] Massi = res1.ToCharArray();
                            char[] Mas = Massi;
                            Array.Reverse(Mas);
                            string mass = new string(Mas);
                            int massa2 = Convert.ToInt32(mass);
                            res2 = res + massa2;
                            c++;
                        } while (massa1 != int.Parse(Massiv));

                    }

                }
                if (c == 0 && res2 == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.Write(c + " " + res2);
                }
                val[i] = int.Parse(Console.ReadLine());
            }

        }
    }
}
