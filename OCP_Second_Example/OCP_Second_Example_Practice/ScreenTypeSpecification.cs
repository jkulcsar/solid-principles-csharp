namespace OCP_Second_Example_Practice
{
    public class ScreenTypeSpecification : ISpecification<ComputerMonitor>
    {
        private readonly ScreenType _screenType;

        public ScreenTypeSpecification(ScreenType screenType)
        {
            _screenType = screenType;
        }
        public bool isSatisfied(ComputerMonitor item)
        {
            return item.Screen == _screenType;
        }
    }
}
