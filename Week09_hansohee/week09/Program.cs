using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] arrProd = new Product[3];  // 배열
            List<Product> listProd = new List<Product>();  // 리스트
            // 리스트를 구성하는 요소 타입을 <> 안에 표기. 제네릭...

            // 데이터 입력
            for (int i = 0; i < arrProd.Length; i++) 
            {
                arrProd[i] = new Product(i.ToString(), "1", 2);
            }
            for (int i = 0; i < 3; i++) 
            {
                listProd.Add(new Product(i.ToString(), "2", 3));  // 추가
                listProd.Insert(0, new Product(i.ToString(), "2", 3));  // 삽입 ,, insert는 위치 지정 후 그 위치에 삽입
            }

            // length는 길이를 뜻함(고정 길이, 배열) list나 스택이나 큐 같은 경우 Count를 이용해서 개수 셈

            // 데이터 확인
            for (int i = 0; i < arrProd.Length; i++)
            {
                Console.WriteLine(arrProd[i]);
            }

            for (int i = 0; i < listProd.Count; i++)
            {
                Console.WriteLine(listProd[i]);
            }

            // 데이터 삭제
            for (int i = 0; i < arrProd.Length; i++)
            {
                arrProd[i] = null;
            }

            // Remove(), RemoveAt()
            // for (int i = 0; i < listProd.Count; i++)
            // {
            //     listProd.RemoveAt(i);
            // }
            var count = listProd.Count;
            for (int i = 0; i < count; i++)
            {
                listProd.RemoveAt(i);
            }

            Product p1 = new Product("A1234", "노트북", 1_200_000);
            Product p2 = new Product("A1235", "키보드", 220_000, 100);

            p1.Price = 130_000; // p1.SetPrice(130_000);

            Console.WriteLine(p1.Price); // p1.GetPrice()
            Console.WriteLine(Product.ProdCount); // Product.ProdCount()

            if (p2.DecreaseStrock(1000))
            {
                Console.WriteLine("판매 완료!");
            }
            else
            {
                Console.WriteLine("재고 부족!");
            }

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
        }
    }
}
