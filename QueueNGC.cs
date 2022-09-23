using System;
using System.Collections;
using System.Text;

namespace CSharpByAniketSir.Collection
{
    class QueueNGC
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);     //add object
            q.Enqueue(30);
            q.Enqueue(40);

            //q.Dequeue();     //fifo structure follow

            q.Peek();

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
