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

        public Project(string name, DateTime startDate, DateTime endDate)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
        }

        public void Update(string name, DateTime startDate, DateTime endDate)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
        }

        public string ProjectState()
        {
            if (StartDate > DateTime.Now)
                return "planned";
            else if (EndDate < DateTime.Now)
                return "finished";
            else
                return "active";
        }
    }
}
