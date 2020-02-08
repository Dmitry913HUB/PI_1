using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] azsTable = new int[3, 3] { { 92, 95, 98 }, { 0, 0, 0 }, { 0, 0, 0 } };
            int[,] azsMarkPrice = new int[n, 2];

            Console.Write("company \t street \t mark \t price \n");
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                string company = s[0];
                string street = s[1];
                azsMarkPrice[i, 0] = int.Parse(s[2]);
                azsMarkPrice[i, 1] = int.Parse(s[3]);
                for (int j = 0; j < 3; j++)
                {
                    if (azsTable[0, j] == azsMarkPrice[i, 0] && azsTable[1, j] < azsMarkPrice[i, 1])
                    {
                        azsTable[1, j] = azsMarkPrice[i, 1];
                    }
                }
            }

            //-------------------------------------------max----------------------------------------------------—

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (azsTable[0, j] == azsMarkPrice[i, 0] && azsTable[1, j] == azsMarkPrice[i, 1])
                    {
                        azsTable[2, j] += 1;
                    }
                }
            }

            //------------------------------------------vivod-----------------------------------------------------—
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(azsTable[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}