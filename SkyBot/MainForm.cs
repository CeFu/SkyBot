using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkyBot
{
    public partial class MainForm : Form
    {
        static ClassIRC SkyBot;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Settings Settings = new Settings();
            Settings.Show();
        }
    }
}
