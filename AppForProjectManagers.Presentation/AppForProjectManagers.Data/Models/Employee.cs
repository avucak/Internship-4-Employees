using AppForProjectManagers.Infrastructure.Enumerators;
using System;
using System.Collections.Generic;
using System.Data;
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
        public Positions Position;

        public Employee(string name, string surname, int oib, DateTime dateOfBirth, Positions position)
        {
            Name = name;
            Surname = surname;
            OIB = oib;
            DateOfBirth = dateOfBirth;
            Position = position;
        }

        public void Update(string name, string surname, int oib, DateTime dateOfBirth, Positions position)
        {
            Name = name;
            Surname = surname;
            OIB = oib;
            DateOfBirth = dateOfBirth;
            Position = position;
        }
    }
}
