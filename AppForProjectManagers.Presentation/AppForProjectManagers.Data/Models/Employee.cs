using AppForProjectManagers.Infrastructure.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForProjectManagers.Data.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int OIB { get; set; }
        public DateTime DateOfBirth{ get; set; }
        //public List<Project> ListOfProjects { get; set; }
        public Positions Role;

        public Employee(string name, string surname, int oib, DateTime dateOfBirth, Positions role)
        {
            Name = name;
            Surname = surname;
            OIB = oib;
            DateOfBirth = dateOfBirth;
            Role = role;
        }
    }
}
