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
    public partial class HoursOnProject : Form
    {
        private int _oib;
        private string _projectName;
        private EmployeeProjectRepository _employeeProjectRepository;
        public HoursOnProject(int oib,string projectName, EmployeeProjectRepository employeeProjectRepository)
        {
            _oib=oib;
            _projectName = projectName;
            _employeeProjectRepository = employeeProjectRepository;
            InitializeComponent();
            WriteLabels();
        }

        private void WriteLabels()
        {
            lblEmployee.Text = _oib.ToString();
            lblProject.Text = _projectName;
        }

        private void btnAddHours_Click(object sender, EventArgs e)
        {
            var numberOfHours = 0;
            if (!int.TryParse(txtNumberOfHours.Text, out numberOfHours))
            {
                MessageBox.Show("Sati moraju biti broj");
                return;
            }

            if (numberOfHours < 1)
            {
                MessageBox.Show("Sati moraju biti veći od 0");
                return;
            }

            var employeeProject = new EmployeeProject(_projectName, _oib, numberOfHours);
            _employeeProjectRepository.Add(employeeProject);
            Close();
        }

        private void txtNumberOfHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void HoursOnProject_Load(object sender, EventArgs e)
        {

        }
    }
}
