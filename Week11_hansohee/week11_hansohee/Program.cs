using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week11_hansohee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            animals.Add(new Dog(1) { Color = "RED" });
            animals.Add(new Cat(2));

            foreach(Animal a in animals)
            {
                Console.WriteLine(a.Age);
                a.Eat();

                if(a is Cat)  // a가 Cat 타입이야?
                {
                    ((Cat)a).Meow();  // 고양이 애들만 형변환
                }

                Dog d = a as Dog;  // as는 형변환 연산자, a변수가 알고 있는 값을 Dog 타입으로 형변환 해서 d로 넘겨줌
                                    // 형변환 안되면 null을 return
                if (d != null)  // null 아니면 형변환이 된 거야
                {
                    d.Bark();
                    Console.WriteLine(d.Color);
                }

                // 형변환이 중요하면 as 쓰고 is...는 어떤 클래스인지가 중요하면?

                
            }

            // List<Dog> dogs = new List<Dog>();
            // List<Cat> cats = new List<Cat>();
            // 
            // dogs.Add(new Dog() { Age = 1, Color = "RED" });
            // cats.Add(new Cat() { Age = 2 });
            // 
            // foreach(var a in dogs)
            // {
            //     Console.WriteLine(a.Age);
            // }
            // 
            // foreach(var a in cats)
            // {
            //     Console.WriteLine(a.Age);
            // }

            Console.WriteLine(1.ToString());  // int
            Console.WriteLine("1".ToString());  // string
            Console.WriteLine(animals.ToString());  // list
            Console.WriteLine((new Dog(0)).ToString()); ;  // Dog, dog는 내가 만들었으... 내가 만들지 않았는데 있다는 것은 상속받았다는것
        }
    }
}
