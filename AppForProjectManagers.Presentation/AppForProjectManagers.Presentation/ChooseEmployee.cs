using AppForProjectManagers.Data.Models;
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
    public partial class ChooseEmployee : Form
    {
        private List<Employee> _employees;
        private EmployeesRepository _employeesRepository;
        private EmployeeProjectRepository _employeeProjectRepository;
        private ProjectsRepository _projectsRepository;
        public ChooseEmployee(EmployeesRepository employeesRepository, EmployeeProjectRepository employeeProjectRepository, ProjectsRepository projectsRepository)
        {
            InitializeComponent();
            _employeesRepository = employeesRepository;
            _employeeProjectRepository = employeeProjectRepository;
            _projectsRepository = projectsRepository;
            FillComboBox();
        }

        private void FillComboBox()
        {
            cbChooseEmployee.Items.Clear();
            _employees = _employeesRepository.GetAll();
            foreach (var employee in _employees)
            {
                cbChooseEmployee.Items.Add(employee.OIB + " " + employee.Name + " " + employee.Surname);
            }
        }

        private void btnSeeDetails_Click(object sender, EventArgs e)
        {
            if (cbChooseEmployee.SelectedIndex < 0)
            {
                MessageBox.Show("Trebate odabrati radnika");
                return;
            }

            var selected = cbChooseEmployee.Text.Split();
            Employee employee = null;
            foreach (var em in _employees)
            {
                if (em.OIB.ToString() == selected[0])
                    employee = em;
            }

            var employeeDetails = new SeeEmployeeDetails(employee,_employeeProjectRepository,_projectsRepository);
            employeeDetails.Show();
        }
    }
}
