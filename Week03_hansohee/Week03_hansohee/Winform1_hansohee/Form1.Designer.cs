namespace Winform1_pyoyurim
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxScore = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.btnAllView = new System.Windows.Forms.Button();
            this.btnAllViewHw1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "학번";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(140, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "이름";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(253, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "성적";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(29, 55);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(90, 21);
            this.tbxNumber.TabIndex = 1;
            this.tbxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(140, 55);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(90, 21);
            this.tbxName.TabIndex = 1;
            this.tbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxScore
            // 
            this.tbxScore.Location = new System.Drawing.Point(253, 55);
            this.tbxScore.Name = "tbxScore";
            this.tbxScore.Size = new System.Drawing.Size(90, 21);
            this.tbxScore.TabIndex = 1;
            this.tbxScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(382, 23);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(88, 52);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "입력";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tbxOutput
            // 
            this.tbxOutput.Location = new System.Drawing.Point(29, 96);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxOutput.Size = new System.Drawing.Size(441, 215);
            this.tbxOutput.TabIndex = 1;
            // 
            // btnAllView
            // 
            this.btnAllView.Location = new System.Drawing.Point(29, 317);
            this.btnAllView.Name = "btnAllView";
            this.btnAllView.Size = new System.Drawing.Size(100, 32);
            this.btnAllView.TabIndex = 2;
            this.btnAllView.Text = "전체조회(1)";
            this.btnAllView.UseVisualStyleBackColor = true;
            this.btnAllView.Click += new System.EventHandler(this.btnAllView_Click);
            // 
            // btnAllViewHw1
            // 
            this.btnAllViewHw1.Location = new System.Drawing.Point(370, 317);
            this.btnAllViewHw1.Name = "btnAllViewHw1";
            this.btnAllViewHw1.Size = new System.Drawing.Size(100, 32);
            this.btnAllViewHw1.TabIndex = 2;
            this.btnAllViewHw1.Text = "전체조회(2)";
            this.btnAllViewHw1.UseVisualStyleBackColor = true;
            this.btnAllViewHw1.Click += new System.EventHandler(this.btnAllViewHw1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 370);
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
            this.Text = "성적입력";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxScore;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.Button btnAllView;
        private System.Windows.Forms.Button btnAllViewHw1;
    }
}

