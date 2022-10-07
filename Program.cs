using System;
using System.Collections;
using System.Collections.Generic;

namespace sales_by_match
{
    class Program
    {
        static int SockMerchant(int n, List<int> ar)
        {
            ar.Sort();
            int pairs = 0;

            for (int i = 0; i < ar.Count - 1; i+=2)
            {
                if (ar[i] == ar[i + 1])
                {
                    pairs++;
                }
            }

            return pairs;
        }

        static void Main(string[] args)
        {
            // var collection = new List<int>() { 1, 2, 1, 2, 1, 3, 2 };
            // var collection = new List<int>() { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            var collection = new List<int>() { 4, 5, 5, 5, 6, 6, 4, 1, 4, 4, 3, 6, 6, 3, 6, 1, 4, 5, 5, 5 };
            Console.WriteLine(SockMerchant(collection.Count, collection).ToString());
        }
    }
}
