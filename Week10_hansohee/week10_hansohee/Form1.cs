using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week10_hansohee
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        // Car[] cars = new Car[5];  // List로 수정
        List<Car> listCars = new List<Car>(new Car[5]);

        bool IsEmptyCarNumber()
        {
            bool result = false;
            if (string.IsNullOrEmpty(tbxNumber.Text))
            {
                MessageBox.Show("차량번호를 넣으세요.");
                result = true;
            }
            return result;
        }

        int SearchCar(string number)
        {
            int index = -1;
            for (int i = 0; i < listCars.Count; i++)
            {
                if (listCars[i] != null && listCars[i].CarNumberPro == number)
                {
                    index = i;
                }
            }
            return index;
        }

        private void btnArrive_Click(object sender, EventArgs e)
        {
            #region code
            tbxView.Text = String.Empty;

            if (IsEmptyCarNumber())
            {
                return;
            }

            if (-1 != SearchCar(tbxNumber.Text))
            {
                MessageBox.Show("기존에 주차가 되어있는 차량입니다.");
                return;
            }

            for (int k = 0; k < listCars.Count; k++)
            {
                if (null == listCars[k])
                {
                    // listCars[k] = new Car();
                    // listCars[k].CarNumber = tbxNumber.Text;
                    // listCars[k].InTime = DateTime.Now;
                    listCars[k] = new Car(tbxNumber.Text, DateTime.Now);

                    tbxView.Text = "차량번호:" + listCars[k].CarNumberPro;
                    tbxView.Text += Environment.NewLine;
                    tbxView.Text += "입차시간:" + listCars[k].InTimePro;
                    tbxView.Text += Environment.NewLine;
                    tbxView.Text += Environment.NewLine;
                    tbxView.Text += "입차 처리를 완료했습니다.";

                    return;
                }
            }

            MessageBox.Show("풀방");
            #endregion
        }

        private void btnDeparture_Click(object sender, EventArgs e)
        {
            #region code
            tbxView.Text = String.Empty;

            if (IsEmptyCarNumber())
            {
                return;
            }

            int i = SearchCar(tbxNumber.Text);
            if (-1 == i)
            {
                MessageBox.Show("없다!");
                return;
            }
            else
            {
                listCars[i].Out();
                Car car = listCars[i];
                listCars[i] = null;

                tbxView.Text = $"차량번호:{car.CarNumberPro}\r\n";
                tbxView.Text += $"입차시간:{car.InTimePro}\r\n";
                tbxView.Text += $"출차시간:{car.OutTimePro}\r\n";
                tbxView.Text += $"주차시간:{car.Diff()}\r\n";
                tbxView.Text += Environment.NewLine;
                tbxView.Text += Environment.NewLine;
                tbxView.Text += "출차 처리를 완료했습니다.";
                return;
            }

            #endregion
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            #region code
            tbxView.Text = "[주차현황]\r\n\r\n";
            for (int i = 0; i < listCars.Count; i++)
            {
                tbxView.Text += $"[{i + 1}] 주차상태 : ";

                tbxView.Text += listCars[i] == null ? "-" : listCars[i].CarNumberPro;
                tbxView.Text += Environment.NewLine;
            }
            #endregion
        }
    }
}
