using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week09
{
    internal class Product
    {
        private static int prodCount = 0;  // 제품 종류의 개수, 초기값 설정 안 하면 0

        private readonly string number = null;  // 제품 번호, 초기값 설정 안 하면 null, 그래서 초기값 설정 안 해도 딱히,,
        private string name = null;    // 제품 이름
        private int price = 0;      // 제품 가격
        private int stock = 0;      // 제품 보유수량

        public string Number
        {
            get { return number; }
            // set { number = value; }
        }

        // getter 메소드
        // public string GetNumber()
        // {
        //     return number;
        // }

        public string Name
        {
            get { return name; }
        }
        // public string GetName()
        // {
        //     return name;
        // }

        public int Price
        {
            get { return price; }
            set {
                if (1 <= value && value <= 10_000_000)
                {
                    price = value;
                }
                else
                {
                    price = 0;
                }
            }
        }

        // public int GetPrice()
        // {
        //     return price;
        // }

        //setter 메소드, 반환 타입 없음
        // public void SetPrice(int pr)
        // {
        //     if (1 <= pr && pr <=10_000_000)
        //     {
        //         price = pr;
        //     }
        //     else
        //     {
        //         price = 0;
        //     }
        // }

        public bool DecreaseStrock(int count)
        {
            if (stock >= count)
            {
                stock -= count;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IncreaseStock(int count)
        {
            stock += count;
            return false;
        }

        public static int ProdCount
        {
            get { return prodCount; }
        }

        // public static int GetProdCount()
        // {
        //     return prodCount;
        // }

        //생성자 생성 (클래스와 이름 같고 반환이 없는 것이 생성자 룰)

        #region TYPE2
        // public Product(string number, string name, int price)  // 외부에서 접근 가능하도록 public       
        //     : this(number, name, price, 0)
        // {
        //     // this.number = number;
        //     // this.name = name;
        //     // this.price = price;
        //     // // this.stock = 0;
        //     // 
        //     // prodCount++;
        // 
        //     // this 반드시 써야 함 밑에는 안 써도 됨
        // }


        // public Product(string nb, string nm, int pr, int st)  
        // {
        //     this.number = nb;
        //     this.name = nm;
        //     this.price = pr;
        //     this.stock = st;
        // 
        //     prodCount++;
        // }
        #endregion

        #region TYPE1
        public Product(string number, string name, int price)  // 외부에서 접근 가능하도록 public       
        {
            this.number = number;
            this.name = name;
            this.price = price;
            prodCount++;
        }  // 기본 생성자 역할을 하고


        public Product(string nb, string nm, int pr, int st)  
            :this(nb, nm, pr)
        {
            this.stock = st;
        }  // 추가할 작업이 잇는 것은 여기에

        #endregion
    }
}
