using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptChan
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
                MessageBox.Show("실행 중인 프로그램을 종료 후 다시 실행해 주세요.");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormCrypto());
        }
    }
}
