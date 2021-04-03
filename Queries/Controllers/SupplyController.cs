using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Interfaces;
using Queries.Validators;

namespace Queries.Controllers
{
    public class SupplyController
    {
        private DataGridView dgv;
        private List<Supply> dgvElements;
        private IRepositoryFactory factory;
        private SupplyValidator supplyValidator;

        public SupplyController(DataGridView dgv, IRepositoryFactory factory)
        {
            dgvElements = new List<Supply>();
            this.dgv = dgv;
            this.factory = factory;
            supplyValidator = new SupplyValidator();
        }
    }
}
