using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyHierarchy
{
    class Developer : RegularEmployee, IRegularEmployee, IDeveloper
    {
        public Developer(int id, string firstName, string lastName, decimal salary, Departments department, List<Project> projects)
            : base(id, firstName, lastName, salary, department)
        {
            this.Projects = projects;
        }
        public List<Project> Projects { get; set; }
        public override string ToString()
        {
            StringBuilder projects = new StringBuilder();
            this.Projects.ForEach(project => projects.AppendLine(string.Format("Project name: {0}, Project start date: {1}, Details: {2}, State: {3}", project.ProjectName, project.ProjectStartDate, project.Details, project.State)));
            return string.Format("Person ID: {0}, First name: {1}, Last name: {2}, Salary: {3}, Department: {4}\nSales:{5}", this.Id, this.FirstName, this.LastName, this.Salary, this.Department, projects);
        }
    }
}
