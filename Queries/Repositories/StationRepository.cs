﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using Queries.Connection;
using Queries.Entities;
using Queries.Interfaces;

namespace Queries.Repositories
{
    public class StationRepository : IStationRepository
    {
        private DataBaseConnection dbc;

        public StationRepository(DataBaseConnection dbc)
        {
            this.dbc = dbc;
        }

        public void Dispose()
        {

        }
    }
}
