using Queries.Connection;
using Queries.Interfaces;

namespace Queries.Repositories
{
    public class CarRepository : ICarRepository
    {
        private DataBaseConnection dbc;

        public CarRepository(DataBaseConnection dbc)
        {
            this.dbc = dbc;
        }

        public void Dispose()
        {

        }
    }
}
