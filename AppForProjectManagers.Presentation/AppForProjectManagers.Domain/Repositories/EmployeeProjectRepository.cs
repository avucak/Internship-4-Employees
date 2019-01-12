using AppForProjectManagers.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForProjectManagers.Domain.Repositories
{
    public class EmployeeProjectRepository
    {
        public List<EmployeeProject> ListOfEmployeesAndProjects { get; set; }

        public EmployeeProjectRepository()
        {
            ListOfEmployeesAndProjects = new List<EmployeeProject>();
        }
        public List<EmployeeProject> GetAll() => ListOfEmployeesAndProjects;
        public void Add(EmployeeProject employeeProject)
        {
            if (CheckIfExists(employeeProject.ProjectName,employeeProject.OIB))
                ListOfEmployeesAndProjects.Add(employeeProject);
        }

        public bool CheckIfExists(string projectName,int oib)
        {
            foreach (var employeeProject in ListOfEmployeesAndProjects)
            {
                if (employeeProject.OIB == oib && employeeProject.ProjectName==projectName)
                    return false;
            }
            return true;
        }
    }
}
