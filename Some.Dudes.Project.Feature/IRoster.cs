using System.Collections.Generic;

namespace Some.Dudes.Project.Feature
{
    public interface IRoster
    {
        public List<Student> ClassRosterArray { get; set; }
        public void Remove(string studentID);
        public void Add(string studentID, string firstName, string lastName, string emailAddress, int age, int daysInCourse1, int daysInCourse2, int daysInCourse3, Degree degreeprogram);
        public void PrintAll();
        public void PrintAverageDaysInCourse(string studentID);
        public void PrintInvalidEmails();
    }
}
