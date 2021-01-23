namespace OCP_First_Example
{
    public class JuniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public JuniorDevSalaryCalculator(DeveloperReport developerReport)
            :base(developerReport)
        {
        }

        public override double CalculateSalary() => DeveloperReport.HourlyRate * DeveloperReport.WorkingHours;
    }
}
