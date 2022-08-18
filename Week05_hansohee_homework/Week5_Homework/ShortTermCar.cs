using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Homework
{

    /*
     클 래스 ShortTermCar 는 클 래스 Ca r 를 상 속 한 다
    A. ShortTermCar 는 기 존 에 사 용 하 단 일 반 주차 차 량 시 사 용 한 다
    B. G etPrice() 메 소 드 를 오 버 라 이 딩 한 다
       i. 내 용 은 주차 시 간 초 당 10 원 으로 계 산 하여 반 환 한 다 (ex: diff() *10)
     */
    internal class ShortTermCar : Car
    {
        public ShortTermCar(string carnumber) : base(carnumber)
        {
        }

        public override int GetPrice()
        {
            return Diff() * 10;
        }
    }
}
