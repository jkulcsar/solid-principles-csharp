using System.Collections.Generic;
using System.Linq;

namespace OCP_Second_Example_Practice
{
    public class MonitorFilter : IFilter<ComputerMonitor>
    {
        
        public List<ComputerMonitor> Filter(IEnumerable<ComputerMonitor> monitors, ISpecification<ComputerMonitor> specification)
        {
            return monitors.Where(m => specification.isSatisfied(m)).ToList();
        }
    }
}