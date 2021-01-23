using System.Linq;

namespace DIP
{
    public class EmployeeStatistics
    {
        private readonly IEmployeeSerchable _emp;

        public EmployeeStatistics(IEmployeeSerchable emp)
        {
            _emp = emp;
        }

        public int CountFemaleManagers() => 
            _emp.GetEmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count();
    }
}
