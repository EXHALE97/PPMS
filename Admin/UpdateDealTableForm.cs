using System;
using System.Windows.Forms;
using Queries.Interfaces;

namespace Admin
{
    public partial class UpdateDealTableForm : Form
    {
        private IRepositoryFactory factory;
        private DataGridViewRow updateRow;
        private DataGridView dgv;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }  

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void tbFuelamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbDealprice_KeyPress(object sender, KeyPressEventArgs e)
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

        public UpdateDealTableForm(DataGridViewRow updateRow, IRepositoryFactory factory, DataGridView dgv)
        {
            InitializeComponent();
            this.updateRow = updateRow;
            this.factory = factory;
            this.dgv = dgv;
        }

        private void updateDealTableForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
