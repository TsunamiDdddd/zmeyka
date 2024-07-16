using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form2()
        {
            InitializeComponent();
        }

        public void buttonstart_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.timer1.Interval = 100 * (indexspeed + 5);
            f1.Show();
        }

        private void buttontable_Click(object sender, EventArgs e)
        {

        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBoxlevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxspeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexspeed = listBoxspeed.SelectedIndex;
            label3.Text = indexspeed.ToString();
        }
    }
}
