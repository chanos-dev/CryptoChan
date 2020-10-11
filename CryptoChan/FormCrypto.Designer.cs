namespace CryptoChan
{
    partial class FormCrypto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrypto));
            this.panel_Turn = new System.Windows.Forms.Panel();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.button_Setting = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Calendar = new System.Windows.Forms.Button();
            this.button_Lock = new System.Windows.Forms.Button();
            this.button_DashBoard = new System.Windows.Forms.Button();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.label_logo = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_Date = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.EncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panel_Left.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Turn
            // 
            this.panel_Turn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel_Turn.Location = new System.Drawing.Point(168, 88);
            this.panel_Turn.Name = "panel_Turn";
            this.panel_Turn.Size = new System.Drawing.Size(7, 88);
            this.panel_Turn.TabIndex = 4;
            // 
            // panel_Left
            // 
            this.panel_Left.Controls.Add(this.button_Setting);
            this.panel_Left.Controls.Add(this.button_Close);
            this.panel_Left.Controls.Add(this.button_Calendar);
            this.panel_Left.Controls.Add(this.button_Lock);
            this.panel_Left.Controls.Add(this.button_DashBoard);
            this.panel_Left.Controls.Add(this.panel_Logo);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(166, 536);
            this.panel_Left.TabIndex = 6;
            // 
            // button_Setting
            // 
            this.button_Setting.FlatAppearance.BorderSize = 0;
            this.button_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Setting.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Setting.ForeColor = System.Drawing.Color.Silver;
            this.button_Setting.Image = global::CryptoChan.Properties.Resources.Setting;
            this.button_Setting.Location = new System.Drawing.Point(0, 352);
            this.button_Setting.Name = "button_Setting";
            this.button_Setting.Size = new System.Drawing.Size(163, 87);
            this.button_Setting.TabIndex = 5;
            this.button_Setting.Text = "Setting";
            this.button_Setting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Setting.UseVisualStyleBackColor = true;
            this.button_Setting.Click += new System.EventHandler(this.button_Setting_Click);
            // 
            // button_Close
            // 
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.ForeColor = System.Drawing.Color.Silver;
            this.button_Close.Image = global::CryptoChan.Properties.Resources.Exit;
            this.button_Close.Location = new System.Drawing.Point(0, 442);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(163, 87);
            this.button_Close.TabIndex = 4;
            this.button_Close.Text = "Close";
            this.button_Close.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Calendar
            // 
            this.button_Calendar.FlatAppearance.BorderSize = 0;
            this.button_Calendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Calendar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Calendar.ForeColor = System.Drawing.Color.Silver;
            this.button_Calendar.Image = global::CryptoChan.Properties.Resources.Calendar;
            this.button_Calendar.Location = new System.Drawing.Point(0, 261);
            this.button_Calendar.Name = "button_Calendar";
            this.button_Calendar.Size = new System.Drawing.Size(163, 87);
            this.button_Calendar.TabIndex = 3;
            this.button_Calendar.Text = "Calendar";
            this.button_Calendar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Calendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Calendar.UseVisualStyleBackColor = true;
            this.button_Calendar.Click += new System.EventHandler(this.button_Calendar_Click);
            // 
            // button_Lock
            // 
            this.button_Lock.FlatAppearance.BorderSize = 0;
            this.button_Lock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Lock.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Lock.ForeColor = System.Drawing.Color.Silver;
            this.button_Lock.Image = global::CryptoChan.Properties.Resources.Lock;
            this.button_Lock.Location = new System.Drawing.Point(0, 171);
            this.button_Lock.Name = "button_Lock";
            this.button_Lock.Size = new System.Drawing.Size(163, 87);
            this.button_Lock.TabIndex = 2;
            this.button_Lock.Text = "Lock";
            this.button_Lock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Lock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Lock.UseVisualStyleBackColor = true;
            this.button_Lock.Click += new System.EventHandler(this.button_Lock_Click);
            // 
            // button_DashBoard
            // 
            this.button_DashBoard.FlatAppearance.BorderSize = 0;
            this.button_DashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DashBoard.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DashBoard.ForeColor = System.Drawing.Color.Silver;
            this.button_DashBoard.Image = ((System.Drawing.Image)(resources.GetObject("button_DashBoard.Image")));
            this.button_DashBoard.Location = new System.Drawing.Point(0, 81);
            this.button_DashBoard.Name = "button_DashBoard";
            this.button_DashBoard.Size = new System.Drawing.Size(163, 87);
            this.button_DashBoard.TabIndex = 1;
            this.button_DashBoard.Text = "DashBoard";
            this.button_DashBoard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_DashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_DashBoard.UseVisualStyleBackColor = true;
            this.button_DashBoard.Click += new System.EventHandler(this.button_DashBoard_Click);
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel_Logo.Controls.Add(this.label_logo);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(166, 71);
            this.panel_Logo.TabIndex = 0;
            // 
            // label_logo
            // 
            this.label_logo.AutoSize = true;
            this.label_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label_logo.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logo.ForeColor = System.Drawing.Color.Silver;
            this.label_logo.Location = new System.Drawing.Point(-4, 14);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(177, 41);
            this.label_logo.TabIndex = 2;
            this.label_logo.Text = "CryptoChan";
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.label_Date);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(166, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(627, 23);
            this.panel_top.TabIndex = 7;
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseDown);
            this.panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            // 
            // label_Date
            // 
            this.label_Date.ForeColor = System.Drawing.Color.Silver;
            this.label_Date.Location = new System.Drawing.Point(0, 0);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(624, 23);
            this.label_Date.TabIndex = 8;
            this.label_Date.Text = "Today()";
            this.label_Date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Date.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseDown);
            this.label_Date.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "CryptoChan";
            this.notifyIcon.Visible = true;
            this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.notifyIcon_BalloonTipClicked);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.EncryptionToolStripMenuItem,
            this.toolStripMenuItem2,
            this.closeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 104);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "CryptoChan Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // EncryptionToolStripMenuItem
            // 
            this.EncryptionToolStripMenuItem.Name = "EncryptionToolStripMenuItem";
            this.EncryptionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EncryptionToolStripMenuItem.Text = "Encryption";
            this.EncryptionToolStripMenuItem.Click += new System.EventHandler(this.EncryptionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panelChild.Location = new System.Drawing.Point(176, 72);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(617, 464);
            this.panelChild.TabIndex = 8;
            // 
            // FormCrypto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(793, 536);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_Left);
            this.Controls.Add(this.panel_Turn);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCrypto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CryptoChan";
            this.Load += new System.EventHandler(this.FormCrypt_Load);
            this.panel_Left.ResumeLayout(false);
            this.panel_Logo.ResumeLayout(false);
            this.panel_Logo.PerformLayout();
            this.panel_top.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Turn;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Calendar;
        private System.Windows.Forms.Button button_Lock;
        private System.Windows.Forms.Button button_DashBoard;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.Label label_logo;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button button_Setting;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.ToolStripMenuItem EncryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}

