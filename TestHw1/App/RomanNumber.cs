namespace App
{
    public record RomanNumber(int Value)
    {
        private static readonly Dictionary<char, int> RomanToIntegerMap = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public static RomanNumber Parse(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return new RomanNumber(0);
            }

            int value = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (!RomanToIntegerMap.TryGetValue(input[i], out int current))
                {
                    throw new ArgumentException("Invalid Roman numeral.");
                }

                if (i + 1 < input.Length && RomanToIntegerMap.TryGetValue(input[i + 1], out int next) && current < next)
                {
                    value -= current;
                }
                else
                {
                    value += current;
                }
            }

            return new RomanNumber(value);
        }
    }
}

