using System;
using System.Collections.Generic;
using System.Data.Common;
using Queries.Connection;
using Queries.Interfaces;

namespace Queries.Repositories
{
    public class StaffRepository : IStaffRepository
    {
        private DataBaseConnection dbc;

        public StaffRepository(DataBaseConnection dbc)
        {
            this.dbc = dbc;
        }

        public void Dispose()
        {

        }
    }
}
