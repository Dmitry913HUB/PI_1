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

            Console.Write("company \t street \t mark \t price \n");
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                string company = s[0];
                string street = s[1];
                int mark = int.Parse(s[2]);
                int price = int.Parse(s[3]);
                for (int j = 0; j < 3; j++)
                {
                    if (azsTable[0, j] == mark && azsTable[1, j] < price)
                    {
                        azsTable[1, j] = price;
                    }
                }
            }

            //-------------------------------------------max----------------------------------------------------—

            /*for (int i = 0; i < n; i++)
            {
            for (int j = 0; j < 3; j++)
            {
            if (azsTable[0, j] == azsArray[i].mark && azsTable[1, j] < azsArray[i].price)
            {
            azsTable[1, j] = azsArray[i].price;
            }
            }
            } */

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
