using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.IO;
using System.Windows.Forms;


namespace SkyBot
{
    class ClassXML
    {
        static XmlTextReader xreader;
        static XmlTextWriter xwriter;
        string SettingsFile = "settings.xml";

        public void XMLInt()
        {
            XMLCheck();
        }

        public void XMLCheck()
        {
            try
            {
                if (!File.Exists(SettingsFile))
                {
                    xwriter = new XmlTextWriter(SettingsFile, null);
                    xwriter.Formatting = Formatting.Indented;
                    xwriter.WriteStartDocument();
                    xwriter.WriteStartElement("settings");
                    xwriter.WriteStartElement("twitch_server");
                    xwriter.WriteAttributeString("value", null);
                    xwriter.WriteEndElement();
                    xwriter.WriteStartElement("twitch_name");
                    xwriter.WriteAttributeString("value", null);
                    xwriter.WriteEndElement();
                    xwriter.WriteStartElement("twitch_auth");
                    xwriter.WriteAttributeString("value", null);
                    xwriter.WriteEndElement();
                    xwriter.WriteEndDocument();
                    xwriter.Close();
                }
            }

            catch (Exception ex)
            {
                
            }
            finally
            {
                //Nothing yet
            }
        }
    }
}
