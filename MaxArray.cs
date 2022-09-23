using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpByAniketSir.ArraysConcept
{
    //Create an array of 10 integers & find the min number from it

    class MinArray
    {
        static void Main(string[] args)
        {
            int[] a = { 1,2,3,4,5,6,7,8,9,10};
            int min = a[0];
            for (int i = 0; i > a.Length-1; i--)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Min is:"+min);
        }
       
    
    }
    //Create an array of 10 integers & find the max number from it
    //
    class MaxArray
    {
        static void Main(string[] args)
        {
            int[] a = { 1,6,4,5,7,8,9,10,30,45};
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            Console.WriteLine("The Maximum No is:"+max);

        }

    }
}
