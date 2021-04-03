using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using Queries.Connection;
using Queries.Entities;
using Queries.Interfaces;

namespace Queries.Repositories
{
    public class AccountRepository : BaseRepository, IAccountRepository
    {
        public AccountRepository(DataBaseConnection dbc)
        {
            DataBaseConnection = dbc;
        }
    }
}
