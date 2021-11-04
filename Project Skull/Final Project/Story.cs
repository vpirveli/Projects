using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            label2.Show();
            label1.Hide();
            pictureBox1.Image = Properties.Resources.Untitled_2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
