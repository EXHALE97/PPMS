using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Interfaces;

namespace Queries.Controllers
{
    public class AccountController
    {
        private DataGridView dgv;
        private List<Accounting> dgvElements;
        private IRepositoryFactory factory;

        public AccountController(DataGridView dgv, IRepositoryFactory factory)
        {
            dgvElements = new List<Accounting>();
            this.dgv = dgv;
            this.factory = factory;
        }
    }
}
