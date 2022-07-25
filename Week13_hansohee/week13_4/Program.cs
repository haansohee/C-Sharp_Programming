#define NO_EXCEPTION
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week13_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "가", "나" };
            var input = int.Parse(Console.ReadLine());
#if NO_EXCEPTION  // code 10 - 1
            Console.WriteLine(arr[input]);
#elif EXCEPTION  // code 10 - 2
            if(intput < arr.Length)
            {
                Console.WriteLine(arr[input]);
            }
#endif

        }
    }
}
