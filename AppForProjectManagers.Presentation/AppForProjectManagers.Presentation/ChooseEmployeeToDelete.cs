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
    public partial class ChooseEmployeeToDelete : Form
    {
        private List<Employee> _employees;
        private EmployeesRepository _employeesRepository;
        private EmployeeProjectRepository _employeeProjectRepository;
        private ProjectsRepository _projectsRepository;
        public ChooseEmployeeToDelete(EmployeesRepository employeesRepository,ProjectsRepository projectsRepository, EmployeeProjectRepository employeeProjectRepository)
        {
            _employeeProjectRepository = employeeProjectRepository;
            _employeesRepository = employeesRepository;
            _projectsRepository = projectsRepository;
            InitializeComponent();
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
        private void Delete_Click(object sender, EventArgs e)
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

            var projectsThisEmployeeWorksOn = _employeeProjectRepository.GetAllProjectsEmployeeWorksOn(employee);
            //var project je string pa imamo dvije foreach petlje jer drugom bas pronađemo projekt, sto je potrebno za
            //metodu GetAllEmployeesOnProject
            foreach (var project in projectsThisEmployeeWorksOn)
            {
                foreach (var pr in _projectsRepository.GetAll())
                {
                    if (project == pr.Name)
                    {
                        if (_employeeProjectRepository.GetAllEmployeesOnProject(pr).Count == 1)
                        {
                            MessageBox.Show($"Ovo je jedini radnik na projektu {project}, brisanje zabranjeno");
                            return;
                        }
                    }
                }
            }
            DialogResult dialogResult = MessageBox.Show($"Confirm deleting employee with OIB {employee.OIB}","Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _employeesRepository.RemoveEmployee(employee);
                foreach (var project in projectsThisEmployeeWorksOn)
                {
                    _employeeProjectRepository.Remove(project,employee.OIB);
                }
                MessageBox.Show("Radnik obrisan");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Radnik nije obrisan");
                
            }
            Close();
        }
    }
}
