using EmployeeDirectory.Models;
using EmployeeDirectory.Services;

namespace EmployeeDirectory
{
    public partial class AddEmployeeForm : Form
    {
        private readonly MainForm _mainForm;
        private readonly IEmployeeService _employeeService;

        public AddEmployeeForm(MainForm mainForm, IEmployeeService employeeService)
        {
            _mainForm = mainForm;
            _employeeService = employeeService;

            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) || string.IsNullOrWhiteSpace(jobTypeTextBox.Text))
            {
                formValidationLabel.Show();
            }
            else
            {
                formValidationLabel.Hide();

                Employee employee = new Employee()
                {
                    Name = nameTextBox.Text,
                    JobTitle = jobTypeTextBox.Text
                };

                _employeeService.AddEmployee(employee);
                _mainForm.ReloadData();
                Close();

                MessageBox.Show("New record was added successfully", "Success");
            }
        }
    }
}
