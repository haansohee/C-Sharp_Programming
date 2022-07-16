using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform2_pyoyurim
{
    public partial class FrmMain : Form
    {
        int index = 0;
        Student[] students = new Student[3];
     
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(index >= students.Length) {
                MessageBox.Show("더 이상 입력할 수 없습니다.");
                return;
            }

            //Hw3.
            //기존에 해당 학번이 있는지 확인하고, 없으면 진행, 있으면
            //메세지로 동일학번 기입력, 안내, 종료
            for (int i = 0; i < index; i++) {
                if(students[i].Number == tbxNumber.Text)
                {
                    MessageBox.Show("동일학번 기입력");
                    return;
                }
            }


            Student stu = new Student();//생성자
            stu.Number = tbxNumber.Text;
            stu.Name = tbxName.Text;
            stu.Score = double.Parse(tbxScore.Text);

            tbxOutput.Text = $"{index+1}번 학생:{stu.Number}/{stu.Name}/{stu.Score}";

            students[index] = stu;

            index++;

        }

        private void btnAllView_Click(object sender, EventArgs e)
        {
            tbxOutput.Clear();

            //foreach
            foreach(Student s in students ) {
                if(s == null) {
                    continue;
                }

                tbxOutput.Text += $"{s.Number}/{s.Name}/{s.Score}";
                tbxOutput.Text += Environment.NewLine;
            }
        }

        private void btnAllViewHw1_Click(object sender, EventArgs e)
        {
            //for - hw4
            tbxOutput.Clear();

            for (int j = 0; j < index; j++)
            {
                if (students[j] == null)
                {
                    continue;
                }

                tbxOutput.Text += $"{students[i].Number}/{students[i].Name}/{students[i].Score}";
                tbxOutput.Text += Environment.NewLine;
            }

        }

        private void btnAllViewHw2_Click(object sender, EventArgs e)
        {
            //while - hw5
            tbxOutput.Clear();

            int i = 0;
            while (i < index)
            {
                if (students[i] == null)
                {
                    continue;
                }

                tbxOutput.Text += $"{students[i].Number}/{students[i].Name}/{students[i].Score}";
                tbxOutput.Text += Environment.NewLine;

                i++;
            }

        }
    }
}
