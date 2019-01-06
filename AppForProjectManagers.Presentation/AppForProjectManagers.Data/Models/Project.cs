using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForProjectManagers.Data.Models
{
    public class Project
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Employee> ListOfEmployees { get; set; }

        public Project(string name, DateTime startDate, DateTime endDate, List<Employee> listOfEmployees)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            ListOfEmployees = listOfEmployees;
        }
    }
}
