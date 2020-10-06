using System; 
using System.Drawing;
using System.Globalization; 
using System.Windows.Forms;

namespace CryptChan
{
    public partial class FormCrypto : Form
    {  
        enum ButtonType
        {
            DashBoard,
            Lock,
            Calendar,
            Setting,
            Close
        }

        Point mousePoint;
        Timer dateTimer;
        CultureInfo culture = new CultureInfo("en-US");

        FormDashBoard formDashBoard;// = new FormDashBoard();
        FormLock formLock;// = new FormLock();
        FormCalendar formCalendar;// = new FormCalendar();
        FormSetting formSetting;// = new FormSetting();   

        public FormCrypto()
        {           
            InitializeComponent();
            InitializeControl();
            InitializeDataBase(); 
        }

        private void InitializeDataBase()
        {
            DB db = new DB();

            if (db.ConnectionDataBase())
            {
                //Success
            }
            else
            {
                //Fail
            }
        }

        private void InitializeControl()
        {
            formDashBoard = new FormDashBoard();
            formLock = new FormLock();
            formCalendar = new FormCalendar();
            formSetting = new FormSetting();

            label_Date.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm (ddd)", culture);
            MoveTurnPanel(ButtonType.DashBoard);

            dateTimer = new Timer();
            dateTimer.Interval = 1000; //1 sec
            dateTimer.Tick += (sender, e) =>
            {
                label_Date.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm (ddd)", culture);
            };
            dateTimer.Start();

            formLock.ShowBallonTip += (title, text) =>
            {
                if (!formLock.Visible || !this.Visible)
                {
                    notifyIcon.ShowBalloonTip(1000, title, text, ToolTipIcon.None);
                    return true;
                } 
                return false;
            }; 
        }

        private void MoveTurnPanel(ButtonType buttonType)
        { 
            switch (buttonType)
            {
                case ButtonType.DashBoard:
                    panel_Turn.Height = button_DashBoard.Height;
                    panel_Turn.Top = button_DashBoard.Top;
                    break;
                case ButtonType.Lock:
                    panel_Turn.Height = button_Lock.Height;
                    panel_Turn.Top = button_Lock.Top;
                    break;
                case ButtonType.Calendar:
                    panel_Turn.Height = button_Calendar.Height;
                    panel_Turn.Top = button_Calendar.Top;
                    break;
                case ButtonType.Setting:
                    panel_Turn.Height = button_Setting.Height;
                    panel_Turn.Top = button_Setting.Top;
                    break;
            }
        }

        private void ShowSelectForm(ButtonType buttonType)
        {
            switch (buttonType)
            {
                case ButtonType.DashBoard:
                    formDashBoard.Visible = true;
                    formLock.Visible = false;
                    formCalendar.Visible = false;
                    formSetting.Visible = false;
                    break;
                case ButtonType.Lock:
                    formDashBoard.Visible = false;
                    formLock.Visible = true;
                    formCalendar.Visible = false;
                    formSetting.Visible = false;
                    break;
                case ButtonType.Calendar:
                    formDashBoard.Visible = false;
                    formLock.Visible = false;
                    formCalendar.Visible = true;
                    formSetting.Visible = false;
                    break;
                case ButtonType.Setting:
                    formDashBoard.Visible = false;
                    formLock.Visible = false;
                    formCalendar.Visible = false;
                    formSetting.Visible = true;
                    break;
            }
        }

        private void button_DashBoard_Click(object sender, EventArgs e)
        {
            MoveTurnPanel(ButtonType.DashBoard);
            ShowSelectForm(ButtonType.DashBoard);
        }

        private void button_Lock_Click(object sender, EventArgs e)
        {  
            MoveTurnPanel(ButtonType.Lock);
            ShowSelectForm(ButtonType.Lock);            
        }

        private void button_Calendar_Click(object sender, EventArgs e)
        {        
            MoveTurnPanel(ButtonType.Calendar);
            ShowSelectForm(ButtonType.Calendar);  
        }

        private void button_Setting_Click(object sender, EventArgs e)
        {
            MoveTurnPanel(ButtonType.Setting);
            ShowSelectForm(ButtonType.Setting);
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
        }

        private void panel_top_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void panel_top_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X), this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowForm(ButtonType buttonType)
        {
            this.Show();

            switch(buttonType)
            {
                case ButtonType.DashBoard:
                default:
                    MoveTurnPanel(ButtonType.DashBoard);
                    ShowSelectForm(ButtonType.DashBoard);
                    break;
                case ButtonType.Lock:
                    MoveTurnPanel(ButtonType.Lock);
                    ShowSelectForm(ButtonType.Lock);
                    break; 
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ButtonType.DashBoard);
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowForm(ButtonType.DashBoard);
        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            ShowForm(ButtonType.Lock);
        }

        private void FormCrypt_Load(object sender, EventArgs e)
        {
            this.Controls.Add(formDashBoard);
            this.Controls.Add(formLock);
            this.Controls.Add(formCalendar);
            this.Controls.Add(formSetting);

            formDashBoard.Parent = this.panelChild;
            formLock.Parent = this.panelChild;
            formCalendar.Parent = this.panelChild;
            formSetting.Parent = this.panelChild; 

            ShowSelectForm(ButtonType.DashBoard);
        }

        private void EncryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ButtonType.Lock);
        }
    }
}
