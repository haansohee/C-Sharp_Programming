using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_2
{
    class Cat
    {
        private const double MAX_WEIGHT = 20.0;  // const = 상수 + static
        private static int Count;  // 클래스 변수, 고양이가 없든 있든 만들어짐 
        private string Name;  // 인스턴스 변수, 고양이가 생겨야지만 만들어지는 변수
        private double Weight;  // 인스턴수 변수, 고양이 별로 특성이 있고 내용이 다르면 인스턴스 변수

        // 변경은 못하게 하되 볼 수 잇게는 해 주는... getter

        public static int GetCount()  // getter
        {
            return Count;  // 데이터가 잇든 없든 실행되는 애들은 클래스 메소드
        }

        public string GetName()  // getter
        {
            return Name;
        }

        public double GetWeight()  // getter
        {
            return Weight;
        }

        private void SetWeight(double weight)  // private setter (내부적으로만 쓰는 setter
        {
            Weight = weight;
        }

        public void Eat(double feed)  // 먹이를 줘서 몸무게가 찌는 메소드(feed를 통해 Weight 증가)
        {
            if (feed < 5)  // 줄 수 있는 먹이를 5kg로 제한
            {
                feed = 5;
            }
            else if (feed < 0)  // 줄 수 있는 먹이가 마이너스면..ㅋ 뭔
            {
                feed = 0;
            }

            Weight += (feed / 10.0);

            if (Weight > MAX_WEIGHT)
            {
                Weight = MAX_WEIGHT;
            }
        }

        public Cat()  // 기본 생성자
        {
            Count++;
        }
        public Cat(double weight)
        {
            Count++;
            this.Weight = weight;
        }

        public Cat(string name, double weight)
        {
            Count++;
            this.Name = name;
            this.Weight = weight;  // 이름이 다르니까 this 안 붙여도 ㅇㅋ 써도 상관 ㄴ
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"현재 고양이 수 : {Cat.GetCount()}");
            // Console.WriteLine($"현재 고양이 이름 : {Cat.Name}");

            Cat c1 = new Cat("키티", 1.5);
            // Cat.Count++;
            // c1.Name = "키티";
            // c1.Weight = 1.5;
            c1.Eat(1000);

            Console.WriteLine($"이름 : {c1.GetName()} 무게 : {c1.GetWeight()}");

            Cat c2 = new Cat("고니", 1.2);
            // Cat.Count++;
            // c2.Name = "고니";
            Console.WriteLine($"이름 : {c2.GetName()} 무게 : {c2.GetWeight()}");

            Cat c3 = new Cat("나비", 1.34);
            // Cat.Count++;
            Console.WriteLine($"이름 : {c3.GetName()} 무게 : {c3.GetWeight()}");

            Console.WriteLine($"현재 고양이 수 : {Cat.GetCount()}");


        }
    }
}
