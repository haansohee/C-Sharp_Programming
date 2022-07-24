using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week10_hansohee
{
    internal class Car
    {
        // private로 설정, CarNumber는 읽기 전용
        private readonly string CarNumber;
        private DateTime InTime;
        private DateTime OutTime;

        // 프로퍼티 생성 (get만)
        public string CarNumberPro
        {
            get { return CarNumber; }
        }

        public DateTime InTimePro
        {
            get { return InTime; }
        }

        public DateTime OutTimePro
        {
            get { return OutTime; }
        }

        // 생성자를 통해 CarNumber, InTime 설정
        public Car(string CarNumber, DateTime InTime)
        {
            this.CarNumber = CarNumber;
            this.InTime = InTime;
        }

        //Out() 메소드 만들어 OutTime 시간 설정
        public DateTime Out()
        {
            this.OutTime = DateTime.Now;
            return OutTime;
        }


        //outtime 과 intime 시간 차를 초단위로 반환하는 메소드 Diff()
        public string Diff()
        {
            return (OutTime - InTime).ToString(@"hh\:mm\:ss");
        }

    }
}

