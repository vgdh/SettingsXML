using System;
using System.IO;
using System.Xml.Serialization;

namespace WpfApplication1
{
    public class Settings
    {
        private SettingsFields _fields = new SettingsFields();
        private readonly string _xmlName;
        public Settings(string XmlNameX)
        {
            //_xmlName = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("PROGRAM_NAME.exe", "") + XmlNameX;
            _xmlName = XmlNameX;

        }

        public bool UpdeteIsEnable
        {
            get
            {
                ReadXml();
                return _fields.UpdeteIsEnable;
            }
            set
            {
                _fields.UpdeteIsEnable = value;
                WriteXml();
            }
        }
        public string TestString
        {
            get
            {
                ReadXml();
                return _fields.TestString;
            }
            set
            {
                _fields.TestString = value;
                WriteXml();
            }
        }
        private void WriteXml()
        {
            XmlSerializer ser = new XmlSerializer(typeof(SettingsFields));
            TextWriter writer = new StreamWriter(_xmlName);
            ser.Serialize(writer, _fields);
            writer.Close();
        }
        private void ReadXml()
        {
            if (File.Exists(_xmlName))
            {
                XmlSerializer ser = new XmlSerializer(typeof(SettingsFields));
                TextReader reader = new StreamReader(_xmlName);
                _fields = ser.Deserialize(reader) as SettingsFields;
                reader.Close();
            }
        }
        public class SettingsFields
        {
            public bool UpdeteIsEnable = false;
            public string TestString = "DefaultTxt";
        }
    }

}

