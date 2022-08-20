using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public partial class frmMain : Form
    {
        public frmMain()  // 화면이 뜰 때 반드시 실행되는 부분
        {
            InitializeComponent();

            int a = 10;
            int b = 2 % 3;
            int c = a / b;

            // //Console.WriteLine(a)
            // lblContent.Text = a.ToString();  // Text는 문자열만 표현 가능, "10"
            // lblContent.Text += b.ToString();  // "2"
            // lblContent.Text += c.ToString();  // "5"

            // string message = string.Format("{0}\n{1}\n{2}", a, b, c);  // string클래스의 Format() 이 메소드는 여러 가지 데이터들을 문자열로 조합해 줌.
            // lblContent.Text = message;

            // 위보다 더 간단한 것

            string message = $"{a}\n{b}\n{c}";
            lblContent.Text = message;
        }
    }
}
