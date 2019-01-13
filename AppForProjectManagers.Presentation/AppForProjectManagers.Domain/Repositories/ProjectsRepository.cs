using AppForProjectManagers.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForProjectManagers.Domain.Repositories
{
    public class ProjectsRepository
    {
        public List<Project> ListOfProjects { get; set; }

        public ProjectsRepository()
        {
            ListOfProjects = new List<Project>();
        }

        public List<Project> GetAll() => ListOfProjects;
        public void Add(Project project)
        {
            if (CheckName(project.Name))
                ListOfProjects.Add(project);
        }

        public bool CheckName(string name)
        {
            foreach (var project in ListOfProjects)
            {
                if (project.Name == name)
                    return false;
            }
            return true;
        }
        public void RemoveProject(Project project)
        {
            if (ListOfProjects.Contains(project))
                ListOfProjects.Remove(project);
        }
    }
}
