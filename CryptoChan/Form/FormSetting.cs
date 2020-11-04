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
using System.Xml.Serialization;

namespace CryptoChan
{
    enum Options
    {
        PW,
        Notify
    }

    public partial class FormSetting : UserControl
    {
        bool isChanged { get; set; } 

        public FormSetting()
        {
            InitializeComponent();
            InitializeControl();
        }

        private void InitializeControl()
        {  
            if (Setting.Option.isPW)
                radioButton_pwYes.Checked = true;
            else
                radioButton_pwNo.Checked = true;

            if (Setting.Option.isNotify)
                radioButton_notifyYes.Checked = true;
            else
                radioButton_notifyNo.Checked = true;            
        }

        private void label_default_MouseLeave(object sender, EventArgs e)
        {
            label_default.ForeColor = Color.Silver;
        }

        private void label_default_MouseEnter(object sender, EventArgs e)
        {
            label_default.ForeColor = Color.FromArgb(62, 120, 138);
        } 

        private void label_default_Click(object sender, EventArgs e)
        {
            isChanged = true;
            radioButton_pwNo.Checked = true;
            radioButton_notifyYes.Checked = true;            
        } 

        private void SetOption(Options options, bool isChecked)
        {
            switch(options)
            {
                case Options.PW:
                    Setting.Option.isPW = isChecked;
                    break;
                case Options.Notify:
                    Setting.Option.isNotify = isChecked;
                    break;
            }
        }  

        private void button_Crypto_Click(object sender, EventArgs e)
        {
            Setting.Option.Save();
        }

        private void radioButton_pwYes_Click(object sender, EventArgs e)
        {
            SetOption(Options.PW, true);

            if (!Setting.Option.isPW)
                return;

            DB db = new DB();

            try
            {
                if (db.ConnectionDataBase())
                {
                    if (string.IsNullOrEmpty(db.GetPassWord()))
                    {
                        //최초 pw 설정 
                        using (FormLogin fm = new FormLogin(FormLogin.FormType.SetPassWord))
                        {
                            fm.ShowDialog();
                        }
                    }
                }
                else
                {
                    //error
                }
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void radioButton_pwNo_Click(object sender, EventArgs e)
        {
            SetOption(Options.PW, false);
        }

        private void radioButton_notifyYes_Click(object sender, EventArgs e)
        {
            SetOption(Options.Notify, true);
        }

        private void radioButton_notifyNo_Click(object sender, EventArgs e)
        {
            SetOption(Options.Notify, false);            
        }
    }

    public class Setting
    {
        public static Option Option { get; private set; } = null;

        static Setting()
        {
            Option = new Option();
        }
    }

    public class Option
    {
        [XmlIgnore]
        private string path => $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\CryptoChan\\setting.xml";

        public bool isPW { get; set; }
        public bool isNotify { get; set; } 

        public Option()
        {
            
        }

        public void Load()
        {
            try
            {
                using (var reader = new StreamReader(path))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Option));
                    Option option = (Option)xs.Deserialize(reader);

                    this.isPW = option.isPW;
                    this.isNotify = option.isNotify;
                }
            }
            catch
            {
                SetDefaultOptions();
                Save();
            }
        }

        public void Save()
        {
            using (StreamWriter wr = new StreamWriter(path))
            {
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");

                XmlSerializer xs = new XmlSerializer(typeof(Option));
                xs.Serialize(wr, this, ns);
            }
        }

        private void SetDefaultOptions()
        {
            this.isPW = false;
            this.isNotify = true;
        }
    }
}
