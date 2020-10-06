namespace CryptChan
{
    partial class UserTextBox
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_IME = new System.Windows.Forms.Label();
            this.pictureBox_show = new System.Windows.Forms.PictureBox();
            this.textBox_pw = new System.Windows.Forms.TextBox();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_show)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.label_IME);
            this.panel_main.Controls.Add(this.pictureBox_show);
            this.panel_main.Controls.Add(this.textBox_pw);
            this.panel_main.Location = new System.Drawing.Point(4, 3);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(225, 27);
            this.panel_main.TabIndex = 0;
            this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_main_Paint);
            // 
            // label_IME
            // 
            this.label_IME.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.label_IME.ForeColor = System.Drawing.Color.Silver;
            this.label_IME.Location = new System.Drawing.Point(198, 6);
            this.label_IME.Name = "label_IME";
            this.label_IME.Size = new System.Drawing.Size(26, 16);
            this.label_IME.TabIndex = 2;
            this.label_IME.Text = "Cap";
            // 
            // pictureBox_show
            // 
            this.pictureBox_show.Image = global::CryptChan.Properties.Resources.show_silver;
            this.pictureBox_show.Location = new System.Drawing.Point(177, 3);
            this.pictureBox_show.Name = "pictureBox_show";
            this.pictureBox_show.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_show.TabIndex = 1;
            this.pictureBox_show.TabStop = false;
            this.pictureBox_show.Tag = "No";
            this.pictureBox_show.Click += new System.EventHandler(this.pictureBox_show_Click);
            // 
            // textBox_pw
            // 
            this.textBox_pw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBox_pw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_pw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBox_pw.Location = new System.Drawing.Point(4, 1);
            this.textBox_pw.Name = "textBox_pw";
            this.textBox_pw.PasswordChar = '●';
            this.textBox_pw.Size = new System.Drawing.Size(170, 23);
            this.textBox_pw.TabIndex = 0;
            this.textBox_pw.TextChanged += new System.EventHandler(this.textBox_pw_TextChanged);
            // 
            // UserTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panel_main);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "UserTextBox";
            this.Size = new System.Drawing.Size(225, 30);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_show)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.TextBox textBox_pw;
        private System.Windows.Forms.PictureBox pictureBox_show;
        private System.Windows.Forms.Label label_IME;
    }
}
