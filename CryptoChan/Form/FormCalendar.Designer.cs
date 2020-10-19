namespace CryptoChan
{
    partial class FormCalendar
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_total4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_total4
            // 
            this.label_total4.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.label_total4.ForeColor = System.Drawing.Color.Silver;
            this.label_total4.Location = new System.Drawing.Point(3, 221);
            this.label_total4.Name = "label_total4";
            this.label_total4.Size = new System.Drawing.Size(614, 23);
            this.label_total4.TabIndex = 14;
            this.label_total4.Text = "In progress";
            this.label_total4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.label_total4);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormCalendar";
            this.Size = new System.Drawing.Size(617, 464);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_total4;
    }
}
