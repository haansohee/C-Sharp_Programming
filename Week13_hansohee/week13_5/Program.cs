using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week13_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            try
            {
                string[] arr = { "가", "나" };
                input = int.Parse(Console.ReadLine());
                Console.WriteLine(arr[input]);
            }
            catch(Exception ex)
            {
                Console.WriteLine("인덱스가 잘못됐어요 : " + input);
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.ToString());
                return;
            }
            finally  // catch 문에 return 이 있으면 그 바로 밑 코드로 떨어지지 않음
            {       // finally 는 catch가 return이 되든 말든 실행됨
                Console.WriteLine("종료");
            }  


        }
    }
}
