using System.Collections.Generic;
using System.Windows.Forms;
using Queries.Interfaces;

namespace Queries.comboBoxFillers
{
    public class ComboBoxStaffFiller
    {
        private ComboBox cb;
        private IRepositoryFactory factory;

        public ComboBoxStaffFiller(ComboBox cb, IRepositoryFactory factory)
        {
            this.cb = cb;
            this.factory = factory;
        }
    }
}
