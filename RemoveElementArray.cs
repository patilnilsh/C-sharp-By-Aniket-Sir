using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpByAniketSir.ArraysConcept
{
    class RemoveElementArray
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            //int n=int.Parse
            for (int i = 0; i < a.Length; i++)

            {
                if (a[i] == 3)
                    Array.Clear(a,1,3);
            }
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
