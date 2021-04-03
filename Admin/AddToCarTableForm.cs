using System;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Controllers;
using Queries.Interfaces;

namespace Admin
{
    public partial class AddToCarTableForm : Form
    {
        private readonly DataGridView dgv;
        private readonly IRepositoryFactory factory;

        public AddToCarTableForm(IRepositoryFactory factory, DataGridView dgv)
        {
            InitializeComponent();
            this.factory = factory;
            this.dgv = dgv;
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
