namespace CryptoChan
{
    partial class FormSetting
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
            this.panel_right = new System.Windows.Forms.Panel();
            this.button_Crypto = new System.Windows.Forms.Button();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.groupBox_notify = new System.Windows.Forms.GroupBox();
            this.label_notify = new System.Windows.Forms.Label();
            this.radioButton_notifyNo = new System.Windows.Forms.RadioButton();
            this.radioButton_notifyYes = new System.Windows.Forms.RadioButton();
            this.groupBox_pw = new System.Windows.Forms.GroupBox();
            this.label_pw = new System.Windows.Forms.Label();
            this.radioButton_pwNo = new System.Windows.Forms.RadioButton();
            this.radioButton_pwYes = new System.Windows.Forms.RadioButton();
            this.label_default = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.panel_right.SuspendLayout();
            this.panel_Left.SuspendLayout();
            this.groupBox_notify.SuspendLayout();
            this.groupBox_pw.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_right);
            this.panel_main.Controls.Add(this.panel_Left);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(617, 464);
            this.panel_main.TabIndex = 0;
            // 
            // panel_right
            // 
            this.panel_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.panel_right.Controls.Add(this.button_Crypto);
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_right.Location = new System.Drawing.Point(308, 0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(309, 464);
            this.panel_right.TabIndex = 1;
            // 
            // button_Crypto
            // 
            this.button_Crypto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Crypto.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.button_Crypto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.button_Crypto.Location = new System.Drawing.Point(230, 432);
            this.button_Crypto.Name = "button_Crypto";
            this.button_Crypto.Size = new System.Drawing.Size(76, 28);
            this.button_Crypto.TabIndex = 13;
            this.button_Crypto.Text = "Save";
            this.button_Crypto.UseVisualStyleBackColor = true;
            this.button_Crypto.Click += new System.EventHandler(this.button_Crypto_Click);
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.panel_Left.Controls.Add(this.groupBox_notify);
            this.panel_Left.Controls.Add(this.groupBox_pw);
            this.panel_Left.Controls.Add(this.label_default);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(308, 464);
            this.panel_Left.TabIndex = 0;
            // 
            // groupBox_notify
            // 
            this.groupBox_notify.Controls.Add(this.label_notify);
            this.groupBox_notify.Controls.Add(this.radioButton_notifyNo);
            this.groupBox_notify.Controls.Add(this.radioButton_notifyYes);
            this.groupBox_notify.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_notify.Location = new System.Drawing.Point(7, 101);
            this.groupBox_notify.Name = "groupBox_notify";
            this.groupBox_notify.Size = new System.Drawing.Size(295, 64);
            this.groupBox_notify.TabIndex = 8;
            this.groupBox_notify.TabStop = false;
            // 
            // label_notify
            // 
            this.label_notify.AutoSize = true;
            this.label_notify.ForeColor = System.Drawing.Color.Silver;
            this.label_notify.Location = new System.Drawing.Point(15, 26);
            this.label_notify.Name = "label_notify";
            this.label_notify.Size = new System.Drawing.Size(42, 23);
            this.label_notify.TabIndex = 8;
            this.label_notify.Text = "알림";
            // 
            // radioButton_notifyNo
            // 
            this.radioButton_notifyNo.AutoSize = true;
            this.radioButton_notifyNo.ForeColor = System.Drawing.Color.Silver;
            this.radioButton_notifyNo.Location = new System.Drawing.Point(180, 24);
            this.radioButton_notifyNo.Name = "radioButton_notifyNo";
            this.radioButton_notifyNo.Size = new System.Drawing.Size(76, 27);
            this.radioButton_notifyNo.TabIndex = 7;
            this.radioButton_notifyNo.TabStop = true;
            this.radioButton_notifyNo.Text = "미사용";
            this.radioButton_notifyNo.UseVisualStyleBackColor = true;
            this.radioButton_notifyNo.Click += new System.EventHandler(this.radioButton_notifyNo_Click);
            // 
            // radioButton_notifyYes
            // 
            this.radioButton_notifyYes.AutoSize = true;
            this.radioButton_notifyYes.ForeColor = System.Drawing.Color.Silver;
            this.radioButton_notifyYes.Location = new System.Drawing.Point(105, 24);
            this.radioButton_notifyYes.Name = "radioButton_notifyYes";
            this.radioButton_notifyYes.Size = new System.Drawing.Size(60, 27);
            this.radioButton_notifyYes.TabIndex = 6;
            this.radioButton_notifyYes.TabStop = true;
            this.radioButton_notifyYes.Text = "사용";
            this.radioButton_notifyYes.UseVisualStyleBackColor = true;
            this.radioButton_notifyYes.Click += new System.EventHandler(this.radioButton_notifyYes_Click);
            // 
            // groupBox_pw
            // 
            this.groupBox_pw.Controls.Add(this.label_pw);
            this.groupBox_pw.Controls.Add(this.radioButton_pwNo);
            this.groupBox_pw.Controls.Add(this.radioButton_pwYes);
            this.groupBox_pw.Location = new System.Drawing.Point(7, 14);
            this.groupBox_pw.Name = "groupBox_pw";
            this.groupBox_pw.Size = new System.Drawing.Size(295, 64);
            this.groupBox_pw.TabIndex = 7;
            this.groupBox_pw.TabStop = false;
            // 
            // label_pw
            // 
            this.label_pw.AutoSize = true;
            this.label_pw.ForeColor = System.Drawing.Color.Silver;
            this.label_pw.Location = new System.Drawing.Point(15, 26);
            this.label_pw.Name = "label_pw";
            this.label_pw.Size = new System.Drawing.Size(74, 23);
            this.label_pw.TabIndex = 5;
            this.label_pw.Text = "비밀번호";
            // 
            // radioButton_pwNo
            // 
            this.radioButton_pwNo.AutoSize = true;
            this.radioButton_pwNo.ForeColor = System.Drawing.Color.Silver;
            this.radioButton_pwNo.Location = new System.Drawing.Point(180, 24);
            this.radioButton_pwNo.Name = "radioButton_pwNo";
            this.radioButton_pwNo.Size = new System.Drawing.Size(76, 27);
            this.radioButton_pwNo.TabIndex = 4;
            this.radioButton_pwNo.TabStop = true;
            this.radioButton_pwNo.Text = "미사용";
            this.radioButton_pwNo.UseVisualStyleBackColor = true;
            this.radioButton_pwNo.Click += new System.EventHandler(this.radioButton_pwNo_Click);
            // 
            // radioButton_pwYes
            // 
            this.radioButton_pwYes.AutoSize = true;
            this.radioButton_pwYes.ForeColor = System.Drawing.Color.Silver;
            this.radioButton_pwYes.Location = new System.Drawing.Point(105, 24);
            this.radioButton_pwYes.Name = "radioButton_pwYes";
            this.radioButton_pwYes.Size = new System.Drawing.Size(60, 27);
            this.radioButton_pwYes.TabIndex = 3;
            this.radioButton_pwYes.TabStop = true;
            this.radioButton_pwYes.Text = "사용";
            this.radioButton_pwYes.UseVisualStyleBackColor = true;
            this.radioButton_pwYes.Click += new System.EventHandler(this.radioButton_pwYes_Click);
            // 
            // label_default
            // 
            this.label_default.AutoSize = true;
            this.label_default.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Underline);
            this.label_default.Location = new System.Drawing.Point(3, 441);
            this.label_default.Name = "label_default";
            this.label_default.Size = new System.Drawing.Size(59, 19);
            this.label_default.TabIndex = 6;
            this.label_default.Text = "Default";
            this.label_default.Click += new System.EventHandler(this.label_default_Click);
            this.label_default.MouseEnter += new System.EventHandler(this.label_default_MouseEnter);
            this.label_default.MouseLeave += new System.EventHandler(this.label_default_MouseLeave);
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panel_main);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormSetting";
            this.Size = new System.Drawing.Size(617, 464);
            this.panel_main.ResumeLayout(false);
            this.panel_right.ResumeLayout(false);
            this.panel_Left.ResumeLayout(false);
            this.panel_Left.PerformLayout();
            this.groupBox_notify.ResumeLayout(false);
            this.groupBox_notify.PerformLayout();
            this.groupBox_pw.ResumeLayout(false);
            this.groupBox_pw.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Label label_default;
        private System.Windows.Forms.GroupBox groupBox_notify;
        private System.Windows.Forms.Label label_notify;
        private System.Windows.Forms.RadioButton radioButton_notifyNo;
        private System.Windows.Forms.RadioButton radioButton_notifyYes;
        private System.Windows.Forms.GroupBox groupBox_pw;
        private System.Windows.Forms.Label label_pw;
        private System.Windows.Forms.RadioButton radioButton_pwNo;
        private System.Windows.Forms.RadioButton radioButton_pwYes;
        private System.Windows.Forms.Button button_Crypto;
    }
}
