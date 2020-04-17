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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void btnRadio_Click(object sender, EventArgs e)
		{
			frmRadio frm = new frmRadio();
			frm.ShowDialog();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void groupBox3_Enter(object sender, EventArgs e)
		{

		}

		private void button14_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (textBox1.Text == "Wail")
			{
				MessageBox.Show("success");
			}
			else
			{
				MessageBox.Show("failed");

			}
		}

		private void CheckBox_Click(object sender, EventArgs e)
		{
			CheckBox frm = new CheckBox();
			frm.ShowDialog();
		}

		private void button5_Click(object sender, EventArgs e)
		{

		}
	}
}
