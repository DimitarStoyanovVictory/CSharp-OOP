using System;

namespace CompanyHierarchy
{
    class Project
    {
        public Project(string projectName, DateTime projectStartDate, string details, States state)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.Details = details;
            this.State = state;
        }

        public void CloseProject()
        {
            this.State = States.closed;
        }
        public string ProjectName { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public string Details { get; set; }
        public States State { get; set; }
    }
}
