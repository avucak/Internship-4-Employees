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

namespace AppForProjectManagers.Presentation
{
    public partial class BtnSeeDetailsProject : Form
    {
        public EmployeesRepository employeesRepository;
        public ProjectsRepository projectsRepository;
        public EmployeeProjectRepository employeeProjectRepository;
        public BtnSeeDetailsProject()
        {
            employeesRepository=new EmployeesRepository();
            projectsRepository = new ProjectsRepository();
            employeeProjectRepository = new EmployeeProjectRepository();
            InitializeComponent();
            InitialEmployeesAndProjects();
        }

        private void InitialEmployeesAndProjects()
        {
            var Pavic = new Employee("Ivan", "Pavić", 1, new DateTime(2000, 1, 1),Positions.Designer);
            var Kalic = new Employee("Ivan", "Kalić", 2, new DateTime(1993, 12, 15), Positions.Designer);
            var Petar = new Employee("Petar", "Palinčić", 3, new DateTime(1997, 4, 5), Positions.Programmer);
            var dumpDays = new Project("Dump days", new DateTime(2017, 12,12), new DateTime(2018, 6, 1));
            employeesRepository.Add(Pavic);
            employeesRepository.Add(Kalic);
            employeesRepository.Add(Petar);
            projectsRepository.Add(dumpDays);
            var dumpPavic = new EmployeeProject(dumpDays.Name, Pavic.OIB, 8);
            var dumpKalic = new EmployeeProject(dumpDays.Name, Kalic.OIB, 3);
            var dumpPetar = new EmployeeProject(dumpDays.Name, Petar.OIB, 28);
            employeeProjectRepository.Add(dumpPavic);
            employeeProjectRepository.Add(dumpKalic);
            employeeProjectRepository.Add(dumpPetar);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var AddE = new AddEmployee(employeesRepository,projectsRepository,employeeProjectRepository);
            AddE.ShowDialog();
        }

        private void BtnSeeDetailsEmployees_Click(object sender, EventArgs e)
        {
            var ChooseE = new ChooseEmployee(employeesRepository,employeeProjectRepository, projectsRepository);
            ChooseE.ShowDialog();
        }

        private void AddProject_Click(object sender, EventArgs e)
        {
            var addP = new AddProject(projectsRepository, employeesRepository, employeeProjectRepository);
            addP.ShowDialog();
        }

        private void BtnEditEmployees_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            var deleteE=new ChooseEmployeeToDelete(employeesRepository,projectsRepository,employeeProjectRepository);
            deleteE.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var chooseP = new ChooseProject(employeesRepository,employeeProjectRepository,projectsRepository);
            chooseP.ShowDialog();
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            var deleteP = new ChooseProjectToDelete(employeesRepository, employeeProjectRepository, projectsRepository);
            deleteP.ShowDialog();
        }
    }
}
