using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    struct Azs
    {
        public string company;
        public string street;
        public int mark;
        public int price;

    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Azs[] azsArray = new Azs[n];
            Console.Write("company \t street \t mark \t price \n");
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                azsArray[i].company = s[0];
                azsArray[i].street = s[1];
                azsArray[i].mark = int.Parse(s[2]);
                azsArray[i].price = int.Parse(s[3]);
            }

            int[,] azsTable = new int[3, 3] { { 92, 95, 98 }, { 0, 0, 0 }, { 0, 0, 0 } };

//-------------------------------------------max----------------------------------------------------—

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (azsTable[0, j] == azsArray[i].mark && azsTable[1, j] < azsArray[i].price)
                    {
                        azsTable[1, j] = azsArray[i].price;
                    }
                }
            }

//-------------------------------------------count----------------------------------------------------—

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (azsTable[0, j] == azsArray[i].mark && azsTable[1, j] == azsArray[i].price)
                    {
                        azsTable[2, j] += 1;
                    }
                }
            }

 //------------------------------------------write on screen-----------------------------------------------------—
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(azsTable[i, j] + "\t");
                }
                Console.WriteLine();
            }
 //-------------------------------------------------------------------------------------------------
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (azsTable[0, j] == azsArray[i].mark && azsTable[1, j] > azsArray[i].price)
                    {
                        azsTable[1, j] = azsArray[i].price;
                    }
                }
            }

            Console.WriteLine("Streets where the brand of gasoline costs the least:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (azsTable[0, j] == azsArray[i].mark && azsTable[1, j] == azsArray[i].price)
                    {
                        Console.Write(azsArray[i].mark + " - " + azsArray[i].street + "\t");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
