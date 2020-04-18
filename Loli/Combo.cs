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
    public partial class FrmCombo : Form
    {
        public FrmCombo()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DaysCombo.Items.Add("Sunday");
            DaysCombo.Items.Add("Monday");
            DaysCombo.Items.Add("Tuesday");
            DaysCombo.Items.Add("Wednesday");
            DaysCombo.Items.Add("Thursday");
            DaysCombo.Items.Add("Friday");
            DaysCombo.Items.Add("Saturday");
            DaysCombo.Items.Add("Examday");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DaysCombo.Items.Add("Sunday");
            DaysCombo.Items.Add("Monday");
            DaysCombo.Items.Add("Tuesday");
            DaysCombo.Items.Add("Wednesday");
            DaysCombo.Items.Add("Thursday");
            DaysCombo.Items.Add("Friday");
            DaysCombo.Items.Add("Saturday");
            DaysCombo.Items.Add("Examday");
        }

        private void BtnShowSelected1_Click(object sender, EventArgs e)

        {



            MessageBox.Show(DaysCombo.Text);



        }



        private void BtnShowSelected2_Click(object sender, EventArgs e)

        {



            string itemText = DaysCombo.GetItemText(DaysCombo.SelectedItem);

            MessageBox.Show(itemText);

        }



        private void BtnShowSelected3_Click(object sender, EventArgs e)

        {





            var item = DaysCombo.SelectedItem;

            if (item != null)

                MessageBox.Show(item.ToString());

        }



        private void btnRemoveByIndex_Click(object sender, EventArgs e)

        {



            DaysCombo.Items.RemoveAt(1);



        }



        private void btnRemoveByName_Click(object sender, EventArgs e)

        {



            DaysCombo.Items.Remove("Friday");

        }



        private void BackBttn_Click(object sender, EventArgs e)

        {

            this.DialogResult = DialogResult.OK;

        }



        private void Form4_Load(object sender, EventArgs e)

        {



        }



        private void BtnRemoveLast_Click(object sender, EventArgs e)

        {

            if (DaysCombo.Items.Count >= 1)

            {

                DaysCombo.Items.RemoveAt(DaysCombo.Items.Count - 1);

            }

            else

            {

                MessageBox.Show("Cant remove last item");

            }

        }



        private void DaysCombo_SelectedIndexChanged(object sender, EventArgs e)

        {



        }



        private void Remove2ndLastBttn_Click(object sender, EventArgs e)

        {

            if (DaysCombo.Items.Count >= 2)

            {

                DaysCombo.Items.RemoveAt(DaysCombo.Items.Count - 2);

            }

            else

            {

                MessageBox.Show("Cant remove 2nd last item");

            }



        }

        private void Combo_Load(object sender, EventArgs e)
        {

        }
    }

}
