using CryptoChan.Lib;
using System;
using System.Threading;
using System.Windows.Forms;

namespace CryptoChan
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //{25AF45BC-AE51-4F04-985E-ECAF7FF51FC3}
            string mutextName = "25AF45BC-AE51-4F04-985E-ECAF7FF51FC3";
            bool createdNew;

            Mutex mtx = new Mutex(true, mutextName); 

            TimeSpan tsWait = new TimeSpan(0, 0, 1); 

            createdNew = mtx.WaitOne(tsWait);  

            if (!createdNew)
            {
                using (FormMessageBox fm = new FormMessageBox(Properties.Resources.AlreadyProgram))
                {
                    fm.ShowDialog();
                } 

                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Setting.Option.Load();

            if (Setting.Option.isPW)
            {
                using (FormLogin fm = new FormLogin(FormLogin.FormType.Login))
                {
                    DialogResult dialogResult = fm.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {
                        Application.Run(new FormCrypto());
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else
            {
                Application.Run(new FormCrypto());
            }
        }
    }
}
