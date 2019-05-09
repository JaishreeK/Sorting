using System;

namespace Sorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // Complete the countSwaps function below.
        public static void countSwaps(int[] a)
        {
            int n = a.Length;
            int swapCnt = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1])
                    {
                        swap(ref a[j], ref a[j + 1]);
                        swapCnt++;
                    }
                }
            }
            Console.WriteLine("Array is sorted in " + swapCnt + " swaps." );
            Console.WriteLine("First Element: "+ a[0]);
            Console.WriteLine("Last Element: " + a[n - 1]);

        }

        private static void swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
