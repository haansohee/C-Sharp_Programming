using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7
{
    class OverLoadingTest
    {
        public static int Add(int y)  // 
        {
            return y + y;
        }

        // public static int Add(int x) => error, 변수이름이 달라도.. 매개변수 개수&매개변수 타입이 같으니까..
        // {
        //     return x + x;
        // }

        public static int Add(int x, int y)  // 초간단 메소드는 인스턴스메소드보다 클래스 메소드가 훨 나음
        {
            return x + y;
        }

        public static int Add(int x, double y)  // 매개변수 타입과 매개변수 개수가 다르면 다른 메소드 => 오버로딩
        {
            return (int)(x + y);
        }
    }

    class Test
    {
        // 거듭제곱값을 만드는 메소드
        public int Power(int x)  // 반환 타입은 int / "static" 이 없으니까 인스턴스 메소드 그래서 클래스가 직접 호출 불가
        {
            return x * x;
        }  

        public static int Power1(int x)  // 클래스 메소드
        {
            return x * x;
        }
    }  // 접근 제한자 안 썼으니까 변수나 메소드가 private
    internal class Program
    {
        public int Power2(int x)  // 인스턴스 메소드
        {
            return x * x;
        }

        public static int Power3(int x)  // 클래스 메소드
        {
            return x * x;
        }

        static void Main(string[] args)  // 클래스 메소드
        {
            //  Power(3);  // 다른 영역에 있는 메소드여서 찾을 수가 없음... ㄱ-;
            // Test.Power(3);   Power는 인스턴스 메소드여서 클래스 이름으로는 호출할 수 없구여
            Test t = new Test();  // Test 타입의 인스턴스(값) 생성, 이 값으로만 Power 호출 가능
            t.Power(3);

            // Power1(3); 얘도 다른 영역에 있는 메소드여서 호출안됨
            Test.Power1(3);  // 클래스 이름으로만!!!!! Power1 호출 가능. 왜냐면 클래스 메소드닉가
            //Test t1 = new Test();
            //t1.Power1(3);  // 왜 에러가 나여? power1은 클래스 메소드기 때문에 인스턴스가 호출할 수 없어여

            // Power2(2);  // 같은 구역 내에 잇는 메소드.. 근데 메인은 Static, Power2는 인스턴스.....
            Program p = new Program();  // 인스턴스 생성
            p.Power2(2);  // 생성 후 호출

            Program.Power3(3);  // 같은 구역에 있고 main도 클래스메소드, Power3도 클래스메소드, 클래스이름 안붙여도 호출할수잇어 같은 클래스에 잇은까

            OverLoadingTest.Add(2);
            OverLoadingTest.Add(2, 1);
            OverLoadingTest.Add(2, 1.0);
            // OverLoadingTest.Add(2.0, 1.0);

            Console.WriteLine();
            Console.WriteLine(1);
            Console.WriteLine(1.0);
            Console.WriteLine('1'); 
            Console.WriteLine("1");
        }

    }
}
