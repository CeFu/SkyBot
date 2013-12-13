using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace SkyBot
{
    public partial class Settings : Form
    {

        string Server, Username, AuthCode;
        static XmlTextReader xreader;
        static XmlTextWriter xwriter;

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            XmlTextReader xreader = new XmlTextReader("settings.xml");

            xreader.ReadToFollowing("twitch_server");
            Server = xreader.GetAttribute("value");
            xreader.ReadToFollowing("twitch_name");
            Username = xreader.GetAttribute("value");
            xreader.ReadToFollowing("twitch_auth");
            AuthCode = xreader.GetAttribute("value");

            xreader.Close();

            tbServer.Text = Server;
            tbUsername.Text = Username;
            tbAuth.Text = AuthCode;

            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbServer_TextChanged(object sender, EventArgs e)
        {
            Server = tbServer.Text;

            var doc = XDocument.Load("settings.xml");
            doc.XPathSelectElement("settings/twitch_server").Attribute("value").Value = tbServer.Text;
            doc.Save("settings.xml");
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            Username = tbUsername.Text;

            var doc = XDocument.Load("settings.xml");
            doc.XPathSelectElement("settings/twitch_name").Attribute("value").Value = tbUsername.Text;
            doc.Save("settings.xml");
            
        }

        private void tbAuthPassword_TextChanged(object sender, EventArgs e)
        {
            AuthCode = tbAuth.Text;

            var doc = XDocument.Load("settings.xml");
            doc.XPathSelectElement("settings/twitch_auth").Attribute("value").Value = tbAuth.Text;
            doc.Save("settings.xml");
        }
    }
}
