namespace LSP
{
    public class Calculator
    {
        private int[] _numbers;

        protected Calculator(int[] numbers)
        {
            _numbers = numbers;
        }

        public virtual int Calculate()
        {
            throw new System.NotImplementedException();
        }
    }
}