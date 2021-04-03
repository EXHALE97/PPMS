using System.Collections.Generic;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Interfaces;
using Queries.Validators;

namespace Queries.Controllers
{
    public class DealController
    {
        private DataGridView dgv;
        private List<Deal> dgvElements;
        private IRepositoryFactory factory;
        private DealValidator dealValidator;


        public DealController(DataGridView dgv, IRepositoryFactory factory)
        {
            dgvElements = new List<Deal>();
            this.factory = factory;
            this.dgv = dgv;
            dealValidator = new DealValidator();
        }
    }
}
