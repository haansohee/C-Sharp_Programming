using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform3_hansohee
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double kor = double.Parse(tbxKor.Text);
            double eng = double.Parse(tbxEng.Text);
            double mat = double.Parse(tbxMat.Text);

            double sum = kor + eng + mat;
            double avg = sum / 3;  // 정수랑 실수 계산하면 무조건 실수

            lblSum.Text = sum.ToString("0.00");  // 소수점 두자리까지만 표현해줘~
            lblAvg.Text = avg.ToString("F2");  // 이게 좀 더 쉽다

            // 60 미만이면 불합격... 60 이상인 사람들의 학점 출력

            string msg;

            if (avg < 60)
            {
                msg = "불합격(F)";
            }
            else  // avg >= 60
            {
                msg = "합격";
                if (avg >= 90)
                {
                    msg = msg + "(A)";  // "합격(A)"
                }
                else if (avg >= 80)
                {
                    msg = msg + "(B)";
                }
                else if (avg >= 70)
                {
                    msg += "(C)";
                }
                else
                {
                    msg += "(D)";
                }
            }

            lblResult.Text = msg;

        }
    }
}
