namespace DESAFIO_TARGET
{
    public class Fibonnaci
    {
        public bool IsInFibonacci(int number)
        {
            int a = 0, b = 1, c = 0;

            while (c < number)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c == number || number == 0;
        }

        public List<int> GenerateFibonacci(int limit)
        {
            var sequence = new List<int> { 0, 1 };
            while (true)
            {
                int next = sequence[sequence.Count - 1] + sequence[sequence.Count - 2];
                if (next > limit) break;
                sequence.Add(next);
            }
            return sequence;
        }
    }
}
