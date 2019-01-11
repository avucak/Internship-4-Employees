using AppForProjectManagers.Data.Models;
using AppForProjectManagers.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForProjectManagers.Presentation
{
    public partial class ChooseEmployee : Form
    {
        private List<Employee> _employees;
        private EmployeesRepository _employeesRepository;
        public ChooseEmployee()
        {
            InitializeComponent();
            _employeesRepository = new EmployeesRepository();
            FillComboBox();
        }

        private void FillComboBox()
        {
            cbChooseEmployee.Items.Clear();
            _employees = _employeesRepository.GetAll();
            foreach (var employee in _employees)
            {
                cbChooseEmployee.Items.Add(employee.OIB + " " + employee.Name + " " + employee.Surname);
            }
        }

        private void btnSeeDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
