using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week13
{
    class Product : IComparable  
    {
        IComparable = new IComparer;
        public string Name { get; set; }
        public int Price { get; set; }

        public int CompareTo(object obj)
        {
            Product target = obj as Product;
            return this.Price.CompareTo(target.Price);
        }

        public override string ToString()
        {
            return Name + " : " + Price + "원";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>()
            {
                new Product() {Name = "고구마", Price = 15000},
                new Product() {Name = "사과", Price = 2400},
                new Product() {Name = "바나나", Price = 1000},
            };
            list.Sort();  
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
