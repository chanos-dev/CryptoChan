using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace CryptChan
{
    public partial class FormLock : UserControl
    { 
        const int PANELHEIGHT = 100;
        const int PANELWIDTH = 574;        

        bool isHide = true;       
        bool isWidth = false;

        public delegate bool EventBallonTip(string title, string text); 
        public event EventBallonTip ShowBallonTip; 

        public FormLock()
        {            
            InitializeComponent();
            InitializeControl(); 
        }

        private void InitializeControl()
        {
            panel_main.AllowDrop = true;

            if(isWidth)            
                panel_SaveAs.Width = 0;
            else
                panel_SaveAs.Height = 0;             
        } 

        private void panel_main_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] strFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string strFile in strFiles)
                {
                    label_name.Text = strFile; // Path.GetFileName(strFile);
                    label_name.ForeColor = Color.LightCoral;
                }
            }
        }

        private void panel_main_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void button_OpenFileBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.ShowDialog();

            label_name.Text = openFileDialog.FileName; // Path.GetFileName(openFileDialog.FileName);
            label_name.ForeColor = Color.LightCoral;
        }

        private async void button_Encrpyt_Click(object sender, EventArgs e)
        { 
            //PW 암호화
            //file 암호화 후 PW 삽입
            //성공 시 sqlite.db에 파일 insert  
            if ((label_name.Text == "(File name)") || string.IsNullOrEmpty(userTextBox1.ToString()))
                return; 

            pictureBox_progress.Visible = true;  

            try
            {
                bool isSuccess = true;
                string msg = "";

                Encrypt.Instance.ext = Path.GetExtension(label_name.Text);
                string ext = Encrypt.Instance.ext;

                await Task.Factory.StartNew(new Action(() =>
                {                    
                    try
                    {                        
                        Encrypt.Instance.FileEncryption(label_name.Text, userTextBox1.ToString()); 
                    }
                    catch (Exception exc)
                    {
                        isSuccess = false;

                        msg = exc.Message; 
                    }
                }));

                pictureBox_progress.Visible = false;

                if (isSuccess)
                {
                    timer_panel.Start();
                    ShowBallonMsg(ext, label_name.Text, "완료");
                }
                else
                {
                    if(string.IsNullOrEmpty(msg))
                        ShowBallonMsg(ext, label_name.Text, "실패");
                    else
                        ShowBallonMsg(ext, label_name.Text, msg);
                } 
            }
            catch(Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }

        private void ShowBallonMsg(string ext, string fileName, string done)        
        {
            bool isSuccess = false;

            if (ext.Contains("chan"))
            {
                isSuccess = ShowBallonTip.Invoke("파일 복호화", $"{label_name.Text} 파일 {done}"); 
            }
            else
            {
                isSuccess = ShowBallonTip.Invoke("파일 암호화", $"{label_name.Text} 파일 {done}"); 
            }

            if (!isSuccess)
            {
                using (FormMessageBox fm = new FormMessageBox(done))
                {
                    fm.ShowDialog();
                }
            }
        }

        private void label_name_TextChanged(object sender, EventArgs e)
        {
            Encrypt.Instance.ext = Path.GetExtension(label_name.Text); 

            if (Encrypt.Instance.ext.Contains("chan"))
                button_Crypto.Text = "Decrypt";
            else
                button_Crypto.Text = "Encrypt"; 
        }

        private void button_Save_Click(object sender, EventArgs e)
        {     
            try
            {
                //byte[] fileBytes = Encrypt.Instance.encryptionFile;
                string ext = Encrypt.Instance.ext;
                string encExt = Encrypt.Instance.encExt; 
                string filter = "";

                if(Encrypt.Instance.isEncrypt) //암호화
                {
                    filter = $"{encExt.Replace(".", "")} files(*{encExt})|*{encExt}";
                }
                else //복호화
                {
                    filter = $"{ext.Replace(".","")} files(*{ext})|*{ext}";
                }

                //Save As 
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = @"C:\";

                saveFileDialog.Title = "CryptoChan Save as";

                saveFileDialog.DefaultExt = ext.Replace(".", "");

                saveFileDialog.Filter = filter;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName.ToString();

                    if (Encrypt.Instance.isEncrypt) //암호화
                    {  
                        using (FileStream fss = new FileStream(filePath, FileMode.Create))
                        {
                            byte[] exts = Encoding.UTF8.GetBytes(ext);

                            fss.Write(Encrypt.Instance.encryptionFile, 0, Encrypt.Instance.encryptionFile.Length);
                            fss.Write(exts, 0, exts.Length);
                        }
                    }
                    else //복호화
                    { 
                        using (FileStream fss = new FileStream(filePath, FileMode.Create))
                        {
                            fss.Write(Encrypt.Instance.encryptionFile, 0, Encrypt.Instance.encryptionFile.Length);
                        }
                    }

                    DB db = new DB();

                    try
                    {
                        if (db.ConnectionDataBase())
                        {
                            db.InsertData(Path.GetFileName(label_name.Text));
                        }
                    }
                    finally
                    {
                        db.CloseConnection();
                        timer_panel.Start();
                    }
                } 
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                Encrypt.Instance.encryptionFile = null;
            }
        }

        private void timer_panel_Tick(object sender, EventArgs e)
        { 
            if (isWidth)
            {
                if (isHide)
                {
                    panel_SaveAs.Width += 2;

                    if (panel_SaveAs.Width >= PANELWIDTH)
                    {
                        timer_panel.Stop();
                        isHide = false;
                        this.Refresh();
                    }
                }
                else
                {
                    panel_SaveAs.Width -= 2;

                    if (panel_SaveAs.Width <= 0)
                    {
                        timer_panel.Stop();
                        isHide = true;
                        this.Refresh();
                    }
                }
            }
            else
            {
                if (isHide)
                {
                    panel_SaveAs.Height += 2;

                    if (panel_SaveAs.Height >= PANELHEIGHT)
                    {
                        timer_panel.Stop();
                        isHide = false;
                        this.Refresh();
                    }
                }
                else
                {
                    panel_SaveAs.Height -= 2;

                    if (panel_SaveAs.Height <= 0)
                    {
                        timer_panel.Stop();
                        isHide = true;
                        this.Refresh();
                    }
                }
            }
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, panel.DisplayRectangle, Color.Silver, ButtonBorderStyle.Dashed);
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            timer_panel.Start();
        }
    }
}
