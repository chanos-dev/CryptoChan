namespace CryptoChan
{
    partial class FormManagementS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagementS));
            this.panel_top = new System.Windows.Forms.Panel();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.label_logo = new System.Windows.Forms.Label();
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
            this.panel_top.Size = new System.Drawing.Size(269, 47);
            this.panel_top.TabIndex = 2;
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Image = global::CryptoChan.Properties.Resources.Close;
            this.pictureBox_Close.Location = new System.Drawing.Point(235, 15);
            this.pictureBox_Close.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Close.TabIndex = 4;
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
            this.label_logo.Size = new System.Drawing.Size(269, 47);
            this.label_logo.TabIndex = 3;
            this.label_logo.Text = "CryptoChan";
            // 
            // FormManagementS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(269, 371);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormManagementS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageBox";
            this.Load += new System.EventHandler(this.FormManagementS_Load);
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.Label label_logo;
    }
}