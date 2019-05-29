﻿using System;
using System.Collections.Generic;

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

        // Complete the countingValleys function below.
        public static int countingValleys(int n, string s)
        {
            int countValley = 0;

            int lvl = 0;   // current level
            foreach (char ch in s)
            {
                if (ch == 'U') ++lvl;
                if (ch == 'D') --lvl;

                // if we just came UP to sea level
                if (lvl == 0 && ch == 'U')
                    ++countValley;
            }           
            return countValley;
        }

        // Complete the jumpingOnClouds function below.
        public static int jumpingOnClouds(int[] c)
        {
            int n = c.Length;
            int minJumps = 0;
            int first = c[0];
            int i = 1;
            while (i < n)
            {
                if (i + 1 < n)
                {
                    if (c[i + 1] == 0)
                    {
                        minJumps++;
                        i += 2;
                        continue;
                    }
                }
                i++;
                minJumps++;
            }
            return minJumps;

        }

        // Complete the repeatedString function below.
        public static long repeatedString(string s, long n)
        {
            int len = s.Length;
            int cnt = 0;
            long repeats = 1, finalCnt;

            if (len > 1)
            {
                repeats = (long)n / len;           

                cnt = s.Split('a').Length - 1;
                finalCnt = cnt * repeats;

                int rem = (int)n % len;
                string rems = s.Substring(0, rem);
                int remCnt = rems.Split('a').Length - 1;

                finalCnt = finalCnt + remCnt;
                return finalCnt;

            }
            else
            {
                if ((s == "a")&&(len==1))
                {
                    return n;
                }
                else
                    return 0;
            }
        }

        // Complete the maximumToys function below.
        public static int maximumToys(int[] prices, int k)
        { 
            int n = prices.Length;            
            int[] cntToys = new int[n];
            long sum = 0;
            //initialise cntToys array to 0
            for(int i=0;i<n;i++)
            {
                cntToys[i] = 0;
            }

            for (int m = 0; m < n; m++)
            {
                sum = prices[m];
                for (int i = m; i < n; i++)
                {
                    sum = sum + prices[i];
                    if (sum > k)
                    {
                        sum = sum - prices[i];
                    }
                    else
                    {
                        cntToys[m]++;
                    }
                }
            }
                  

            //find the max of the cntToys Array
            int maxCnt = cntToys[0];
            if (cntToys.Length > 1)
            {                
                for (int i = 1; i < cntToys.Length; i++)
                {
                    if (maxCnt < cntToys[i])
                        maxCnt = cntToys[i];
                }
            }      

            return maxCnt;
        }


        // Complete the maximumToys function below.
        public static int maximumToys2(int[] prices, int k)
        {
            int n = prices.Length;
            Array.Sort(prices);           
            int count = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] <= k)
                {
                    k -= prices[i];
                    count++;
                }
            }
            return count;           
        }


        public static int alphaBeta(List<int> pile)
        {
            int n = pile.Count;
            int betaPick = 0;

            if (n > 1)
            {
                pile.Sort();
                int top = pile[n - 1];

                pile.RemoveAll(x => x == top);
                n = pile.Count;
                if(n>=1)
                    betaPick = pile[n - 1];
            }

            return betaPick;

        }
    }
}
