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
            foreach (string wold in input)
            {
                if(wold.Length >10)
                {
                    output.Add(wold);
                }
            }
            return output;
        }
    }
}
