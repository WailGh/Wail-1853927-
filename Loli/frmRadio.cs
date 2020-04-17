using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loli
{
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.ShowDialog();
        }

        private void Red3_CheckedChanged(object sender, EventArgs e)
        {
            if (Red3.Checked == true)
                Red3.ForeColor = Color.FromArgb(255, 0, 0);
            else
                Red3.ForeColor = Color.FromArgb(0, 0, 0);

            {

            }
            Red3.ForeColor = Color.FromArgb(255, 0, 0);
        }

        private void Green3_CheckedChanged(object sender, EventArgs e)
        {
            Green3.ForeColor = Color.FromName("green");
        }

        private void Blue3_CheckedChanged(object sender, EventArgs e)
        {
            Blue3.ForeColor = Color.FromName("blue");
        }

        private void Yellow3_CheckedChanged(object sender, EventArgs e)
        {
            Yellow3.ForeColor = Color.FromName("yellow");
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Red3.ForeColor = Color.FromArgb(0, 0, 0);
            Yellow3.ForeColor = Color.FromArgb(0, 0, 0);
            Blue3.ForeColor = Color.FromArgb(0, 0, 0);
            Green3.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void Groupped_Enter(object sender, EventArgs e)
        {

        }
        
        private void Red2_CheckedChanged(object sender, EventArgs e)
        {
            if (Red2.Checked == true)
                Red2.ForeColor = Color.FromArgb(255, 0, 0);
            else
                Red2.ForeColor = Color.FromArgb(0, 0, 0);

            {

            }
            Red2.ForeColor = Color.FromArgb(255, 0, 0);
        }

        private void Green2_CheckedChanged(object sender, EventArgs e)
        {
            Green2.ForeColor = Color.FromName("green");
        }

        private void Blue2_CheckedChanged(object sender, EventArgs e)
        {
            Blue2.ForeColor = Color.FromName("blue");
        }

        private void Yellow2_CheckedChanged(object sender, EventArgs e)
        {
            Yellow2.ForeColor = Color.FromName("yellow");
        }

        private void Red2_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}