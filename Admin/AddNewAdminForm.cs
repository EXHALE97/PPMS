using System;
using System.Windows.Forms;
using Queries.Interfaces;

namespace Admin
{
    public partial class AddNewAdminForm : Form
    {
        private readonly IRepositoryFactory factory;

        public AddNewAdminForm(IRepositoryFactory factory)
        {
            InitializeComponent();
            this.factory = factory;
            tbPass.UseSystemPasswordChar = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                tbPass.UseSystemPasswordChar = false;
            }
            else tbPass.UseSystemPasswordChar = true;
        }
    }
}
