using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zmeyka
{
    public partial class Form3 : Form
    {
        public int intervalofmove;
        private int speed;
        public Form3(int intervalofmove,int numberofobstacles,int score,TimeSpan ts)
        {
            InitializeComponent();
            this.intervalofmove = intervalofmove;
            speed = 5-intervalofmove / 100;
            labelLevel.Text = numberofobstacles.ToString();
            labelScore.Text = score.ToString();
            labelSpeed.Text = speed.ToString();
            labelTime.Text = ts.ToString();
            DateTime thisDay = DateTime.Now;
            string[] result = { "Дата: "+ thisDay.ToString("d"),
            "Уровень: "+numberofobstacles.ToString(),
            "Скорость: "+ speed.ToString(),
            "Счёт: "+score.ToString(),
            "Время прохождения: "+ts.ToString(),
            ""};
            File.AppendAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Table.txt"),result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
