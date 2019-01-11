using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppForProjectManagers.Domain.Repositories;

namespace AppForProjectManagers.Presentation
{
    public partial class Form1 : Form
    {
        public EmployeesRepository employeesRepository;
        public Form1()
        {
            employeesRepository=new EmployeesRepository();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var AddE = new AddEmployee(employeesRepository);
            AddE.ShowDialog();
        }

        private void btnSeeDetailsEmployees_Click(object sender, EventArgs e)
        {
            var ChooseE = new ChooseEmployee();
            ChooseE.ShowDialog();
        }
    }
}
