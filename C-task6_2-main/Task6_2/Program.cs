using System;
using System.Collections.Generic;

namespace Task6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentCorrespondence student1 = new StudentCorrespondence("Student", "First", "FirstP", "1827462",
                new List<string>() {"math", "eng", "rus"}, new List<int>() {3, 5, 3, 2});
            StudentCorrespondence student2 = new StudentCorrespondence("Student2", "Second", "SecondP", "262723",
                new List<string>() {"math", "eng", "rus"}, new List<int>() {3, 4, 4, 4});
            StudentCorrespondence student3 = new StudentCorrespondence("Student3", "Third", "ThirdP", "2365853",
                new List<string>() {"math", "eng", "rus"}, new List<int>() {4, 5, 5, 5});
            StudentCorrespondence student4 = new StudentCorrespondence("Student4", "Fourth", "FourthP", "2377327",
                new List<string>() {"math", "eng", "rus"}, new List<int>() {3, 2, 3, 2});


            List<IEnrollee> list = new List<IEnrollee>();

            list.Add(student1);
            list.Add(student2);
            list.Add(student3);
            list.Add(student4);

            foreach (var student in list)
            {
                Console.WriteLine(student.GetInfo() + " Passport: " + student.PassportNumber);
            }
        }
    }
}