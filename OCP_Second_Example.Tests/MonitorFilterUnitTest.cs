using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace OCP_Second_Example.Tests
{
    public class MonitorFilterUnitTest
    {
        private readonly MonitorFilter _monitorFilter;
        private readonly IList<ComputerMonitor> _monitors;

        public MonitorFilterUnitTest()
        {
            _monitorFilter = new MonitorFilter();
            _monitors = CreateMonitors();
        }
        
        [Theory]
        [InlineData(MonitorType.OLED, 2)]
        [InlineData(MonitorType.LED, 1)]
        public void WhenMonitorTypeSpecified_CountOfFilteredItems_ShouldBeAsExpected(MonitorType monitorType, int expectedCount)
        {
            var actual = _monitorFilter.Filter(_monitors, new MonitorTypeSpecification(monitorType));

            actual.Count.Should().Be(expectedCount);
        }

        [Theory]
        [InlineData(Screen.CurvedScreen, 2)]
        [InlineData(Screen.WideScreen, 3)]
        public void WhenScreenTypeSpecified_CountOfFilteredMonitors_ShouldBeAsExpected(Screen screen, int expectedCount)
        {
            var actual = _monitorFilter.Filter(_monitors, new ScreenSpecification(screen));

            actual.Count.Should().Be(expectedCount);
        }

        private IList<ComputerMonitor> CreateMonitors()
        {
            var monitors = new List<ComputerMonitor>
            {
                new() { Name = "Samsung S345", Screen = Screen.CurvedScreen, Type = MonitorType.OLED },
                new() { Name = "Philips P532", Screen = Screen.WideScreen, Type = MonitorType.LCD },
                new() { Name = "LG L888", Screen = Screen.WideScreen, Type = MonitorType.LED },
                new() { Name = "Samsung S999", Screen = Screen.WideScreen, Type = MonitorType.OLED },
                new() { Name = "Dell D2J47", Screen = Screen.CurvedScreen, Type = MonitorType.LCD }
            };

            return monitors;
        }
    }
}