using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Sorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            String location;
            DateTime time;

            Console.WriteLine("Hello World!");
            //Console.WriteLine(location == null ? "location is null" : location);
           // Console.WriteLine(time == null ? "time is null" : time.ToString());
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
            long len = s.Length;
            long cnt = 0;
            long repeats = 1, finalCnt;

            if (len > 1)
            {
                repeats = (long)Math.Floor((decimal)n / len);           

                cnt = s.Split('a').Length - 1;
                finalCnt = cnt * repeats;

               long rem = (long)n % len;
                string rems = s.Substring(0,(int)rem);
                long remCnt = rems.Split('a').Length - 1;

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

        //    5 4
        //1 2 3 4 4
        // Complete the activityNotifications function below.
        public static int activityNotifications(int[] expenditure, int d)
        {
            int n = expenditure.Length;
            int[] shortExp = new int[d];
            int cntNotice = 0;
            int[] freqArray = new int[201];
            bool first_time = true;
            int pop_element = 0;
            for (int i = d; i < n; i++)
            {
                if (first_time)
                {
                    first_time = false;
                    for (int j = i - d; j <= i - 1; j++)
                        freqArray[expenditure[j]]++;
                }
                else
                {
                    freqArray[pop_element]--;
                    freqArray[expenditure[i - 1]]++;
                }
                int median = getMedian(freqArray, d);
                if (d % 2 == 0)
                {
                    if (expenditure[i] >= median)
                        cntNotice++;
                }
                else
                {
                    if (expenditure[i] >= 2 * median)
                        cntNotice++;
                }
                pop_element = expenditure[i - d];               
            }
            return cntNotice;

        }

        public static int getMedian(int[] freq, int d)
        {
            int[] prefix_sum = new int[201];
            prefix_sum[0] = freq[0];
            for (int i = 1; i < 201; i++)
            {
                prefix_sum[i] = prefix_sum[i - 1] + freq[i];
            }
            int median;
            int a = 0;
            int b = 0;
            if (d % 2 == 0)
            {
                int first = d / 2;
                int second = first + 1;
                int i = 0;
                for (; i < 201; i++)
                {
                    if (first <= prefix_sum[i])
                    {
                        a = i;
                        break;
                    }
                }
                for (; i < 201; i++)
                {
                    if (second <= prefix_sum[i])
                    {
                        b = i;
                        break;
                    }
                }

            }
            else
            {
                int first = d / 2 + 1;
                for (int i = 0; i < 201; i++)
                {
                    if (first <= prefix_sum[i])
                    {
                        a = i;
                        break;
                    }
                }
            }
            median = a + b;
            return median;
        }


        //int n = expenditure.Length;
        //int[] shortExp = new int[d];
        //int cntNotice = 0;           
        //    for (int i = d; i<n; i++)
        //    {
        //        decimal median;
        //Array.Copy(expenditure, i - d, shortExp, 0, d);
        //        Array.Sort(shortExp);
        //        int midIndex = (int)(Math.Floor((decimal)shortExp.Length / 2));
        //        if (shortExp.Length % 2 != 0)
        //        {
        //            median= shortExp[midIndex];
        //        }
        //        else
        //        {
        //            median=((shortExp[midIndex] + shortExp[midIndex + 1]) / 2);
        //        }                
        //        if(expenditure[d] >= 2* median)
        //        {
        //            cntNotice++;
        //        }
        //    }
        //    return cntNotice;

        private static decimal getMedian(int[] shortExp)
        {
            Array.Sort(shortExp);
            int midIndex = (int)(Math.Floor((decimal)shortExp.Length / 2));
            if (shortExp.Length %2 != 0)
            {              
               return shortExp[midIndex];
            }
            else
            {
                return ((shortExp[midIndex] + shortExp[midIndex + 1]) / 2);                
            }            
        }

        public static int MissingLeastInteger(int[] A)
        {
            int num = 1;
            List<int> listA = new List<int>(A);
            listA.RemoveAll(x => x < 0);
            while (listA.Count > 0)
            {
                if (listA.Find(x => x == num) > 0)
                {
                    listA.RemoveAll(x => x == num);
                    num++;
                }
                else break;
            }
            return num;
        }
    }



    public class Checker : IComparable<Player>
    {
        public Player p1;

        public Checker(Player p1)
        {
            this.p1 = p1;
        }

        public int CompareTo(Player p2)
        {
            if (p1.score > p2.score)
                return 1;
            else if (p1.score == p2.score)
            {
                return string.Compare(p1.name, p2.name);               
            }
            else
                return -1;
        }        
    }

   



}
