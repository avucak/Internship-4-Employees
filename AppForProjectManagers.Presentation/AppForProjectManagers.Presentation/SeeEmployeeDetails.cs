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
        public SeeEmployeeDetails(Employee employee, EmployeeProjectRepository employeeProjectRepository,ProjectsRepository projectsRepository)
        {
            _projectsRepository = projectsRepository;
            _employeeProjectRepository = employeeProjectRepository;
            _employee = employee;
            InitializeComponent();
            FillAndDisable();
            
        }

        private void FillAndDisable()
        {
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
            var hoursThisWeek =
                _employeeProjectRepository.CalculateAllHoursForEmployee(_employee.OIB, _projectsRepository.GetAll());
            txtHoursThisWeek.Text = hoursThisWeek.ToString();
            btnIndicator.BackColor = Color.Green;
            if (hoursThisWeek < 30)
                btnIndicator.BackColor = Color.Yellow;
            else if(hoursThisWeek>40)
                btnIndicator.BackColor = Color.Red;
            txtHoursThisWeek.ReadOnly = true;
            foreach (var project in projectList)
            {
                var hours = _employeeProjectRepository.ReturnHours(_employee.OIB, project);
                ListOfProjects.Items.Add($"{project} ({hours} hours)");
            }
            ListOfProjects.Enabled = false;

        }



        private void Edit_Click(object sender, EventArgs e)
        {

        }
    }
}
