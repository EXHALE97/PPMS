using System.Windows.Forms;
using Queries.Interfaces;
using Queries.Validators;

namespace Queries.Controllers
{
    public class CarController
    {
        private DataGridView dgv;
        private IRepositoryFactory factory;
        private CarValidator carValidator;

        public CarController(DataGridView dgv, IRepositoryFactory factory)
        {
            this.factory = factory;
            this.dgv = dgv;
            carValidator = new CarValidator();
        }
    }
}
