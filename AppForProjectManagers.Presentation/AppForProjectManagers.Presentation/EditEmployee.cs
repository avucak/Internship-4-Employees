using AppForProjectManagers.Data.Models;
using AppForProjectManagers.Domain.Repositories;
using AppForProjectManagers.Infrastructure.Enumerators;
using AppForProjectManagers.Infrastructure.Extensions;
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
    public partial class EditEmployee : Form
    {
        private Employee _employee;
        private EmployeeProjectRepository _employeeProjectRepository;
        private ProjectsRepository _projectsRepository;
        public EmployeesRepository _employeesRepository;
        public EditEmployee(Employee employee, EmployeeProjectRepository employeeProjectRepository, ProjectsRepository projectsRepository,EmployeesRepository employeesRepository)
        {
            _employeesRepository = employeesRepository;
            _projectsRepository = projectsRepository;
            _employeeProjectRepository = employeeProjectRepository;
            _employee = employee;
            InitializeComponent();
            AddPositions();
            LoadProjects();
            FillInformation();
        }
        private void AddPositions()
        {
            foreach (var position in Enum.GetValues(typeof(Positions)).Cast<Positions>())
            {
                cbPosition.Items.Add(position);
            }
        }

        private void LoadProjects()
        {
            foreach (var project in _projectsRepository.GetAll())
            {
                ListOfProjects.Items.Add(project.Name);
            }
        }
        private void FillInformation()
        {
            txtName.Text = _employee.Name;
            txtSurname.Text = _employee.Surname;
            txtOIB.Text = _employee.OIB.ToString();
            DateOfBirthPicker.Value = _employee.DateOfBirth;
            foreach (var position in cbPosition.Items)
            {
                if (position.ToString() == _employee.Position.ToString())
                    cbPosition.SelectedItem = position;
            }

            var index = -1;
            var listOfIndicesToCheck = new List<int>();
            foreach (var project in ListOfProjects.Items)
            {
                index++;
                foreach (var employeesProject in _employeeProjectRepository.GetAllProjectsEmployeeWorksOn(_employee))
                {
                    if(project.ToString()==employeesProject)
                        listOfIndicesToCheck.Add(index);
                }
            }
            foreach (var i in listOfIndicesToCheck)
            {
                ListOfProjects.SetItemChecked(i, true);
            }
           
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtSurname.Text == "" || txtOIB.Text == "")
            {
                MessageBox.Show("Morate unijeti ime, prezime i OIB");
                return;
            }
            var name = txtName.Text;
            var surname = txtSurname.Text;
            var oib = txtOIB.Text.RemoveAllSpaces();
            var OIB = 0;
            if (!int.TryParse(oib, out OIB))
            {
                MessageBox.Show("OIB mora biti broj");
                return;
            }
            //OIB ako se ponavlja nije greška ako je isti kao i prije
            if (!_employeesRepository.CheckOIB(OIB) && OIB!=_employee.OIB)
            {
                MessageBox.Show("Postoji korisnik s ovim OIB-om");
                return;
            }
            var dateOfBirth = DateOfBirthPicker.Value;
            if (dateOfBirth.AddYears(18) > DateTime.Now)
            {
                MessageBox.Show("Radnik mora imati barem 18 godina.");
                return;
            }

            if (cbPosition.SelectedIndex < 0)
            {
                MessageBox.Show("Morate odabrati poziciju");
                return;
            }
            var positionInput = cbPosition.SelectedItem;
            var position = Positions.Accountant;
            foreach (var role in Enum.GetValues(typeof(Positions)))
            {
                if (positionInput.ToString() == role.ToString())
                    position = (Positions)role;
            }
            foreach (var project in ListOfProjects.Items)
            {
                var projectName = project.ToString();
                if (ListOfProjects.CheckedItems.Contains(project))
                 {
                     if (OIB != _employee.OIB)
                     {
                         _employeeProjectRepository.Remove(projectName, OIB);
                     }
                    var hoursOnProject = new HoursOnProject(OIB, projectName, _employeeProjectRepository);
                     hoursOnProject.ShowDialog();
                 }
                else
                _employeeProjectRepository.Remove(projectName,_employee.OIB);
            }
            if(OIB==_employee.OIB)
            _employee.Update(name.FirstLetterCapitalRestNot(), surname.FirstLetterCapitalRestNot(), OIB, dateOfBirth, position);
            else
            {
                _employeesRepository.RemoveEmployee(_employee);
                var employee = new Employee(name.FirstLetterCapitalRestNot(), surname.FirstLetterCapitalRestNot(), OIB, dateOfBirth, position);
                _employeesRepository.Add(employee);
            }
            Close();
        }
    }
}
