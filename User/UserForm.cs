using System;
using System.Windows.Forms;
using Queries.Interfaces;

namespace User
{
    public partial class UserForm : Form //форма пользователя
    {
        private IRepositoryFactory factory;
        private string cardnum;

        public UserForm(string cardnum, IRepositoryFactory factory)
        {
            InitializeComponent();
            this.cardnum = cardnum;
            this.factory = factory; 
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать!");
            lbSessionName1.Text = "Вы зашли как:" + cardnum;
            lbSessionName2.Text = "Вы зашли как:" + cardnum;
        }

        private void dataView1_Click(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void btnShowUserDeal_Click(object sender, EventArgs e)
        {
        }

        private void lbSessionName1_Click(object sender, EventArgs e)
        {

        }
    }
}
