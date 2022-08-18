using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Homework
{
    internal class LongTermCar : Car  // 클 래스 LongTermCar 는 클 래스 Car 를 상 속 한 다
    {                                   // L ongTermCar 는 정 기 주차 차 량 시 사 용 한 다
        private DateTime _estimatedTime;
        public DateTime EstimatedTime
        {
            get { return _estimatedTime; }
        }
        /*
         * 생 성 자에 주차 예 정 기 간 초 단 위 을 추 가로 입 력 받 도 록 한 다
        i. 예 new LongTermCar(“11가1111”, 100); // “11가1111”차량은 100초간 주차하기로 기간 설정
        ii. 현재 시간에서 100초 더해 주차 예정 시간을 만드는 예: (DataTime.Now).AddSeconds(100);
        iii. 주차 예정시간을 저장하는 _estimatedTime 변수를 만들고 해당 내용의 get property인 EstimatedTime을 추가한다.
         */

        public LongTermCar(string carnumber, int term) : base(carnumber)
        {
            _estimatedTime = InTime.AddSeconds(term);
        }

        // GetPrice() 메소드를 오버라이딩한다.
        // i.내용은 주차 시간 초당 8원으로 계산하여 반환한다. (ex: diff() * 8))
        public override int GetPrice()
        {
            return Diff() * 8; 
        }

        /* 메소드 ToString()을 오버라이딩하여, Car의 ToString()의 내용에 ‘장기주차’라는 옵션을 추가하도록 한다.
        i.예) base.ToString() + “*장기주차” */

        public override string ToString()  // ToString()은 코드 상 Car 클래스의 메서드
        {
            return base.ToString() + "\r\n 장기 주차";
        }  

        // 메소드 Diff()를 오버라이딩한다.
        /*
         i. 주차완료가 된 경우,
            1. 주차 완료시간이 원래 예정한 시간보다 더 늦는다면, 완료시간에 입차시간 차이를 계산한다.
            2. 주차 완료 시간이 원래 예정한 시간보다 이르다면 무조건 예정시간과 입차시간의 차이를 계산한다.
            (즉, 주차예정시간을 채우지 않아도 무조건 계약한 금액을 받아야 한다.)
        ii. 아직 주차중이라면
            1. 현재 시간이 원래 예정한 시간보다 더 늦는다면 현재시간에서 입차 시간 차이를 계산한다.
            2. 현재 시간이 원래 예정한 시간보다 이전이라면 무조건 예정시간과 입차 시간의 차이를 계산한다. (즉,
            미리 나가도 무조건 계약한 시간을 계산한다.) 
         */
        public override int Diff()  // estimatedTime 생기면서 돈 계산 용도....  
        {  // Car의 Diff()가 호출되려낭? ㄴㄴ Diff를 override 했으니까 LongTermCar의 Diff()가 호출된다
            // Car의 Diff()를 호출하고 싶으면 override 키워드를 new 로 변경하면 됨......=> 오버하이딩
            int time = 0;

            if (OutTime >= InTime)
            {
                if(EstimatedTime <= OutTime)
                {
                    time = (int)(OutTime - InTime).TotalSeconds;
                }
                else
                {
                    time = (int)(EstimatedTime - InTime).TotalSeconds;
                }
            }
            else
            {
                if(EstimatedTime <= DateTime.Now)
                {
                    time = (int)(DateTime.Now - InTime).TotalSeconds;
                }
                else
                {
                    time = (int)(EstimatedTime - InTime).TotalSeconds;
                }
            }

            return time;
        }
    }
}
