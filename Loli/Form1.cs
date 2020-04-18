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
		private int attempt;
		private string username;

		public int MaxAttempts { get; private set; }

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

		private void txtPass_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtUser_TextChanged(object sender, EventArgs e)
		{
			if (txtUser.Text == "Wail")
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
			FrmCombo frm = new FrmCombo();
			frm.ShowDialog();
		}

		private void LoginBttn_Click(object sender, EventArgs e)
		{
			if (txtUser.Text == "Wail")
				if (txtPass.Text == "1234")
					MessageBox.Show("Login Succesful");
				else
					MessageBox.Show("Incorrect Passsword");
			else
			{
				MessageBox.Show("Incorrect Username");
			}
			while ( attempt <= MaxAttempts )
			{
				if (txtUser.Text != username)
				{
					MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + "attempt remainig");
					attempt++;
					txtUser.Clear();
					txtPass.Clear();
					return;
				}
				else
				{
					attempt = 0;
					MessageBox.Show("Login Succesful");
					txtUser.Clear();
					txtPass.Clear();

					LoginBttn.Text = "Logout";
					
					break;
				}
			}
		}
	}
}

