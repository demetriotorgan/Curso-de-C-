using System;

class Program
{
    public static void Main(string[] args)
    {
        // Gerar um número aleatório entre 1 e 100
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int tentativa = 0;
        bool acertou = false;

        Console.WriteLine("Bem-vindo ao Jogo da Adivinhação!");
        Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100.");

        // Enquanto o usuário não acertar
        while (!acertou)
        {
            Console.Write("Digite sua tentativa: ");
            string input = Console.ReadLine();

            // Verificar se a entrada é um número válido
            if (int.TryParse(input, out tentativa))
            {
                if (tentativa < 1 || tentativa > 100)
                {
                    Console.WriteLine("Por favor, digite um número entre 1 e 100.");
                }
                else if (tentativa < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é maior!");
                }
                else if (tentativa > numeroSecreto)
                {
                    Console.WriteLine("O número secreto é menor!");
                }
                else
                {
                    Console.WriteLine("Parabéns! Você acertou o número!");
                    acertou = true;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número.");
            }
        }

        Console.WriteLine("Obrigado por jogar!");
    }
}
