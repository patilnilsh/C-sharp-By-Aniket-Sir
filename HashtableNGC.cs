using System;
using System.Collections;
using System.Text;

namespace CSharpByAniketSir.Collection
{
    class HashtableNGC
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(91, "IND");
            ht.Add(1, "USA");
            ht.Add(63, "AUS");
            ht.Add(33, "FR");

            ht.Remove(1);

            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine($"{d.Key}  {d.Value}");
            }
        }


    }
}
