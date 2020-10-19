namespace CryptoChan
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_top = new System.Windows.Forms.Panel();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.label_logo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.userTextBox1 = new CryptoChan.UserTextBox();        
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel_top.Controls.Add(this.pictureBox_Close);
            this.panel_top.Controls.Add(this.label_logo);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(382, 47);
            this.panel_top.TabIndex = 3;
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Image = global::CryptoChan.Properties.Resources.Close;
            this.pictureBox_Close.Location = new System.Drawing.Point(353, 15);
            this.pictureBox_Close.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Close.TabIndex = 5;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            // 
            // label_logo
            // 
            this.label_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_logo.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logo.ForeColor = System.Drawing.Color.Silver;
            this.label_logo.Location = new System.Drawing.Point(0, 0);
            this.label_logo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(382, 47);
            this.label_logo.TabIndex = 3;
            this.label_logo.Text = "CryptoChan";
            this.label_logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_logo_MouseDown);
            this.label_logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_logo_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(11, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "PassWord";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_ok
            // 
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ok.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.button_ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.button_ok.Location = new System.Drawing.Point(317, 72);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(45, 31);
            this.button_ok.TabIndex = 14;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // userTextBox1
            // 
            this.userTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.userTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.userTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.userTextBox1.Location = new System.Drawing.Point(82, 71);
            this.userTextBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userTextBox1.Name = "userTextBox1";
            this.userTextBox1.Size = new System.Drawing.Size(231, 30);
            this.userTextBox1.TabIndex = 12;
            this.userTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userTextBox1_KeyDown);
            // 
            // FormLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(382, 125);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userTextBox1);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label_logo;
        private System.Windows.Forms.Label label1;
        private UserTextBox userTextBox1;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.PictureBox pictureBox_Close;
    }
}