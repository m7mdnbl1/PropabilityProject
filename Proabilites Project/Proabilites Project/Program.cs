using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proabilites_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i;
            int sum = 0;
            int median;
            Console.WriteLine("enter size of arr");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[50];
            Console.WriteLine("enter number in arr");
            for (i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            if (n % 2 == 0)
            {
                int x = arr[(i / 2) - 1];
                int y = arr[(i / 2)];
                median = (x + y) / 2;

                Console.WriteLine("median = " + median);
            }
            else
            {
                median = arr[i / 2];

                Console.WriteLine("median is = " + median);
            }

            Console.WriteLine("ــــــــــــــــــــــــــــــــــــــــــــــــ");

            int mean;
            for (i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            mean = sum / n;
            Console.WriteLine("mean = " + mean);

            Console.WriteLine("ــــــــــــــــــــــــــــــــــــــــــــــــ");





            int Range;
            int max = arr[0];
            for (int q = 0; q < arr.Length; q++)
            {
                if (arr[q] > max)
                {
                    max = arr[q];
                }
            }
            int min = arr[0];
            for (int e = 0; e > arr.Length; e++)
            {
                if (arr[e] < min)
                {
                    min = arr[e];
                }
            }
            Range = max - min;
            Console.WriteLine("Range = " + Range);

            Console.WriteLine("ــــــــــــــــــــــــــــــــــــــــــــــــ");

            int mode;
            for (mode = 0; mode < n; mode++)
            {
                if (arr[mode] == arr[mode + 1])
                {
                    Console.WriteLine("the mode = " + arr[mode]);
                }
            }

            Console.WriteLine("ــــــــــــــــــــــــــــــــــــــــــــــــ");


            int Q1 = (arr[i * 1 / 4]);
            Console.WriteLine("(( Q1 )) = " + Q1);
            int Q2 = median;
            Console.WriteLine("(( Q2 )) = " + Q2);
            int Q3 = (arr[i * 3 / 4]);
            Console.WriteLine("(( Q3 )) = " + Q3);
            Console.WriteLine("ــــــــــــــــــــــــــــــــــــــــــــــــ");
            double p90 = i * .90;
            int index = (int)Math.Round(p90);
            Console.WriteLine("percentiles 90 is\n" + arr[index - 1]);
            Console.WriteLine("ــــــــــــــــــــــــــــــــــــــــــــــــ");
            int interquartile = Q3 - Q1;
            Console.WriteLine("interquartile is\n" + interquartile);
            Console.WriteLine("ــــــــــــــــــــــــــــــــــــــــــــــــ");
            double outlierLowerBoundary = Q1 - (1.5 * interquartile);
            double outlierUpperBoundary = Q3 + (1.5 * interquartile);
            Console.WriteLine("The Lower boundary is\n" + outlierLowerBoundary);
            Console.WriteLine("The Upper boundary is\n" + outlierUpperBoundary);
            Console.WriteLine("ـــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ");
            

            
        }
    }
}
