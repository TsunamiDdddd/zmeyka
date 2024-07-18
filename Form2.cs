using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zmeyka
{
    public partial class Form2 : Form
    {
        public int indexspeed = 0;
        public int indexlevel = 0;
        public Form2()
        {
            InitializeComponent();
        }

        public void buttonstart_Click(object sender, EventArgs e)
        {
            int intervalofmove = 100 * (5 - indexspeed);
            int numberofobstacles = indexlevel+1;
            Form1 f1 = new(intervalofmove, numberofobstacles);
            f1.Show();
        }

        private void buttontable_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe",Path.Combine( Directory.GetCurrentDirectory(),"Table.txt"));
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBoxlevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexlevel = listBoxlevel.SelectedIndex;
        }

        private void listBoxspeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexspeed = listBoxspeed.SelectedIndex;
        }
    }
}
