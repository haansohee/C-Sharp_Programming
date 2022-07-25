using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week13_2
{
    class TestClass : IBasic
    {

    }
    class IBasic
    {

        // public 무조건
        public int abstraestInstanceMethod();  // public

        //summary<>
        // ㅏㅈ동 구현, property 아님
        // 반드시 testProperty 프로퍼티 만들고 get과 set 구현


        public int TestProperty
        {
            get; set;// get { throw new NotImplementedException(); }
                     // set { throw new NotImplementedException(); }
        }

        public int TestInstaceMethoD()
        {
            // throw new NotImplementedException();
            return 3;
        }
        internal class Program
        {


            static void Main(string[] args)
            {
                IBasic a = new TestClass();
                TestClass b = new TestClass();
                TestClass c = new TestClass();

            }


        }
    }
}
