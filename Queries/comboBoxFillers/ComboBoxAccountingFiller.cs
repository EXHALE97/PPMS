using System.Windows.Forms;
using Queries.Interfaces;

namespace Queries.comboBoxFillers
{
    public class ComboBoxAccountingFiller
    {
        private readonly ComboBox comboBox;
        private readonly IRepositoryFactory factory;

        public ComboBoxAccountingFiller(ComboBox comboBox, IRepositoryFactory factory)
        {
            this.comboBox = comboBox;
            this.factory = factory;
        }
    }
}
