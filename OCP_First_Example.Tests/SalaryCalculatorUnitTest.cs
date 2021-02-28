using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace OCP_First_Example.Tests
{
    public class SalaryCalculatorUnitTest
    {
        private readonly IList<BaseSalaryCalculator> _salaryCalculators;
        private readonly SalaryCalculator _salaryCalculator;

        public SalaryCalculatorUnitTest()
        {
            _salaryCalculators = CreateSalaryCalculators();
            _salaryCalculator = new SalaryCalculator(_salaryCalculators);
        }
        
        [Fact]
        public void GivenTheActualSalaryInformation_ResultShouldBeExactly()
        {
            var actual = _salaryCalculator.CalculateTotalSalaries();
            actual.Should().BeGreaterOrEqualTo(15444);
        }

        private IList<BaseSalaryCalculator> CreateSalaryCalculators()
        {
            var salaryCalculators = new List<BaseSalaryCalculator>
            {
                new SeniorDevSalaryCalculator(new DeveloperReport {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 160 }),
                new JuniorDevSalaryCalculator(new DeveloperReport {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate = 20, WorkingHours = 150 }),
                new SeniorDevSalaryCalculator(new DeveloperReport {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 180 })
            };

            return salaryCalculators;
        }
    }
}