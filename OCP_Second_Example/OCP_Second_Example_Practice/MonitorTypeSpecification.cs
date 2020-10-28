using System;
using System.Runtime.InteropServices;

namespace OCP_Second_Example_Practice
{
    public class MonitorTypeSpecification : ISpecification<ComputerMonitor>
    {
        private readonly MonitorType _monitorType;

        public MonitorTypeSpecification(MonitorType monitorMonitorType)
        {
            _monitorType = monitorMonitorType;
        }
        public bool isSatisfied(ComputerMonitor item)
        {
            return item.Type == _monitorType;
        }
    }
}