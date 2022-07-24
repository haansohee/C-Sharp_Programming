using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week11_hansohee
{
    class Animal : Object  // animal의 조상님은 object ...... 흐릿한 색은 맞긴 한데 안써도 되는거야 컴파일러가 알아서 해줌
    {
        private static int count = 0;
        protected readonly int Seq;  //private는 아무리 파생된 클래스라고 해도 막ived 클래스가 여기에 접근할 권리 없음
                                    // protected는 public과 private 사이.... 상속 없으면 protected 는 private랑 똒~같아..

        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("먹는다.");
        }

        public Animal(int age) : base()
        {
            Seq = count++;
            Age = age;
        }
    }
    class Dog : Animal  // dog는 animal를 기반으로 해서 파생된 클래스야
    {
        // public int Age { get; set; }  // animal한테 물려받았으니까 지워도 되겟쬬?
        public string Color { get; set; }
        
        // public void Eat()
        // {
        //     Console.WriteLine("먹는다.");
        // }

        public void Bark()
        {
            Console.WriteLine("멍멍");
        }

        public Dog(int age) : base(age)  // 상속을 받은 자기 생성자 실행 전에 base 생성자 먼저 실행해야 됨
        {
            Console.WriteLine(Seq);
        }
    }    
    
    class Cat : Animal
    {
        // public int Age { get; set; }

        // public void Eat()
        // {
        //     Console.WriteLine("먹는다.");
        // }
        public void Meow()
        {
            Console.WriteLine("야옹");
        
        }

        public Cat(int age) : base(age)
        {

        }
    }
}
