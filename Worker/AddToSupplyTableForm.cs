using System;
using System.Windows.Forms;
using Queries.Interfaces;

namespace Worker
{
    public partial class AddToSupplyTableForm : Form
    {
        private IRepositoryFactory factory;
        private DataGridView dgv;
        private int id;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkNow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNow.Checked)
            {
                tbHours.Visible = false;
                tbMinutes.Visible = false;
                label5.Visible = false;
                label4.Visible = false;
            }
            if (!checkNow.Checked)
            {
                tbHours.Visible = true;
                tbMinutes.Visible = true;
                label5.Visible = true;
                label4.Visible = true;
            }
        }

        private void tbFuelAmount_KeyPress(object sender, KeyPressEventArgs e)
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

        public AddToSupplyTableForm(int id, IRepositoryFactory factory, DataGridView dgv)
        {
            InitializeComponent();
            this.id = id;
            this.factory = factory;
            this.dgv = dgv;
        }

        private void addToSupplyTableForm_Load(object sender, EventArgs e)
        {
            cbFuelType.Items.Add("A92");
            cbFuelType.Items.Add("A95");
            cbFuelType.Items.Add("A95+");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }
    }
}
