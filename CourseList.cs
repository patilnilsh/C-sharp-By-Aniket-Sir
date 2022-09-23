using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpByAniketSir.ArraysConcept
{
    public class CourseList
    {
        public int Course_Id { get; set; }
        public String C_name { get; set; }
        public int C_Fees { get; set; }

        public override string ToString()
        {
            return $"Course Details Are : {Course_Id}  {C_name}  {C_Fees}";
        }

        static void Main(string[] args)
        {


            CourseList[] Course =
            {
                new CourseList{Course_Id=1,C_name="Dot net",C_Fees=35000},
                new CourseList{Course_Id=2,C_name="Java",C_Fees=35400},
                new CourseList{Course_Id=3,C_name="Sql",C_Fees=35050},
                new CourseList{Course_Id=4,C_name="Html",C_Fees=34000},
                new CourseList{Course_Id=5,C_name="Python",C_Fees=31000}

        };
            foreach (CourseList c in Course)
            {
                Console.WriteLine(c);
            }
        }
    }
}


        
    





    

