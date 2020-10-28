namespace OCP_Second_Example_Practice
{
    public class ComputerMonitor
    {
        public string Name { get; set; }
        public MonitorType Type { get; set; }
        public ScreenType Screen { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Type: {Type}, Screen: {Screen}";
        }
    }
}