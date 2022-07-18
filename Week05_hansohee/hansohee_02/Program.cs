using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hansohee_02
{
    class Car  // 사용자 정의 자료형 Car Type
    {
        public string Number;
        public DateTime InTime;
        public DateTime OutTume;

    }
    internal class Program
    { // 자동차 정보를 만들 수 있는 프로그램
        static void Main(string[] args)  // 프로그램 진입점 entry point 그럼 main이 종료되면 프로그램이 끝나겟져?
        {
            // string[] carNumber;
            // DateTime[] inTime;
            // DateTime[] outTime;  // 시간과 날짜 지원해 주는 DateTime
            Car[] cars;

            Console.Write("최대 용량 : ");
            int max = 0;
            if (false == int.TryParse(Console.ReadLine(), out max))  // 변환 실패
            {
                max = 5;  // 잘못 입력햇어? 그럼 max 5로 할게
            }

            // carNumber = new string[max];
            // inTime = new DateTime[max];
            // outTime = new DateTime[max]; 
            cars = new Car[max];

            while(true)
            {
                Console.WriteLine("1. 입차");
                Console.WriteLine("2. 출차");

                var menu = Console.ReadLine();

                switch(menu)
                {
                    case "1":
                        int k = 0;
                        for (; k < cars.Length; k++)
                        {
                            // if (carNumber[k] == null || carNumber[k] == "")  // 문자열이 할당이 안되어잇어? 그럼 차량번호 넣어 null은 아닌데 빈문자열이야? 너도 넣어
                            // if (string.IsNullOrEmpty(carNumber[k]))
                            if (cars[k] == null)
                            {
                                Console.Write("차량번호 : ");
                                cars[k] = new Car();
                                cars[k].Number = Console.ReadLine();  // carNumber[k] = Console.ReadLine();
                                cars[k].InTime = DateTime.Now;  // inTime[k] = DateTime.Now;
                                break;  // for문의 break
                            }
                        }

                        if (k >= cars.Length)
                        {
                            Console.WriteLine("풀방");
                        }
                        break;


                    case "2":
                        Console.Write("차량번호 : ");
                        var number = Console.ReadLine();
                        for (int i = 0; i < cars.Length; i++)
                        {
                            if(cars[i] != null && cars[i].Number == number)  // 비었는지 먼저 물어보고 차량 번호 묻기
                            {
                                cars[i].OutTume = DateTime.Now;

                                Car car = cars[i];

                                Console.WriteLine($"차량번호 : {car.Number}");
                                Console.WriteLine($"입고시간 : {car.InTime}");
                                Console.WriteLine($"출고시간 : {car.OutTume}");

                                cars[i] = null;
                                break;
                            }
                        }
                        break;
                }
            }

        }
    }
}
