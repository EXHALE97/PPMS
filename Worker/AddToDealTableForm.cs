using System;
using System.Windows.Forms;
using Queries.Interfaces;

namespace Worker
{
    public partial class AddToDealTableForm : Form
    {
        private DataGridView dgv;
        private IRepositoryFactory factory;
        private int Id;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public AddToDealTableForm(int ID, IRepositoryFactory factory, DataGridView dgv)
        {
            InitializeComponent();
            this.factory = factory;
            this.dgv = dgv;
            this.Id = ID;
        }

        private void checkNow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNow.Checked)
            {
                tbHours.Visible = false;
                tbMinutes.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            }
            if (!checkNow.Checked)
            {
                tbHours.Visible = true;
                tbMinutes.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void tbFuelamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbDealPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbMinutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void dealDatePick_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbDealPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void updateDealTableForm_Load(object sender, EventArgs e)
        {
        }
    }
}
