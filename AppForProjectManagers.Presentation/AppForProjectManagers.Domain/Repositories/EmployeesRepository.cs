using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppForProjectManagers.Data.Models;

namespace AppForProjectManagers.Domain.Repositories
{
    public class EmployeesRepository
    {
        public List<Employee> ListOfEmployees { get; set; }

        public EmployeesRepository()
        {
            ListOfEmployees = new List<Employee>();
        }

        public List<Employee> GetAll() => ListOfEmployees;
        public void Add(Employee employee)
        {
            if(CheckOIB(employee.OIB))
                ListOfEmployees.Add(employee);
        }

        public bool CheckOIB(int oib)
        {
            foreach (var employee in ListOfEmployees)
            {
                if (employee.OIB == oib)
                    return false;
            }
            return true;
        }
    }
}
