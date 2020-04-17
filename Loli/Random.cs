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
    public partial class Random : Form
    {
        public Random()
        {
            InitializeComponent();
        }

        private void Random_Load(object sender, EventArgs e)
        {


            int r = y.Next(0, 255);
            int g = y.Next(0, 255);
            int b = y.Next(0, 255);

            label1.Text = Convert.ToString(r) + "-" + Convert.ToString(g) + "-" + Convert.ToString(b);
            GenerateBtn.BackColor = Color.FromArgb(r, g, b);
            this.BackColor = Color.FromArgb(255 - r, 255 - g, 255 - b);


        }

        private void BackBttn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void RandomNoBtn_Click(object sender, EventArgs e)
        {

            RandomBtn.Text = Convert.ToString(y.Next(1, 10));

        }

        internal int Next(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
