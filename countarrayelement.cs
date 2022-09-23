using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpByAniketSir.ArraysConcept
{
    //Find duplicate numbers in an array of integers  { 1,2,3,2,4,3,5}
    class CountArrayElement
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 2, 4, 3, 5 };
            int count = 1;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length - 1; j++)
                {

                    if (array[j] == array[j + 1])
                        count = count + 1;
                }
                Console.WriteLine("\t\n " + array[i] + " Occurse:" + count);
                
            }



        }
    }
}

