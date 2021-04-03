using System;
using System.Windows.Forms;
using Queries.Interfaces;

namespace Admin
{
    public partial class UpdateStaffTableForm : Form
    {
        private IRepositoryFactory factory;
        private DataGridViewRow updateRow;
        private DataGridView dgv;

        public UpdateStaffTableForm(DataGridViewRow updateRow, IRepositoryFactory factory, DataGridView dgv)
        {
            InitializeComponent();
            this.updateRow = updateRow;
            this.factory = factory;
            this.dgv = dgv;
        }

        private void tbSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void updateStaffTableForm_Load(object sender, EventArgs e)
        {
            tbSurname.Text = updateRow.Cells["surname"].Value.ToString().Trim().Replace(" ", string.Empty);
            tbName.Text = updateRow.Cells["name"].Value.ToString().Trim().Replace(" ", string.Empty);
            tbFunction.Text = updateRow.Cells["function"].Value.ToString().Trim().Replace(" ", string.Empty);
            tbFunction.Text = updateRow.Cells["function"].Value.ToString().Trim().Replace(" ", string.Empty);
            tbSalary.Text = updateRow.Cells["salary"].Value.ToString().Trim().Replace(" ", string.Empty);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
