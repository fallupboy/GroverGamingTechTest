using EmployeeDirectory.Models;
using EmployeeDirectory.Services;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace EmployeeDirectory
{
    public partial class MainForm : Form
    {
        private EmployeeContext _dbContext;
        private IEmployeeService _employeeService;

        public MainForm(IEmployeeService employeeService)
        {
            InitializeComponent();
            _employeeService = employeeService;
        }

        protected override void OnLoad(EventArgs e)
        {
            _dbContext = new EmployeeContext();

            // Uncomment the line below to start with a new database.
            //_dbContext.Database.EnsureDeleted();
            _dbContext.Database.EnsureCreated();
            _dbContext.Employees.Load();

            employeeBindingSource.DataSource = _dbContext.Employees.Local.ToBindingList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm(this, _employeeService);
            addEmployeeForm.ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!IsEmployeeSelected())
            {
                MessageBox.Show("Please select employee!");
            }
            else
            {
                UpdateEmployeeForm updateEmployeeForm = new UpdateEmployeeForm(this, _employeeService);
                updateEmployeeForm.ShowDialog();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (!IsEmployeeSelected())
            {
                MessageBox.Show("Please select employee!");
            }

            else if (MessageBox.Show("Are you sure you want to delete the record?", "Delete Confirmation",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (EmployeeContext db = new EmployeeContext())
                {
                    Employee selectedEmployee = GetSelectedEmployee();
                    _employeeService.DeleteEmployee(selectedEmployee);

                    ReloadData();
                    MessageBox.Show("Record was deleted successfully", "Success");
                }
            }
        }

        public void ReloadData()
        {
            using (EmployeeContext db = new EmployeeContext())
            {
                employeesDataGridView.DataSource = db.Employees.ToList();
            }
        }

        public Employee GetSelectedEmployee()
        {
            return (Employee)employeesDataGridView.CurrentRow.DataBoundItem;
        }

        public bool IsEmployeeSelected()
        {
            return employeesDataGridView.CurrentRow != null;
        }
    }
}