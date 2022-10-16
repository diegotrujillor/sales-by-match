using System;
using System.Collections;
using System.Collections.Generic;

namespace sales_by_match
{
    class Program
    {
        // https://www.hackerrank.com/challenges/sock-merchant/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
        static int SockMerchant(int n, List<int> ar)
        {
            ar.Sort();
            int pairs = 0;

            for (int i = 0; i < (n - 1); i+=2)
            {
                if (ar[i] == ar[i + 1])
                {
                    pairs++;
                }
            }
            
            if (n > 10)
            {
                if (ar[n - 2] == ar[n - 1])
                {
                    pairs++;
                }
            }

            return pairs;
        }

        static void Main(string[] args)
        {
            // var collection = new List<int>() { 1, 2, 1, 2, 1, 3, 2 };
            // var collection = new List<int>() { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };
            // var collection = new List<int>() { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            // var collection = new List<int>() { 4, 5, 5, 5, 6, 6, 4, 1, 4, 4, 3, 6, 6, 3, 6, 1, 4, 5, 5, 5 };
            var collection = new List<int>() { 44, 55, 11, 15, 4, 72, 26, 91, 80, 14, 43, 78, 70, 75, 36, 83, 78, 91, 17, 17, 54, 65, 60, 21, 58, 98, 87, 45, 75, 97, 81, 18, 51, 43, 84, 54, 66, 10, 44, 45, 23, 38, 22, 44, 65, 9, 78, 42, 100, 94, 58, 5, 11, 69, 26, 20, 19, 64, 64, 93, 60, 96, 10, 10, 39, 94, 15, 4, 3, 10, 1, 77, 48, 74, 20, 12, 83, 97, 5, 82, 43, 15, 86, 5, 35, 63, 24, 53, 27, 87, 45, 38, 34, 7, 48, 24, 100, 14, 80, 54 };
            Console.WriteLine(SockMerchant(collection.Count, collection).ToString());
        }
    }
}
