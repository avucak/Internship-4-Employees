using AppForProjectManagers.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForProjectManagers.Presentation
{
    public partial class AddProject : Form
    {
        private ProjectsRepository _projectsRepository;
        private EmployeesRepository _employeesRepository;
        public EmployeeProjectRepository _employeeProjectRepository;
        public AddProject(ProjectsRepository projectsRepository,EmployeesRepository employeesRepository,EmployeeProjectRepository employeeProjectRepository)
        {
            _projectsRepository = projectsRepository;
            _employeesRepository = employeesRepository;
            _employeeProjectRepository = employeeProjectRepository;
            InitializeComponent();
            LoadEmployees();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoadEmployees()
        {
            foreach (var employee in _employeesRepository.GetAll())
            {
                listOfEmployees.Items.Add(employee.OIB + " " + employee.Name + " " + employee.Surname);
            }
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            if (txtProjectName.Text == "")
            {
                MessageBox.Show("Projekt mora imati ime");
                return;
            }

            var name = txtProjectName.Text;
            var startDate = startDatePicker.Value;
            var endDate = endDatePicker.Value;
            if (endDate <= startDate)
            {
                MessageBox.Show("Početni datum ne smije biti veći od krajnjeg datuma");
                return;
            }
            if (listOfEmployees.CheckedItems.Count <= 0)
            {
                MessageBox.Show("Projekt mora imati barem jednog radnika");
                return;
            }
            foreach (var employee in listOfEmployees.CheckedItems)
            {
                var oib = employee.ToString().Split()[0];
                var hoursOnProject = new HoursOnProject(int.Parse(oib),name, _employeeProjectRepository);
                hoursOnProject.ShowDialog();
            }

            Close();
        }
    }
}
