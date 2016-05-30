using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringChallenge
{
    class Program
    {

        public static string Melange(string a, string b)
        {
            int Max = 0;
            string rt = "";

            if (a.Length > b.Length)
                Max = a.Length;
            else
                Max = b.Length;

            if (a.Length == 0)
                return b;
            if (b.Length == 0)
                return a;

            for (int i = 0; i < Max; i++)
            {
                if (i > a.Length - 1)
                {
                    rt += b[i];
                }
                else if (i > b.Length - 1)
                {

                    rt += a[i];

                }
                else
                {
                    rt += a[i];
                    rt += b[i];
                }
            }

            return rt;


        }

        static void Main(string[] args)
        {
            Console.WriteLine(" M:");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("N:");
            int N = Convert.ToInt32(Console.ReadLine());


            int[] myIntArray = new int[M];
            //myIntArray = Enumerable.Repeat(0, 0).ToArray();
            myIntArray.ToList().ForEach(F => Console.WriteLine(F.ToString()));


            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(" a: / b: / k: ");

                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int K = Convert.ToInt32(Console.ReadLine());

                for (int j = a - 1; j < b; j++)
                {

                    myIntArray[j] += K;

                }

                myIntArray.ToList().ForEach(G => Console.WriteLine(G.ToString()));

            }
            Console.WriteLine(myIntArray.Max());
            Console.ReadLine();



        }
    }
}