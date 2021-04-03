using System.Collections.Generic;
using System.Windows.Forms;
using Queries.Interfaces;

namespace Queries.comboBoxFillers
{
    public class ComboBoxDealFiller
    {
        private ComboBox cb;
        private IRepositoryFactory factory;

        public ComboBoxDealFiller(ComboBox cb, IRepositoryFactory factory)
        {
            this.cb = cb;
            this.factory = factory;
        }
    }
}
