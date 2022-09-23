using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpByAniketSir.ArraysConcept
{
    public class ProductList
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"Product details : {Id}  {Name}  {Price}";
        }



        //making Productlist

        static void Main(string[] args)
        {
            ProductList[] products =
            {
                new ProductList{Id=1,Name="HP Laptop",Price=35000},
                new ProductList{Id=2,Name="Dell Laptop",Price=35400},
                new ProductList{Id=3,Name="Lenovo Laptop",Price=35050},
                new ProductList{Id=4,Name="Sony Laptop",Price=34000},
                new ProductList{Id=5,Name="Accer Laptop",Price=31000}

            };
            foreach (ProductList p in products)
            {
                Console.WriteLine(p);
            }
        }

    }

}