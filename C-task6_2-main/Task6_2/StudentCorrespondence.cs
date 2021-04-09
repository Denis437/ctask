using System;
using System.Collections.Generic;

namespace Task6_2
{
    public class StudentCorrespondence : Student
    {
        private List<string> Subjects { get; set; }
        private List<int> Grades { get; set; }


        public StudentCorrespondence(string firstName, string lastName, string patronymic, string passportNumber,
            List<string> subjects, List<int> grades) :
            base(firstName, lastName, patronymic, passportNumber)
        {
            Subjects = subjects;
            Grades = grades;
        }

        public override string GetInfo()
        {
            return "Student: " + base.GetFullName() + " Avg grade: " + GetAvgGrade();
        }

        public override double GetAvgGrade()
        {
            int sum = 0;
            foreach (var grade in Grades)
            {
                sum += grade;
            }

            return sum / Convert.ToDouble(Grades.Count);
        }

        public string GetAllStudentSubjects()
        {
            string result = "";
            foreach (var subject in Subjects)
            {
                result += subject + " ";
            }

            return result;
        }

        public void AddGrade(int grade)
        {
            Grades.Add(grade);
        }

        public void AddSubject(string subject)
        {
            Subjects.Add(subject);
        }
    }
}