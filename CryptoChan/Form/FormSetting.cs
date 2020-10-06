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

namespace CryptChan
{
    enum Options
    {
        PW,
        Notify
    }

    public partial class FormSetting : UserControl
    {
        bool isChanged { get; set; }
        private Setting setting;

        public FormSetting()
        {
            InitializeComponent();
            InitializeControl();
        }

        private void InitializeControl()
        {
            setting = new Setting();
            setting.Load();

            if (setting.isPW)
                radioButton_pwYes.Checked = true;
            else
                radioButton_pwNo.Checked = true;

            if (setting.isNotify)
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

        private bool Save(Setting setting)
        {
            return true;
        }

        private void SetOption(Options options, bool isChecked)
        {
            switch(options)
            {
                case Options.PW:
                    setting.isPW = isChecked;
                    break;
                case Options.Notify:
                    setting.isNotify = isChecked;
                    break;
            }
        }

        private void radioButton_pwYes_CheckedChanged(object sender, EventArgs e)
        {
            SetOption(Options.PW, true);  

            DB db = new DB();

            try
            {
                if (db.ConnectionDataBase())
                {
                    if (string.IsNullOrEmpty(db.GetPassWord()))
                    {
                        //최초 pw 설정
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

        private void radioButton_pwNo_CheckedChanged(object sender, EventArgs e)
        {
            SetOption(Options.PW, false);
        }

        private void radioButton_notifyYes_CheckedChanged(object sender, EventArgs e)
        {
            SetOption(Options.Notify, true);
        }

        private void radioButton_notifyNo_CheckedChanged(object sender, EventArgs e)
        {
            SetOption(Options.Notify, false);
        }

        private void button_Crypto_Click(object sender, EventArgs e)
        {
            setting.Save();
        } 
    }

    public class Setting
    {
        [XmlIgnore]
        private string path => $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\CryptoChan\\setting.xml";

        public bool isPW { get; set; }
        public bool isNotify { get; set; }

        public Setting()
        {
            
        }

        public void Load()
        {
            using (var reader = new StreamReader(path))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Setting));
                Setting setting = (Setting)xs.Deserialize(reader);

                this.isPW = setting.isPW;
                this.isNotify = setting.isNotify;
            }
        }

        public void Save()
        {
            using (StreamWriter wr = new StreamWriter(path))
            {
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");

                XmlSerializer xs = new XmlSerializer(typeof(Setting));
                xs.Serialize(wr, this, ns);
            }
        }
    }
}
