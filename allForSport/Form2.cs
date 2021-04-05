using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allForSport
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            Form f = new Form4();
            f.Show();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            Form f = new Form5();
            f.Show();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            Form f = new Form6Authentity();
            this.Opacity = 0;
            f.Owner = this;
            f.ShowDialog();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void advButton1_Click(object sender, EventArgs e)
        {
            Form f = new Form10();
            f.Show();
        }

        private void advButton2_Click(object sender, EventArgs e)
        {
            Form f = new Form10();
            f.Show();
        }

        private void advButton3_Click(object sender, EventArgs e)
        {
            Form f = new Form10();
            f.Show();
        }
    }
}
