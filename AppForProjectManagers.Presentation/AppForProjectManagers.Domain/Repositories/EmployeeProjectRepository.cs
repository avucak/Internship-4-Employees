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


        public List<string> GetAllProjectsEmployeeWorksOn(Employee employee)
        {
            List<string> listOfProjectNames = new List<string>();
            foreach (var employeeProject in ListOfEmployeesAndProjects)
            {
                if (employeeProject.OIB == employee.OIB)
                    listOfProjectNames.Add(employeeProject.ProjectName);
            }

            return listOfProjectNames;
        }
        public List<int> GetAllEmployeesOnProject(Project project)
        {
            List<int> listOfEmployeeOIBs = new List<int>();
            foreach (var employeeProject in ListOfEmployeesAndProjects)
            {
                if (employeeProject.ProjectName == project.Name)
                    listOfEmployeeOIBs.Add(employeeProject.OIB);
            }

            return listOfEmployeeOIBs;
        }

        public int ReturnHours(int oib, string projectName)
        {
            var hours = 0;
            foreach (var employeeProject in ListOfEmployeesAndProjects)
            {
                if (employeeProject.OIB == oib && employeeProject.ProjectName == projectName)
                    hours = employeeProject.Hours;
            }
            return hours;
        }
        public int CalculateAllHoursForEmployee(int oib, List<Project> allProjects)
        {
            var hours = 0;
            foreach (var employeeProject in ListOfEmployeesAndProjects)
            {
                if (employeeProject.OIB == oib)
                {
                    foreach (var project in allProjects)
                    {
                        if(project.Name==employeeProject.ProjectName && project.EndDate<=DateTime.Now.AddDays(7))
                            hours += employeeProject.Hours;
                    }
                }
                    
            }
            return hours;
        }

    }
}
