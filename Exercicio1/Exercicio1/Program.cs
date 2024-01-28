namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = new List<string> {
                "Idiossincrasia",
                "Ambivalente",
                "Quimérica",
                "Perpendicular",
                "Efêmero",
                "Pletora",
                "Obnubilado",
                "Xilografia",
                "Quixote",
                "Inefável"
            };

            List<string> filteredWords = WordsFilter(input);
            

            foreach (string word in  filteredWords)
            {
                Console.WriteLine(word);
            }
        }

        static List<string> WordsFilter(List<string> input)
        {
            List<string> output = new List<string>();
            foreach (string word in input)
            {
                // Os limites são sempre focos de bugs.
                // Na implementação anterior havia um bug que deixava de lado as palavras que tinham exatamente 10 caracteres.
                if (word.Length >= 10)
                {
                    output.Add(word);
                }
            }
            return output;
        }
    }
}
