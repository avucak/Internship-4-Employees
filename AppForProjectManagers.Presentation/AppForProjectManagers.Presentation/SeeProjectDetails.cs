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
    public partial class SeeProjectDetails : Form
    {
        private Project _project;
        private ProjectsRepository _projectsRepository;
        private EmployeesRepository _employeesRepository;
        private EmployeeProjectRepository _employeeProjectRepository;
        public SeeProjectDetails(Project project,ProjectsRepository projectsRepository, EmployeesRepository employeesRepository, EmployeeProjectRepository employeeProjectRepository)
        {
            _project = project;
            _projectsRepository = projectsRepository;
            _employeesRepository = employeesRepository;
            _employeeProjectRepository = employeeProjectRepository;
            InitializeComponent();
            Fill();
        }

        private void Fill()
        {
            lblProjectName.Text = _project.Name;
            lblDuration.Text = _project.StartDate.ToString("dd/MM/yyyy") + " - " + _project.EndDate.ToString("dd/MM/yyyy");
            var employeesOnThisProject=_employeeProjectRepository.GetAllEmployeesOnProject(_project);
            var countDesigners = 0;
            var countProgrammers = 0;
            var countSecretaries = 0;
            var countAccountants = 0;
            foreach (var employee in _employeesRepository.GetAll())
            {
                foreach (var e in employeesOnThisProject)
                {
                    if (employee.OIB == e)
                    {
                        switch (employee.Position.ToString())
                        {
                            case "Programmer":
                                countProgrammers++;
                                break;
                            case "Designer":
                                countDesigners++;
                                break;
                            case "Secretary":
                                countSecretaries++;
                                break;
                            case "Accountant":
                                countAccountants++;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            numberOfProgrammers.Text += countProgrammers.ToString();
                numberOfDesigners.Text += countDesigners.ToString();
                numberOfSecretaries.Text += countSecretaries.ToString();
                numberOfAccountants.Text += countAccountants.ToString();
            foreach (var employee in _employeesRepository.GetAll())
            foreach (var e in employeesOnThisProject)
            {
                if (employee.OIB == e)
                {
                    listOfEmployees.Items.Add($"{employee.Name} {employee.Surname} ({_employeeProjectRepository.ReturnHours(e,_project.Name)} hours)");
                }
            }

            listOfEmployees.Enabled = false;


        }

        private void Edit_Click(object sender, EventArgs e)
        {
            var editProject =
                new EditProject(_project, _projectsRepository, _employeesRepository, _employeeProjectRepository);
            editProject.ShowDialog();
            Close();
        }
    }
}
