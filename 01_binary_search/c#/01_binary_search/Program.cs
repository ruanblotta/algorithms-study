using System;
using System.Collections.Generic;

namespace BinarySearchMain
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            var my_list = new List<int> {1,3,5,7,9};
            Console.WriteLine(Binary_search(my_list, 3));
            Console.WriteLine(Binary_search(my_list, - 1));            
        }

        private static int? Binary_search(IList<int> list, int item)
            {
                var low = 0;
                var high = list.Count() -1;

                 while (low <= high)
                {
                    var mid = (low + high) / 2;
                    var guess = list[mid];
                    if (guess == item)
                    {
                        return mid;
                    }
                    if (guess > item)
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
                return null;
            }         
    }
}