namespace Winform2_pyoyurim
{
    partial class FrmMain
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
            this.btnAllViewHw2 = new System.Windows.Forms.Button();
            this.btnAllViewHw1 = new System.Windows.Forms.Button();
            this.btnAllView = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbxScore = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAllViewHw2
            // 
            this.btnAllViewHw2.Location = new System.Drawing.Point(364, 323);
            this.btnAllViewHw2.Name = "btnAllViewHw2";
            this.btnAllViewHw2.Size = new System.Drawing.Size(100, 32);
            this.btnAllViewHw2.TabIndex = 10;
            this.btnAllViewHw2.Text = "전체조회(3)";
            this.btnAllViewHw2.UseVisualStyleBackColor = true;
            this.btnAllViewHw2.Click += new System.EventHandler(this.btnAllViewHw2_Click);
            // 
            // btnAllViewHw1
            // 
            this.btnAllViewHw1.Location = new System.Drawing.Point(258, 323);
            this.btnAllViewHw1.Name = "btnAllViewHw1";
            this.btnAllViewHw1.Size = new System.Drawing.Size(100, 32);
            this.btnAllViewHw1.TabIndex = 11;
            this.btnAllViewHw1.Text = "전체조회(2)";
            this.btnAllViewHw1.UseVisualStyleBackColor = true;
            this.btnAllViewHw1.Click += new System.EventHandler(this.btnAllViewHw1_Click);
            // 
            // btnAllView
            // 
            this.btnAllView.Location = new System.Drawing.Point(23, 323);
            this.btnAllView.Name = "btnAllView";
            this.btnAllView.Size = new System.Drawing.Size(100, 32);
            this.btnAllView.TabIndex = 12;
            this.btnAllView.Text = "전체조회(1)";
            this.btnAllView.UseVisualStyleBackColor = true;
            this.btnAllView.Click += new System.EventHandler(this.btnAllView_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(376, 29);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(88, 52);
            this.btnInsert.TabIndex = 13;
            this.btnInsert.Text = "입력";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tbxScore
            // 
            this.tbxScore.Location = new System.Drawing.Point(247, 61);
            this.tbxScore.Name = "tbxScore";
            this.tbxScore.Size = new System.Drawing.Size(90, 21);
            this.tbxScore.TabIndex = 6;
            this.tbxScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(134, 61);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(90, 21);
            this.tbxName.TabIndex = 7;
            this.tbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxOutput
            // 
            this.tbxOutput.Location = new System.Drawing.Point(23, 102);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxOutput.Size = new System.Drawing.Size(441, 215);
            this.tbxOutput.TabIndex = 8;
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(23, 61);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(90, 21);
            this.tbxNumber.TabIndex = 9;
            this.tbxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(247, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "성적";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(134, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "이름";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "학번";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 387);
            this.Controls.Add(this.btnAllViewHw2);
            this.Controls.Add(this.btnAllViewHw1);
            this.Controls.Add(this.btnAllView);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbxScore);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.tbxNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "성적관리";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAllViewHw2;
        private System.Windows.Forms.Button btnAllViewHw1;
        private System.Windows.Forms.Button btnAllView;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbxScore;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

