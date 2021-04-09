namespace Task6_2
{
    public interface IEnrollee
    {
        string PassportNumber { get; set; }

        string GetInfo();

        double GetAvgGrade();
    }
}