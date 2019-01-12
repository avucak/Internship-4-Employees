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
            if (CheckIfExistsAndUpdate(employeeProject.ProjectName,employeeProject.OIB,employeeProject.Hours))
                ListOfEmployeesAndProjects.Add(employeeProject);
        }

        public bool CheckIfExistsAndUpdate(string projectName,int oib, int hours)
        {
            foreach (var employeeProject in ListOfEmployeesAndProjects)
            {
                if (employeeProject.OIB == oib && employeeProject.ProjectName == projectName)
                {
                    employeeProject.Hours = hours;
                    return false;
                }
            }
            return true;
        }

        public void Remove(string projectName, int oib)
        {
            EmployeeProject employeeProjectToRemove=null;
            foreach (var employeeProject in ListOfEmployeesAndProjects)
            {
                if (employeeProject.OIB == oib && employeeProject.ProjectName == projectName)
                employeeProjectToRemove = employeeProject;
             }
            ListOfEmployeesAndProjects.Remove(employeeProjectToRemove);
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
        public int CalculateAllHoursThisWeekForEmployee(int oib, List<Project> allProjects)
        {
            var hours = 0;
            foreach (var employeeProject in ListOfEmployeesAndProjects)
            {
                if (employeeProject.OIB == oib)
                {
                    foreach (var project in allProjects)
                    {
                        DayOfWeek currentDayOfWeek = DateTime.Now.DayOfWeek;
                        int days = currentDayOfWeek - DayOfWeek.Monday;
                        DateTime MondayThisWeek = DateTime.Now.AddDays(-days);
                        if (project.Name==employeeProject.ProjectName && project.EndDate>=MondayThisWeek && project.StartDate<=MondayThisWeek.AddDays(7))
                            hours += employeeProject.Hours;
                    }
                }
                    
            }
            return hours;
        }

    }
}
