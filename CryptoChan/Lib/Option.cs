using System;
using System.IO;
using System.Xml.Serialization;

namespace CryptoChan.Lib
{
    public class Option
    {
        [XmlIgnore]
        private string path => $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\CryptoChan\\setting.xml";

        public bool isPW { get; set; }
        public bool isNotify { get; set; }

        public Option()
        {
            if (Directory.Exists(path))
                Directory.CreateDirectory(path);
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
