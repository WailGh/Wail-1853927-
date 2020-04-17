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
    public partial class frmRandomCombo : Form
    {
        public frmRandomCombo()
        {
            InitializeComponent();
        }

        private void frmRandomCombo_Load(object sender, EventArgs e)
        {
            Randomcom1.ResetText();
            Randomcom1.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 51); i++)
            {
                Randomcom1.Items.Add(r.Next(100, 999));
            }
        }

        private void ResetBttn_Click(object sender, EventArgs e)
        {

            Randomcom1.ResetText();
            Randomcom1.Items.Clear();
            RadioLs1.Checked = false;
            RadioGrt1.Checked = false;
        }

        private void cmbRandom_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Convert.ToInt32(Randomcom1.Text) > 499)
            {
                RadioGrt1.Checked = true;
            }
            else
            {
                RadioLs1.Checked = true;
            }

        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void BtnGenerate2_Click(object sender, EventArgs e)
        {
            RandomCom.ResetText();
            RandomCom.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(2, 9) - 1; i++)
            {
                RandomCom.Items.Add(r.Next(10, 99));
            }
            label1.Text = Convert.ToString(RandomCom.Items.Count);
        }

        private void RandomCom_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Convert.ToInt32(RandomCom.Text) > 49)
            {
                RadioGrt2.Checked = true;
            }
            else
            {
                RadioLs2.Checked = true;
            }

        }

        private void ResetBttn2_Click(object sender, EventArgs e)
        {
            RandomCom.ResetText();
            RandomCom.Items.Clear();
            RadioLs2.Checked = false;
            RadioGrt2.Checked = false;
            label1.Text = Convert.ToString(RandomCom.Items.Count);

        }

        private void rdoLess_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmRandomCombo_Load(object sender, EventArgs e)
        {

        }

    }
}
