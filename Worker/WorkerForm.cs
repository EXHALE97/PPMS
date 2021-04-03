using System;
using System.Windows.Forms;
using Queries.Interfaces;

namespace Worker
{
    public partial class WorkerForm : Form
    {
        int ID;
        IRepositoryFactory factory;

        public WorkerForm(int ID, IRepositoryFactory factory)
        {
            InitializeComponent();
            this.ID = ID;
            this.factory = factory;
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddSupply_Click(object sender, EventArgs e)
        {
           
        }

        private void RefreshTables_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnSupplyUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTableView_Click(object sender, EventArgs e)
        {

        }
    }
}
