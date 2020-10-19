using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoChan
{
    public partial class FormLogin : Form
    {
        public enum FormType
        {
            Login,
            SetPassWord
        }

        FormType formType;
        Point mousePoint;
        int reTry = 0;

        public FormLogin(FormType formType)
        {
            InitializeComponent();
            this.formType = formType;
            InitializeControl();
        }

        private void InitializeControl()
        {
            userTextBox1.Button = button_ok;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            switch(formType)
            {
                case FormType.Login:
                    Login();
                    break;
                case FormType.SetPassWord:
                    SetPassWord();
                    break;
            } 
        }

        private void Login()
        { 
            DB db = new DB();
            string pw = "";

            try
            {
                if (db.ConnectionDataBase())
                { 
                    pw = Encrypt.Instance.DecryptPass(db.GetPassWord()); 
                }
            }
            catch (Exception ex)
            {
                string msg = $"{Properties.Resources.GetPassWord}\n{ex.Message}";

                using (FormMessageBox fm = new FormMessageBox(msg))
                {
                    fm.ShowDialog();
                }
            }
            finally
            {
                db.CloseConnection(); 
            }

            if(string.IsNullOrEmpty(pw))
            { 
                using (FormMessageBox fm = new FormMessageBox(Properties.Resources.GetPassWord))
                {
                    fm.ShowDialog();
                }

                this.DialogResult = DialogResult.No;
                this.Close();

            } 

            if(pw == userTextBox1.ToString())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                reTry++;

                if (reTry > 2)
                {
                    using (FormMessageBox fm = new FormMessageBox(Properties.Resources.RetryPassWord))
                    {
                        fm.ShowDialog();
                    }

                    this.DialogResult = DialogResult.No;
                    this.Close();
                }
                else
                {
                    using (FormMessageBox fm = new FormMessageBox(Properties.Resources.IncPassWord))
                    {
                        fm.ShowDialog();
                    }
                }
            }
        }

        private void SetPassWord()
        {
            if (string.IsNullOrEmpty(userTextBox1.ToString()))
                return;

            string pw = userTextBox1.ToString();

            DB db = new DB();

            try
            {
                if (db.ConnectionDataBase())
                {
                    db.InsertPassWord(pw);
                }
            }
            catch (Exception ex)
            {
                string msg = $"{Properties.Resources.SetPassWord}\n{ex.Message}";

                using (FormMessageBox fm = new FormMessageBox(msg))
                {
                    fm.ShowDialog();
                }
            }
            finally
            {
                db.CloseConnection();
                this.Close();
            }
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void label_logo_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X), this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void label_logo_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void userTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                button_ok.PerformClick();
        }
    }
}
