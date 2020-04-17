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
    public partial class CheckBox : Form
    {
        public CheckBox()
        {
            InitializeComponent();
        }

        private void chkDonut_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(chkCoffee.Text);
            if (chkCoffee.Checked == true)
                MessageBox.Show(chkCoffee.Text);
            {
                MessageBox.Show(chkDonut.Text);
                if (chkDonut.Checked == true)
                    MessageBox.Show(chkDonut.Text);
            } 
        }

        private void chkCoffee_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void btnShow_Load(object sender, EventArgs e)
        {
            string msg = "";

            if (chkCoffee.Checked == true)
            {
                msg = chkCoffee.Text;
            }

            if (chkDonut.Checked == true)
            {
                msg = msg + " " + chkDonut.Text;
            }

            if (chkBrownie.Checked == true)
            {
                msg = msg + " " + chkBrownie.Text;
            }

            if (msg.Length > 0)
            {
                MessageBox.Show(msg + " selected ");
            }
            else 
            {
                MessageBox.Show("Nothing selected");
            }

        }


    }

    private void BackBttn_Click(object sender, EventArgs e)
        {
           
        }
    }
