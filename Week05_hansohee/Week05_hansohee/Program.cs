using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05_hansohee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int scores[10]; // C언어

            int[] scores;  // 배열 변수 (배열을 가리키는 변수) 배열이 아님!!~~!!
            scores = new int[5];
            
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            // for (int i = 0; i < scores.Length; i++)
            // {
            //     sum += scores[i];
            // }

            var a = "20"; 
            var b = 10;  // var는 가변 변수, 형이 정해져 있지 않고 바뀌는 변수...

            foreach(var score in scores)  // scores는 int 배열이니까 score는 int 형으로 되겟지요
            {
                sum += score;
            }

            Console.WriteLine(sum / scores.Length);
        }
    }
}
