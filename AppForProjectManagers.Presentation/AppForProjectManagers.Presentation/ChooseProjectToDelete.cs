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
    public partial class ChooseProjectToDelete : Form
    {
        private List<Project> _projects;
        private EmployeesRepository _employeesRepository;
        private EmployeeProjectRepository _employeeProjectRepository;
        private ProjectsRepository _projectsRepository;
        public ChooseProjectToDelete(EmployeesRepository employeesRepository, EmployeeProjectRepository employeeProjectRepository, ProjectsRepository projectsRepository)
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

        private void Delete_Click(object sender, EventArgs e)
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

            DialogResult dialogResult = MessageBox.Show($"Confirm deleting project {project.Name}", "Confirm", MessageBoxButtons.YesNo);
            var employeesWorkingOnThisProject = _employeeProjectRepository.GetAllEmployeesOnProject(project);
            if (dialogResult == DialogResult.Yes)
            {
                _projectsRepository.RemoveProject(project);
                foreach (var employee in employeesWorkingOnThisProject)
                {
                    _employeeProjectRepository.Remove(project.Name, employee);
                }
                MessageBox.Show("Projekt obrisan");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Projekt nije obrisan");

            }
            Close();
        }
    }
}
