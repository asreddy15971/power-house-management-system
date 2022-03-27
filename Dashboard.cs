using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uc_gen1.BringToFront(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uc_expenses1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            uc_settings2.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            uc_reports1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
