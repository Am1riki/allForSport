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
    public partial class ModeForm : Form
    {
        public ModeForm()
        {
            InitializeComponent();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            Form F2 = new Form2();
            F2.Show();
            this.Hide();
        }
    }
}
