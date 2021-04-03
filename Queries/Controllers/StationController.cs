using System.Windows.Forms;
using Queries.Interfaces;
using Queries.Validators;

namespace Queries.Controllers
{
    public class StationController
    {
        private DataGridView dgv;
        private StationValidator stationValidator;
        private IRepositoryFactory factory;

        public StationController(DataGridView dgv, IRepositoryFactory factory)
        {
            this.factory = factory;
            this.dgv = dgv;
            stationValidator = new StationValidator();
        }
    }
}
