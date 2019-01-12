using AppForProjectManagers.Data.Models;
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
    public partial class SeeEmployeeDetails : Form
    {
        private Employee _employee;
        public SeeEmployeeDetails(Employee employee)
        {
            _employee = employee;
            InitializeComponent();
            FillAndDisable();
        }

        private void FillAndDisable()
        {
            txtName.Text = _employee.Name;
            txtName.ReadOnly = true;
            txtSurname.Text = _employee.Surname;
            txtSurname.ReadOnly = true;
            txtOIB.Text = _employee.OIB.ToString();
            txtOIB.ReadOnly = true;
            DateOfBirthPicker.Value = _employee.DateOfBirth;
            DateOfBirthPicker.Enabled = false;
            cbPosition.Text = _employee.Position.ToString();
            cbPosition.Enabled = false;
        }



        private void Edit_Click(object sender, EventArgs e)
        {

        }
    }
}
