using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myList = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};

            Console.Write("Enter the secret number between 1 - 20: ");
            int.TryParse(Console.ReadLine(), out int v);
            Console.WriteLine();

            BinarySearch bs = new BinarySearch(myList);
            if (bs.Search(v) == -1)
            {
                Console.WriteLine("Could Not Match!");
            }
            
            Console.ReadKey();
        }
    }
}
