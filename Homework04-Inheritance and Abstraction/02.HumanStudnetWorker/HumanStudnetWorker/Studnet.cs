using System;

namespace HumanStudnetWorker
{
    public class Studnet : Human
    {
        public Studnet(string firstName, string lastName, int facultyNumber)
            :base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }
        public int FacultyNumber { get; set; }
    }
}
