namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma equação:");
            string equation = Console.ReadLine();

            bool balanceEquation = BalanceTest(equation);
            
            if (balanceEquation == true)
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
                else if(c == ')' || c == ']' || c == '}')
                {
                    if(symbols.TryPeek(out char lastSymbol))
                    {
                        if(lastSymbol == '(' && c == ')' || lastSymbol == '[' && c == ']' || lastSymbol == '{' && c == '}')
                        {
                            symbols.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            if (symbols.Count == 0)
                return true;
            else
                return false;
        }
    }
}
