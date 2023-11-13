using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment_C_
{
    public partial class problem_2 : Form
    {
        public problem_2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ONE");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TWO");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FIVE");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THREE");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FOUR");
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            problem_1 Npage = new problem_1();
            this.Hide();
            Npage.Show();
        }*/
    }
}
