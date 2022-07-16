using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_01_hansohee
{
    class UserInt  // 클래스는 사용자 정의 자료형
    {
        public int Number;
    }
    internal class Program
    {
        static void Main(string[] args)  // 프로그램 진입점 entry point
        {
            // arrInt는 배열이 아님! 실제로 만든 배열의 정보를 알 수 있게 해 주는 이름일 뿐,,
            int[] arrInt = new int[4];  // value type
            UserInt[] arrUserInt = new UserInt[4];  //ref type

            // for(int i = 0; i < arrInt.Length; i++)
            // {
            //     Console.WriteLine(arrInt[i]);
            // }

            for (int i = 0; i < arrUserInt.Length; i++)
            {
                Console.WriteLine(arrUserInt[i].Number);
            }
        }
    }
}
