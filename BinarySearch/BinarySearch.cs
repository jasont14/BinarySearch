using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinarySearch
    {
        int[] workingList;
        int left;
        int right;
        int match;

        //List must be sorted. 
        public BinarySearch(int[] sortedList)
        {
            workingList = sortedList;
            left = 0;
            right = sortedList.Length-1;
        }

        public int Match { get => match; set => match = value; }
                
        public int Search(int lookup)
        {
            Console.Write("Starting List: ");
            Print(left,right);
            Console.Write("Secret Number is {0} \n\n", lookup.ToString());

            while (left <= right)
            {
                int guess = (right + left) / 2;
                Console.Write("Guess: {0} ", workingList[guess].ToString());                
                
                if(workingList[guess] == lookup)
                {
                    Console.Write(" MATCH!\n");
                    return guess;
                }
                else if(workingList[guess] > lookup)
                {   
                    //Since guess was too big set right side of list to guess - 1 and guess again.
                    right = guess - 1;
                    #region Print
                            Console.Write(" TOO BIG\n");
                            Console.Write("Reduce list.  New List: ");
                            Print(left, right);
                            Console.WriteLine();
                            #endregion
                }                
                else
                {
                    //Since guess was too small set left of list to guess + 1 and guess again.
                    left = guess + 1;
                    #region Print
                    Console.Write(" TOO small\n");
                    Console.Write("Reduce list.  New List: ");
                    Print(left, right);
                    Console.WriteLine();
                    #endregion
                }
            }
            return -1;
        }

        private void Print()
        {
            for(int i = left; i<right; i++)
            {
                Console.Write(workingList[i].ToString() + " ");
            }
            Console.WriteLine();
        }

        private void Print(int left, int right)
        {
            for (int i = left; i < right+1; i++)
            {
                Console.Write(workingList[i].ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}
