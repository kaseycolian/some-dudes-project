using System.Collections.Generic;

namespace Some.Dudes.Project.Feature
{
    public class Student : IStudent
    {
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int Age { get; set; }
        public List<int> DaysToComplete { get; set; }
        public Degree Degree { get; set; }

        public Student(string id, string firstName, string lastName, string emailAddress, int age, int daysCourse1, int daysCourse2, int daysCourse3, Degree degree)
        {
            this.StudentID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddress = emailAddress;
            this.Age = age;
            this.DaysToComplete = new List<int> { daysCourse1, daysCourse2, daysCourse3 };
            this.Degree = degree;
        }

        private string PrintEachDaysInCourse()
        {
            var dayList = "";
            foreach (var days in this.DaysToComplete)
            {
                dayList += $"{days}, ";
            }
            var formatted = dayList.Trim(' ', ',');
            return formatted.ToString();
        }

        public override string ToString()
        {
            return $"Student ID: {StudentID}, Student Name: {FirstName} {LastName}, Age: {Age}; Degree: {Degree.Title}; Days To Complete: {PrintEachDaysInCourse()}";
        }
    }
}
