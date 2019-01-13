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
    public partial class EditProject : Form
    {
        private Project _project;
        private ProjectsRepository _projectsRepository;
        private EmployeesRepository _employeesRepository;
        private EmployeeProjectRepository _employeeProjectRepository;
        public EditProject(Project project, ProjectsRepository projectsRepository, EmployeesRepository employeesRepository, EmployeeProjectRepository employeeProjectRepository)
        {
            _project = project;
            _projectsRepository = projectsRepository;
            _employeesRepository = employeesRepository;
            _employeeProjectRepository = employeeProjectRepository;
            InitializeComponent();
            LoadEmployees();
            FillInformation();
        }

        private void FillInformation()
        {
            txtProjectName.Text = _project.Name;
            startDatePicker.Value = _project.StartDate;
            endDatePicker.Value = _project.EndDate;
            var employeesOnThisProject = _employeeProjectRepository.GetAllEmployeesOnProject(_project);
            var index = -1;
            var listOfIndicesToCheck = new List<int>();
            foreach (var employee in listOfEmployees.Items)
            {
                var oib = employee.ToString().Split()[0];
                index++;
                foreach (var e in employeesOnThisProject)
                {
                    if (oib == e.ToString())
                        listOfIndicesToCheck.Add(index);
                }
            }
            foreach (var i in listOfIndicesToCheck)
            {
                listOfEmployees.SetItemChecked(i, true);
            }
            
            
        }

        private void LoadEmployees()
        {
            var employeesOnThisProject = _employeeProjectRepository.GetAllEmployeesOnProject(_project);
            var employeeAdded = false;
            foreach (var employee in _employeesRepository.GetAll())
            {
                employeeAdded = false;
                foreach (var e in employeesOnThisProject)
                {
                    if (employee.OIB == e)
                    {
                        listOfEmployees.Items.Add($"{employee.OIB} {employee.Name} {employee.Surname} ({_employeeProjectRepository.ReturnHours(e, _project.Name)} hours)");
                        employeeAdded = true;
                    }
                }
                if(!employeeAdded)
                listOfEmployees.Items.Add(employee.OIB + " " + employee.Name + " " + employee.Surname);
            }
        }

        private void btnEditProject_Click(object sender, EventArgs e)
        {
            if (txtProjectName.Text == "")
            {
                MessageBox.Show("Projekt mora imati ime");
                return;
            }

            var name = txtProjectName.Text;
            //ako postoji projekt s ovim imenom ne smijemo dopustiti to ime, osim ako je to bilo ime ovog projekta prije edit-a
            if (!_projectsRepository.CheckName(name) && name != _project.Name)
            {
                MessageBox.Show("Postoji projekt s ovim imenom!");
                return;
            }
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
            foreach (var employee in listOfEmployees.Items)
            {
                var oib = employee.ToString().Split()[0];
                if (listOfEmployees.CheckedItems.Contains(employee))
                {
                    if (name != _project.Name)
                    {
                        _employeeProjectRepository.Remove(_project.Name, int.Parse(oib));
                    }

                    var hoursOnProject = new HoursOnProject(int.Parse(oib), name, _employeeProjectRepository);
                    hoursOnProject.ShowDialog();
                }
                else
                    _employeeProjectRepository.Remove(_project.Name, int.Parse(oib));
            }
            if (name == _project.Name)
                _project.Update(name, startDate, endDate);
            else
            {
                _projectsRepository.RemoveProject(_project);
                var newProject = new Project(name,startDate,endDate);
                _projectsRepository.Add(newProject);
            }
            Close();
        }
    }
}
