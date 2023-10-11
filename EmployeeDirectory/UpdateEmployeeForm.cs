using EmployeeDirectory.Models;
using EmployeeDirectory.Services;

namespace EmployeeDirectory
{
    public partial class UpdateEmployeeForm : Form
    {
        private readonly MainForm _mainForm;
        private readonly IEmployeeService _employeeService;

        public UpdateEmployeeForm(MainForm mainForm, IEmployeeService employeeService)
        {
            _mainForm = mainForm;
            _employeeService = employeeService;

            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                Id = Convert.ToInt32(employeeIdTextBox.Text),
                Name = employeeNameTextBox.Text,
                JobTitle = employeeJobTypeTextBox.Text
            };

            _employeeService.UpdateEmployee(employee);
            _mainForm.ReloadData();

            Close();
            MessageBox.Show("Record was updated successfully", "Success");
        }

        private void UpdateEmployeeForm_Load(object sender, EventArgs e)
        {
            Employee selectedEmployee = _mainForm.GetSelectedEmployee();
            employeeIdTextBox.Text = selectedEmployee.Id.ToString();
            employeeNameTextBox.Text = selectedEmployee.Name;
            employeeJobTypeTextBox.Text = selectedEmployee.JobTitle;
        }
    }
}
