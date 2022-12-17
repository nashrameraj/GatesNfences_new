using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Form10 f10 = new Form10();
        private void button2_Click(object sender, EventArgs e)
        {
            
            f10.order.Add("Entrance of Eden, Size: 10 ft x 6 ft, Prize: $5,400");
            f10.total += 5400;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            f10.order.Add("Entrance of Eden, Size: 12 ft x 6 ft, Prize: $6,480");
            f10.total += 6480;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f10.order.Add("Entrance of Eden, Size: 14 ft x 6 ft, Prize: $7,560");
            f10.total += 7560;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f10.order.Add("Entrance of Eden, Size: 16 ft x 6 ft, Prize: $8,640");
            f10.total += 8640;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f10.Show();
        }
    }
}
