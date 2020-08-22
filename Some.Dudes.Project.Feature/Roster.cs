using System;
using System.Collections.Generic;
using System.Linq;

namespace Some.Dudes.Project.Feature
{
    public class Roster
    {
        public List<Student> Students{ get; set; }

        public Roster()
        {
            Students = new List<Student>();
        }

        public void Add(string studentID, string firstName, string lastName, string emailAddress, int age, int daysInCourse1, int daysInCourse2, int daysInCourse3, Degree degreeprogram)
        {
            if(Students.FirstOrDefault(s => s.StudentID.ToLower() == studentID.ToLower()) != null)
            {
                Console.WriteLine($"Student ID {studentID} for {firstName} {lastName} already in Roster and was not added.");
            }
            else
            {
                var student = new Student(studentID, firstName, lastName, emailAddress, age, daysInCourse1, daysInCourse2, daysInCourse3, degreeprogram);
                Students.Add(student);
            }
        }

        public void Remove(string studentID)
        {
            var foundStudent = Students.FirstOrDefault(s => s.StudentID.ToLower() == studentID.ToLower());

            if (foundStudent != null)
                Students.Remove(foundStudent);
        }

        public void PrintAll()
        {
            foreach (var student in Students)
            {
                Console.WriteLine(student.ToString());
            }
        }

        public void PrintAverageDaysInCourse(string studentID)
        {
            var foundStudent = Students.FirstOrDefault(s => s.StudentID.ToLower() == studentID.ToLower());

            if (foundStudent != null)
            {
                var days = foundStudent.DaysToComplete.Average();
                Console.WriteLine($"Average days in course for student {foundStudent.StudentID}: {days}");
            }
            else
            {
                Console.WriteLine($"Student ID '{studentID}' not found in roster");
            }
        }

        public void PrintInvalidEmails()
        {
            foreach (var student in this.Students)
            {
                if (student.EmailAddress.Contains(' ') || !student.EmailAddress.Contains('@') || !student.EmailAddress.Contains('.'))
                {
                    Console.WriteLine($"{student.EmailAddress} is invalid");
                }
            }
        }
    }
}
