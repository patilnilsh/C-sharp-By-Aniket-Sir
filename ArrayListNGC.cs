using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CSharpByAniketSir.Collection
{
    class ArrayListNGC
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(10);
            list.Insert(1, 15);
            list.IndexOf(10); // 0
            list.LastIndexOf(10);  //3
            //list.Remove(30);
            // list.RemoveAt(0);

            //list.Sort();
            // list.Reverse();
            // list.Clear();
            Console.WriteLine($"Capacity of list is {list.Capacity}");
            Console.WriteLine(list.Count);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


        }

    }
}
