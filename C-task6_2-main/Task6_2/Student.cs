namespace Task6_2
{
    public abstract class Student : IEnrollee
    {
        public string PassportNumber { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }

        public Student(string firstName, string lastName, string patronymic, string passportNumber)
        {
            PassportNumber = passportNumber;
            FirstName = lastName;
            LastName = lastName;
            Patronymic = patronymic;
        }

        public abstract string GetInfo();

        public abstract double GetAvgGrade();

        public string GetFullName()
        {
            return LastName + " " + FirstName + " " + Patronymic;
        }
        
        
    }
}