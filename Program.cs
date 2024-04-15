namespace _11._04
{
    public static class StringExtensions
    {
        public static string CapitalizeSentences(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            string[] lines = input.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].CapitalizeFirstLetter();
            }
            return string.Join(Environment.NewLine, lines);
        }

        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            return char.ToUpper(input[0]) + input.Substring(1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "input.txt";
            string text = File.ReadAllText(filePath);
            string result = text.CapitalizeSentences();
            Console.WriteLine(result);
        }
    }
}
