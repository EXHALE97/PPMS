using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Interfaces;
using Queries.Validators;

namespace Queries.Controllers
{
    public class EmployeeController
    {
        private readonly IRepositoryFactory factory;
        private readonly DataGridView dataGridView;
        private readonly StaffValidator staffValidator;
        private List<Employee> dgvElements;

        public EmployeeController(DataGridView dataGridView, IRepositoryFactory factory)
        {
            this.dataGridView = dataGridView;
            this.factory = factory;
            staffValidator = new StaffValidator();
            dgvElements = new List<Employee>();
        }
    }
}
