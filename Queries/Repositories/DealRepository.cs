using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using Queries.Connection;
using Queries.Interfaces;


namespace Queries.Repositories
{
    public class DealRepository : IDealRepository
    {
        private DataBaseConnection dbc;

        public DealRepository(DataBaseConnection dbc)
        {
            this.dbc = dbc;
        }

        public void Dispose()
        {

        }
    }
}
