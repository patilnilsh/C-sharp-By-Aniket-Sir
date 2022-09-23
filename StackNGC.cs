using System;
using System.Collections;
using System.Text;

namespace CSharpByAniketSir.Collection
{
    class StackNGC
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(10);
            s.Push(20);    //add objects in stack
            s.Push(30);

            s.Pop();     // lifo structure follow

           // s.Peek();
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
