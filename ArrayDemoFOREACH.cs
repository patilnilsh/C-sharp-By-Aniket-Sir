using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpByAniketSir.ArraysConcept
{
    class ArrayString
    {
        static void Main(string[] args)
        {

            

            string[] names = {"Ajay","Nilesh", "Tushar", "Rohan", "Suraj","Aman", "Raj" };
            Console.WriteLine("Original List Of String Name");
            Console.WriteLine("----------------------");
            foreach (var A in names)
            {
                Console.WriteLine(A);
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("Sorted String");
            Console.WriteLine("----------------------");
            Array.Sort(names);
            foreach(var B in names)
                Console.WriteLine(B);

            Console.WriteLine("----------------------");
            Console.WriteLine("String in reverse sort");
            Console.WriteLine("----------------------");

            Array.Reverse(names);
            foreach(var C in names)
                Console.WriteLine(C);

            Console.WriteLine("----------------------");
            Console.WriteLine("String getting  clear");
            Console.WriteLine("----------------------");

            Array.Clear(names,0,2);
            foreach(var D in names)
                Console.WriteLine(D);


            Console.WriteLine("----------------------");
            Console.WriteLine("String Copy");
            Console.WriteLine("----------------------");
            string[] nams = new string[5];
            Array.Copy(names,0, nams, 3, names.Length);

            foreach(var E in nams)
                Console.WriteLine(E);
        }
    }




    class ArrayDemoOFMethod   //for numbers
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[5] { 45, 78, 99, 34, 59 };
            int[] nums = new int[5];
            Console.WriteLine("Original array");

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("sorted array");
            //Array.Sort(numbers);
            // Array.Reverse(numbers);
            // Array.Clear(numbers, 2, 2);
            //Array.Copy(numbers, 1, nums, 0, 3);
            Array.Copy(numbers, nums, numbers.Length);
            int index = Array.IndexOf(numbers, 34);
            Console.WriteLine($"index of 34 is {index}");
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

        }

    }





        /// <summary>
        /// /////////////////
        /// </summary>
    class ArrayDemoFOREACH
    {
        static void Main(string[] args)
        {

        }
    }
}
