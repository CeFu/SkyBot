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

        public void XMLCheck()
        {
            try
            {
                if (!File.Exists(SettingsFile))
                {
                   
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
