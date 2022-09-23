using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpByAniketSir.ArraysConcept
{
    //Create a class Department with id,name & location .
    //create an array of 5 departments & display the list
  public class DepartmentListArray
    {
        public int D_ID { get; set; }
        public string DT_Name {get;set;}
        public String D_Location { get; set; }

        public override string ToString()
        {
            return $"Departement Details Are:{D_ID}  {DT_Name}  {D_Location}";
        }


        static void Main(string[] args)
        {
            DepartmentListArray [] department=
                 {
                   new DepartmentListArray{D_ID =1,DT_Name="Center",D_Location="Delhi"},
                   new DepartmentListArray{D_ID=2,DT_Name="State",D_Location="Mumbai"},
                   new DepartmentListArray{D_ID=3,DT_Name="Local",D_Location="Jalgaon"}

                 };

            foreach (DepartmentListArray D in department)
            {
                Console.WriteLine(D);
            }

        }

    }
}
