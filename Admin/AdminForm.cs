using System;
using System.Windows.Forms;
using Queries.Interfaces;
using Queries.comboBoxFillers;
using Queries.Controllers;

namespace Admin
{
    public partial class AdminForm : Form
    {
        private readonly IRepositoryFactory factory;
        private readonly EmployeeController employeeController;
        private readonly CarController clientController;
        private readonly AccountController accountingController;
        private readonly DealController dealController;
        private readonly StationController stationController;
        private readonly SupplyController supplyController;
        private readonly ComboBoxDealFiller dealComboBox;
        private readonly ComboBoxAccountingFiller accountingComboBox;
        private readonly ComboBoxSupplyFiller supplyComboBox;

        public AdminForm(IRepositoryFactory factory)
        {
            InitializeComponent();
            this.factory = factory;
            stationController = new StationController(dgvVievAZS, factory);
            employeeController = new EmployeeController(dgvViewStaff, factory);
            clientController = new CarController(dgvViewCars, factory);
            accountingController = new AccountController(dgvViewAccounting, factory);
            dealController = new DealController(dgvViewDeal, factory);
            supplyController = new SupplyController(dgvViewSupply, factory);
            dealComboBox = new ComboBoxDealFiller(cbDealFilterByStation, factory);
            accountingComboBox = new ComboBoxAccountingFiller(cbAccountingFilterByStation, factory);
            supplyComboBox = new ComboBoxSupplyFiller(cbSupplyFilterByStation, factory);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать, администратор!");
        }

        private void btnTableView_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new UpdateStaffTableForm(dgvViewStaff.CurrentRow, factory, dgvViewStaff).ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddToStaffTableForm(factory, dgvViewStaff).ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }

        private void btnFindDeals_Click(object sender, EventArgs e)
        {
            new DealList(Convert.ToInt32(dgvViewCars[0, dgvViewCars.CurrentRow.Index].Value), factory).ShowDialog();
        }

        private void btnCarAdd_Click(object sender, EventArgs e)
        {
            new AddToCarTableForm(factory, dgvViewCars).ShowDialog();
        }

        private void btnDealUpdate_Click(object sender, EventArgs e)
        {
            new UpdateDealTableForm(dgvViewDeal.CurrentRow, factory, dgvViewDeal).ShowDialog();
        }

        private void btnStationAdd_Click(object sender, EventArgs e)
        {
            new AddToStationTableForm(factory, dgvViewCars).ShowDialog();
        }

        private void RefreshTables_Click(object sender, EventArgs e)
        {
        }

        private void AddNewAdmin_Click(object sender, EventArgs e)
        {
            new AddNewAdminForm(factory).ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new AddWorkerToLoginTableForm(dgvViewStaff.CurrentRow, factory).ShowDialog();
        }

        private void btnActivateCarCard_Click(object sender, EventArgs e)
        {
            new AddUserToLoginTableForm(dgvViewCars.CurrentRow, factory).ShowDialog();
        }

        private void btnTableStationView_Click(object sender, EventArgs e)
        {
        }

        private void btnTableCarView_Click(object sender, EventArgs e)
        {
        }

        private void btnTableDealView_Click(object sender, EventArgs e)
        {
        }

        private void cbFilterByStation_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbAccountingFilterByStation_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbSupplyFilterByStation_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnTableAccountingView_Click(object sender, EventArgs e)
        {
        }

        private void btnTableSupplyView_Click(object sender, EventArgs e)
        {
        }
    }
}
