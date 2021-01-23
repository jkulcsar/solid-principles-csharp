using System.Linq;

namespace LSP
{
    public class SumCalculator : Calculator
    {
        private int[] _numbers;
        
        public SumCalculator(int[] numbers)
            :base(numbers)
        {
            _numbers = numbers;
        }

        public override int Calculate() => _numbers.Sum();
    }
}
