﻿using System.Collections.Generic;
using System.Windows.Forms;
using Queries.Interfaces;

namespace Queries.comboBoxFillers
{
    public class ComboBoxCardNumFiller
    {
        private readonly ComboBox comboBox;
        private readonly IRepositoryFactory factory;

        public ComboBoxCardNumFiller(ComboBox comboBox, IRepositoryFactory factory)
        {
            this.comboBox = comboBox;
            this.factory = factory;
        }
    }
}
