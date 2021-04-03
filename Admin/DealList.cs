using System;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.Interfaces;

namespace Admin
{
    public partial class DealList : Form
    {
        private int id;
        private IRepositoryFactory factory;
        public DealList(int id, IRepositoryFactory factory)
        {
            InitializeComponent();
            this.id = id;
            this.factory = factory; 
        }

        private void DealListForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
