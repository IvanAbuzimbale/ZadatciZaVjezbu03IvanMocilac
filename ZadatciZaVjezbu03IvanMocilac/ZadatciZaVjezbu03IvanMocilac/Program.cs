using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatciZaVjezbu03IvanMocilac
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 9, 16, 7, 5, 17, 4, 14, 39, 1 };
            Sort sort = new Sort();
            sort.QuickSort(arr, 1, arr.Length - 2);
            for (int i = 0; i < arr.Length; i++){
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
