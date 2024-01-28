namespace Exercicio3
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Digite o número de participantes");
            if (int.TryParse(Console.ReadLine(), out int numPlayers))
                HotPotatoGame(numPlayers);
                
        }

        internal static void HotPotatoGame(int numPlayers)
        {
            Queue<string> players = new Queue<string>(); //Poderia ser Queue<int>. Mas deixei string para facilitar
                                                         //se quiser inserir nomes futuramente

            for (int i = 1; i <= numPlayers; i++)
            {
                players.Enqueue($"Jogador {i}");
            }

            Random random = new Random();
            int passes = random.Next(1, 10); //trocar o máximo para 100, mas eu queria os testes mais rápidos

            while (players.Count > 1)
            {
                for (int i = 0; i < passes; i++)
                {
                    string currentPlayer = players.Dequeue();
                    players.Enqueue(currentPlayer);
                }

                string playerWithPotato = players.Dequeue();
                Console.WriteLine($"A batata explodiu para {playerWithPotato}. Restam {players.Count} jogadores na brincadeira.");
            }

            string winner = players.Peek();
            Console.WriteLine($"O vencedor é {winner}!");
        }
    }
}
