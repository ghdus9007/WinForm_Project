namespace Pos
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(320, 528);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(254, 82);
            this.button5.TabIndex = 11;
            this.button5.Text = "Pos관리";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Paint += new System.Windows.Forms.PaintEventHandler(this.button5_Paint);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(272, 432);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(254, 82);
            this.button4.TabIndex = 10;
            this.button4.Text = "직원관리";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.Paint += new System.Windows.Forms.PaintEventHandler(this.button4_Paint);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(272, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(254, 82);
            this.button3.TabIndex = 9;
            this.button3.Text = "환경설정";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Paint += new System.Windows.Forms.PaintEventHandler(this.button3_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 82);
            this.button2.TabIndex = 8;
            this.button2.Text = "정산관리";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Paint += new System.Windows.Forms.PaintEventHandler(this.button2_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1008, 123);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 82);
            this.button1.TabIndex = 6;
            this.button1.Text = "판매등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(372, 624);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(254, 82);
            this.button6.TabIndex = 12;
            this.button6.Text = "Pos종료";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.Paint += new System.Windows.Forms.PaintEventHandler(this.button6_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
    }
}

