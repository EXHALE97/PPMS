using System;
using System.Windows.Forms;
using Queries.Interfaces;

namespace Admin
{
    public partial class AddWorkerToLoginTableForm : Form
    {
        private DataGridViewRow row;
        private IRepositoryFactory factory;

        public AddWorkerToLoginTableForm(DataGridViewRow row, IRepositoryFactory factory)
        {
            InitializeComponent();
            this.row = row;
            this.factory = factory;
        }

        private void AddToLoginTableForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            tbPass.UseSystemPasswordChar = !checkPass.Checked;
        }
    }
}
