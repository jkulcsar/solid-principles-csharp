namespace OCP_Second_Example
{
    public class MonitorTypeSpecification: ISpecification<ComputerMonitor>
    {
        private readonly MonitorType _type;

        public MonitorTypeSpecification(MonitorType type)
        {
            _type = type;
        }

        public bool isSatisfied(ComputerMonitor item) => item.Type == _type;
    }
}
