using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpByAniketSir.ArraysConcept
{
    class JaggedArrayDemo
    {
        static void Main(string[] args)
        {
            // jagged array
            // row size is 3
            int[][] jaggeArray = new int[3][];

            jaggeArray[0] = new int[] { 1, 2, 3, 4, 5 }; // 0th row
            jaggeArray[1] = new int[] { 1, 2, 3 };//1st row
            jaggeArray[2] = new int[] { 1, 2 }; // 2nd row

            for (int i = 0; i < jaggeArray.Length; i++) // 3
            {
                for (int j = 0; j < jaggeArray[i].Length; j++)
                {
                    Console.Write(jaggeArray[i][j] + "  ");
                }
                Console.WriteLine();
            }

        }
    }
}
