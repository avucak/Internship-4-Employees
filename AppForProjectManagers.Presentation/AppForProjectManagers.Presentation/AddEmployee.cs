using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppForProjectManagers.Data.Models;
using AppForProjectManagers.Domain.Repositories;
using AppForProjectManagers.Infrastructure.Enumerators;
using AppForProjectManagers.Infrastructure.Extensions;

namespace AppForProjectManagers.Presentation
{
    public partial class AddEmployee : Form
    {
        private ProjectsRepository _projectsRepository;
        private EmployeeProjectRepository _employeeProjectRepository;
        private EmployeesRepository _employeesRepository;
        public AddEmployee(EmployeesRepository employeesRepository, ProjectsRepository projectsRepository, EmployeeProjectRepository employeeProjectRepository)
        {
            _projectsRepository = projectsRepository;
            _employeesRepository = employeesRepository;
            _employeeProjectRepository = employeeProjectRepository;
            InitializeComponent();
            AddPositions();
            LoadProjects();
        }

        private void LoadProjects()
        {
            foreach (var project in _projectsRepository.GetAll())
            {
                ListOfProjects.Items.Add(project.Name);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtSurname.Text =="" || txtOIB.Text == "")
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
            if (!_employeesRepository.CheckOIB(OIB))
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
            var position=Positions.Accountant;
            foreach (var role in Enum.GetValues(typeof(Positions)))
            {
                if (positionInput.ToString() == role.ToString())
                    position = (Positions)role;
            }
            foreach (var project in ListOfProjects.CheckedItems)
            {
                var projectName = project.ToString();
                var hoursOnProject = new HoursOnProject(int.Parse(oib), projectName, _employeeProjectRepository);
                hoursOnProject.ShowDialog();
            }
           
            var employee = new Employee(name.FirstLetterCapitalRestNot(), surname.FirstLetterCapitalRestNot(), OIB, dateOfBirth, position);
            _employeesRepository.Add(employee);
            Close();

        }

        private void AddPositions()
        {
            foreach (var position in Enum.GetValues(typeof(Positions)).Cast<Positions>())
            {
                cbPosition.Items.Add(position);
            }
        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
