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
    public partial class ChooseProject : Form
    {
        private List<Project> _projects;
        private EmployeesRepository _employeesRepository;
        private EmployeeProjectRepository _employeeProjectRepository;
        private ProjectsRepository _projectsRepository;
        public ChooseProject(EmployeesRepository employeesRepository, EmployeeProjectRepository employeeProjectRepository, ProjectsRepository projectsRepository)
        {
            _employeesRepository = employeesRepository;
            _employeeProjectRepository = employeeProjectRepository;
            _projectsRepository = projectsRepository;
            InitializeComponent();
            FillComboBox();
        }
        private void FillComboBox()
        {
            cbChooseProject.Items.Clear();
            _projects = _projectsRepository.GetAll();
            foreach (var project in _projects)
            {
                cbChooseProject.Items.Add(project.Name);
            }
        }

        private void SeeDetails_Click(object sender, EventArgs e)
        {
            if (cbChooseProject.SelectedIndex < 0)
            {
                MessageBox.Show("Trebate odabrati projekt");
                return;
            }

            var selected = cbChooseProject.Text;
            Project project = null;
            foreach (var pr in _projects)
            {
                if (pr.Name == selected)
                    project = pr;
            }

            var pDetails = new SeeProjectDetails(project,_projectsRepository,_employeesRepository,_employeeProjectRepository);
            pDetails.ShowDialog();
            Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (cbChooseProject.SelectedIndex < 0)
            {
                MessageBox.Show("Trebate odabrati projekt");
                return;
            }

            var selected = cbChooseProject.Text;
            Project project = null;
            foreach (var pr in _projects)
            {
                if (pr.Name == selected)
                    project = pr;
            }

            var editProject =
                new EditProject(project, _projectsRepository, _employeesRepository, _employeeProjectRepository);
            editProject.ShowDialog();
            Close();
        }
    }
}
