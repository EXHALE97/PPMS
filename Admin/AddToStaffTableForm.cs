using System;
using System.Windows.Forms;
using Queries.Interfaces;

namespace Admin
{
    public partial class AddToStaffTableForm : Form
    {
        private IRepositoryFactory factory;
        private DataGridView dgv;

        public AddToStaffTableForm(IRepositoryFactory factory, DataGridView dgv)
        {
            InitializeComponent();
            this.factory = factory;
            this.dgv = dgv;
        }

        private void addToStaffTableForm_Load(object sender, EventArgs e)
        {
           
        }

        private void cbOrgList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
