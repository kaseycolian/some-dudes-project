using System.Collections.Generic;

namespace Some.Dudes.Project.Feature
{
    public interface IStudent
    {
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int Age { get; set; }
        public List<int> DaysToComplete { get; set; }
        public Degree Degree { get; set; }
    }
}
