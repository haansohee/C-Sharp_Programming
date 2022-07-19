using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Product.TotalCount);

            Product p1 = new Product();
            p1.Name = "모니터";
            p1.Price = 1000000;

            Product p2 = new Product();  // 프로덕트의 인스턴스를 만듭닏아...
            p2.Name = "키보드";
            p2.Price = 320000;

            // int a = 1;  // Int32 a = new Int32(1);
            // int b = 1; 

            Product p3 = new Product();
            p3.Name = "모니터";
            p3.Price = 1000000;  // p1과는 다른 인스턴스

            Product p4 = p2; // 오른쪽 """"카피"""해서 왼쪾에다가 ((대입연산자)
            p4.Name = "마우스";
            p4.Price = 10000;

            // 인스턴스는 3개(new 통해서 생성), 변수는 4개

            int a = 0;
            Console.WriteLine(a);

            Product p5 = new Product();
            Console.WriteLine(p5.Price);
            
            if (p5.Name == null)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                Console.WriteLine("EMPTY");
            }

            Product p6 = new Product() { Name = "지갑", Price = 1000 }; // 생성과 동시에 값 초기화하는 방법

            // 정적(클래스)변수
            int b = Product.TotalCount;  // 정적변수는 클래스 이름 써야 됨 꼮!!!!!!!!!!!!!!!!!!!
            int c = p6.TotalCount;

            // 인스턴스 변수
            int d = p6.Price;
            int e = Product.Price;  // 인스턴스 변수는 반드시 인스턴스 생성 후에 접근해야 함

            int f = int.Parse("10");  // int의 메소드 == Parse (static)
            string j = 1.ToString();  // 예를들어서 int형이 만든 값이 호출되어야 됨 int.Tostring()하면 오류난다..

        }
    }
}
