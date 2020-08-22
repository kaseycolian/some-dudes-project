using System;

namespace Some.Dudes.Project.Feature
{
    class Program
    {
        static void Main(string[] args)
        {
            var roster = new Roster();
            var hsstory = new Degree { Title = "hsssstory" };
            var algeprrr = new Degree { Title = "algeprrr" };

            Console.ForegroundColor = ConsoleColor.Cyan;

            roster.Add("123asdf", "Chubington", "Mars Mellow", "iampear@fatbottomedcat.com", 3, 46, 2, 3, algeprrr);
            roster.Add("asdf2341", "Mister", "Anderson", "iamtheoone@neon", 14, 42, 34, 33, hsstory);
            roster.Add("8s8azsdf", "Tank", "AndDozer", "furrybushtails.com", 6, 82, 39, 63, algeprrr);
            roster.Add("8s8azsdf", "Duplicate", "Cat", "iamduplicateid", 8, 82, 39, 63, hsstory);
            roster.Add("8675309", "Chairman", "Mrow", "ilikepinkbeds@sleepsallday.net", 10, 30, 14, 5, algeprrr);

            Console.WriteLine("\r\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Entire Roster");
            roster.PrintAll();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\r\n");
            Console.WriteLine("Invalid emails:");
            roster.PrintInvalidEmails();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\r\n");
            Console.WriteLine("Average days in course for requested student IDs:");
            roster.PrintAverageDaysInCourse("123asdf");
            roster.PrintAverageDaysInCourse("asdf2341");
            roster.PrintAverageDaysInCourse("8s8azsdf");
            roster.PrintAverageDaysInCourse("11111");
            Console.WriteLine("\r\n");
            Console.WriteLine("\r\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;

        }
    }
}
