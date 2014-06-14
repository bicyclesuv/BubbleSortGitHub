using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray = { 9, 7, 11, 25, 3, 18, 0 };
            Console.WriteLine("Initial Array: ");
            BubbleSort(MyArray);
            Console.ReadKey();

        }
        static void BubbleSort(int[] arr)
        {
            if (arr.Length <= 1)
                return;
            for (int i = 0; i < arr.Length; i++)
            {
                int CurrentMaxIndex = 0;
                int temp = 0;
                for (int n = 1; n < arr.Length - i; n++)
                {
                    if (arr[n] < arr[CurrentMaxIndex])
                    {
                        temp = arr[CurrentMaxIndex];
                        arr[CurrentMaxIndex] = arr[n];
                        arr[n] = temp;
                        CurrentMaxIndex = n;
                    }
                    else
                    {
                        CurrentMaxIndex = n;
                    }
                }
                PringIntArr(i + 1, arr);
            }
        }
        /// <summary>
        /// out put array
        /// </summary>
        /// <param name="arr"></param>
        static void PringIntArr(int[] arr)
        {
            foreach (int e in arr)
            {
                Console.Write(e.ToString() + " ");
            }
            Console.WriteLine();
        }

        static void PringIntArr(int SortCounter, int[] arr)
        {
            Console.Write(SortCounter.ToString() + "        ");
            foreach (int e in arr)
            {
                Console.Write(e.ToString() + " ");
            }
            Console.WriteLine();
        }
    }


}
