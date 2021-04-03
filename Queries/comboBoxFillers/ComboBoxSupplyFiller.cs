using System.Windows.Forms;
using Queries.Interfaces;

namespace Queries.comboBoxFillers
{
    public class ComboBoxSupplyFiller
    {
        private ComboBox cb;
        private IRepositoryFactory factory;

        public ComboBoxSupplyFiller(ComboBox cb, IRepositoryFactory factory)
        {
            this.cb = cb;
            this.factory = factory;
        }

        public void СbStationListFill()
        {
        }
    }
}
