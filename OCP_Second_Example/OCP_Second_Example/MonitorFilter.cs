using System.Collections.Generic;
using System.Linq;

namespace OCP_Second_Example
{
    public class MonitorFilter : IFilter<ComputerMonitor>
    {
        public List<ComputerMonitor> Filter(IEnumerable<ComputerMonitor> monitors, ISpecification<ComputerMonitor> specification) =>
            monitors.Where(m => specification.isSatisfied(m)).ToList();
    }
}
