namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o texto que será analisado:");
            string? text = Console.ReadLine();
            text = text.ToLower();
            
            Dictionary<string, int> WordData = new Dictionary<string, int>();

            WordData = GetTextData(text);

            foreach (var word in WordData)
            {
                Console.WriteLine($"Palavra: {word.Key}, Frequência: {word.Value}");
            }
        }

        internal static Dictionary<string, int> GetTextData(string text)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();
            char[] delimiterChars = { ' ', ',', '.', ':', '!', '?'};
            if (text != null)
            {
                string[] words = text.Split(delimiterChars);

                foreach (string word in words) 
                {
                    if (output.ContainsKey(word))
                    {
                        output[word] += 1;
                    }
                    else
                    {
                        output.Add(word, 1);
                    }
                }
            }

            return output;
        }
    }
}
