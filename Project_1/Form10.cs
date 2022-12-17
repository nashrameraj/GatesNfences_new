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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        public List<string> order = new List<string>();
        public int total = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order of total " + total + " is placed.");
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            Label label1 = new Label();
            label1.Text = "Total amount = " + total;
            label1.Location = new Point(38, 44);
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.BackColor = Color.Aquamarine;

            this.Controls.Add(label1);

            TextBox textbox1 = new TextBox();
            textbox1.Text = string.Join(", " +
                    " ", order);
            textbox1.Location = new Point(36, 89);
            textbox1.AutoSize = true;
            textbox1.Font = new Font("Microsoft Sans Serif", 8);
            textbox1.BorderStyle = BorderStyle.Fixed3D;
            textbox1.BackColor = Color.White;
            textbox1.ReadOnly = true;
            textbox1.Multiline = true;
            textbox1.Size = new Size(254, 233);

            this.Controls.Add(textbox1);
        }
    }
}
