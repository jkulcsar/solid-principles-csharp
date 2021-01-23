using System.Linq;

namespace LSP
{
    public class EvenNumbersSumCalculator: Calculator
    {
        private int[] _numbers;
        public EvenNumbersSumCalculator(int[] numbers)
            :base(numbers)
        {
            _numbers = numbers;
        }

        public override int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
    }
}
