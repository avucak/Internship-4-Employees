using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForProjectManagers.Data.Models
{
    public class EmployeeProject
    {
        public int OIB { get; set; }
        public string ProjectName { get; set; }
        public int Hours { get; set; }

        public EmployeeProject(string projectName, int oib, int hours)
        {
            OIB = oib;
            ProjectName = projectName;
            Hours = hours;
        }
    }
}
