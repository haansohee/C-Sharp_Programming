using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week13_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sData = Console.ReadLine();
            int input = 0;
            try
            {
                List<string> arr = new List<string>() { "가", "나" };
                input = int.Parse(sData);
                arr.Sort();
                Console.WriteLine(arr[input]);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("똑바로 숫자 입력해 : " + sData);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("잘못 입력한 인덱스 : " + input);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("종료");
            }
        }
    }
}
