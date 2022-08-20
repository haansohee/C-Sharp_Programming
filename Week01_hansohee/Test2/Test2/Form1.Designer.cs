namespace Test2
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
            this.lblContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblContent
            // 
            this.lblContent.BackColor = System.Drawing.Color.Black;
            this.lblContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContent.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblContent.Location = new System.Drawing.Point(10, 10);
            this.lblContent.Name = "lblContent";
            this.lblContent.Padding = new System.Windows.Forms.Padding(5);
            this.lblContent.Size = new System.Drawing.Size(362, 333);
            this.lblContent.TabIndex = 0;
            this.lblContent.Text = "인하공전";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.lblContent);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "테스트2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblContent;
    }
}

