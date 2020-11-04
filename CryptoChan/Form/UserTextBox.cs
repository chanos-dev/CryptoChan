using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CryptoChan
{
    public partial class UserTextBox : UserControl
    {  
        [DllImport("imm32.dll")]
        private static extern IntPtr ImmGetContext(IntPtr hwnd);
        [DllImport("imm32.dll")]
        private static extern bool ImmGetConversionStatus(IntPtr himc, ref int lpdw, ref int lpdw2); 

        public object Button { get; set; }

        public bool EnterKey()
        {
            if(Button is Button button)
            {
                button.PerformClick();
                return true;
            }
            else
            {
                return false;
            }            
        }

        public UserTextBox()
        {
            InitializeComponent();
            InitializeControl();
        }

        private void InitializeControl()
        {
            pictureBox_show.Tag = "No";

            GetCapsLock();
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, panel.DisplayRectangle, Color.Silver, ButtonBorderStyle.Solid);
        }

        public void Clear()
        {
            textBox_pw.Text = "";
        }

        public override string ToString()
        {
            return textBox_pw.Text;
        }

        private void pictureBox_show_Click(object sender, EventArgs e)
        {
            string showPassWord = pictureBox_show.Tag as string;

            if(showPassWord != null)
            {
                if(showPassWord.Equals("Yes"))
                {
                    pictureBox_show.Image = Properties.Resources.show_silver;
                    pictureBox_show.Tag = "No";
                    textBox_pw.PasswordChar = '●';
                }
                else
                {
                    pictureBox_show.Image = Properties.Resources.show_green;
                    pictureBox_show.Tag = "Yes";
                    textBox_pw.PasswordChar = '\0';
                }
            }            
        }

        private void textBox_pw_TextChanged(object sender, EventArgs e)
        {
            if (GetCapsLock())
                label_IME.ForeColor = Color.FromArgb(62, 120, 138);
            else
                label_IME.ForeColor = Color.Silver; 
        } 

        private bool GetCapsLock()
        {
            return Control.IsKeyLocked(Keys.CapsLock);
        }

        private void GetIMEMode(object sender)
        {
            TextBox textBox = sender as TextBox;

            if (textBox is null)
                return;

            IntPtr hIMC;
            int conversion = 0;
            int sentence = 0;
            bool isCheck; 

            hIMC = ImmGetContext(textBox.Handle);
            isCheck = ImmGetConversionStatus(hIMC, ref conversion, ref sentence); 

            if(conversion ==0)
                label_IME.Text = "A";
            else
                label_IME.Text = "가"; 
        }

        private void textBox_pw_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                EnterKey();
            }
        }
    }
}
