using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week09
{
    internal class Constant
    {
        readonly int number;  // 학번, 학번은 변하면 안되니까 readonly 
        const int MAXCOUNT = 10;  // const를 쓴다는 것은 (상수 + static)
        // readonly는 생성자에서 값 설정 가능
        // const는 생성과 동시에 값 선언하는데.. readonly는 안 그래도 된다

        public Constant (int nm)
        {
            number = nm;
            // MAXCOUNT = 11; // error
            // readonly는 생성자 끝나고 나면 학번 변경 ㄴㄴ
        }
        public void DoTest()
        {
            // number = 10;
            // MAXCOUNT = 10; 둘 다 error

            const int DATA = 10; // const는 변수 선언과 동시에 값 초기화 해 줘야 해요~
            // const int DATA;
            Console.WriteLine(DATA);  // 값 조회
            // DATA = 20;                // 값 입력

        }
    }
}
