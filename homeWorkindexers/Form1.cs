using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeWorkindexers
{
    public partial class Form1 : Form
    {
        Weather w1 = new Weather();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double D = w1.GetMARRYWeather(Day.Text);
            Tempture.Text = D.ToString();
            
        }

        private void Day_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tempture_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
