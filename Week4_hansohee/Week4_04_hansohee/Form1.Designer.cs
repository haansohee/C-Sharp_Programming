﻿namespace Week4_04_hansohee
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxMat = new System.Windows.Forms.TextBox();
            this.tbxEng = new System.Windows.Forms.TextBox();
            this.tbxKor = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxMat
            // 
            this.tbxMat.Location = new System.Drawing.Point(656, 56);
            this.tbxMat.Name = "tbxMat";
            this.tbxMat.Size = new System.Drawing.Size(146, 25);
            this.tbxMat.TabIndex = 4;
            this.tbxMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxEng
            // 
            this.tbxEng.Location = new System.Drawing.Point(504, 56);
            this.tbxEng.Name = "tbxEng";
            this.tbxEng.Size = new System.Drawing.Size(146, 25);
            this.tbxEng.TabIndex = 3;
            this.tbxEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxKor
            // 
            this.tbxKor.Location = new System.Drawing.Point(352, 56);
            this.tbxKor.Name = "tbxKor";
            this.tbxKor.Size = new System.Drawing.Size(146, 25);
            this.tbxKor.TabIndex = 2;
            this.tbxKor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.Gainsboro;
            this.lblOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblOutput.Location = new System.Drawing.Point(0, 103);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(1092, 451);
            this.lblOutput.TabIndex = 11;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(970, 48);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(111, 37);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "조회";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(833, 48);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(111, 37);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "입력";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(13, 56);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(146, 25);
            this.tbxNumber.TabIndex = 0;
            this.tbxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(165, 56);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(146, 25);
            this.tbxName.TabIndex = 1;
            this.tbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "학번";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(161, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "이름";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(348, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "국어";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(503, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "영어";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(652, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "수학";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxMat);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxEng);
            this.Controls.Add(this.tbxNumber);
            this.Controls.Add(this.tbxKor);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnInsert);
            this.Name = "Form1";
            this.Text = "예제4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMat;
        private System.Windows.Forms.TextBox tbxEng;
        private System.Windows.Forms.TextBox tbxKor;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

