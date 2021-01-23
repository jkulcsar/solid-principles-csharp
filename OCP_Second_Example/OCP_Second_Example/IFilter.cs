using System.Collections.Generic;

namespace OCP_Second_Example
{
    public interface IFilter<T>
    {
        List<T> Filter(IEnumerable<T> monitors, ISpecification<T> specification);
    }
}
