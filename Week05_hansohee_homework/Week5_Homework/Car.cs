using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Homework
{
    internal abstract class Car  // 클래스 Car 는 추상 클래스로 변 경 한 다
    {
        private readonly string _carNumber;
        private DateTime _inTime;
        private DateTime _outTime;

        public string CarNumber
        {
            get { return _carNumber; }
        }
        public DateTime InTime
        {
            get { return _inTime; }
        }

        public DateTime OutTime
        {
            get { return _outTime; }
        }

        public Car(string carnumber)
        {
            _carNumber = carnumber;
            _inTime = DateTime.Now;
        }

        // 메 소드 D iff() 와 O ut() 은 오 버 라 이 딩 이 가 능 하 도 록 virtual method 로 만 든 다

        public virtual void Out()
        {
            _outTime = DateTime.Now;
        }

        public virtual int Diff()
        {
            int term = 0;
            if (_outTime >= _inTime) {
                term = (int)(_outTime - _inTime).TotalSeconds;
            } else {
                term = (int)(DateTime.Now - _inTime).TotalSeconds;
            }
            return term;
        }

        /*
         메 소드 ToString() 을 오버라이딩 하여 아 래 와 같 은 문 자 을 반 환 하 도 록 한 다
            i. 주 차 중 인 경 우 에 는 차 량 번호 입 차 시 간 현재 주 차 시 간 을 출 력 한 다
            ii. 주 차 를 종 료 한 경 우 에 는 차 량 번호 입 차 시 간 출 차 시 간 총 주 차 시 간 을 출 력 한 다
         */
        public override string ToString()
        {
            string msg = $"차량 번호 : {CarNumber}";
            msg += Environment.NewLine;
            msg += $"입차 시간 : {InTime}";
            msg += Environment.NewLine;
            
            if (OutTime >= InTime)
            {
                msg += $"출차 시간 : {OutTime}";
                msg += Environment.NewLine;
            }

            msg += $"주차 시간 : {Diff()}";
            return msg;
        }

        // 추 상 메 소드 GetPrice() 를 선 언 한 다 . 접 근 제 한자 public, 반 환 타 입 int

        public abstract int GetPrice();  // 머리만 있는 추상 메서드
    }
}
