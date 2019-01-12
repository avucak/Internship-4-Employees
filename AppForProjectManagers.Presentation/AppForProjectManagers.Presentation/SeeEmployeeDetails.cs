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
    public partial class SeeEmployeeDetails : Form
    {
        private Employee _employee;
        private EmployeeProjectRepository _employeeProjectRepository;
        private ProjectsRepository _projectsRepository;
        private EmployeesRepository _employeesRepository;
        public SeeEmployeeDetails(Employee employee, EmployeeProjectRepository employeeProjectRepository,ProjectsRepository projectsRepository, EmployeesRepository employeesRepository)
        {
            _projectsRepository = projectsRepository;
            _employeeProjectRepository = employeeProjectRepository;
            _employee = employee;
            _employeesRepository = employeesRepository;
            InitializeComponent();
            FillAndDisable();
        }

        private void FillAndDisable()
        {
            ColorIndicatorButton();
            txtName.Text = _employee.Name;
            txtName.ReadOnly = true;
            txtSurname.Text = _employee.Surname;
            txtSurname.ReadOnly = true;
            txtOIB.Text = _employee.OIB.ToString();
            txtOIB.ReadOnly = true;
            DateOfBirthPicker.Value = _employee.DateOfBirth;
            DateOfBirthPicker.Enabled = false;
            cbPosition.Text = _employee.Position.ToString();
            cbPosition.Enabled = false;
            var projectList = _employeeProjectRepository.GetAllProjectsEmployeeWorksOn(_employee);
            var allProjects = _projectsRepository.GetAll();
            txtHoursThisWeek.ReadOnly = true;

            var numberOfActiveProjects = 0;
            var numberOfPlannedProjects = 0;
            var numberOfFinnishedProjects = 0;
            foreach (var project in projectList)
            {
                foreach (var pr in allProjects)
                {
                    if (pr.Name == project)
                    {
                        if (pr.ProjectState() == "active")
                            numberOfActiveProjects++;
                        else if (pr.ProjectState() == "planned")
                            numberOfPlannedProjects++;
                        else
                            numberOfFinnishedProjects++;
                    }
                    
                }
                var hours = _employeeProjectRepository.ReturnHours(_employee.OIB, project);
                ListOfProjects.Items.Add($"{project} ({hours} hours)");
            }
            ListOfProjects.Enabled = false;
            lblFinishedProjects.Text += numberOfFinnishedProjects;
            lblActiveProjects.Text += numberOfActiveProjects;
            lblPlannedProjects.Text += numberOfPlannedProjects;

        }

        private void ColorIndicatorButton()
        {
            var hoursThisWeek =
                _employeeProjectRepository.CalculateAllHoursThisWeekForEmployee(_employee.OIB, _projectsRepository.GetAll());
            txtHoursThisWeek.Text = hoursThisWeek.ToString();
            btnIndicator.BackColor = Color.Green;
            if (hoursThisWeek < 30)
                btnIndicator.BackColor = Color.Yellow;
            else if (hoursThisWeek > 40)
                btnIndicator.BackColor = Color.Red;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            var editE = new EditEmployee(_employee,_employeeProjectRepository,_projectsRepository,_employeesRepository);
            editE.ShowDialog();
            Close();
        }
    }
}
