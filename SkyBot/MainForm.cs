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

namespace SkyBot
{
    public partial class MainForm : Form
    {
        static ClassIRC SkyBot;

        ClassXML XML = new ClassXML();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            XML.XMLInt();
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Settings Settings = new Settings();
            Settings.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
