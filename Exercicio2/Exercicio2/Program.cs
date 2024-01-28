namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma equação:");
            string equation = Console.ReadLine();

            bool isBalanced = BalanceTest(equation);
            
            // Só de mudar o nome da variável já deixa mais intuitivo e fácil usá-la como boolean diretamente:
            if (isBalanced)
                Console.WriteLine("A equação está balanceada");
            else
                Console.WriteLine("A equação NÃO está balanceada");
        }

        internal static bool BalanceTest(string equation)
        {
            Stack<char> symbols = new Stack<char>();

            foreach(char c in equation)
            {
                if(c == '(' || c == '[' || c == '{')
                {
                    symbols.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    // Na implementação anterior havia um bug que entendia expressões como "[[]]}" como balanceada.
                    if (symbols.Count == 0)
                        return false;

                    var lastSymbol = symbols.Pop();
                    
                    if(lastSymbol == '(' && c == ')' || lastSymbol == '[' && c == ']' || lastSymbol == '{' && c == '}')
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            // Quanto menos 'if' no código mais fácil fica de ler. Tente evitar sempre que possível
            return symbols.Count == 0;
        }
    }
}
